using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace YeTrade
{
    public partial class ChartForm : Form
    {
        public CBreakStrategy mBs;
        public ChartForm(CBreakStrategy bs)
        {
            mBs = bs;
            InitializeComponent();
        }
        string getCheLvText()
        {
            string re = "";

            re = string.Format("品种数量：{0}\n风险因子：{1}/{2}\n突破周期：{3}\nATR周期：{4}\n",mBs.mSymbolCount
                ,(mBs.mRisk/mBs.mSymbolCount).ToString("F3")+"%"
                , mBs.mRisk+"%"
                ,mBs.mBreakPeriod
                ,mBs.mAtrPeriod);
            if(mBs.mUseAveFilter)
            {
                re += string.Format("均线过滤：{0}-{1}\n", mBs.mAveFilterSmall, mBs.mAveFilterBig);
            }
            return re;
        }
        private void ChartForm_Load(object sender, EventArgs e)
        {
            comboBox1_symbolType.Items.Add("全部");
            comboBox1_symbolType.Items.Add("非农商品");
            comboBox1_symbolType.Items.Add("农商品");
            comboBox1_symbolType.Items.Add("外汇");
            comboBox1_symbolType.Items.Add("指数");
            comboBox1_symbolType.Items.Add("加密货币");
            comboBox1_symbolType.Items.Add("债券&利率");

            comboBox1_symbolType.SelectedIndex = 0;

            double shouyi = (mBs.mMoney / mBs.mInitMoney * 100);
            label2_money.Text = (mBs.mMoney).ToString("F2") + " " + shouyi.ToString("F2") + "%";
            label1_huiche.Text = (mBs.mHuiChe.mHuiCheRadio * 100).ToString("F4") + "%";
            label1_hightime.Text = mBs.mHuiChe.mHighTime.ToShortDateString();
            label2_lowTime.Text = mBs.mHuiChe.mLowTime.ToShortDateString();

            double allTime = ((mBs.mEndTime - mBs.mStartTime).TotalDays / 365);
            label3_allTime.Text = allTime.ToString("F2") + "年" + "\n" + mBs.mStartTime.ToShortDateString() + "\n" + mBs.mEndTime.ToShortDateString();
            label4_profitAnnual.Text = ((Math.Pow(mBs.mMoney/mBs.mInitMoney,1/allTime)-1)*100.0f).ToString("F2") + "%";

            label2_BS.Text = getCheLvText();

            Series moneyLineSe = new Series();
            moneyLineSe.ChartType = SeriesChartType.Line;
            foreach (var v in mBs.mMoneyLine)
                moneyLineSe.Points.AddXY(v.Key, v.Value);
            chart1.Series.Add(moneyLineSe);

            tongji(dateTimePicker1_start.Value, dateTimePicker2_end.Value, comboBox1_symbolType.Text);
        }
        void tongji(DateTime t1,DateTime t2,string symbolType)
        {
            chart2.Series.Clear();
            Series typeSe = new Series();
            typeSe.ChartType = SeriesChartType.Bar;

            if(symbolType=="全部")
            {
                var vRe = mBs.mProfitChange.Where(d=>d.mTime>=t1 && d.mTime<=t2).GroupBy(i => i.mSymbolType).Select(j => new
                {
                    SymbolName = j.First().mSymbolType,
                    Profit = j.Sum(k => k.mProfit),
                });
                foreach (var v in vRe)
                {
                    typeSe.Points.InsertY(0,v.Profit);
                    typeSe.Points[0].Label = v.SymbolName;
                }
            }
            else
            {
                var vRe = mBs.mProfitChange.Where(d => d.mTime >= t1 && d.mTime <= t2 && d.mSymbolType == symbolType).GroupBy(j=>j.mSymbol).Select(j => new
                {
                    SymbolName = j.First().mSymbol,
                    Profit = j.Sum(k => k.mProfit),
                });
                foreach (var v in vRe)
                {
                    typeSe.Points.InsertY(0, v.Profit);
                    typeSe.Points[0].Label = v.SymbolName;
                }

            }

            chart2.Series.Add(typeSe);
        }
        private void button1_tongji_Click(object sender, EventArgs e)
        {
            tongji(dateTimePicker1_start.Value, dateTimePicker2_end.Value, comboBox1_symbolType.Text);
        }
    }
}
