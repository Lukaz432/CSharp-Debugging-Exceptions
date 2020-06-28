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
            this.label3.Location = new System.Drawing.Point(78, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grand Total:";
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
            this.CalcBtn.Location = new System.Drawing.Point(345, 89);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 23);
            this.CalcBtn.TabIndex = 6;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // CalcErrBtn
            // 
            this.CalcErrBtn.Location = new System.Drawing.Point(345, 188);
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
            this.label4.Location = new System.Drawing.Point(90, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Please enter a numeric value (xx.xx;  € sign is added automatically)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ClrBtn
            // 
            this.ClrBtn.Location = new System.Drawing.Point(345, 142);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(75, 23);
            this.ClrBtn.TabIndex = 9;
            this.ClrBtn.Text = "Clear Fields";
            this.ClrBtn.UseVisualStyleBackColor = true;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // CalcErrIntBtn
            // 
            this.CalcErrIntBtn.Location = new System.Drawing.Point(345, 233);
            this.CalcErrIntBtn.Name = "CalcErrIntBtn";
            this.CalcErrIntBtn.Size = new System.Drawing.Size(120, 23);
            this.CalcErrIntBtn.TabIndex = 10;
            this.CalcErrIntBtn.Text = "Calculate (int error)";
            this.CalcErrIntBtn.UseVisualStyleBackColor = true;
            this.CalcErrIntBtn.Click += new System.EventHandler(this.CalcErrIntBtn_Click);
            // 
            // EmptErrBtn
            // 
            this.EmptErrBtn.Location = new System.Drawing.Point(345, 286);
            this.EmptErrBtn.Name = "EmptErrBtn";
            this.EmptErrBtn.Size = new System.Drawing.Size(150, 23);
            this.EmptErrBtn.TabIndex = 11;
            this.EmptErrBtn.Text = "Calculate (empty field error)";
            this.EmptErrBtn.UseVisualStyleBackColor = true;
            this.EmptErrBtn.Click += new System.EventHandler(this.EmptErrBtn_Click);
            // 
            // CalcUnkwnErrBtn
            // 
            this.CalcUnkwnErrBtn.Location = new System.Drawing.Point(346, 337);
            this.CalcUnkwnErrBtn.Name = "CalcUnkwnErrBtn";
            this.CalcUnkwnErrBtn.Size = new System.Drawing.Size(150, 23);
            this.CalcUnkwnErrBtn.TabIndex = 12;
            this.CalcUnkwnErrBtn.Text = "Calculate (unknown error)";
            this.CalcUnkwnErrBtn.UseVisualStyleBackColor = true;
            this.CalcUnkwnErrBtn.Click += new System.EventHandler(this.CalcUnkwnErrBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 401);
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
    }
}

