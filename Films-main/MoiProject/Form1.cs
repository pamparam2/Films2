using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoiProject
{
    public struct Film
    {
        public PictureBox picture;
        public string category;
        public string genre;
        public string name;
    };

    public partial class Form1 : Form
    {
        Film[] films_list = new Film[700];

        public Form1()
        {
            InitializeComponent();

            films_list[0].picture = pictureBox3;
            films_list[0].category = "Кино";
            films_list[0].genre = "Научная фантастика";
            films_list[0].name = "Назад в Будущее";


            films_list[1].picture = pictureBox1;
            films_list[1].category = "Кино";
            films_list[1].genre = "Научная фантастика";
            films_list[1].name = "Начало";

            films_list[2].picture = pictureBox2;
            films_list[2].category = "Кино";
            films_list[2].genre = "Драма";
            films_list[2].name = "Побег из Шоушенка";
        
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FilmForm Nachalo = new FilmForm(label2.Text);
            Nachalo.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FilmForm Nachalo = new FilmForm("Побег из Шоушенка");
            Nachalo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                films_list[i].picture.Visible = false;
                if (films_list[i].name.Contains(textBox1.Text))
                    films_list[i].picture.Visible = true;
            }
            /*
            if (textBox1.Text.Contains("Начало"))
            {
                pictureBox1.Visible = true;
                label2.Visible = true;
                pictureBox1.Load("../../Pictures/nachalo.jpg");
                label2.Text = films_list[7].name;
            }
            else if (textBox1.Text.Contains("Побег"))
            {
                pictureBox1.Visible = true;
                label2.Visible = true;
                pictureBox1.Load("../../Pictures/poster.jpg");
                label2.Text = "Побег из Шоушенка";
            }
            else if (textBox1.Text.Contains("Властелин Колец:Возвращение Короля "))
            {
                pictureBox1.Visible = true;
                label2.Visible = true;
                pictureBox1.Load("../../Pictures/vlastelin.jpg");
            }
            else if (textBox1.Text.Contains("Назад в Будущее"))
            {
                pictureBox1.Visible = true;
                label2.Visible = true;
                pictureBox1.Load("../../Pictures/backfuture.jpg");
            }
            else if (textBox1.Text.Contains("Форрест Гамп"))
            {
                pictureBox1.Visible = true;
                label2.Visible = true;
                pictureBox1.Load("../../Pictures/forestgamp.jpg");
                label2.Text = "Форрест Гамп";
            }
            else if (textBox1.Text.Contains("Побег"))
            {
                pictureBox1.Visible = true;
                label2.Visible = true;
                pictureBox1.Load("../../Pictures/poster.jpg");
            }

            else
            { 
                pictureBox1.Visible = false;
                label2.Visible = false;
            }*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("Побег из Шоушенка"))
            {
                textBox1.Text = "";

            }
                
                
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
