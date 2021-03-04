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

        public Film(string category1, string genre1,  string name1 )
        {
            category = category1;
            genre = genre1;
            name = name1;
            picture = new PictureBox();
            label = new Label();
        }
    };

    public partial class Form1 : Form
    {
        Film[] films_list = new Film[700];

        public Form1()
        {
            InitializeComponent();

            films_list[0] = new Film("Кино", "Научная фантастика", "Назад в Будущее");
            films_list[1] = new Film("Кино", "Драма", "Побег из Шоушенка");
            films_list[2] = new Film("Кино", "Научная фантастика", "Интерстеллар");
            films_list[3] = new Film("Кино", "Драма", "Форрест Гамп");
            films_list[4] = new Film("Кино", "Научная фантастика", "Начало");
            films_list[5] = new Film("Кино", "Комедия", "Один дома");
            films_list[6] = new Film("Кино", "Драма", "Зелёная миля");
            films_list[7] = new Film("Кино", "Драма", "Престиж");
            films_list[8] = new Film("Кино", "Драма, Комедия", "Поймай меня если сможешь");



            int x = 10;
            int y = 100;
            for (int i = 0; i < 9; i++)
            {
                //Название фильма
                films_list[i].label = new Label();
                films_list[i].label.Location = new Point(x, y);
                films_list[i].label.Size = new Size(220, 60);
                films_list[i].label.Text = films_list[i].name;
                films_list[i].label.TextAlign = ContentAlignment.TopCenter;
                Controls.Add(films_list[i].label);

                //Картинка
                films_list[i].picture = new PictureBox();
                films_list[i].picture.Location = new Point(x, y+20);
                films_list[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                films_list[i].picture.Size = new Size(220, 260);
                films_list[i].picture.Tag = films_list[i].name;
                films_list[i].picture.Click += new EventHandler(OpenFilm);
                try
                {
                    films_list[i].picture.Load("../../Pictures/" + films_list[i].name + ".jpg");
                }
                catch (Exception)
                {
                    try
                    {
                        films_list[i].picture.Load("../../Pictures/" + films_list[i].name + ".jpeg");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            films_list[i].picture.Load("../../Pictures/" + films_list[i].name + ".jfif");
                        }
                        catch (Exception) { }
                    }
                }
                Controls.Add(films_list[i].picture);


                x = x + 230;
                if (x + 220 > Width)
                {
                    y = y + 300 ;
                    x = 10;                   
                }
            }

        }

        private void OpenFilm(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            FilmForm Nachalo = new FilmForm(pb.Tag.ToString());
            Nachalo.Show();
        }


        private void Search(object sender, EventArgs e)
        {
            int x = 10;
            int y = 100;
            for (int i = 0; i < 9; i++)
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
                
                if (films_list[i].picture.Visible)
                {

                    films_list[i].label.Location = new Point(x, y);
                    films_list[i].picture.Location = new Point(x, y + 20);

                    x = x + 230;
                    if (x + 220 > Width)
                    {
                        y = y + 300;
                        x = 10;
                    }



                }
            }
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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
