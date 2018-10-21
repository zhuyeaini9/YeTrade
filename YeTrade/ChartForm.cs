﻿using System;
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

            label1_huiche.Text = (mBs.mHuiChe.mHuiCheRadio * 100).ToString("F4");
            label1_hightime.Text = mBs.mHuiChe.mHighTime.ToShortDateString();
            label2_lowTime.Text = mBs.mHuiChe.mLowTime.ToShortDateString();

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
