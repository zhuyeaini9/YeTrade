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
            CBreakStrategy bs = new CBreakStrategy();
            bs.mAtrPeriod = int.Parse(textBox8_atrPeriod.Text.Trim());
            bs.mBreakPeriod = int.Parse(textBox1_breakPeriod.Text.Trim());
            bs.mCloseStopAtr = double.Parse(textBox2_closeStopAtr.Text.Trim());
            bs.mImeStopAtr = double.Parse(textBox3_imeStopAtr.Text.Trim());
            bs.mLeverage = double.Parse(textBox1_leverage.Text.Trim());
            bs.mMoney = double.Parse(textBox7_money.Text.Trim());
            bs.mRisk = double.Parse(textBox6_risk.Text.Trim());
            bs.mSymbolCount = mSymbols.mSymbolNodeList.Sum(i => i.mSymbols.Count);

            DateTime startTime = dateTimePicker1_start.Value;
            DateTime endTime = dateTimePicker2_end.Value;

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

            do
            {
                foreach (var v in symbols)
                {
                    v.Value.step(startTime, bs);
                }
                startTime = startTime.AddDays(1);
            }
            while (startTime.ToShortDateString() != endTime.ToShortDateString());
        }

        private void button1_historyDownload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("将会下载该时间段所有品种的历史价格数据，需要较多时间，确定继续吗？", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

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
                            string sql = string.Format("select count(*) from PriceData where Symbol='{0}' and Period='{1}'", j, pricePeriod);
                            if (int.Parse(CSqliteDBHelp.getValue(sql).ToString()) == 0)
                            {
                                sql = string.Format("insert into PriceData (Symbol,Period,Data) values ('{0}','{1}','{2}')", j, pricePeriod, JsonConvert.SerializeObject(priceData));
                            }
                            else
                            {
                                sql = string.Format("update PriceData set Period='{0}',Data='{1}'", pricePeriod, JsonConvert.SerializeObject(priceData));
                            }
                            CSqliteDBHelp.executeSql(sql);
                        }
                        Invoke(new Action(() =>
                        {
                            progressBar1_historyData.Value++;
                        }));
                    }
                }
            }));

            thread.IsBackground = true;
            thread.Start();
        }

        Dictionary<DateTime,CCandleData> getCandleDataFromSqlite(string symbol,string period)
        {
            Dictionary<DateTime, CCandleData> re = new Dictionary<DateTime, CCandleData>();

            string sql = string.Format("select Data from PriceData where Symbol='{0}' and Period='{1}'", symbol, period);
            string priceData = CSqliteDBHelp.getValue(sql).ToString();
            re = JsonConvert.DeserializeObject<Dictionary<DateTime, CCandleData>>(priceData);
            return re;
        }
    }
}
