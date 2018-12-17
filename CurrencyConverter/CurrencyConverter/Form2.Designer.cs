namespace CurrencyConverter
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "                1 RUB= 0.032 BYN | 0.013 EUR | 0.015 USD | 0.056 PLN | 0.43 UAX",
            "                1 UAX= 0.13 PLN | 0.0074 BLN | 0.036 USD | 0.030 EUR | 2.34 RUB",
            "                1 PLN= 0.57 BYN | 0.27 USD | 0.23 EUR | 17.29 RUB | 7.67 UAX",
            "                1 BYN= 0.48 USD | 0.41 EUR | 1.76 PLN | 31.60 RUB | 13.48 UAX",
            "                1 USD= 65.83 RUB | 2.08 BYN | 0.85 EUR | 3.66 PLN | 28.12 UAX",
            "                1 UAX= 0.13 PLN | 0.0074 BLN | 0.036 USD | 0.030 EUR | 2.34 RUB",
            "",
            "",
            ""});
            this.listBox1.Location = new System.Drawing.Point(47, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(570, 228);
            this.listBox1.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 317);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
    }
}