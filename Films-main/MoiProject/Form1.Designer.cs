
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.categoryCombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelnach = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelpob = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelback = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelint = new System.Windows.Forms.Label();
            this.genreCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryCombo
            // 
            this.categoryCombo.FormattingEnabled = true;
            this.categoryCombo.Items.AddRange(new object[] {
            "Игры",
            "Кино",
            "Сериалы"});
            this.categoryCombo.Location = new System.Drawing.Point(158, 12);
            this.categoryCombo.Name = "categoryCombo";
            this.categoryCombo.Size = new System.Drawing.Size(161, 37);
            this.categoryCombo.TabIndex = 3;
            this.categoryCombo.Text = "Кино";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 11);
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
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Категория";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 34);
            this.textBox1.TabIndex = 6;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // labelnach
            // 
            this.labelnach.AutoSize = true;
            this.labelnach.Location = new System.Drawing.Point(79, 124);
            this.labelnach.Name = "labelnach";
            this.labelnach.Size = new System.Drawing.Size(99, 29);
            this.labelnach.TabIndex = 7;
            this.labelnach.Text = "Начало";
            this.labelnach.UseMnemonic = false;
            this.labelnach.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Начало";
            this.pictureBox1.Click += new System.EventHandler(this.OpenFilm);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(272, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Побег из Шоушенка";
            this.pictureBox2.Click += new System.EventHandler(this.OpenFilm);
            // 
            // labelpob
            // 
            this.labelpob.AutoSize = true;
            this.labelpob.Location = new System.Drawing.Point(267, 124);
            this.labelpob.Name = "labelpob";
            this.labelpob.Size = new System.Drawing.Size(242, 29);
            this.labelpob.TabIndex = 10;
            this.labelpob.Text = "Побег из Шоушенка";
            this.labelpob.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(535, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(229, 260);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Назад в Будущее";
            this.pictureBox3.Click += new System.EventHandler(this.OpenFilm);
            // 
            // labelback
            // 
            this.labelback.AutoSize = true;
            this.labelback.Location = new System.Drawing.Point(557, 124);
            this.labelback.Name = "labelback";
            this.labelback.Size = new System.Drawing.Size(207, 29);
            this.labelback.TabIndex = 13;
            this.labelback.Text = "Назад в Будущее\r\n";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(798, 156);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(229, 260);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "Интерстеллар";
            this.pictureBox4.Click += new System.EventHandler(this.OpenFilm);
            // 
            // labelint
            // 
            this.labelint.AutoSize = true;
            this.labelint.Location = new System.Drawing.Point(822, 124);
            this.labelint.Name = "labelint";
            this.labelint.Size = new System.Drawing.Size(181, 29);
            this.labelint.TabIndex = 16;
            this.labelint.Text = "Интерстеллар\r\n";
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
            this.genreCombo.Location = new System.Drawing.Point(158, 67);
            this.genreCombo.Name = "genreCombo";
            this.genreCombo.Size = new System.Drawing.Size(161, 37);
            this.genreCombo.TabIndex = 19;
            this.genreCombo.SelectedIndexChanged += new System.EventHandler(this.genreCombo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1092, 553);
            this.Controls.Add(this.genreCombo);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.labelint);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelback);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelpob);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelnach);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryCombo);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Сервис рецензий на игры";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelnach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelpob;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelback;
        private System.Windows.Forms.ComboBox categoryCombo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelint;
        private System.Windows.Forms.ComboBox genreCombo;
    }
}

