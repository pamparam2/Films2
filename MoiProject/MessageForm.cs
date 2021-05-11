using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace MoiProject
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                MailAddress from = new MailAddress("interesno22815@gmail.com", "Ilya");
                // кому отправляем
                MailAddress to = new MailAddress("istrelov10@gmail.com");
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = comboBox1.Text;

                // текст письма
                m.Body = textBox3.Text +
                    Environment.NewLine + "Отправитель: " + textBox1.Text;
    
                if (adress != "")
                {
                    Attachment x = new Attachment(adress);
                    x.Name = "1.png";
                    m.Attachments.Add(x);
                }

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                // логин и пароль
                smtp.Credentials = new NetworkCredential(from.Address, "Proverka12345");
                smtp.EnableSsl = true;
                smtp.Send(m);

                MessageBox.Show("Успешно отправлено!");
            }
        }

        string adress = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                pictureBox1.Load(adress);

            }
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
