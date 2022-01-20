
namespace AVM_Harita
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Yukari = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lcw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Kampanyalar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.timer12 = new System.Windows.Forms.Timer(this.components);
            this.timer13 = new System.Windows.Forms.Timer(this.components);
            this.timer14 = new System.Windows.Forms.Timer(this.components);
            this.timer15 = new System.Windows.Forms.Timer(this.components);
            this.timer16 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.White;
            this.ımageList1.Images.SetKeyName(0, "BK.jpg");
            this.ımageList1.Images.SetKeyName(1, "hdiskender.png");
            this.ımageList1.Images.SetKeyName(2, "kofteciyusuf.png");
            this.ımageList1.Images.SetKeyName(3, "lcw.png");
            this.ımageList1.Images.SetKeyName(4, "Mavi.png");
            this.ımageList1.Images.SetKeyName(5, "McDonalds.png");
            this.ımageList1.Images.SetKeyName(6, "Media_Markt.png");
            this.ımageList1.Images.SetKeyName(7, "nike.png");
            this.ımageList1.Images.SetKeyName(8, "Starbucks.png");
            this.ımageList1.Images.SetKeyName(9, "gratis.jpg");
            this.ımageList1.Images.SetKeyName(10, "boyner.png");
            this.ımageList1.Images.SetKeyName(11, "vatan.jpg");
            this.ımageList1.Images.SetKeyName(12, "defacto.jpg");
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "yukari.png");
            // 
            // Yukari
            // 
            this.Yukari.ImageIndex = 0;
            this.Yukari.ImageList = this.ımageList2;
            this.Yukari.Location = new System.Drawing.Point(239, 69);
            this.Yukari.Name = "Yukari";
            this.Yukari.Size = new System.Drawing.Size(86, 41);
            this.Yukari.TabIndex = 8;
            this.Yukari.UseVisualStyleBackColor = true;
            this.Yukari.Click += new System.EventHandler(this.Yukari_Click_1);
            // 
            // button5
            // 
            this.button5.ImageKey = "boyner.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(388, 385);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 96);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.ImageKey = "gratis.jpg";
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(388, 273);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 96);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.ImageKey = "Mavi.png";
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(388, 156);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(147, 96);
            this.button7.TabIndex = 5;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.ImageKey = "Starbucks.png";
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(388, 31);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 96);
            this.button8.TabIndex = 4;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.ImageKey = "vatan.jpg";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(27, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 96);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.ImageKey = "Media_Markt.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(27, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 96);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lcw
            // 
            this.lcw.ImageKey = "lcw.png";
            this.lcw.ImageList = this.ımageList1;
            this.lcw.Location = new System.Drawing.Point(27, 157);
            this.lcw.Name = "lcw";
            this.lcw.Size = new System.Drawing.Size(147, 96);
            this.lcw.TabIndex = 1;
            this.lcw.UseVisualStyleBackColor = true;
            this.lcw.Click += new System.EventHandler(this.lcw_Click);
            // 
            // button1
            // 
            this.button1.ImageKey = "defacto.jpg";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(27, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 96);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AVM_Harita.Properties.Resources.adam1;
            this.pictureBox1.Location = new System.Drawing.Point(264, 446);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Kampanyalar
            // 
            this.Kampanyalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kampanyalar.Location = new System.Drawing.Point(199, 21);
            this.Kampanyalar.Name = "Kampanyalar";
            this.Kampanyalar.Size = new System.Drawing.Size(165, 33);
            this.Kampanyalar.TabIndex = 12;
            this.Kampanyalar.Text = "Kampanyalar";
            this.Kampanyalar.UseVisualStyleBackColor = true;
            this.Kampanyalar.Click += new System.EventHandler(this.Kampanyalar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 13;
            this.label1.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // timer9
            // 
            this.timer9.Tick += new System.EventHandler(this.timer9_Tick);
            // 
            // timer11
            // 
            this.timer11.Tick += new System.EventHandler(this.timer11_Tick);
            // 
            // timer13
            // 
            this.timer13.Tick += new System.EventHandler(this.timer13_Tick);
            // 
            // timer15
            // 
            this.timer15.Tick += new System.EventHandler(this.timer15_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::AVM_Harita.Properties.Resources.AVM;
            this.ClientSize = new System.Drawing.Size(562, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kampanyalar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Yukari);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lcw);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Mağaza Katı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button lcw;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button Yukari;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Kampanyalar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Timer timer9;
        private System.Windows.Forms.Timer timer10;
        private System.Windows.Forms.Timer timer11;
        private System.Windows.Forms.Timer timer12;
        private System.Windows.Forms.Timer timer13;
        private System.Windows.Forms.Timer timer14;
        private System.Windows.Forms.Timer timer15;
        private System.Windows.Forms.Timer timer16;
    }
}

