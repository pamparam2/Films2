using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public string imdb;
        public string kinopoisk;
        public string ocenkakinopoisk;
        public string ocenkaimdb;

        public Film(string category1, string genre1,  string name1, string site1, string site2, string ocenka1, string ocenka2)
        {
            category = category1;
            genre = genre1;
            name = name1;
            imdb = site1;
            kinopoisk = site2;
            ocenkakinopoisk = ocenka1;
            ocenkaimdb = ocenka2;
            picture = new PictureBox();
            label = new Label();
        }
    };

    public partial class Form1 : Form
    {
        public static List<Film> films_list = new List<Film>();
        public static List<Film> sohraneno_list = new List<Film>();
        public static Dictionary<string, string> EngWords = new Dictionary<string, string>();
        public static Dictionary<string, string> RusWords = new Dictionary<string, string>();
        public static string Language;

        void translate(Dictionary<string, string> words)
        {
            label1.Text = words["Категория"] + ":";
            label2.Text = words["Жанр"];
            button2.Text = words["Избранное"];
            button1.Text = words["Найти"];
            button4.Text = words["Добавить"];
            button5.Text = words["Войти"];
            button6.Text = words["Помощь"]; 



        }

        private void EngButton_Click(object sender, EventArgs e)
        {
            translate(EngWords);
            Form1.Language = "Английский";
        }

        private void RuButton_Click(object sender, EventArgs e)
        {
            translate(RusWords);
            Form1.Language = "Русский";
        }
        public Form1()
        {
            InitializeComponent();

            EngWords.Add("Категория", "Category");
            EngWords.Add("Жанр", "Genre");
            EngWords.Add("Найти", "Search");
            EngWords.Add("Избранное", "Basket");
            EngWords.Add("Описание", "Description");
            EngWords.Add("Оценки:", "Ratings:");
            EngWords.Add("Добавить", "Add");
            EngWords.Add("Помощь", "Support");
            EngWords.Add("Войти", "Sign");



            RusWords.Add("Категория", "Категория");
            RusWords.Add("Жанр", "Жанр");
            RusWords.Add("Найти", "Найти");
            RusWords.Add("Избранное", "Избранное");
            RusWords.Add("Описание", "Описание");
            RusWords.Add("Оценки:", "Оценки:");
            RusWords.Add("Добавить", "Добавить");
            RusWords.Add("Помощь", "Помощь");
            RusWords.Add("Войти", "Войти");

            string[] lines = File.ReadAllLines("../../Всё.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { "; " }, StringSplitOptions.None);
                if (parts.Length > 6)//больше двух элементов в блокноте том...
                {
                    films_list.Add(new Film(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]));

                    if (!categoryCombo.Items.Contains(parts[0]))
                        categoryCombo.Items.Add(parts[0]);
                }
            }

            /*
            films_list.Add(new Film("Кино", "Научная фантастика", "Назад в Будущее", "https://imdb.com/title/tt0088763/", "https://kinopoisk.ru/film/476/", "2.28", "2.28"));
            films_list.Add(new Film("Кино", "Драма", "Побег из Шоушенка", "https://imdb.com/title/tt0111161/", "https://kinopoisk.ru/film/326/", "2.28", "2.28"));
            films_list.Add(new Film("Кино", "Научная фантастика", "Интерстеллар", "https://imdb.com/title/tt0816692/", "https://kinopoisk.ru/film/258687/", "2.28", "2.28"));
            films_list.Add(new Film("Кино", "Драма", "Форрест Гамп", "https://imdb.com/title/tt0109830/", "https://kinopoisk.ru/film/448/", "2.28", "2.28"));
            films_list.Add(new Film("Кино", "Научная фантастика", "Начало", "https://imdb.com/title/tt1375666/", "https://kinopoisk.ru/film/447301/", "2.28", "2.28"));
            films_list.Add(new Film("Кино", "Комедия", "Один дома", "https://imdb.com/title/tt0099785/", "https://kinopoisk.ru/film/8124/", "2.28", "2.28"));
            films_list.Add(new Film("Кино", "Драма", "Зелёная миля", "https://imdb.com/title/tt0120689/", "https://kinopoisk.ru/film/435/", "2.28", "2.28"));
            films_list.Add(new Film("Кино", "Драма", "Престиж", "https://imdb.com/title/tt0120689/", "https://kinopoisk.ru/film/195334/", "2.28", "2.28"));
            films_list.Add(new Film("Кино", "Драма, Комедия", "Поймай меня если сможешь", "https://imdb.com/title/tt0264464/", "https://kinopoisk.ru/324/", "2.28", "2.28"));
            films_list.Add(new Film("Кино", "Драма, Детектив", "Остров проклятых", "https://imdb.com/title/tt1130884/", "https://kinopoisk.ru/film/397667/", "2.28", "2.28"));
            films_list.Add(new Film("Кино", "Научная фантастика, Комедия", "Матрица", "https://imdb.com/title/tt0133093/", "https://kinopoisk.ru/film/301/", "2.28", "2.28"));
            films_list.Add(new Film("Кино", "Драма, Триллер", "Бойцовский клуб", "https://imdb.com/title/tt0137523/", "https://kinopoisk.ru/film/361/", "2.28", "2.28"));
            films_list.Add(new Film("Игры", "Шутер", "Half-life", "", "https://metacritic.com/game/pc/half-life", "2.28", ""));//
            */

            
            int x = 10;
            int y = 10;
            for (int i = 0; i < films_list.Count; i++)
            {
                //Название фильма
                films_list[i].label.Location = new Point(x, y);
                films_list[i].label.Size = new Size(220, 60);
                films_list[i].label.AutoSize = false;
                films_list[i].label.TextAlign = ContentAlignment.BottomCenter;
                films_list[i].label.Text = films_list[i].name;
                films_list[i].label.TextAlign = ContentAlignment.TopCenter;
                filmsPanel.Controls.Add(films_list[i].label);

                //Картинка
                films_list[i].picture.Location = new Point(x, y + 60);
                films_list[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                films_list[i].picture.Size = new Size(220, 260);
                films_list[i].picture.Tag = films_list[i].name;
                films_list[i].picture.Click += new EventHandler(OpenFilm);
                try
                {
                    films_list[i].picture.Load("../../Pictures/" + films_list[i].name.Trim() + ".jpg");
                }
                catch (Exception)
                {
                    try
                    {
                        films_list[i].picture.Load("../../Pictures/" + films_list[i].name.Trim() + ".jpeg");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            films_list[i].picture.Load("../../Pictures/" + films_list[i].name.Trim() + ".jfif");
                        }
                        catch (Exception) { }
                    }
                }
                filmsPanel.Controls.Add(films_list[i].picture);


                x = x + 230;
                if (x + 220 > Width)
                {
                    y = y + 340;
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
            int y = 10;
            for (int i = 0; i < films_list.Count; i++)
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
                        y = y + 340;
                        x = 10;
                    }



                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("Побег из Шоушенка"))
            {
                textBox1.Text = "";

            }
                
                
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void genreCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form SohranenoForm = new SohranenoForm();
            SohranenoForm.Show();

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search(null, null);
            }
        }

        private void categoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            genreCombo.Items.Clear();
            if (categoryCombo.Text == "Игры")
            {
                genreCombo.Items.AddRange(new object[] {
                    "Экшен",
                    "Платформер",
                    "Шутер",
                    "Файтинг",
                    "BEAT-EM UP",
                    "Стелс - экшен",
                    "Интерактивное кино",
                    "РПГ",
                    "Симулятор",
                    "Стратегия",
                    "Песочница",
                    "Хоррор",



                });
            }

            else if (categoryCombo.Text == "Сериалы")
            {
                genreCombo.Items.AddRange(new object[] {
                 "Комедийные",
                    "Фантастические",
                    "Драматические",
                    "Документальные фильмы",
                    "Боевики",
                    "Триллеры",
                    "Хорроры",
                    "Криминальные",
                    "Мультфильм",
                    "Приключения ",
                    "Мюзиклы",
                    "Мелодрамы",
                    "Детективы"});
            }
            else if (categoryCombo.Text == "Кино")
            {
                genreCombo.Items.AddRange(new object[] {
                    "Комедия",
                    "Фантастика",
                    "Драма",
                    "Документальный фильм",
                    "Боевик",
                    "Триллер",
                    "Хоррор",
                    "Криминал",
                    "Мультфильмы",
                    "Приключение",
                    "Вестерн",
                    "Мюзикл",
                    "Детектив"});
            }


            Search(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (filterPanel.Height > 50)
            {
                filterPanel.Height = 50;            
            }
            else
            {
                filterPanel.Height = 100;
            } 
               
        }

        private void filmsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form AddForm = new AddForm();
            AddForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SignForm Form1 = new SignForm();
            Form1.ShowDialog();

            if (SignForm.Login == "Админ") 
            {
              SignForm.Password = "qwerty1234";
          
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form MessageForm = new MessageForm();
            MessageForm.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
