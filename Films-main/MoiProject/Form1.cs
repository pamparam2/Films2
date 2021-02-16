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
        public string Location;
        public string Size;
    };

    public partial class Form1 : Form
    {
        Film[] films_list = new Film[700];

        public Form1()
        {
            InitializeComponent();

            
            films_list[0].category = "Кино";
            films_list[0].genre = "Научная фантастика";
            films_list[0].name = "Назад в Будущее";


            
            films_list[1].category = "Кино";
            films_list[1].genre = "Научная фантастика";
            films_list[1].name = "Начало";

            
            films_list[2].category = "Кино";
            films_list[2].genre = "Драма";
            films_list[2].name = "Побег из Шоушенка";


            films_list[3].category = "Кино";
            films_list[3].genre = "Научная фантастика";
            films_list[3].name = "Интерстеллар";

            films_list[3].category = "Кино";
            films_list[3].genre = "Научная фантастика";
            films_list[3].name = "Интерстеллар";

            for (int i = 0; i < 4; i++)
            {
                //Название фильма
                films_list[i].label = new Label();
                films_list[i].label.Location = new Point(250 * i, 100);
                films_list[i].label.Size = new Size(220, 29);
                films_list[i].label.Text = films_list[i].name;
                films_list[i].label.TextAlign = ContentAlignment.TopCenter;
                Controls.Add(films_list[i].label);

                //Картинка
                films_list[i].picture = new PictureBox();
                films_list[i].picture.Location = new Point(250 * i, 120);
                films_list[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                films_list[i].picture.Size = new Size(220, 260);
                films_list[i].picture.Tag = films_list[i].name;
                films_list[i].picture.Click += new EventHandler(OpenFilm);
                try
                {
                    films_list[i].picture.Load("../../Pictures/" + films_list[i].name + ".jpg");
                }
                catch (Exception) { }
                Controls.Add(films_list[i].picture);

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
