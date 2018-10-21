using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;

namespace YeTrade
{
    public partial class Form1 : Form
    {
        MenuItem mAddMenuItem = new MenuItem("添加品种");
        MenuItem mDelMenuItem = new MenuItem("删除品种");
        ContextMenu mMenu = new ContextMenu();

        public CSymbolTree mSymbols = new CSymbolTree();
        public CBreakStrategy mBs = new CBreakStrategy();
        public void loadSymbol()
        {
            string sql = "select Data from Config where Id=1";
            object symbolData = CSqliteDBHelp.getValue(sql);
            if (symbolData == null)
            {
                CSymbolNode n = new CSymbolNode();
                n.mTypeName = "非农商品";
                mSymbols.mSymbolNodeList.Add(n);

                n = new CSymbolNode();
                n.mTypeName = "农商品";
                mSymbols.mSymbolNodeList.Add(n);

                n = new CSymbolNode();
                n.mTypeName = "外汇";
                mSymbols.mSymbolNodeList.Add(n);

                n = new CSymbolNode();
                n.mTypeName = "指数";
                mSymbols.mSymbolNodeList.Add(n);

                n = new CSymbolNode();
                n.mTypeName = "加密货币";
                mSymbols.mSymbolNodeList.Add(n);

                n = new CSymbolNode();
                n.mTypeName = "债券&利率";
                mSymbols.mSymbolNodeList.Add(n);
            }
            else
            {
                mSymbols = JsonConvert.DeserializeObject<CSymbolTree>(symbolData.ToString());
            }

            treeView1.Nodes.Clear();
            foreach(var v in mSymbols.mSymbolNodeList)
            {
                TreeNode n = treeView1.Nodes.Add(v.mTypeName);
                foreach(var c in v.mSymbols)
                {
                    n.Nodes.Add(c.mSymbolName);
                }
            }
            treeView1.ExpandAll();
        }
        public void saveSymbol()
        {
            string sql = "select count(*) from Config where Id=1";
            if(int.Parse(CSqliteDBHelp.getValue(sql).ToString()) > 0)
            {
                sql = string.Format("update Config set Data='{0}' where Id=1", JsonConvert.SerializeObject(mSymbols));
            }
            else
            {
                sql = string.Format("insert into Config (Id,Data) values (1,'{0}')", JsonConvert.SerializeObject(mSymbols));
            }
            CSqliteDBHelp.executeSql(sql);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mAddMenuItem.Enabled = false;
            mMenu.MenuItems.Add(mAddMenuItem);
            mAddMenuItem.Click += new EventHandler(addNewSymbol_Click);

            mDelMenuItem.Enabled = false;
            mMenu.MenuItems.Add(mDelMenuItem);
            mDelMenuItem.Click += new EventHandler(delSymbol_Click);

            comboBox1_PricePeriod.SelectedItem = "D";

            loadSymbol();
        }
        void resetMenuItem()
        {
            mAddMenuItem.Enabled = false;
            mDelMenuItem.Enabled = false;
        }
        void addNewSymbol_Click(object sender, EventArgs e)
        {
            AddSymbolForm f = new AddSymbolForm(this);
            f.ShowDialog();
        }
        void delSymbol_Click(object sender, EventArgs e)
        {
            TreeNode curSelNode = treeView1.SelectedNode;
            string nodeName = curSelNode.Text;

            if (curSelNode != null)
            {
                curSelNode.Remove();

                CSymbolNode sn = mSymbols.mSymbolNodeList.FirstOrDefault(i => i.mSymbols.Exists(j => j.mSymbolName == nodeName));
                if (sn != null)
                {
                    sn.mSymbols.RemoveAll(i => i.mSymbolName == nodeName);
                }
            }
        }
        public void addNewSymbol(CSymbolPro symbol)
        {
            TreeNode curSelNode = treeView1.SelectedNode;
            string nodeName = curSelNode.Text;
            if(curSelNode!=null)
            {
                curSelNode.Nodes.Add(symbol.mSymbolName);
                curSelNode.ExpandAll();

                CSymbolNode sn = mSymbols.mSymbolNodeList.FirstOrDefault(i => i.mTypeName == nodeName);
                if(sn!=null)
                {
                    symbol.mSymbolTypeName = nodeName;
                    sn.mSymbols.Add(symbol);
                }
            }
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Button != MouseButtons.Right)
            {
                return;
            }
            resetMenuItem();
            treeView1.SelectedNode = e.Node;

