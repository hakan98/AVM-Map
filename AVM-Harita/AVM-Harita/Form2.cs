using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVM_Harita
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Asagi_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                timer1.Start();
                label1.Text = "1";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                pictureBox1.Top -= 1;
                if (pictureBox1.Location.Y <= 62)

                {
                    timer1.Stop();
                }
                else if (label1.Text == "1")
                {
                    pictureBox1.Left -= 4;
                    if (pictureBox1.Location.X >= 176)
                    {
                        timer2.Stop();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                timer3.Start();
                label1.Text = "1";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                pictureBox1.Top -= 1;
                if (pictureBox1.Location.Y <= 62)

                {
                    timer3.Stop();
                }
                else if (label1.Text == "1")
                {
                    pictureBox1.Left += 4;
                    if (pictureBox1.Location.X >= 180)
                    {
                        timer4.Stop();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                timer5.Start();
                label1.Text = "1";
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                pictureBox1.Top += 10;
                if (pictureBox1.Location.Y >= 190)

                {
                    timer5.Stop();
                }
                else if (label1.Text == "1")
                {
                    pictureBox1.Left -= 4;
                    if (pictureBox1.Location.X >= 250)
                    {
                        timer6.Stop();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                timer7.Start();
                label1.Text = "1";
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                pictureBox1.Top += 10;
                if (pictureBox1.Location.Y >= 190)

                {
                    timer7.Stop();
                }
                else if (label1.Text == "1")
                {
                    pictureBox1.Left += 4;
                    if (pictureBox1.Location.X >= 250)
                    {
                        timer8.Stop();
                    }
                }
            }
        }
    }
}
