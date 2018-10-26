namespace YeTrade
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2_BS = new System.Windows.Forms.Label();
            this.label2_money = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2_lowTime = new System.Windows.Forms.Label();
            this.label1_hightime = new System.Windows.Forms.Label();
            this.label1_huiche = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox1_symbolType = new System.Windows.Forms.ComboBox();
            this.button1_tongji = new System.Windows.Forms.Button();
            this.dateTimePicker2_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1_start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3_allTime = new System.Windows.Forms.Label();
            this.label4_profitAnnual = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(743, 402);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1026, 651);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.chart1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label4_profitAnnual);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.label3_allTime);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label2_BS);
            this.splitContainer2.Panel2.Controls.Add(this.label2_money);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.label2_lowTime);
            this.splitContainer2.Panel2.Controls.Add(this.label1_hightime);
            this.splitContainer2.Panel2.Controls.Add(this.label1_huiche);
            this.splitContainer2.Panel2.Controls.Add(this.label14);
            this.splitContainer2.Size = new System.Drawing.Size(1026, 402);
            this.splitContainer2.SplitterDistance = 743;
            this.splitContainer2.TabIndex = 1;
            // 
            // label2_BS
            // 
            this.label2_BS.AutoSize = true;
            this.label2_BS.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2_BS.Location = new System.Drawing.Point(13, 251);
            this.label2_BS.Name = "label2_BS";
            this.label2_BS.Size = new System.Drawing.Size(40, 16);
            this.label2_BS.TabIndex = 35;
            this.label2_BS.Text = "策略";
            // 
            // label2_money
            // 
            this.label2_money.AutoSize = true;
            this.label2_money.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2_money.Location = new System.Drawing.Point(113, 21);
            this.label2_money.Name = "label2_money";
            this.label2_money.Size = new System.Drawing.Size(16, 16);
            this.label2_money.TabIndex = 34;
            this.label2_money.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "最终收益：";
            // 
            // label2_lowTime
            // 
            this.label2_lowTime.AutoSize = true;
            this.label2_lowTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2_lowTime.Location = new System.Drawing.Point(75, 198);
            this.label2_lowTime.Name = "label2_lowTime";
            this.label2_lowTime.Size = new System.Drawing.Size(64, 16);
            this.label2_lowTime.TabIndex = 32;
            this.label2_lowTime.Text = "lowtime";
            // 
            // label1_hightime
            // 
            this.label1_hightime.AutoSize = true;
            this.label1_hightime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_hightime.Location = new System.Drawing.Point(75, 173);
            this.label1_hightime.Name = "label1_hightime";
            this.label1_hightime.Size = new System.Drawing.Size(72, 16);
            this.label1_hightime.TabIndex = 31;
            this.label1_hightime.Text = "hightime";
            // 
            // label1_huiche
            // 
            this.label1_huiche.AutoSize = true;
            this.label1_huiche.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_huiche.Location = new System.Drawing.Point(113, 147);
            this.label1_huiche.Name = "label1_huiche";
            this.label1_huiche.Size = new System.Drawing.Size(24, 16);
            this.label1_huiche.TabIndex = 30;
            this.label1_huiche.Text = "0%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(13, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 16);
            this.label14.TabIndex = 29;
            this.label14.Text = "最大回测：";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.chart2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.comboBox1_symbolType);
            this.splitContainer3.Panel2.Controls.Add(this.button1_tongji);
            this.splitContainer3.Panel2.Controls.Add(this.dateTimePicker2_end);
            this.splitContainer3.Panel2.Controls.Add(this.dateTimePicker1_start);
            this.splitContainer3.Size = new System.Drawing.Size(1026, 245);
            this.splitContainer3.SplitterDistance = 743;
            this.splitContainer3.TabIndex = 0;
            // 
            // chart2
            // 
            chartArea10.AxisX.MajorGrid.LineWidth = 0;
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend10.Name = "Legend1";
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(743, 245);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // comboBox1_symbolType
            // 
            this.comboBox1_symbolType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_symbolType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1_symbolType.FormattingEnabled = true;
            this.comboBox1_symbolType.Location = new System.Drawing.Point(36, 26);
            this.comboBox1_symbolType.Name = "comboBox1_symbolType";
            this.comboBox1_symbolType.Size = new System.Drawing.Size(136, 24);
            this.comboBox1_symbolType.TabIndex = 24;
            // 
            // button1_tongji
            // 
            this.button1_tongji.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1_tongji.Location = new System.Drawing.Point(68, 167);
            this.button1_tongji.Name = "button1_tongji";
            this.button1_tongji.Size = new System.Drawing.Size(104, 49);
            this.button1_tongji.TabIndex = 23;
            this.button1_tongji.Text = "统计";
            this.button1_tongji.UseVisualStyleBackColor = true;
            this.button1_tongji.Click += new System.EventHandler(this.button1_tongji_Click);
            // 
            // dateTimePicker2_end
            // 
            this.dateTimePicker2_end.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker2_end.Location = new System.Drawing.Point(36, 113);
            this.dateTimePicker2_end.Name = "dateTimePicker2_end";
            this.dateTimePicker2_end.Size = new System.Drawing.Size(136, 26);
            this.dateTimePicker2_end.TabIndex = 22;
            // 
            // dateTimePicker1_start
            // 
            this.dateTimePicker1_start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1_start.Location = new System.Drawing.Point(36, 68);
            this.dateTimePicker1_start.Name = "dateTimePicker1_start";
            this.dateTimePicker1_start.Size = new System.Drawing.Size(136, 26);
            this.dateTimePicker1_start.TabIndex = 21;
            this.dateTimePicker1_start.Value = new System.DateTime(2005, 3, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "持续时间：";
            // 
            // label3_allTime
            // 
            this.label3_allTime.AutoSize = true;
            this.label3_allTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3_allTime.Location = new System.Drawing.Point(113, 73);
            this.label3_allTime.Name = "label3_allTime";
            this.label3_allTime.Size = new System.Drawing.Size(16, 16);
            this.label3_allTime.TabIndex = 37;
            this.label3_allTime.Text = "0";
            // 
            // label4_profitAnnual
            // 
            this.label4_profitAnnual.AutoSize = true;
            this.label4_profitAnnual.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4_profitAnnual.Location = new System.Drawing.Point(129, 47);
            this.label4_profitAnnual.Name = "label4_profitAnnual";
            this.label4_profitAnnual.Size = new System.Drawing.Size(16, 16);
            this.label4_profitAnnual.TabIndex = 39;
            this.label4_profitAnnual.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(13, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "复合年收益：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "高点：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(13, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "低点：";
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 651);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ChartForm";
            this.Text = "ChartForm";
            this.Load += new System.EventHandler(this.ChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1_tongji;
        private System.Windows.Forms.DateTimePicker dateTimePicker2_end;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_start;
        private System.Windows.Forms.ComboBox comboBox1_symbolType;
        private System.Windows.Forms.Label label1_huiche;
        private System.Windows.Forms.Label label2_lowTime;
        private System.Windows.Forms.Label label1_hightime;
        private System.Windows.Forms.Label label2_money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2_BS;
        private System.Windows.Forms.Label label4_profitAnnual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3_allTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}