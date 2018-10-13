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
            if(string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("请输入品种名");
                return;
            }
            mParent.addNewSymbol(textBox1.Text.Trim());
            Close();
        }
    }
}