            if (e.Node.Parent == null)
            {
                mAddMenuItem.Enabled = true;
            }
            else
            {
                mDelMenuItem.Enabled = true;
            }
            mMenu.Show(treeView1, e.Location);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveSymbol();
        }

        private void button1_test_Click(object sender, EventArgs e)
        {
            button1_test.Enabled = false;

            mBs = new CBreakStrategy();
            mBs.mAtrPeriod = int.Parse(textBox8_atrPeriod.Text.Trim());
            mBs.mBreakPeriod = int.Parse(textBox1_breakPeriod.Text.Trim());
            mBs.mCloseStopAtr = double.Parse(textBox2_closeStopAtr.Text.Trim());
            mBs.mImeStopAtr = double.Parse(textBox3_imeStopAtr.Text.Trim());
            mBs.mLeverage = double.Parse(textBox1_leverage.Text.Trim());
            mBs.mMoney = double.Parse(textBox7_money.Text.Trim());
            mBs.mRisk = double.Parse(textBox6_risk.Text.Trim());
            mBs.mSymbolCount = mSymbols.mSymbolNodeList.Sum(i => i.mSymbols.Count);

            DateTime startTime = dateTimePicker1_start.Value.Date;
            DateTime endTime = dateTimePicker2_end.Value.Date;

            Dictionary<string, CSymbol> symbols = new Dictionary<string, CSymbol>();
            foreach (var v in mSymbols.mSymbolNodeList)
            {
                foreach (var j in v.mSymbols)
                {
                    CSymbol s = new CSymbol();
                    s.mPro = j;
                    s.mCandleData = getCandleDataFromSqlite(s.mPro.mSymbolName, comboBox1_PricePeriod.SelectedItem.ToString());

                    symbols[s.mPro.mSymbolName] = s;
                }
            }

            progressBar1_test.Value = 0;
            progressBar1_test.Maximum = (endTime - startTime).Days;

            mBs.initHuiChe(startTime);

            Thread thread = new Thread(new ThreadStart(() =>
            {
                do
                {
                    Invoke(new Action(() =>
                    {
                        progressBar1_test.Value++;
                    }));
                    foreach (var v in symbols)
                    {
                        v.Value.step(startTime, mBs);
                    }
                    mBs.addMoneyLine(startTime);

                    startTime = startTime.AddDays(1);
                }
                while (startTime.Date != endTime.Date);

                Invoke(new Action(() =>
                {
                    button1_test.Enabled = true;
                    button1_tongji.Enabled = true;
                }));

                Log4netHelper.LogInfo("money:" + mBs.mMoney.ToString("F2"));
            }));

            thread.IsBackground = true;
            thread.Start();

        }

