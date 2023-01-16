using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikusKontroll
{
    public partial class Form1 : Form
    {
        int sorokSzama = 3;
        int oszlopokSzama = 6;
        int pictureSize = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    Button button = new Button();
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.ImageLocation = "..//../images/muslim2.png";
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.SetBounds(j * pictureSize, i * pictureSize, pictureSize, pictureSize);
                    pictureBox.Text = (i*oszlopokSzama+j).ToString();
                    pictureBox.Click += (o, ev) =>{

                        PictureBox pictureBox1 = (PictureBox)o;
                        pictureBox.ImageLocation = "..//../images/muslim.png";
                    };
                    panel_tarolo.Controls.Add(pictureBox);
                }
            }
        }
    }
}
