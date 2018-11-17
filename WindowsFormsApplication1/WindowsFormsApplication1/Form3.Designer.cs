namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.oprocentowanie = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.anualCost = new System.Windows.Forms.TextBox();
            this.taxRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inflationRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // oprocentowanie
            // 
            this.oprocentowanie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oprocentowanie.FormattingEnabled = true;
            this.oprocentowanie.Location = new System.Drawing.Point(143, 58);
            this.oprocentowanie.Name = "oprocentowanie";
            this.oprocentowanie.Size = new System.Drawing.Size(121, 21);
            this.oprocentowanie.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(25, 217);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "KIEDY SKOŃCZY SIĘ KASA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Oprocentowanie [%]";
            // 
            // startMoney
            // 
            this.startMoney.Location = new System.Drawing.Point(143, 32);
            this.startMoney.Name = "startMoney";
            this.startMoney.Size = new System.Drawing.Size(100, 20);
            this.startMoney.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Oszczędności";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Licz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Wydatki rocznie";
            // 
            // anualCost
            // 
            this.anualCost.Location = new System.Drawing.Point(143, 87);
            this.anualCost.Name = "anualCost";
            this.anualCost.Size = new System.Drawing.Size(100, 20);
            this.anualCost.TabIndex = 18;
            // 
            // taxRate
            // 
            this.taxRate.Location = new System.Drawing.Point(143, 116);
            this.taxRate.Name = "taxRate";
            this.taxRate.Size = new System.Drawing.Size(92, 20);
            this.taxRate.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Inflacja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Podatek od kapitału";
            // 
            // inflationRate
            // 
            this.inflationRate.Location = new System.Drawing.Point(143, 146);
            this.inflationRate.Name = "inflationRate";
            this.inflationRate.Size = new System.Drawing.Size(100, 20);
            this.inflationRate.TabIndex = 20;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.inflationRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.taxRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.anualCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.oprocentowanie);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox oprocentowanie;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox anualCost;
        private System.Windows.Forms.TextBox taxRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inflationRate;
    }
}