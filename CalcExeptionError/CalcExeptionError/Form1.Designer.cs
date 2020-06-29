namespace CalcExeptionError
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
            this.SubTotBox = new System.Windows.Forms.TextBox();
            this.TaxBox = new System.Windows.Forms.TextBox();
            this.GranTotBox = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.CalcErrBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.CalcErrIntBtn = new System.Windows.Forms.Button();
            this.EmptErrBtn = new System.Windows.Forms.Button();
            this.CalcUnkwnErrBtn = new System.Windows.Forms.Button();
            this.SubNTaxExcErrBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TaxBoxExcBox = new System.Windows.Forms.TextBox();
            this.GranTotExcBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SubTotExcBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grand Total (including tax):";
            // 
            // SubTotBox
            // 
            this.SubTotBox.Location = new System.Drawing.Point(181, 89);
            this.SubTotBox.Name = "SubTotBox";
            this.SubTotBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotBox.TabIndex = 3;
            // 
            // TaxBox
            // 
            this.TaxBox.Location = new System.Drawing.Point(181, 142);
            this.TaxBox.Name = "TaxBox";
            this.TaxBox.Size = new System.Drawing.Size(100, 20);
            this.TaxBox.TabIndex = 4;
            // 
            // GranTotBox
            // 
            this.GranTotBox.Location = new System.Drawing.Point(181, 190);
            this.GranTotBox.Name = "GranTotBox";
            this.GranTotBox.Size = new System.Drawing.Size(100, 20);
            this.GranTotBox.TabIndex = 5;
            this.GranTotBox.TextChanged += new System.EventHandler(this.GranTotBox_TextChanged);
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(359, 58);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 23);
            this.CalcBtn.TabIndex = 6;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // CalcErrBtn
            // 
            this.CalcErrBtn.Location = new System.Drawing.Point(359, 116);
            this.CalcErrBtn.Name = "CalcErrBtn";
            this.CalcErrBtn.Size = new System.Drawing.Size(120, 23);
            this.CalcErrBtn.TabIndex = 7;
            this.CalcErrBtn.Text = "Calculate (string error)";
            this.CalcErrBtn.UseVisualStyleBackColor = true;
            this.CalcErrBtn.Click += new System.EventHandler(this.CalcErrBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Please enter a numeric value (xx.xx;  € sign is added automatically)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ClrBtn
            // 
            this.ClrBtn.Location = new System.Drawing.Point(359, 87);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(75, 23);
            this.ClrBtn.TabIndex = 9;
            this.ClrBtn.Text = "Clear Fields";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // CalcErrIntBtn
            // 
            this.CalcErrIntBtn.Location = new System.Drawing.Point(359, 145);
            this.CalcErrIntBtn.Name = "CalcErrIntBtn";
            this.CalcErrIntBtn.Size = new System.Drawing.Size(120, 23);
            this.CalcErrIntBtn.TabIndex = 10;
            this.CalcErrIntBtn.Text = "Calculate (int error)";
            this.CalcErrIntBtn.UseVisualStyleBackColor = true;
            this.CalcErrIntBtn.Click += new System.EventHandler(this.CalcErrIntBtn_Click);
            // 
            // EmptErrBtn
            // 
            this.EmptErrBtn.Location = new System.Drawing.Point(359, 174);
            this.EmptErrBtn.Name = "EmptErrBtn";
            this.EmptErrBtn.Size = new System.Drawing.Size(150, 23);
            this.EmptErrBtn.TabIndex = 11;
            this.EmptErrBtn.Text = "Calculate (empty field error)";
            this.EmptErrBtn.UseVisualStyleBackColor = true;
            this.EmptErrBtn.Click += new System.EventHandler(this.EmptErrBtn_Click);
            // 
            // CalcUnkwnErrBtn
            // 
            this.CalcUnkwnErrBtn.Location = new System.Drawing.Point(359, 203);
            this.CalcUnkwnErrBtn.Name = "CalcUnkwnErrBtn";
            this.CalcUnkwnErrBtn.Size = new System.Drawing.Size(150, 23);
            this.CalcUnkwnErrBtn.TabIndex = 12;
            this.CalcUnkwnErrBtn.Text = "Calculate (unknown error)";
            this.CalcUnkwnErrBtn.UseVisualStyleBackColor = true;
            this.CalcUnkwnErrBtn.Click += new System.EventHandler(this.CalcUnkwnErrBtn_Click);
            // 
            // SubNTaxExcErrBtn
            // 
            this.SubNTaxExcErrBtn.Location = new System.Drawing.Point(359, 251);
            this.SubNTaxExcErrBtn.Name = "SubNTaxExcErrBtn";
            this.SubNTaxExcErrBtn.Size = new System.Drawing.Size(118, 56);
            this.SubNTaxExcErrBtn.TabIndex = 13;
            this.SubNTaxExcErrBtn.Text = "Calculate (0 subTot, 0 tax rate exception error)";
            this.SubNTaxExcErrBtn.UseVisualStyleBackColor = true;
            this.SubNTaxExcErrBtn.Click += new System.EventHandler(this.SubNTaxExcErrBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(532, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "--------------";
            // 
            // TaxBoxExcBox
            // 
            this.TaxBoxExcBox.Location = new System.Drawing.Point(181, 291);
            this.TaxBoxExcBox.Name = "TaxBoxExcBox";
            this.TaxBoxExcBox.Size = new System.Drawing.Size(100, 20);
            this.TaxBoxExcBox.TabIndex = 16;
            // 
            // GranTotExcBox
            // 
            this.GranTotExcBox.Location = new System.Drawing.Point(181, 329);
            this.GranTotExcBox.Name = "GranTotExcBox";
            this.GranTotExcBox.Size = new System.Drawing.Size(100, 20);
            this.GranTotExcBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tax Rate(%):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Grand Total (including tax):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Subtotal:";
            // 
            // SubTotExcBox
            // 
            this.SubTotExcBox.Location = new System.Drawing.Point(181, 251);
            this.SubTotExcBox.Name = "SubTotExcBox";
            this.SubTotExcBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotExcBox.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Clear Fields";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SubTotExcBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GranTotExcBox);
            this.Controls.Add(this.TaxBoxExcBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SubNTaxExcErrBtn);
            this.Controls.Add(this.CalcUnkwnErrBtn);
            this.Controls.Add(this.EmptErrBtn);
            this.Controls.Add(this.CalcErrIntBtn);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalcErrBtn);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.GranTotBox);
            this.Controls.Add(this.TaxBox);
            this.Controls.Add(this.SubTotBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubTotBox;
        private System.Windows.Forms.TextBox TaxBox;
        private System.Windows.Forms.TextBox GranTotBox;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.Button CalcErrBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClrBtn;
        private System.Windows.Forms.Button CalcErrIntBtn;
        private System.Windows.Forms.Button EmptErrBtn;
        private System.Windows.Forms.Button CalcUnkwnErrBtn;
        private System.Windows.Forms.Button SubNTaxExcErrBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TaxBoxExcBox;
        private System.Windows.Forms.TextBox GranTotExcBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SubTotExcBox;
        private System.Windows.Forms.Button button1;
    }
}

