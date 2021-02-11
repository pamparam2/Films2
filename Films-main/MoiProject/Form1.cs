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
        public Label label;
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

            films_list[0].label = labelback;
            films_list[0].picture = pictureBox3;
            films_list[0].category = "Кино";
            films_list[0].genre = "Научная фантастика";
            films_list[0].name = "Назад в Будущее";


            films_list[1].label = labelnach;
            films_list[1].picture = pictureBox1;
            films_list[1].category = "Кино";
            films_list[1].genre = "Научная фантастика";
            films_list[1].name = "Начало";

            films_list[2].label = labelpob;
            films_list[2].picture = pictureBox2;
            films_list[2].category = "Кино";
            films_list[2].genre = "Драма";
            films_list[2].name = "Побег из Шоушенка";

            films_list[3].label = labelint;
            films_list[3].picture = pictureBox4;
            films_list[3].category = "Кино";
            films_list[3].genre = "Научная фантастика";
            films_list[3].name = "Интерстеллар";

            for (int i = 0; i < 4; i++)
                films_list[i].picture.Tag = films_list[i].name;

        }

        private void OpenFilm(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            FilmForm Nachalo = new FilmForm(pb.Tag.ToString());
            Nachalo.Show();
        }


        private void Search(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                films_list[i].picture.Visible = true;
                films_list[i].label.Visible = true;
                if (textBox1.Text != "" &&
                    !films_list[i].name.Contains(textBox1.Text))
                {
                    films_list[i].picture.Visible = false;
                    films_list[i].label.Visible = false;
                }

                if (categoryCombo.Text != "" &&
                   !films_list[i].category.Contains(categoryCombo.Text))
                {
                    films_list[i].picture.Visible = false;
                    films_list[i].label.Visible = false;
                }
                if (genreCombo.Text != "" &&
                   !films_list[i].genre.Contains(genreCombo.Text))
                {
                    films_list[i].picture.Visible = false;
                    films_list[i].label.Visible = false;
                }
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

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void genreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }
    }
}
