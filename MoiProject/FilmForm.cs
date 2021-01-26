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
    public partial class FilmForm : Form
    {
        public FilmForm(string film)
        {
            InitializeComponent();

            if (film == "Побег из Шоушенка")
            {
                pictureBox1.Load("../../Pictures/poster.jpg");
                textBox1.Text = "ФИльм про судьбу двух зеков. " +
                    "Один убежал, второй - Морган Фриман";
            }
            if (film == "Форрест Гамп")
            {
                pictureBox1.Load("../../Pictures/" + film + ".jpg");
                textBox1.Text = "ФИльм про очень тупого Тома Хэнкса и двух зеков. " +
                    "Один убежал, второй - Морган Фриман";
            }
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
    }
}
