using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bouncing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int spd = 5;
        int stage = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //pictureBox1.Top -= spd;
            //pictureBox1.Left += spd;
            //if (pictureBox1.Top>=ClientSize.Height || pictureBox1.Left>=ClientSize.Width)
            //{
            //    spd = -spd;
            //}
            //if (pictureBox1.Top <= 0 || pictureBox1.Left <= 0)
            //{
            //    spd = -spd;
            //}

            if (stage==1)
            {
                pictureBox1.Left += spd;
                if (pictureBox1.Left>=ClientSize.Width)
                {
                    pictureBox1.Left = 200;
                       pictureBox1.Left = 223;
                    stage++;
                }
                

            }
            if (stage == 2)
            {
                pictureBox1.Top += spd;
                if (pictureBox1.Top <= 0)
                {
                    stage++;
                }

            }
            if (stage == 3)
            {
                pictureBox1.Left -= spd;
                if (pictureBox1.Left >= ClientSize.Width)
                {
                    stage++;
                }

            }
            if (stage == 4)
            {
                pictureBox1.Top -= spd;
                if (pictureBox1.Top >= ClientSize.Width)
                {
                    stage++;
                }

            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }
    }
}
