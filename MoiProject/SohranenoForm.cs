﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace MoiProject
{
    public partial class SohranenoForm : Form
    {
        public SohranenoForm()
        {
            InitializeComponent();

            int x = 10;
            int y = 100;
            foreach (Film film in Form1.sohraneno_list)
            {
                //Название фильма
                Label label = new Label();
                label.Location = new Point(x + 60, y - 70);
                label.Size = new Size(220, 60);
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = film.name;
                label.Font = new Font("Arial", 11);
                Controls.Add(label);
                //Картинка
                PictureBox picture = new PictureBox();
                picture.Image = film.picture.Image;
                picture.Location = new Point(x + 60, y );
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Size = new Size(220, 260);
                picture.Tag = film.name;
             
                Controls.Add(picture);

                x = x + 230;
                if (x + 220 > Width)
                {
                    y = y + 340;
                    x = 10;
                }

            }
        }

        private void follow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("interesno22815@gmail.com", "Ilya");
            // кому отправляем
            MailAddress to = new MailAddress(textBox1.Text);
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "";

            // текст письма
            m.Body = "Привет! Здесь сохранённые тобой фильмы, сериалы и т.д.";
            File.WriteAllText("Сохранённое.csv", "Название, Оценка1, Оценка2, Ссылка");
            foreach (Film film in Form1.sohraneno_list)
            {
                File.AppendAllText("Сохранённое.csv",
                    Environment.NewLine +
                    film.name +  "," + film.ocenkakinopoisk + "," + film.ocenkaimdb + "," +  film.kinopoisk);
            }
            m.Attachments.Add(new Attachment("Сохранённое.csv"));

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential(from.Address, "Proverka12345");
            smtp.EnableSsl = true;
            smtp.Send(m);

            MessageBox.Show("Успешно отправлено!");
        }
    }
}
