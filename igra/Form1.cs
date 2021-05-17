using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace igra
{
    public partial class Form1 : Form
    {
        PictureBox[] cloud;
        int backgroudspeed;
        Random random;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i=0; i < cloud.Length; i++)
            {
                cloud[i].Left += backgroudspeed;
                if(cloud[i].Left>=1280)
                {
                    cloud[i].Left = cloud[i].Height;
                }
            }

            for(int i=0; i<cloud.Length; i++)
            {
              cloud[i].Left += backgroudspeed - 10;

              if (cloud[i].Left>=1280)
                {
                    cloud[i].Left = cloud[i].Left;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backgroudspeed = 10;
            cloud = new PictureBox[20];
            random = new Random();

            for (int i = 0; i < cloud.Length; i++)
                {
                cloud[i] = new PictureBox();
                cloud[i].BorderStyle = BorderStyle.None;
                cloud[i].Location = new Point(random.Next(-1000, 1280), random.Next(140, 320));
                if (i % 2 == 1)
                {
                    cloud[i].Size = new Size(random.Next(100, 225), random.Next(30, 70));
                    cloud[i].BackColor = Color.FromArgb(random.Next(50, 125), 255, 200, 200);
                }
                else
                {
                    cloud[i].Size = new Size(150, 25);
                    cloud[i].BackColor = Color.FromArgb(random.Next(50, 125), 255, 205, 205);
                }
                this.Controls.Add(cloud[i]);
            }
        }
    }
}
