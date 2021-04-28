namespace depostokotomasyonu
{
    partial class musteriEkle
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
            this.label5 = new System.Windows.Forms.Label();
            this.musteri_tckno = new System.Windows.Forms.TextBox();
            this.musteri_vd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.musteri_kurumsal = new System.Windows.Forms.RadioButton();
            this.musteri_bireysel = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.musteri_ad = new System.Windows.Forms.TextBox();
            this.musteri_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.musteri_fax = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.musteri_telefon = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.musteri_yetkilimail = new System.Windows.Forms.TextBox();
            this.musteri_adres = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.musteri_ilce = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.musteri_yetkiliad = new System.Windows.Forms.TextBox();
            this.musteri_web = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.musteri_sehir = new System.Windows.Forms.TextBox();
            this.musteri_ulke = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.musteri_ekle_button = new System.Windows.Forms.Button();
            this.musteri_sil_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::depostokotomasyonu.Properties.Resources.bg;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.musteri_tckno);
            this.groupBox1.Controls.Add(this.musteri_vd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.musteri_kurumsal);
            this.groupBox1.Controls.Add(this.musteri_bireysel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.musteri_ad);
            this.groupBox1.Controls.Add(this.musteri_no);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ön Müşteri Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vergi No / TCKN :";
            // 
            // musteri_tckno
            // 
            this.musteri_tckno.Location = new System.Drawing.Point(373, 62);
            this.musteri_tckno.Name = "musteri_tckno";
            this.musteri_tckno.Size = new System.Drawing.Size(129, 20);
            this.musteri_tckno.TabIndex = 4;
            this.musteri_tckno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceSayi);
            // 
            // musteri_vd
            // 
            this.musteri_vd.Location = new System.Drawing.Point(373, 30);
            this.musteri_vd.Name = "musteri_vd";
            this.musteri_vd.Size = new System.Drawing.Size(129, 20);
            this.musteri_vd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vergi Dairesi :";
            // 
            // musteri_kurumsal
            // 
            this.musteri_kurumsal.AutoSize = true;
            this.musteri_kurumsal.Location = new System.Drawing.Point(434, 94);
            this.musteri_kurumsal.Name = "musteri_kurumsal";
            this.musteri_kurumsal.Size = new System.Drawing.Size(68, 17);
            this.musteri_kurumsal.TabIndex = 6;
            this.musteri_kurumsal.TabStop = true;
            this.musteri_kurumsal.Text = "Kurumsal";
            this.musteri_kurumsal.UseVisualStyleBackColor = true;
            // 
            // musteri_bireysel
            // 
            this.musteri_bireysel.AutoSize = true;
            this.musteri_bireysel.Location = new System.Drawing.Point(373, 94);
            this.musteri_bireysel.Name = "musteri_bireysel";
            this.musteri_bireysel.Size = new System.Drawing.Size(61, 17);
            this.musteri_bireysel.TabIndex = 5;
            this.musteri_bireysel.TabStop = true;
            this.musteri_bireysel.Text = "Bireysel";
            this.musteri_bireysel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Müşteri Tipi :";
            // 
            // musteri_ad
            // 
            this.musteri_ad.Location = new System.Drawing.Point(106, 58);
            this.musteri_ad.Name = "musteri_ad";
            this.musteri_ad.Size = new System.Drawing.Size(129, 20);
            this.musteri_ad.TabIndex = 2;
            // 
            // musteri_no
            // 
            this.musteri_no.Location = new System.Drawing.Point(106, 26);
            this.musteri_no.Name = "musteri_no";
            this.musteri_no.ReadOnly = true;
            this.musteri_no.Size = new System.Drawing.Size(129, 20);
            this.musteri_no.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müşteri Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Numarası :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.musteri_fax);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.musteri_telefon);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.musteri_yetkilimail);
            this.groupBox2.Controls.Add(this.musteri_adres);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.musteri_ilce);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.musteri_yetkiliad);
            this.groupBox2.Controls.Add(this.musteri_web);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.musteri_sehir);
            this.groupBox2.Controls.Add(this.musteri_ulke);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(4, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 266);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temel Müşteri Bilgileri";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(276, 233);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(91, 23);
            this.progressBar1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(389, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 18;
            this.button1.Text = "Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(273, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "İşlem İlerlemesi :";
            // 
            // musteri_fax
            // 
            this.musteri_fax.Location = new System.Drawing.Point(373, 143);
            this.musteri_fax.Name = "musteri_fax";
            this.musteri_fax.Size = new System.Drawing.Size(129, 20);
            this.musteri_fax.TabIndex = 15;
            this.musteri_fax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceSayi);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(273, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Fax No :";
            // 
            // musteri_telefon
            // 
            this.musteri_telefon.Location = new System.Drawing.Point(373, 117);
            this.musteri_telefon.Name = "musteri_telefon";
            this.musteri_telefon.Size = new System.Drawing.Size(129, 20);
            this.musteri_telefon.TabIndex = 14;
            this.musteri_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceSayi);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(273, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Telefon No :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Yetkili Mail :";
            // 
            // musteri_yetkilimail
            // 
            this.musteri_yetkilimail.Location = new System.Drawing.Point(373, 91);
            this.musteri_yetkilimail.Name = "musteri_yetkilimail";
            this.musteri_yetkilimail.Size = new System.Drawing.Size(129, 20);
            this.musteri_yetkilimail.TabIndex = 13;
            // 
            // musteri_adres
            // 
            this.musteri_adres.Location = new System.Drawing.Point(106, 115);
            this.musteri_adres.Multiline = true;
            this.musteri_adres.Name = "musteri_adres";
            this.musteri_adres.Size = new System.Drawing.Size(129, 78);
            this.musteri_adres.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Adres :";
            // 
            // musteri_ilce
            // 
            this.musteri_ilce.Location = new System.Drawing.Point(106, 87);
            this.musteri_ilce.Name = "musteri_ilce";
            this.musteri_ilce.Size = new System.Drawing.Size(129, 20);
            this.musteri_ilce.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "İlçe :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Yetkili Adı :";
            // 
            // musteri_yetkiliad
            // 
            this.musteri_yetkiliad.Location = new System.Drawing.Point(373, 62);
            this.musteri_yetkiliad.Name = "musteri_yetkiliad";
            this.musteri_yetkiliad.Size = new System.Drawing.Size(129, 20);
            this.musteri_yetkiliad.TabIndex = 12;
            // 
            // musteri_web
            // 
            this.musteri_web.Location = new System.Drawing.Point(373, 33);
            this.musteri_web.Name = "musteri_web";
            this.musteri_web.Size = new System.Drawing.Size(129, 20);
            this.musteri_web.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Web Sitesi :";
            // 
            // musteri_sehir
            // 
            this.musteri_sehir.Location = new System.Drawing.Point(106, 58);
            this.musteri_sehir.Name = "musteri_sehir";
            this.musteri_sehir.Size = new System.Drawing.Size(129, 20);
            this.musteri_sehir.TabIndex = 8;
            // 
            // musteri_ulke
            // 
            this.musteri_ulke.Location = new System.Drawing.Point(106, 26);
            this.musteri_ulke.Name = "musteri_ulke";
            this.musteri_ulke.Size = new System.Drawing.Size(129, 20);
            this.musteri_ulke.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Şehir";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ülke :";
            // 
            // musteri_ekle_button
            // 
            this.musteri_ekle_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.musteri_ekle_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.musteri_ekle_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.musteri_ekle_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.musteri_ekle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteri_ekle_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.musteri_ekle_button.ForeColor = System.Drawing.Color.White;
            this.musteri_ekle_button.Location = new System.Drawing.Point(13, 357);
            this.musteri_ekle_button.Name = "musteri_ekle_button";
            this.musteri_ekle_button.Size = new System.Drawing.Size(120, 30);
            this.musteri_ekle_button.TabIndex = 16;
            this.musteri_ekle_button.Text = "Müşteri Ekle";
            this.musteri_ekle_button.UseVisualStyleBackColor = false;
            this.musteri_ekle_button.Click += new System.EventHandler(this.musteri_ekle_button_Click);
            // 
            // musteri_sil_button
            // 
            this.musteri_sil_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.musteri_sil_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.musteri_sil_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.musteri_sil_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.musteri_sil_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteri_sil_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.musteri_sil_button.ForeColor = System.Drawing.Color.White;
            this.musteri_sil_button.Location = new System.Drawing.Point(139, 357);
            this.musteri_sil_button.Name = "musteri_sil_button";
            this.musteri_sil_button.Size = new System.Drawing.Size(120, 30);
            this.musteri_sil_button.TabIndex = 17;
            this.musteri_sil_button.Text = "Müşteri Sil";
            this.musteri_sil_button.UseVisualStyleBackColor = false;
            this.musteri_sil_button.Visible = false;
            this.musteri_sil_button.Click += new System.EventHandler(this.musteriSil);
            // 
            // musteriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::depostokotomasyonu.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(521, 401);
            this.Controls.Add(this.musteri_sil_button);
            this.Controls.Add(this.musteri_ekle_button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "musteriEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Ekleme";
            this.Load += new System.EventHandler(this.musteriEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox musteri_tckno;
        private System.Windows.Forms.TextBox musteri_vd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton musteri_kurumsal;
        private System.Windows.Forms.RadioButton musteri_bireysel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox musteri_ad;
        private System.Windows.Forms.TextBox musteri_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox musteri_fax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox musteri_telefon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox musteri_yetkilimail;
        private System.Windows.Forms.TextBox musteri_adres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox musteri_ilce;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox musteri_yetkiliad;
        private System.Windows.Forms.TextBox musteri_web;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox musteri_sehir;
        private System.Windows.Forms.TextBox musteri_ulke;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button musteri_ekle_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button musteri_sil_button;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label15;
    }
}