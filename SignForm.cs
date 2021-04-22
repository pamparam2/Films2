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

    public partial class SignForm : Form
        
    {
        public SignForm()

        {
            InitializeComponent();
            Users = new List<string>();
            Users.Add("Админ");            Users.Add("qwerty1234");
        }
        
        public static string Login = "";
        public static string Password = "";
        List<string> Users = new List<string>();

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                for (int i = 0; i < Users.Count; i = i + 2)
                {
                    if (textBox1.Text != "" & textBox2.Text != "")
                    {
                        if (textBox1.Text == Users[i] & textBox2.Text == Users[i + 1])
                        {
                            if (Users[i] == "Admin")
                                MessageBox.Show("Вы вошли в аккаунт админа");
                            else
                                MessageBox.Show("Вы вошли в аккаунт");
                            Login = textBox1.Text;
                            Close();
                        }
                        else
                            MessageBox.Show("Вы не зарегистрированы");
                    }
                }

            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
