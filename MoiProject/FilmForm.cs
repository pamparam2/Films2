using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoiProject
{
    public partial class FilmForm : Form
    {
        Film film;
        void translate(Dictionary<string, string> words)
        {

            label1.Text = words["Описание"];
            label3.Text = words["Оценки:"];
        }
        public FilmForm(string name)
        {
            InitializeComponent();


            if (Form1.Language==  "Русский")
                 translate(Form1.RusWords);
            if (Form1.Language == "Английский")
                 translate(Form1.EngWords);



            Text = name; 
            foreach (Film film1 in Form1.films_list)
            {
                if (film1.name == name)
                {
                    film = film1;
                    label2.Text = film1.name;
                    label5.Text = film1.ocenkaimdb;
                    label4.Text = film1.ocenkakinopoisk;
                    pictureBox1.Image = film1.picture.Image;
                    try
                    {
                        textBox1.Text = File.ReadAllText("../../Pictures/" + name + ".txt");
                    }
                    catch (Exception) { }

                    if (film1.category == "Игры")
                    {
                        linkLabel1.Text = "Metacritic:";
                        linkLabel2.Visible = false;
                        label5.Visible = false;
                    }
                }
            }


        }
        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(film.imdb);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(film.kinopoisk);
        }

        /// <summary>
        /// Добавит в "смотреть позже"
        /// </summary>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1.sohraneno_list.Add(film);
            MessageBox.Show("Успешно сохранено!");
        }

        private void FilmForm_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
