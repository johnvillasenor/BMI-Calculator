namespace BMI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.radioKg = new System.Windows.Forms.RadioButton();
            this.radioLb = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(288, 115);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(203, 20);
            this.textWeight.TabIndex = 3;
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(288, 156);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(203, 20);
            this.textHeight.TabIndex = 4;
            // 
            // textResult
            // 
            this.textResult.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textResult.Location = new System.Drawing.Point(186, 242);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(371, 103);
            this.textResult.TabIndex = 5;
            // 
            // radioKg
            // 
            this.radioKg.AutoSize = true;
            this.radioKg.Location = new System.Drawing.Point(293, 194);
            this.radioKg.Name = "radioKg";
            this.radioKg.Size = new System.Drawing.Size(65, 17);
            this.radioKg.TabIndex = 6;
            this.radioKg.TabStop = true;
            this.radioKg.Text = "Kilogram";
            this.radioKg.UseVisualStyleBackColor = true;
            this.radioKg.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioLb
            // 
            this.radioLb.AutoSize = true;
            this.radioLb.Location = new System.Drawing.Point(369, 194);
            this.radioLb.Name = "radioLb";
            this.radioLb.Size = new System.Drawing.Size(56, 17);
            this.radioLb.TabIndex = 7;
            this.radioLb.TabStop = true;
            this.radioLb.Text = "Pound";
            this.radioLb.UseVisualStyleBackColor = true;
            this.radioLb.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(288, 375);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(193, 23);
            this.buttonCalculate.TabIndex = 8;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(288, 429);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(83, 23);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(398, 429);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(83, 23);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 61);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(252, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "BMI CALCULATOR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.radioLb);
            this.Controls.Add(this.radioKg);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.RadioButton radioKg;
        private System.Windows.Forms.RadioButton radioLb;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}

