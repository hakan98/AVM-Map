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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Yukari_Click_1(object sender, EventArgs e)
        {
            Form2 yukari = new Form2();
            yukari.Show();
            this.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            timer15.Start();
            label1.Text = "1";
        }

        public void Kampanyalar_Click(object sender, EventArgs e)
        {
            Form3 kampanyalar = new Form3();
            kampanyalar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = "1";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                pictureBox1.Top -= 6;
                if (pictureBox1.Location.Y <= 309)

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

        private void button6_Click(object sender, EventArgs e)
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
                pictureBox1.Top -= 6;
                if (pictureBox1.Location.Y <= 306)

                {
                    timer3.Stop();
                }
                else if (label1.Text == "1")
                {
                    pictureBox1.Left += 3;
                    if (pictureBox1.Location.X >= 176)
                    {
                        timer4.Stop();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
                pictureBox1.Top -= 2;
                if (pictureBox1.Location.Y <= 418)

                {
                    timer5.Stop();
                }
                else if (label1.Text == "1")
                {
                    pictureBox1.Left -= 7;
                    if (pictureBox1.Location.X >= 120)
                    {
                        timer6.Stop();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
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
                pictureBox1.Top -= 3;
                if (pictureBox1.Location.Y <= 422)

                {
                    timer7.Stop();
                }
                else if (label1.Text == "1")
                {
                    pictureBox1.Left += 9;
                    if (pictureBox1.Location.X >= 150)
                    {
                        timer8.Stop();
                    }
                }
            }
        }

        private void lcw_Click(object sender, EventArgs e)
        {
            timer9.Start();
            label1.Text = "1";
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                pictureBox1.Top -= 11;
                if (pictureBox1.Location.Y <= 193)

                {
                    timer9.Stop();
                }
                else if (label1.Text == "1")
                {
                    pictureBox1.Left -= 4;
                    if (pictureBox1.Location.X >= 180)
                    {
                        timer10.Stop();
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                timer11.Start();
                label1.Text = "1";
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                pictureBox1.Top -= 11;
                if (pictureBox1.Location.Y <= 193)

                {
                    timer11.Stop();
                }
                else if (label1.Text == "1")
                {
                    pictureBox1.Left += 3;
                    if (pictureBox1.Location.X >= 176)
                    {
                        timer12.Stop();
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            {
                timer13.Start();
                label1.Text = "1";
            }
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                pictureBox1.Top -= 16;
                if (pictureBox1.Location.Y <= 70)

                {
                    timer13.Stop();
                }
                else if (label1.Text == "1")
                {
                    pictureBox1.Left += 3;
                    if (pictureBox1.Location.X >= 250)
                    {
                        timer14.Stop();
                    }
                }
            }
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "1")
            {
                pictureBox1.Top -= 16;
                if (pictureBox1.Location.Y <= 78)

                {
                    timer15.Stop();
                }
                else if (label1.Text == "1")
                {
                    pictureBox1.Left -= 4;
                    if (pictureBox1.Location.X >= 176)
                    {
                        timer16.Stop();
                    }
                }
            }
        }
    }
}
