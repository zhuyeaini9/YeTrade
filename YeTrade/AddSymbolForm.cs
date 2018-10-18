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
    public partial class AddSymbolForm : Form
    {
        Form1 mParent = null;
        public AddSymbolForm(Form1 p)
        {
            InitializeComponent();
            mParent = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CSymbolPro s = new CSymbolPro();
            s.mContractSize = double.Parse(textBox4_contractSize.Text.Trim());
            s.mMaxVol = double.Parse(textBox6_maxVol.Text.Trim());
            s.mMinVol = double.Parse(textBox5_minVol.Text.Trim());
            s.mStepVol = double.Parse(textBox7_minStepVol.Text.Trim());
            s.mSymbolName = textBox1_symbolName.Text.Trim();
            s.mTickSize = double.Parse(textBox2_tickSize.Text.Trim());
            s.mTickVal = double.Parse(textBox3_tickValue.Text.Trim());
            
            mParent.addNewSymbol(s);
            Close();
        }
    }
}
