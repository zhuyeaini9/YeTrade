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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1_saveSymbolPro = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox7_minStepVol = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox6_maxVol = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox5_minVol = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox4_contractSize = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox3_tickValue = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox2_tickSize = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox1_symbolName = new System.Windows.Forms.TextBox();
            this.label21_taskCount = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.progressBar1_test = new System.Windows.Forms.ProgressBar();
            this.textBox1_leverage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.checkBox1_averageFilter = new System.Windows.Forms.CheckBox();
            this.textBox5_aveBig = new System.Windows.Forms.TextBox();
            this.textBox4_aveSmall = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3_imeStopAtr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2_closeStopAtr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_breakPeriod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
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
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(214, 604);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
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
            this.splitContainer2.Panel1.Controls.Add(this.button1_saveSymbolPro);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.textBox7_minStepVol);
            this.splitContainer2.Panel1.Controls.Add(this.label14);
            this.splitContainer2.Panel1.Controls.Add(this.textBox6_maxVol);
            this.splitContainer2.Panel1.Controls.Add(this.label15);
            this.splitContainer2.Panel1.Controls.Add(this.textBox5_minVol);
            this.splitContainer2.Panel1.Controls.Add(this.label16);
            this.splitContainer2.Panel1.Controls.Add(this.textBox4_contractSize);
            this.splitContainer2.Panel1.Controls.Add(this.label17);
            this.splitContainer2.Panel1.Controls.Add(this.textBox3_tickValue);
            this.splitContainer2.Panel1.Controls.Add(this.label18);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2_tickSize);
            this.splitContainer2.Panel1.Controls.Add(this.label19);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1_symbolName);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Teal;
            this.splitContainer2.Panel2.Controls.Add(this.label21_taskCount);
            this.splitContainer2.Panel2.Controls.Add(this.label20);
            this.splitContainer2.Panel2.Controls.Add(this.progressBar1_test);
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
            this.splitContainer2.Panel2.Controls.Add(this.checkBox1_averageFilter);
            this.splitContainer2.Panel2.Controls.Add(this.textBox5_aveBig);
            this.splitContainer2.Panel2.Controls.Add(this.textBox4_aveSmall);
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
            // button1_saveSymbolPro
            // 
            this.button1_saveSymbolPro.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1_saveSymbolPro.Location = new System.Drawing.Point(647, 138);
            this.button1_saveSymbolPro.Name = "button1_saveSymbolPro";
            this.button1_saveSymbolPro.Size = new System.Drawing.Size(85, 35);
            this.button1_saveSymbolPro.TabIndex = 30;
            this.button1_saveSymbolPro.Text = "保存";
            this.button1_saveSymbolPro.UseVisualStyleBackColor = true;
            this.button1_saveSymbolPro.Click += new System.EventHandler(this.button1_saveSymbolPro_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(442, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "最小变化手数：";
            // 
            // textBox7_minStepVol
            // 
            this.textBox7_minStepVol.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7_minStepVol.Location = new System.Drawing.Point(568, 102);
            this.textBox7_minStepVol.Name = "textBox7_minStepVol";
            this.textBox7_minStepVol.Size = new System.Drawing.Size(164, 26);
            this.textBox7_minStepVol.TabIndex = 29;
            this.textBox7_minStepVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(474, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "最大手数：";
            // 
            // textBox6_maxVol
            // 
            this.textBox6_maxVol.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6_maxVol.Location = new System.Drawing.Point(568, 53);
            this.textBox6_maxVol.Name = "textBox6_maxVol";
            this.textBox6_maxVol.Size = new System.Drawing.Size(164, 26);
            this.textBox6_maxVol.TabIndex = 27;
            this.textBox6_maxVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(474, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "最小手数：";
            // 
            // textBox5_minVol
            // 
            this.textBox5_minVol.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5_minVol.Location = new System.Drawing.Point(568, 7);
            this.textBox5_minVol.Name = "textBox5_minVol";
            this.textBox5_minVol.Size = new System.Drawing.Size(164, 26);
            this.textBox5_minVol.TabIndex = 25;
            this.textBox5_minVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(104, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "每手合约大小：";
            // 
            // textBox4_contractSize
            // 
            this.textBox4_contractSize.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4_contractSize.Location = new System.Drawing.Point(230, 147);
            this.textBox4_contractSize.Name = "textBox4_contractSize";
            this.textBox4_contractSize.Size = new System.Drawing.Size(164, 26);
            this.textBox4_contractSize.TabIndex = 23;
            this.textBox4_contractSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(128, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = "TickValue：";
            // 
            // textBox3_tickValue
            // 
            this.textBox3_tickValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3_tickValue.Location = new System.Drawing.Point(230, 102);
            this.textBox3_tickValue.Name = "textBox3_tickValue";
            this.textBox3_tickValue.Size = new System.Drawing.Size(164, 26);
            this.textBox3_tickValue.TabIndex = 21;
            this.textBox3_tickValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(136, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 16);
            this.label18.TabIndex = 20;
            this.label18.Text = "TickSize：";
            // 
            // textBox2_tickSize
            // 
            this.textBox2_tickSize.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2_tickSize.Location = new System.Drawing.Point(230, 53);
            this.textBox2_tickSize.Name = "textBox2_tickSize";
            this.textBox2_tickSize.Size = new System.Drawing.Size(164, 26);
            this.textBox2_tickSize.TabIndex = 19;
            this.textBox2_tickSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(168, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 16);
            this.label19.TabIndex = 18;
            this.label19.Text = "品种：";
            // 
            // textBox1_symbolName
            // 
            this.textBox1_symbolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1_symbolName.Location = new System.Drawing.Point(230, 7);
            this.textBox1_symbolName.Name = "textBox1_symbolName";
            this.textBox1_symbolName.Size = new System.Drawing.Size(164, 26);
            this.textBox1_symbolName.TabIndex = 17;
            this.textBox1_symbolName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21_taskCount
            // 
            this.label21_taskCount.AutoSize = true;
            this.label21_taskCount.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21_taskCount.Location = new System.Drawing.Point(401, 214);
            this.label21_taskCount.Name = "label21_taskCount";
            this.label21_taskCount.Size = new System.Drawing.Size(16, 16);
            this.label21_taskCount.TabIndex = 31;
            this.label21_taskCount.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(306, 215);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 16);
            this.label20.TabIndex = 30;
            this.label20.Text = "当前任务：";
            // 
            // progressBar1_test
            // 
            this.progressBar1_test.Location = new System.Drawing.Point(404, 170);
            this.progressBar1_test.Name = "progressBar1_test";
            this.progressBar1_test.Size = new System.Drawing.Size(326, 23);
            this.progressBar1_test.TabIndex = 29;
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
            this.textBox8_atrPeriod.Text = "14";
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
            this.button1_test.Location = new System.Drawing.Point(309, 163);
            this.button1_test.Name = "button1_test";
            this.button1_test.Size = new System.Drawing.Size(85, 35);
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
            this.textBox6_risk.Text = "45";
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
            // checkBox1_averageFilter
            // 
            this.checkBox1_averageFilter.AutoSize = true;
            this.checkBox1_averageFilter.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1_averageFilter.Location = new System.Drawing.Point(306, 75);
            this.checkBox1_averageFilter.Name = "checkBox1_averageFilter";
            this.checkBox1_averageFilter.Size = new System.Drawing.Size(15, 14);
            this.checkBox1_averageFilter.TabIndex = 10;
            this.checkBox1_averageFilter.UseVisualStyleBackColor = true;
            // 
            // textBox5_aveBig
            // 
            this.textBox5_aveBig.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5_aveBig.Location = new System.Drawing.Point(471, 69);
            this.textBox5_aveBig.Name = "textBox5_aveBig";
            this.textBox5_aveBig.Size = new System.Drawing.Size(46, 26);
            this.textBox5_aveBig.TabIndex = 9;
            this.textBox5_aveBig.Text = "100";
            // 
            // textBox4_aveSmall
            // 
            this.textBox4_aveSmall.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4_aveSmall.Location = new System.Drawing.Point(419, 69);
            this.textBox4_aveSmall.Name = "textBox4_aveSmall";
            this.textBox4_aveSmall.Size = new System.Drawing.Size(46, 26);
            this.textBox4_aveSmall.TabIndex = 8;
            this.textBox4_aveSmall.Text = "20";
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
            this.textBox1_breakPeriod.Text = "105";
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
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBox1_averageFilter;
        private System.Windows.Forms.TextBox textBox5_aveBig;
        private System.Windows.Forms.TextBox textBox4_aveSmall;
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
        private System.Windows.Forms.ProgressBar progressBar1_test;
        private System.Windows.Forms.Button button1_saveSymbolPro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox7_minStepVol;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox6_maxVol;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox5_minVol;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox4_contractSize;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox3_tickValue;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox2_tickSize;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox1_symbolName;
        private System.Windows.Forms.Label label21_taskCount;
        private System.Windows.Forms.Label label20;
    }
}

