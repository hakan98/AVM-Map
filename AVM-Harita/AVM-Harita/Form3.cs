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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Defacto %15 indirim");
            comboBox1.Items.Add("McDonalds star menü 19,90TL");
            comboBox1.Items.Add("Mavi Jeans %10 indirim kodu");
            comboBox1.Items.Add("MediaMarkt Tabletlerde %10 indirim");
            comboBox1.Items.Add("Starbucks 1 alana 1 bedava");
            comboBox1.Items.Add("Gratis Avon ürünleri %30 indirim");
            comboBox1.Items.Add("Köfteci Yusuf ücretsiz içecek");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Lütfen İndirim seçiniz.");
            }
            else
            {
                Random rastgelekod = new Random();
                int sayi1, sayi2, sayi3;
                int harf;
                sayi1 = rastgelekod.Next(1, 9);
                sayi2 = rastgelekod.Next(0, 9);
                sayi3 = rastgelekod.Next(4, 8);
                harf = rastgelekod.Next(65, 91);
                char karakter;
                karakter = Convert.ToChar(harf);
                label3.Text = sayi1.ToString() + sayi2.ToString() + karakter + sayi3.ToString();

                if (button1.Visible)
                    button1.Visible = false;

                else
                    button1.Visible = true;
            }
        }
    } 
}
