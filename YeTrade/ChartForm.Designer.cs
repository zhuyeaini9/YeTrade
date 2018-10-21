﻿namespace YeTrade
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
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
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(812, 402);
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
            this.splitContainer2.Panel2.Controls.Add(this.label2_lowTime);
            this.splitContainer2.Panel2.Controls.Add(this.label1_hightime);
            this.splitContainer2.Panel2.Controls.Add(this.label1_huiche);
            this.splitContainer2.Panel2.Controls.Add(this.label14);
            this.splitContainer2.Size = new System.Drawing.Size(1026, 402);
            this.splitContainer2.SplitterDistance = 812;
            this.splitContainer2.TabIndex = 1;
            // 
            // label2_lowTime
            // 
            this.label2_lowTime.AutoSize = true;
            this.label2_lowTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2_lowTime.Location = new System.Drawing.Point(13, 132);
            this.label2_lowTime.Name = "label2_lowTime";
            this.label2_lowTime.Size = new System.Drawing.Size(0, 16);
            this.label2_lowTime.TabIndex = 32;
            // 
            // label1_hightime
            // 
            this.label1_hightime.AutoSize = true;
            this.label1_hightime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_hightime.Location = new System.Drawing.Point(13, 97);
            this.label1_hightime.Name = "label1_hightime";
            this.label1_hightime.Size = new System.Drawing.Size(0, 16);
            this.label1_hightime.TabIndex = 31;
            // 
            // label1_huiche
            // 
            this.label1_huiche.AutoSize = true;
            this.label1_huiche.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_huiche.Location = new System.Drawing.Point(113, 52);
            this.label1_huiche.Name = "label1_huiche";
            this.label1_huiche.Size = new System.Drawing.Size(24, 16);
            this.label1_huiche.TabIndex = 30;
            this.label1_huiche.Text = "0%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(13, 52);
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
            this.splitContainer3.SplitterDistance = 812;
            this.splitContainer3.TabIndex = 0;
            // 
            // chart2
            // 
            chartArea2.AxisX.MajorGrid.LineWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(812, 245);
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
    }
}