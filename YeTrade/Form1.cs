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

        List<CSymbolPro> mSymbolList = new List<CSymbolPro>();
        public void loadSymbol()
        {
            string sql = "select Data from Config where Id=2";
            object symbolData = CSqliteDBHelp.getValue(sql);

            treeView1.Nodes.Add("非农商品").Name = "非农商品";
            treeView1.Nodes.Add("农商品").Name = "农商品";
            treeView1.Nodes.Add("外汇").Name = "外汇";
            treeView1.Nodes.Add("指数").Name = "指数";
            treeView1.Nodes.Add("债券&利率").Name = "债券&利率";
            treeView1.Nodes.Add("加密货币").Name = "加密货币";

            if (symbolData != null)
            {
                mSymbolList = JsonConvert.DeserializeObject<IEnumerable<CSymbolPro>>(symbolData.ToString()) as List<CSymbolPro>;
            }

            foreach (var v in mSymbolList)
            {
                treeView1.Nodes[v.mSymbolTypeName].Nodes.Add(v.mSymbolName);
            }
            treeView1.ExpandAll();
        }
        public void saveSymbol()
        {
            string sql = "select count(*) from Config where Id=2";
            if (int.Parse(CSqliteDBHelp.getValue(sql).ToString()) > 0)
            {
                sql = string.Format("update Config set Data='{0}' where Id=2", JsonConvert.SerializeObject(mSymbolList));
            }
            else
            {
                sql = string.Format("insert into Config (Id,Data) values (2,'{0}')", JsonConvert.SerializeObject(mSymbolList));
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
                mSymbolList.RemoveAll(i => i.mSymbolName == nodeName);
            }
        }
        public void addNewSymbol(CSymbolPro symbol)
        {
            TreeNode curSelNode = treeView1.SelectedNode;
            string nodeName = curSelNode.Text;
            if (curSelNode != null)
            {
                symbol.mSymbolTypeName = nodeName;
                curSelNode.Nodes.Add(symbol.mSymbolName);
                curSelNode.ExpandAll();

                mSymbolList.Add(symbol);
            }
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
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

            CBreakStrategy BS = new CBreakStrategy();
            BS.mAtrPeriod = int.Parse(textBox8_atrPeriod.Text.Trim());
            BS.mBreakPeriod = int.Parse(textBox1_breakPeriod.Text.Trim());
            BS.mCloseStopAtr = double.Parse(textBox2_closeStopAtr.Text.Trim());
            BS.mImeStopAtr = double.Parse(textBox3_imeStopAtr.Text.Trim());
            BS.mLeverage = double.Parse(textBox1_leverage.Text.Trim());
            BS.mMoney = double.Parse(textBox7_money.Text.Trim());
            BS.mInitMoney = BS.mMoney;
            BS.mRisk = double.Parse(textBox6_risk.Text.Trim());
            BS.mAveFilterSmall = int.Parse(textBox4_aveSmall.Text.Trim());
            BS.mAveFilterBig = int.Parse(textBox5_aveBig.Text.Trim());
            BS.mUseAveFilter = checkBox1_averageFilter.Checked;

            DateTime startTime = dateTimePicker1_start.Value.Date;
            DateTime endTime = dateTimePicker2_end.Value.Date;

            BS.mStartTime = startTime;
            BS.mEndTime = endTime;

            Dictionary<string, CSymbol> symbols = new Dictionary<string, CSymbol>();
            List<CSymbolPro> selSym = getSelSymbol();
            foreach (var v in selSym)
            {
                CSymbol s = new CSymbol();
                s.mPro = v;
                s.mCandleData = getCandleDataFromSqlite(s.mPro.mSymbolName, comboBox1_PricePeriod.SelectedItem.ToString());

                symbols[s.mPro.mSymbolName] = s;
            }

            BS.mSymbolCount = symbols.Count;

            if (int.Parse(label21_taskCount.Text.Trim()) == 0)
            {
                progressBar1_test.Value = 0;
                progressBar1_test.Maximum = (endTime - startTime).Days;
            }
            else
            {
                progressBar1_test.Maximum += (endTime - startTime).Days;
            }

            BS.initHuiChe(startTime);

            Thread thread = new Thread(new ThreadStart(() =>
            {
                Invoke(new Action(() =>
                {
                    int taskCount = int.Parse(label21_taskCount.Text.Trim());
                    taskCount++;
                    label21_taskCount.Text = taskCount.ToString();
                }));

                do
                {
                    Invoke(new Action(() =>
                    {
                        progressBar1_test.Value++;
                    }));
                    foreach (var v in symbols)
                    {
                        v.Value.step(startTime, BS);
                    }
                    BS.addMoneyLine(startTime);

                    startTime = startTime.AddDays(1);
                }
                while (startTime.Date != endTime.Date);

                Invoke(new Action(() =>
                {
                    ChartForm cf = new ChartForm(BS);
                    cf.Show();

                    int taskCount = int.Parse(label21_taskCount.Text.Trim());
                    taskCount--;
                    label21_taskCount.Text = taskCount.ToString();
                }));

                Log4netHelper.LogInfo("money:" + BS.mMoney.ToString("F2"));
            }));

            thread.IsBackground = true;
            thread.Start();

            Invoke(new Action(() =>
            {
                button1_test.Enabled = true;
            }));
        }
        List<CSymbolPro> getSelSymbol()
        {
            List<CSymbolPro> re = new List<CSymbolPro>();
            foreach (TreeNode i in treeView1.Nodes)
            {
                foreach (TreeNode j in i.Nodes)
                {
                    if (j.Checked)
                    {
                        re.Add(mSymbolList.First(k => k.mSymbolName == j.Text));
                    }
                }
            }

            return re;
        }
        private void button1_historyDownload_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("将会下载该时间段所有品种的历史价格数据，需要较多时间，确定继续吗？", "", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            button1_historyDownload.Enabled = false;

            List<CSymbolPro> selSymbols = getSelSymbol();

            string pricePeriod = comboBox1_PricePeriod.SelectedItem.ToString().Trim();
            progressBar1_historyData.Maximum = selSymbols.Count;
            progressBar1_historyData.Value = 0;

            Thread thread = new Thread(new ThreadStart(() =>
            {
                foreach (var j in selSymbols)
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
                Invoke(new Action(() =>
                {
                    button1_historyDownload.Enabled = true;
                }));

            }));

            thread.IsBackground = true;
            thread.Start();
        }

        Dictionary<DateTime, CCandleData> getCandleDataFromSqlite(string symbol, string period)
        {
            Dictionary<DateTime, CCandleData> re = new Dictionary<DateTime, CCandleData>();

            string sql = string.Format("select Data from PriceData where Symbol='{0}' and Period='{1}'", symbol, period);
            string priceData = CSqliteDBHelp.getValue(sql).ToString();
            re = JsonConvert.DeserializeObject<CCandleDataWrap>(priceData).mPrice;
            return re;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                if (mSymbolList.Exists(i => i.mSymbolName == e.Node.Text))
                {
                    CSymbolPro sp = mSymbolList.First(i => i.mSymbolName == e.Node.Text);

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

        private void button1_saveSymbolPro_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Parent != null)
            {
                if (mSymbolList.Exists(i => i.mSymbolName == textBox1_symbolName.Text))
                {
                    CSymbolPro sp = mSymbolList.First(i => i.mSymbolName == textBox1_symbolName.Text);

                    sp.mContractSize = double.Parse(textBox4_contractSize.Text.Trim());
                    sp.mMaxVol = double.Parse(textBox6_maxVol.Text.Trim());
                    sp.mMinVol = double.Parse(textBox5_minVol.Text.Trim());
                    sp.mStepVol = double.Parse(textBox7_minStepVol.Text.Trim());
                    sp.mSymbolName = textBox1_symbolName.Text.Trim();
                    sp.mTickSize = double.Parse(textBox2_tickSize.Text.Trim());
                    sp.mTickVal = double.Parse(textBox3_tickValue.Text.Trim());

                }

                saveSymbol();
                MessageBox.Show("保存成功");
            }
        }

        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    // If the current node has child nodes, call the CheckAllChildsNodes method recursively.
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                if (e.Node.Nodes.Count > 0)
                {
                    /* Calls the CheckAllChildNodes method, passing in the current 
                    Checked value of the TreeNode whose checked state changed. */
                    this.CheckAllChildNodes(e.Node, e.Node.Checked);
                }
            }
        }
    }
}
