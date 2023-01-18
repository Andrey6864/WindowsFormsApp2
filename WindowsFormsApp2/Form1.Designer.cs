namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.клиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.валютаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.валютаКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентToolStripMenuItem,
            this.клиентToolStripMenuItem1,
            this.валютаToolStripMenuItem,
            this.валютаКлиентаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // клиентToolStripMenuItem
            // 
            this.клиентToolStripMenuItem.Name = "клиентToolStripMenuItem";
            this.клиентToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.клиентToolStripMenuItem.Text = "Регистрация";
            this.клиентToolStripMenuItem.Click += new System.EventHandler(this.клиентToolStripMenuItem_Click);
            // 
            // клиентToolStripMenuItem1
            // 
            this.клиентToolStripMenuItem1.Name = "клиентToolStripMenuItem1";
            this.клиентToolStripMenuItem1.Size = new System.Drawing.Size(58, 20);
            this.клиентToolStripMenuItem1.Text = "Клиент";
            this.клиентToolStripMenuItem1.Click += new System.EventHandler(this.клиентToolStripMenuItem1_Click);
            // 
            // валютаToolStripMenuItem
            // 
            this.валютаToolStripMenuItem.Name = "валютаToolStripMenuItem";
            this.валютаToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.валютаToolStripMenuItem.Text = "Валюта ";
            this.валютаToolStripMenuItem.Click += new System.EventHandler(this.валютаToolStripMenuItem_Click);
            // 
            // валютаКлиентаToolStripMenuItem
            // 
            this.валютаКлиентаToolStripMenuItem.Name = "валютаКлиентаToolStripMenuItem";
            this.валютаКлиентаToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.валютаКлиентаToolStripMenuItem.Text = "Валюта клиента";
            this.валютаКлиентаToolStripMenuItem.Click += new System.EventHandler(this.валютаКлиентаToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Для регистрациии под учеткой админа или пользователя вам нужно нажать на кнопку \"" +
    "Регистрация\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Для редактирование таблиц вам нужно перейти на 4 вкладки \"Клиент\", \"Валюта\", \"Вал" +
    "юта клиента\".";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 114);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "База данных Банка РФ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem валютаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem валютаКлиентаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button2;
    }
}

