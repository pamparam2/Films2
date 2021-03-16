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
    public partial class SohranenoForm : Form
    {
        public SohranenoForm()
        {
            InitializeComponent();

            int x = 10;
            int y = 100;
            foreach (Film film in Form1.sohraneno_list)
            {
                //Название фильма
                Label label = new Label();
                label.Location = new Point(x + 50, y);
                label.Size = new Size(220, 40);
                label.Text = film.name;
                label.TextAlign = ContentAlignment.TopCenter;
                Controls.Add(label);
                //Картинка
                PictureBox picture = new PictureBox();
                picture.Image = film.picture.Image;
                picture.Location = new Point(x + 50, y );
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Size = new Size(220, 260);
                picture.Tag = film.name;
             
                Controls.Add(picture);

                x = x + 230;
                if (x + 220 > Width)
                {
                    y = y + 300;
                    x = 10;
                }

            }
        }

        private void follow_Load(object sender, EventArgs e)
        {

        }
    }
}
