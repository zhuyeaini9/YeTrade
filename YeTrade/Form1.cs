using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YeTrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<DateTime, CCandleData> priceData = CHelp.getCandleHistoryData("USB10Y_USD", new DateTime(2018, 10, 1), new DateTime(2018,10,5), "D");
        }
    }
}
