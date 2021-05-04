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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string adress = "";

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText("../../Всё.txt", Environment.NewLine +  
                categoryCombo.Text + "; " + textBox5.Text  + "; " + textBox1.Text + "; " + textBox3.Text + "; " + textBox4.Text);
            MessageBox.Show("Успешно сохранено!");
            if (adress != "")
                File.Copy(adress, "../../Pictures/" + textBox1.Text + ".jpg");
        
    }

        

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                pictureBox1.Load(adress);

            }
        }
    }
}