        private void button1_historyDownload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("将会下载该时间段所有品种的历史价格数据，需要较多时间，确定继续吗？", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            button1_historyDownload.Enabled = false;

            string pricePeriod = comboBox1_PricePeriod.SelectedItem.ToString().Trim();
            progressBar1_historyData.Maximum = mSymbols.mSymbolNodeList.Sum(i => i.mSymbols.Count);
            progressBar1_historyData.Value = 0;

            Thread thread = new Thread(new ThreadStart(() =>
            {
                foreach (var v in mSymbols.mSymbolNodeList)
                {
                    foreach (var j in v.mSymbols)
                    {
                        Dictionary<DateTime, CCandleData> priceData = CHelp.getCandleHistoryData(j.mSymbolName, dateTimePicker1_start.Value, dateTimePicker2_end.Value, pricePeriod);

                        if (priceData.Count > 0)
                        {
                            string sql = string.Format("select count(*) from PriceData where Symbol='{0}' and Period='{1}'", j.mSymbolName, pricePeriod);
                            if (int.Parse(CSqliteDBHelp.getValue(sql).ToString()) == 0)
                            {
                                sql = string.Format("insert into PriceData (Symbol,Period,Data) values ('{0}','{1}','{2}')", j.mSymbolName, pricePeriod, JsonConvert.SerializeObject(new CCandleDataWrap(priceData)));
                            }
                            else
                            {
                                sql = string.Format("update PriceData set Data='{0}' where Symbol='{1}' and Period='{2}'", JsonConvert.SerializeObject(new CCandleDataWrap(priceData)), j.mSymbolName, pricePeriod);
                            }
                            CSqliteDBHelp.executeSql(sql);
                        }
                        Invoke(new Action(() =>
                        {
                            progressBar1_historyData.Value++;
                        }));
                    }
                }
                Invoke(new Action(() =>
                {
                    button1_historyDownload.Enabled = true;
                }));

            }));

            thread.IsBackground = true;
            thread.Start();
        }

        Dictionary<DateTime,CCandleData> getCandleDataFromSqlite(string symbol,string period)
        {
            Dictionary<DateTime, CCandleData> re = new Dictionary<DateTime, CCandleData>();

            string sql = string.Format("select Data from PriceData where Symbol='{0}' and Period='{1}'", symbol, period);
            string priceData = CSqliteDBHelp.getValue(sql).ToString();
            re = JsonConvert.DeserializeObject<CCandleDataWrap>(priceData).mPrice;
            return re;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Parent!=null)
            {
                foreach(var v in mSymbols.mSymbolNodeList)
                {
                    if(v.mSymbols.Exists(i=>i.mSymbolName == e.Node.Text))
                    {
                        CSymbolPro sp = v.mSymbols.First(i => i.mSymbolName == e.Node.Text);

                        textBox1_symbolName.Text = sp.mSymbolName;
                        textBox2_tickSize.Text = sp.mTickSize.ToString();
                        textBox3_tickValue.Text = sp.mTickVal.ToString();
                        textBox4_contractSize.Text = sp.mContractSize.ToString();
                        textBox5_minVol.Text = sp.mMinVol.ToString();
                        textBox6_maxVol.Text = sp.mMaxVol.ToString();
                        textBox7_minStepVol.Text = sp.mStepVol.ToString();

                    }
                }
            }
        }

        private void button1_saveSymbolPro_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Parent != null)
            {
                foreach (var v in mSymbols.mSymbolNodeList)
                {
                    if (v.mSymbols.Exists(i => i.mSymbolName == textBox1_symbolName.Text))
                    {
                        CSymbolPro sp = v.mSymbols.First(i => i.mSymbolName == textBox1_symbolName.Text);

                        sp.mContractSize = double.Parse(textBox4_contractSize.Text.Trim());
                        sp.mMaxVol = double.Parse(textBox6_maxVol.Text.Trim());
                        sp.mMinVol = double.Parse(textBox5_minVol.Text.Trim());
                        sp.mStepVol = double.Parse(textBox7_minStepVol.Text.Trim());
                        sp.mSymbolName = textBox1_symbolName.Text.Trim();
                        sp.mTickSize = double.Parse(textBox2_tickSize.Text.Trim());
                        sp.mTickVal = double.Parse(textBox3_tickValue.Text.Trim());

                    }
                }

                saveSymbol();
                MessageBox.Show("保存成功");
            }
        }

        private void button1_tongji_Click(object sender, EventArgs e)
        {
            ChartForm cf = new ChartForm(mBs);
            cf.ShowDialog();
        }
    }
}
