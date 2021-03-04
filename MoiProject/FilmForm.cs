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
        public FilmForm(string film)
        {
            InitializeComponent();

            try
            {
                label2.Text = film;
                pictureBox1.Load("../../Pictures/"+ film + ".jpg");
                
                textBox1.Text = File.ReadAllText("../../Pictures/" + film + ".txt");
            }
            catch (Exception) { }
            try
            {
                label2.Text = film;
                pictureBox1.Load("../../Pictures/" + film + ".jpeg");

                textBox1.Text = File.ReadAllText("../../Pictures/" + film + ".txt");
            }
            catch (Exception) { }
            try
            {
                label2.Text = film;
                pictureBox1.Load("../../Pictures/" + film + ".jfif");

                textBox1.Text = File.ReadAllText("../../Pictures/" + film + ".txt");
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
    }
}
