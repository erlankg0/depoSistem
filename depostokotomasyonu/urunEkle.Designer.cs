namespace depostokotomasyonu
{
    partial class urunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.detay_grupAd = new System.Windows.Forms.ComboBox();
            this.detay_ad = new System.Windows.Forms.TextBox();
            this.detay_stok = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.detay_vazgec = new System.Windows.Forms.Button();
            this.detay_sil = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.detay_barkod = new System.Windows.Forms.TextBox();
            this.detay_kdv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.detay_miktar = new System.Windows.Forms.TextBox();
            this.detay_birim = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.detay_kaydet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.detay_satis = new System.Windows.Forms.TextBox();
            this.detay_alis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.detay_grupKod = new System.Windows.Forms.TextBox();
            this.grup_ad = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::depostokotomasyonu.Properties.Resources.bg;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.detay_grupAd);
            this.groupBox1.Controls.Add(this.detay_ad);
            this.groupBox1.Controls.Add(this.detay_stok);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ana Stok Bilgileri";
            // 
            // detay_grupAd
            // 
            this.detay_grupAd.FormattingEnabled = true;
            this.detay_grupAd.Location = new System.Drawing.Point(494, 5);
            this.detay_grupAd.Name = "detay_grupAd";
            this.detay_grupAd.Size = new System.Drawing.Size(10, 21);
            this.detay_grupAd.TabIndex = 8;
            this.detay_grupAd.Visible = false;
            // 
            // detay_ad
            // 
            this.detay_ad.Location = new System.Drawing.Point(75, 50);
            this.detay_ad.Name = "detay_ad";
            this.detay_ad.Size = new System.Drawing.Size(164, 20);
            this.detay_ad.TabIndex = 4;
            // 
            // detay_stok
            // 
            this.detay_stok.Enabled = false;
            this.detay_stok.Location = new System.Drawing.Point(75, 25);
            this.detay_stok.Name = "detay_stok";
            this.detay_stok.Size = new System.Drawing.Size(164, 20);
            this.detay_stok.TabIndex = 3;
            this.detay_stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceSayi);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stok Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Kodu :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::depostokotomasyonu.Properties.Resources.bg;
            this.groupBox2.Controls.Add(this.detay_vazgec);
            this.groupBox2.Controls.Add(this.detay_sil);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.detay_kaydet);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 315);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genel Stok Bilgileri";
            // 
            // detay_vazgec
            // 
            this.detay_vazgec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.detay_vazgec.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.detay_vazgec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.detay_vazgec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.detay_vazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detay_vazgec.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.detay_vazgec.ForeColor = System.Drawing.Color.White;
            this.detay_vazgec.Location = new System.Drawing.Point(392, 275);
            this.detay_vazgec.Name = "detay_vazgec";
            this.detay_vazgec.Size = new System.Drawing.Size(100, 30);
            this.detay_vazgec.TabIndex = 12;
            this.detay_vazgec.Text = "Vazgeç";
            this.detay_vazgec.UseVisualStyleBackColor = false;
            this.detay_vazgec.Click += new System.EventHandler(this.detay_vazgec_Click);
            // 
            // detay_sil
            // 
            this.detay_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.detay_sil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.detay_sil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.detay_sil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.detay_sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detay_sil.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.detay_sil.ForeColor = System.Drawing.Color.White;
            this.detay_sil.Location = new System.Drawing.Point(133, 275);
            this.detay_sil.Name = "detay_sil";
            this.detay_sil.Size = new System.Drawing.Size(100, 30);
            this.detay_sil.TabIndex = 13;
            this.detay_sil.Text = "Ürün Sil";
            this.detay_sil.UseVisualStyleBackColor = false;
            this.detay_sil.Visible = false;
            this.detay_sil.Click += new System.EventHandler(this.detay_sil_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.detay_barkod);
            this.groupBox6.Controls.Add(this.detay_kdv);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(254, 142);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(244, 115);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Diğer Bilgiler";
            // 
            // detay_barkod
            // 
            this.detay_barkod.Location = new System.Drawing.Point(82, 75);
            this.detay_barkod.Name = "detay_barkod";
            this.detay_barkod.Size = new System.Drawing.Size(156, 20);
            this.detay_barkod.TabIndex = 4;
            this.detay_barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceSayi);
            // 
            // detay_kdv
            // 
            this.detay_kdv.Location = new System.Drawing.Point(82, 40);
            this.detay_kdv.Name = "detay_kdv";
            this.detay_kdv.Size = new System.Drawing.Size(156, 20);
            this.detay_kdv.TabIndex = 3;
            this.detay_kdv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceSayi);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Barkod No :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "KDV Miktarı :";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.detay_miktar);
            this.groupBox5.Controls.Add(this.detay_birim);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(9, 142);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(230, 115);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Birim ve Miktar";
            // 
            // detay_miktar
            // 
            this.detay_miktar.Location = new System.Drawing.Point(73, 71);
            this.detay_miktar.Name = "detay_miktar";
            this.detay_miktar.Size = new System.Drawing.Size(151, 20);
            this.detay_miktar.TabIndex = 6;
            this.detay_miktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceSayi);
            // 
            // detay_birim
            // 
            this.detay_birim.FormattingEnabled = true;
            this.detay_birim.Items.AddRange(new object[] {
            "ADET",
            "KİLOGRAM"});
            this.detay_birim.Location = new System.Drawing.Point(73, 35);
            this.detay_birim.Name = "detay_birim";
            this.detay_birim.Size = new System.Drawing.Size(151, 21);
            this.detay_birim.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Miktarı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Birim Türü :";
            // 
            // detay_kaydet
            // 
            this.detay_kaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.detay_kaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.detay_kaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.detay_kaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.detay_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detay_kaydet.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.detay_kaydet.ForeColor = System.Drawing.Color.White;
            this.detay_kaydet.Location = new System.Drawing.Point(9, 275);
            this.detay_kaydet.Name = "detay_kaydet";
            this.detay_kaydet.Size = new System.Drawing.Size(100, 30);
            this.detay_kaydet.TabIndex = 11;
            this.detay_kaydet.Text = "Ürün Ekle";
            this.detay_kaydet.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.detay_satis);
            this.groupBox4.Controls.Add(this.detay_alis);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(254, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 117);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fiyat Bilgileri";
            // 
            // detay_satis
            // 
            this.detay_satis.Location = new System.Drawing.Point(82, 67);
            this.detay_satis.Name = "detay_satis";
            this.detay_satis.Size = new System.Drawing.Size(156, 20);
            this.detay_satis.TabIndex = 4;
            this.detay_satis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceSayi);
            // 
            // detay_alis
            // 
            this.detay_alis.Location = new System.Drawing.Point(82, 34);
            this.detay_alis.Name = "detay_alis";
            this.detay_alis.Size = new System.Drawing.Size(156, 20);
            this.detay_alis.TabIndex = 3;
            this.detay_alis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceSayi);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Satış Fiyatı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Alış Fiyatı :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.detay_grupKod);
            this.groupBox3.Controls.Add(this.grup_ad);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 117);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grup Bilgileri";
            // 
            // detay_grupKod
            // 
            this.detay_grupKod.Enabled = false;
            this.detay_grupKod.Location = new System.Drawing.Point(76, 30);
            this.detay_grupKod.Name = "detay_grupKod";
            this.detay_grupKod.Size = new System.Drawing.Size(151, 20);
            this.detay_grupKod.TabIndex = 7;
            this.detay_grupKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceSayi);
            // 
            // grup_ad
            // 
            this.grup_ad.FormattingEnabled = true;
            this.grup_ad.Location = new System.Drawing.Point(76, 70);
            this.grup_ad.Name = "grup_ad";
            this.grup_ad.Size = new System.Drawing.Size(151, 43);
            this.grup_ad.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grup Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grup Kodu :";
            // 
            // urunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::depostokotomasyonu.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(528, 440);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "urunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekleme";
            this.Load += new System.EventHandler(this.urunEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button detay_vazgec;
        private System.Windows.Forms.Button detay_kaydet;
        private System.Windows.Forms.TextBox detay_ad;
        private System.Windows.Forms.TextBox detay_stok;
        private System.Windows.Forms.TextBox detay_barkod;
        private System.Windows.Forms.TextBox detay_kdv;
        private System.Windows.Forms.TextBox detay_miktar;
        private System.Windows.Forms.ComboBox detay_birim;
        private System.Windows.Forms.TextBox detay_satis;
        private System.Windows.Forms.TextBox detay_alis;
        private System.Windows.Forms.TextBox detay_grupKod;
        private System.Windows.Forms.Button detay_sil;
        private System.Windows.Forms.ComboBox detay_grupAd;
        private System.Windows.Forms.ListBox grup_ad;
    }
}