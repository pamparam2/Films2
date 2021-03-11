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
        public FilmForm(string name)
        {
            InitializeComponent();

            Text = name; 
            foreach (Film film1 in Form1.films_list)
            {
                if (film1.name == name)
                {
                    film = film1;
                    label2.Text = film1.name;
                    pictureBox1.Image = film1.picture.Image;
                    textBox1.Text = File.ReadAllText("../../Pictures/" + name + ".txt");
                }
            }


            try
            {
                textBox1.Text = File.ReadAllText("../../Pictures/" + name + ".txt");
            }
            catch (Exception) { }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(film.imdb);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start(film.kinopoisk);
        }
    }
}
