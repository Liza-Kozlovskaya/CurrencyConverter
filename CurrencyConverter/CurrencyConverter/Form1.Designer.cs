namespace CurrencyConverter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.fromcombo1 = new System.Windows.Forms.ComboBox();
            this.tocombo2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.display_txt = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсВалютToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rUBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bYNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eURToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uAXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Convert = new System.Windows.Forms.Button();
            this.курсВалютToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите сумму";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите валюту";
            // 
            // amount_txt
            // 
            this.amount_txt.Location = new System.Drawing.Point(149, 91);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(207, 22);
            this.amount_txt.TabIndex = 2;
            // 
            // fromcombo1
            // 
            this.fromcombo1.FormattingEnabled = true;
            this.fromcombo1.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "RUB",
            "BYN",
            "PLN",
            "UAX"});
            this.fromcombo1.Location = new System.Drawing.Point(149, 138);
            this.fromcombo1.Name = "fromcombo1";
            this.fromcombo1.Size = new System.Drawing.Size(207, 24);
            this.fromcombo1.TabIndex = 3;
            // 
            // tocombo2
            // 
            this.tocombo2.FormattingEnabled = true;
            this.tocombo2.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "RUB",
            "BYN",
            "PLN",
            "UAX"});
            this.tocombo2.Location = new System.Drawing.Point(149, 191);
            this.tocombo2.Name = "tocombo2";
            this.tocombo2.Size = new System.Drawing.Size(207, 24);
            this.tocombo2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите валюту \r\nдля конвертации";
            // 
            // display_txt
            // 
            this.display_txt.AutoSize = true;
            this.display_txt.Location = new System.Drawing.Point(82, 289);
            this.display_txt.Name = "display_txt";
            this.display_txt.Size = new System.Drawing.Size(42, 17);
            this.display_txt.TabIndex = 6;
            this.display_txt.Text = "Итог:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.курсВалютToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.курсВалютToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.exitToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem1.Text = "Выход";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.ExitToolStripMenuItem1_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПриложенииToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.оПриложенииToolStripMenuItem.Text = "О приложении";
            this.оПриложенииToolStripMenuItem.Click += new System.EventHandler(this.ОПриложенииToolStripMenuItem_Click);
            // 
            // курсВалютToolStripMenuItem
            // 
            this.курсВалютToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rUBToolStripMenuItem,
            this.bYNToolStripMenuItem,
            this.eURToolStripMenuItem,
            this.pLNToolStripMenuItem,
            this.uAXToolStripMenuItem,
            this.uSDToolStripMenuItem});
            this.курсВалютToolStripMenuItem.Name = "курсВалютToolStripMenuItem";
            this.курсВалютToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.курсВалютToolStripMenuItem.Text = "Курс валют";
            // 
            // rUBToolStripMenuItem
            // 
            this.rUBToolStripMenuItem.Name = "rUBToolStripMenuItem";
            this.rUBToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.rUBToolStripMenuItem.Text = "RUB";
            this.rUBToolStripMenuItem.Click += new System.EventHandler(this.RUBToolStripMenuItem_Click);
            // 
            // bYNToolStripMenuItem
            // 
            this.bYNToolStripMenuItem.Name = "bYNToolStripMenuItem";
            this.bYNToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.bYNToolStripMenuItem.Text = "BYN";
            this.bYNToolStripMenuItem.Click += new System.EventHandler(this.BYNToolStripMenuItem_Click);
            // 
            // eURToolStripMenuItem
            // 
            this.eURToolStripMenuItem.Name = "eURToolStripMenuItem";
            this.eURToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.eURToolStripMenuItem.Text = "EUR";
            this.eURToolStripMenuItem.Click += new System.EventHandler(this.EURToolStripMenuItem_Click);
            // 
            // pLNToolStripMenuItem
            // 
            this.pLNToolStripMenuItem.Name = "pLNToolStripMenuItem";
            this.pLNToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.pLNToolStripMenuItem.Text = "PLN";
            this.pLNToolStripMenuItem.Click += new System.EventHandler(this.PLNToolStripMenuItem_Click);
            // 
            // uAXToolStripMenuItem
            // 
            this.uAXToolStripMenuItem.Name = "uAXToolStripMenuItem";
            this.uAXToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.uAXToolStripMenuItem.Text = "UAX";
            this.uAXToolStripMenuItem.Click += new System.EventHandler(this.UAXToolStripMenuItem_Click);
            // 
            // uSDToolStripMenuItem
            // 
            this.uSDToolStripMenuItem.Name = "uSDToolStripMenuItem";
            this.uSDToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.uSDToolStripMenuItem.Text = "USD";
            this.uSDToolStripMenuItem.Click += new System.EventHandler(this.USDToolStripMenuItem_Click);
            // 
            // Convert
            // 
            this.Convert.BackColor = System.Drawing.Color.MidnightBlue;
            this.Convert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Convert.Location = new System.Drawing.Point(224, 234);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(132, 29);
            this.Convert.TabIndex = 9;
            this.Convert.Text = "Конвертировать";
            this.Convert.UseVisualStyleBackColor = false;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // курсВалютToolStripMenuItem1
            // 
            this.курсВалютToolStripMenuItem1.Name = "курсВалютToolStripMenuItem1";
            this.курсВалютToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.курсВалютToolStripMenuItem1.Text = "Курс валют";
            this.курсВалютToolStripMenuItem1.Click += new System.EventHandler(this.курсВалютToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(406, 359);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.display_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tocombo2);
            this.Controls.Add(this.fromcombo1);
            this.Controls.Add(this.amount_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.ComboBox fromcombo1;
        private System.Windows.Forms.ComboBox tocombo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label display_txt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem курсВалютToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rUBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bYNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eURToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uAXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсВалютToolStripMenuItem1;
    }
}

