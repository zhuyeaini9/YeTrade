namespace YeTrade
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("非农商品");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("农商品");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("外汇");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("指数");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("加密货币");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("债券&利率");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8_atrPeriod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1_PricePeriod = new System.Windows.Forms.ComboBox();
            this.progressBar1_historyData = new System.Windows.Forms.ProgressBar();
            this.button1_historyDownload = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1_start = new System.Windows.Forms.DateTimePicker();
            this.button1_test = new System.Windows.Forms.Button();
            this.textBox7_money = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6_risk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3_imeStopAtr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2_closeStopAtr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_breakPeriod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1_leverage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1055, 604);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Teal;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "节点0";
            treeNode1.Text = "非农商品";
            treeNode2.Name = "节点1";
            treeNode2.Text = "农商品";
            treeNode3.Name = "节点2";
            treeNode3.Text = "外汇";
            treeNode4.Name = "节点3";
            treeNode4.Text = "指数";
            treeNode5.Name = "节点4";
            treeNode5.Text = "加密货币";
            treeNode6.Name = "节点5";
            treeNode6.Text = "债券&利率";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(214, 604);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Teal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Teal;
            this.splitContainer2.Panel2.Controls.Add(this.textBox1_leverage);
            this.splitContainer2.Panel2.Controls.Add(this.label12);
            this.splitContainer2.Panel2.Controls.Add(this.label11);
            this.splitContainer2.Panel2.Controls.Add(this.label10);
            this.splitContainer2.Panel2.Controls.Add(this.textBox8_atrPeriod);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.comboBox1_PricePeriod);
            this.splitContainer2.Panel2.Controls.Add(this.progressBar1_historyData);
            this.splitContainer2.Panel2.Controls.Add(this.button1_historyDownload);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.dateTimePicker2_end);
            this.splitContainer2.Panel2.Controls.Add(this.dateTimePicker1_start);
            this.splitContainer2.Panel2.Controls.Add(this.button1_test);
            this.splitContainer2.Panel2.Controls.Add(this.textBox7_money);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.textBox6_risk);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.checkBox1);
            this.splitContainer2.Panel2.Controls.Add(this.textBox5);
            this.splitContainer2.Panel2.Controls.Add(this.textBox4);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.textBox3_imeStopAtr);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.textBox2_closeStopAtr);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1_breakPeriod);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(837, 604);
            this.splitContainer2.SplitterDistance = 179;
            this.splitContainer2.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(284, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "%";
            // 
            // textBox8_atrPeriod
            // 
            this.textBox8_atrPeriod.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8_atrPeriod.Location = new System.Drawing.Point(182, 69);
            this.textBox8_atrPeriod.Name = "textBox8_atrPeriod";
            this.textBox8_atrPeriod.Size = new System.Drawing.Size(98, 26);
            this.textBox8_atrPeriod.TabIndex = 24;
            this.textBox8_atrPeriod.Text = "50";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(75, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "ATR周期：";
            // 
            // comboBox1_PricePeriod
            // 
            this.comboBox1_PricePeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_PricePeriod.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1_PricePeriod.FormattingEnabled = true;
            this.comboBox1_PricePeriod.Items.AddRange(new object[] {
            "H1",
            "H2",
            "H3",
            "H4",
            "H6",
            "H8",
            "H12",
            "D",
            "W",
            "M"});
            this.comboBox1_PricePeriod.Location = new System.Drawing.Point(340, 333);
            this.comboBox1_PricePeriod.Name = "comboBox1_PricePeriod";
            this.comboBox1_PricePeriod.Size = new System.Drawing.Size(121, 24);
            this.comboBox1_PricePeriod.TabIndex = 22;
            // 
            // progressBar1_historyData
            // 
            this.progressBar1_historyData.Location = new System.Drawing.Point(78, 375);
            this.progressBar1_historyData.Name = "progressBar1_historyData";
            this.progressBar1_historyData.Size = new System.Drawing.Size(522, 23);
            this.progressBar1_historyData.TabIndex = 21;
            // 
            // button1_historyDownload
            // 
            this.button1_historyDownload.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1_historyDownload.Location = new System.Drawing.Point(481, 299);
            this.button1_historyDownload.Name = "button1_historyDownload";
            this.button1_historyDownload.Size = new System.Drawing.Size(119, 58);
            this.button1_historyDownload.TabIndex = 20;
            this.button1_historyDownload.Text = "历史数据下载";
            this.button1_historyDownload.UseVisualStyleBackColor = true;
            this.button1_historyDownload.Click += new System.EventHandler(this.button1_historyDownload_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(74, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "结束时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(74, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "开始时间：";
            // 
            // dateTimePicker2_end
            // 
            this.dateTimePicker2_end.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker2_end.Location = new System.Drawing.Point(182, 332);
            this.dateTimePicker2_end.Name = "dateTimePicker2_end";
            this.dateTimePicker2_end.Size = new System.Drawing.Size(136, 26);
            this.dateTimePicker2_end.TabIndex = 17;
            // 
            // dateTimePicker1_start
            // 
            this.dateTimePicker1_start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1_start.Location = new System.Drawing.Point(182, 299);
            this.dateTimePicker1_start.Name = "dateTimePicker1_start";
            this.dateTimePicker1_start.Size = new System.Drawing.Size(136, 26);
            this.dateTimePicker1_start.TabIndex = 16;
            this.dateTimePicker1_start.Value = new System.DateTime(2005, 3, 1, 0, 0, 0, 0);
            // 
            // button1_test
            // 
            this.button1_test.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1_test.Location = new System.Drawing.Point(355, 156);
            this.button1_test.Name = "button1_test";
            this.button1_test.Size = new System.Drawing.Size(162, 35);
            this.button1_test.TabIndex = 15;
            this.button1_test.Text = "开始回测";
            this.button1_test.UseVisualStyleBackColor = true;
            this.button1_test.Click += new System.EventHandler(this.button1_test_Click);
            // 
            // textBox7_money
            // 
            this.textBox7_money.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7_money.Location = new System.Drawing.Point(182, 165);
            this.textBox7_money.Name = "textBox7_money";
            this.textBox7_money.Size = new System.Drawing.Size(98, 26);
            this.textBox7_money.TabIndex = 14;
            this.textBox7_money.Text = "20000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(75, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "开始金额：";
            // 
            // textBox6_risk
            // 
            this.textBox6_risk.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6_risk.Location = new System.Drawing.Point(182, 118);
            this.textBox6_risk.Name = "textBox6_risk";
            this.textBox6_risk.Size = new System.Drawing.Size(98, 26);
            this.textBox6_risk.TabIndex = 12;
            this.textBox6_risk.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(75, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "总风险因子：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(306, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(471, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(46, 26);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "100";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(419, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(46, 26);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(326, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "均线过滤：";
            // 
            // textBox3_imeStopAtr
            // 
            this.textBox3_imeStopAtr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3_imeStopAtr.Location = new System.Drawing.Point(638, 25);
            this.textBox3_imeStopAtr.Name = "textBox3_imeStopAtr";
            this.textBox3_imeStopAtr.Size = new System.Drawing.Size(92, 26);
            this.textBox3_imeStopAtr.TabIndex = 6;
            this.textBox3_imeStopAtr.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(543, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "即时止损：";
            // 
            // textBox2_closeStopAtr
            // 
            this.textBox2_closeStopAtr.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2_closeStopAtr.Location = new System.Drawing.Point(413, 25);
            this.textBox2_closeStopAtr.Name = "textBox2_closeStopAtr";
            this.textBox2_closeStopAtr.Size = new System.Drawing.Size(104, 26);
            this.textBox2_closeStopAtr.TabIndex = 4;
            this.textBox2_closeStopAtr.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(303, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "收盘价止损：";
            // 
            // textBox1_breakPeriod
            // 
            this.textBox1_breakPeriod.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1_breakPeriod.Location = new System.Drawing.Point(182, 25);
            this.textBox1_breakPeriod.Name = "textBox1_breakPeriod";
            this.textBox1_breakPeriod.Size = new System.Drawing.Size(98, 26);
            this.textBox1_breakPeriod.TabIndex = 1;
            this.textBox1_breakPeriod.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(75, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "突破周期：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(310, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(328, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "总风险因子：是指所有品种加起来的最大止损";
            // 
            // textBox1_leverage
            // 
            this.textBox1_leverage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1_leverage.Location = new System.Drawing.Point(182, 210);
            this.textBox1_leverage.Name = "textBox1_leverage";
            this.textBox1_leverage.Size = new System.Drawing.Size(98, 26);
            this.textBox1_leverage.TabIndex = 28;
            this.textBox1_leverage.Text = "100";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(75, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "杠杆：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 604);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ye交易测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox7_money;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6_risk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3_imeStopAtr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2_closeStopAtr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_breakPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1_test;
        private System.Windows.Forms.Button button1_historyDownload;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2_end;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_start;
        private System.Windows.Forms.ProgressBar progressBar1_historyData;
        private System.Windows.Forms.ComboBox comboBox1_PricePeriod;
        private System.Windows.Forms.TextBox textBox8_atrPeriod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1_leverage;
        private System.Windows.Forms.Label label12;
    }
}

