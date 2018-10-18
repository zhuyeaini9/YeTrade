namespace YeTrade
{
    partial class AddSymbolForm
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
            this.textBox1_symbolName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_tickSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3_tickValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4_contractSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5_minVol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6_maxVol = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7_minStepVol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1_symbolName
            // 
            this.textBox1_symbolName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1_symbolName.Location = new System.Drawing.Point(147, 25);
            this.textBox1_symbolName.Name = "textBox1_symbolName";
            this.textBox1_symbolName.Size = new System.Drawing.Size(164, 26);
            this.textBox1_symbolName.TabIndex = 2;
            this.textBox1_symbolName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(561, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(85, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "品种：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(53, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "TickSize：";
            // 
            // textBox2_tickSize
            // 
            this.textBox2_tickSize.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2_tickSize.Location = new System.Drawing.Point(147, 73);
            this.textBox2_tickSize.Name = "textBox2_tickSize";
            this.textBox2_tickSize.Size = new System.Drawing.Size(164, 26);
            this.textBox2_tickSize.TabIndex = 5;
            this.textBox2_tickSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(45, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "TickValue：";
            // 
            // textBox3_tickValue
            // 
            this.textBox3_tickValue.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3_tickValue.Location = new System.Drawing.Point(147, 122);
            this.textBox3_tickValue.Name = "textBox3_tickValue";
            this.textBox3_tickValue.Size = new System.Drawing.Size(164, 26);
            this.textBox3_tickValue.TabIndex = 7;
            this.textBox3_tickValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(21, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "每手合约大小：";
            // 
            // textBox4_contractSize
            // 
            this.textBox4_contractSize.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4_contractSize.Location = new System.Drawing.Point(147, 167);
            this.textBox4_contractSize.Name = "textBox4_contractSize";
            this.textBox4_contractSize.Size = new System.Drawing.Size(164, 26);
            this.textBox4_contractSize.TabIndex = 9;
            this.textBox4_contractSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(391, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "最小手数：";
            // 
            // textBox5_minVol
            // 
            this.textBox5_minVol.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5_minVol.Location = new System.Drawing.Point(485, 25);
            this.textBox5_minVol.Name = "textBox5_minVol";
            this.textBox5_minVol.Size = new System.Drawing.Size(164, 26);
            this.textBox5_minVol.TabIndex = 11;
            this.textBox5_minVol.Text = "0.01";
            this.textBox5_minVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(391, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "最大手数：";
            // 
            // textBox6_maxVol
            // 
            this.textBox6_maxVol.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6_maxVol.Location = new System.Drawing.Point(485, 73);
            this.textBox6_maxVol.Name = "textBox6_maxVol";
            this.textBox6_maxVol.Size = new System.Drawing.Size(164, 26);
            this.textBox6_maxVol.TabIndex = 13;
            this.textBox6_maxVol.Text = "100000";
            this.textBox6_maxVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(359, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "最小变化手数：";
            // 
            // textBox7_minStepVol
            // 
            this.textBox7_minStepVol.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7_minStepVol.Location = new System.Drawing.Point(485, 122);
            this.textBox7_minStepVol.Name = "textBox7_minStepVol";
            this.textBox7_minStepVol.Size = new System.Drawing.Size(164, 26);
            this.textBox7_minStepVol.TabIndex = 15;
            this.textBox7_minStepVol.Text = "0.01";
            this.textBox7_minStepVol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddSymbolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(737, 370);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7_minStepVol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6_maxVol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5_minVol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4_contractSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3_tickValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2_tickSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1_symbolName);
            this.Name = "AddSymbolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加品种";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_symbolName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2_tickSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3_tickValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4_contractSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5_minVol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6_maxVol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7_minStepVol;
    }
}