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
                    n.Nodes.Add(c);
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

                CSymbolNode sn = mSymbols.mSymbolNodeList.FirstOrDefault(i => i.mSymbols.Exists(j => j == nodeName));
                if (sn != null)
                {
                    sn.mSymbols.Remove(nodeName);
                }
            }
        }
        public void addNewSymbol(string symbol)
        {
            TreeNode curSelNode = treeView1.SelectedNode;
            string nodeName = curSelNode.Text;
            if(curSelNode!=null)
            {
                curSelNode.Nodes.Add(symbol);
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
                        Dictionary<DateTime, CCandleData> priceData = CHelp.getCandleHistoryData(j, dateTimePicker1_start.Value, dateTimePicker2_end.Value, pricePeriod);
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
    }
}
