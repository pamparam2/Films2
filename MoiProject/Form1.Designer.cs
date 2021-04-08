
namespace MoiProject
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
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.genreCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.filmsPanel = new System.Windows.Forms.Panel();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.EngButton = new System.Windows.Forms.Button();
            this.RuButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryCombo
            // 
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Items.AddRange(new object[] {
            "Игры",
            "Кино",
            "Сериалы"});
            this.categoryCombo.Location = new System.Drawing.Point(156, 17);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(161, 37);
            this.categoryCombo.TabIndex = 3;
            this.categoryCombo.Text = "Кино";
            this.categoryCombo.SelectedIndexChanged += new System.EventHandler(this.categoryCombo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(262, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Search);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Категория:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 34);
            this.textBox1.TabIndex = 6;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // genreCombo
            // 
            this.genreCombo.FormattingEnabled = true;
            this.genreCombo.Items.AddRange(new object[] {
            "Комедия",
            "Научная фантастика",
            "Драма",
            "Документальный фильм",
            "Боевик",
            "Триллер",
            "Хоррор",
            "Детектив"});
            this.genreCombo.Location = new System.Drawing.Point(156, 72);
            this.genreCombo.Name = "genreCombo";
            this.genreCombo.Size = new System.Drawing.Size(161, 37);
            this.genreCombo.TabIndex = 19;
            this.genreCombo.SelectedIndexChanged += new System.EventHandler(this.Search);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Жанр:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(366, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "Сохранённое";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1019, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 45);
            this.button3.TabIndex = 22;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // filmsPanel
            // 
            this.filmsPanel.AutoScroll = true;
            this.filmsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filmsPanel.Location = new System.Drawing.Point(0, 112);
            this.filmsPanel.Name = "filmsPanel";
            this.filmsPanel.Size = new System.Drawing.Size(1092, 441);
            this.filmsPanel.TabIndex = 23;
            this.filmsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.filmsPanel_Paint);
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.button4);
            this.filterPanel.Controls.Add(this.EngButton);
            this.filterPanel.Controls.Add(this.RuButton);
            this.filterPanel.Controls.Add(this.label1);
            this.filterPanel.Controls.Add(this.button3);
            this.filterPanel.Controls.Add(this.button1);
            this.filterPanel.Controls.Add(this.button2);
            this.filterPanel.Controls.Add(this.categoryCombo);
            this.filterPanel.Controls.Add(this.label2);
            this.filterPanel.Controls.Add(this.textBox1);
            this.filterPanel.Controls.Add(this.genreCombo);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(1092, 112);
            this.filterPanel.TabIndex = 24;
            this.filterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.filterPanel_Paint);
            // 
            // EngButton
            // 
            this.EngButton.Location = new System.Drawing.Point(880, 65);
            this.EngButton.Name = "EngButton";
            this.EngButton.Size = new System.Drawing.Size(56, 43);
            this.EngButton.TabIndex = 24;
            this.EngButton.Text = "EN";
            this.EngButton.UseVisualStyleBackColor = true;
            this.EngButton.Click += new System.EventHandler(this.EngButton_Click);
            // 
            // RuButton
            // 
            this.RuButton.Location = new System.Drawing.Point(818, 65);
            this.RuButton.Name = "RuButton";
            this.RuButton.Size = new System.Drawing.Size(56, 43);
            this.RuButton.TabIndex = 23;
            this.RuButton.Text = "RU";
            this.RuButton.UseVisualStyleBackColor = true;
            this.RuButton.Click += new System.EventHandler(this.RuButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(674, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 39);
            this.button4.TabIndex = 25;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1092, 553);
            this.Controls.Add(this.filmsPanel);
            this.Controls.Add(this.filterPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Сервис рецензий на игры";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Search);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.ComboBox genreCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel filmsPanel;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Button EngButton;
        private System.Windows.Forms.Button RuButton;
        private System.Windows.Forms.Button button4;
    }
}

