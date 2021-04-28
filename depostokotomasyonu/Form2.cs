using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace depostokotomasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            hosgeldin.BackColor = Color.Transparent;
            isim_set.BackColor = Color.Transparent;

        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\depootomasyon.accdb");
        OleDbCommand command;
        OleDbDataAdapter genelAdaptor;
        DataSet veriAyarla;

        private void yetkiliMi()
        {
            if (Form1.yetkili == true)
            {
                menuStrip1.Visible = true;
            }
            else
            {
                menuStrip2.Visible = true;
            }
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelKapat();
            kullanici_gor_panel.Visible = true;
            kullanici_gor_table.Visible = true;
            this.Text = "Kullanıcı İşlemleri";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kullaniciGuncelle();
            urunGuncelle();
            yetkiliMi();
            hosgeldin_panel.Visible = true;
            isim_set.Text = Form1.girisİsim;
        }

        private void kullaniciGuncelle()
        {
            genelAdaptor = new OleDbDataAdapter("SELECT * FROM kullanicilar", baglan);
            veriAyarla = new DataSet();
            baglan.Open();
            genelAdaptor.Fill(veriAyarla, "kullanici_gor_table");
            baglan.Close();
            kullanici_gor_table.DataSource = veriAyarla.Tables["kullanici_gor_table"];
            kullanici_gor_table.Columns[0].HeaderText = "Sicil Numarası";
            kullanici_gor_table.Columns[1].HeaderText = "Adı Soyadı";
            kullanici_gor_table.Columns[2].HeaderText = "Kullanıcı Adı";
            kullanici_gor_table.Columns[3].HeaderText = "Şifre";
            kullanici_gor_table.Columns[4].HeaderText = "Yetkili Mi?";
            kullanici_gor_adsoyad.Clear();
            kullanici_gor_kadi.Clear();
            kullanici_gor_sifre.Clear();
            kullanici_gor_yetki.SelectedIndex = -1;
        }

        private void kullanici_gor_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kullanici_gor_adsoyad.Text = kullanici_gor_table.CurrentRow.Cells[1].Value.ToString();
            kullanici_gor_kadi.Text = kullanici_gor_table.CurrentRow.Cells[2].Value.ToString();
            kullanici_gor_sifre.Text = kullanici_gor_table.CurrentRow.Cells[3].Value.ToString();
            if (kullanici_gor_table.CurrentRow.Cells[4].Value.ToString() == "True")
            {
                kullanici_gor_yetki.SelectedIndex = 0;
            }
            else
            {
                kullanici_gor_yetki.SelectedIndex = 1;
            }

        }

        private void kullanici_gor_ekle_Click(object sender, EventArgs e)
        {
            bool yetki;
            if (kullanici_gor_yetki.SelectedIndex==0)
            {
                yetki = true;
            }
            else
            {
                yetki = false;
            }

            try
            {
                baglan.Open();
                OleDbCommand command = new OleDbCommand("INSERT INTO kullanicilar (ad_soyad,kullanici_adi,sifre,yetkili)values(@ad_soyad, @kullanici_adi, @sifre, @yetki)", baglan);
                command.Parameters.AddWithValue("@kullanici_adi", kullanici_gor_adsoyad.Text);
                command.Parameters.AddWithValue("@kullanici_adi", kullanici_gor_kadi.Text);
                command.Parameters.AddWithValue("@sifre", kullanici_gor_sifre.Text);
                command.Parameters.AddWithValue("@yetki", yetki);
                command.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kullanıcı Eklendi!", "Kullanıcı İşlemleri");
                kullaniciGuncelle();
            }
            catch (Exception aciklama)
            {

                MessageBox.Show(aciklama.Message, "Kullanıcı İşlemleri");
                baglan.Close();
            }
            
        }

        private void kullanici_gor_guncelle_Click(object sender, EventArgs e)
        {
            bool yetki;
            if (kullanici_gor_yetki.SelectedIndex == 0)
            {
                yetki = true;
            }
            else
            {
                yetki = false;
            }

            try
            {
                baglan.Open();
                command = new OleDbCommand("UPDATE kullanicilar SET ad_soyad=@ad_soyad, kullanici_adi=@kullanici_adi, sifre=@sifre, yetkili=@yetki WHERE id=" + Convert.ToInt32(kullanici_gor_table.CurrentRow.Cells[0].Value.ToString()), baglan);
                command.Parameters.AddWithValue("@ad_soyad", kullanici_gor_adsoyad.Text);
                command.Parameters.AddWithValue("@kullanici_adi", kullanici_gor_kadi.Text);
                command.Parameters.AddWithValue("@sifre", kullanici_gor_sifre.Text);
                command.Parameters.AddWithValue("@yetki", yetki);
                command.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kullanıcı Güncellendi!", "Kullanıcı İşlemleri");
                kullaniciGuncelle();
            }
            catch (Exception aciklama)
            {

                MessageBox.Show(aciklama.Message, "Kullanıcı İşlemleri");
                baglan.Close();
            }
            
        }

        private void kullanici_gor_sil_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                command = new OleDbCommand("DELETE FROM kullanicilar WHERE id=" + Convert.ToInt32(kullanici_gor_table.CurrentRow.Cells[0].Value.ToString()), baglan);
                command.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kullanıcı Silindi!", "Kullanıcı İşlemleri");
                kullaniciGuncelle();
            }
            catch (Exception aciklama)
            {

                MessageBox.Show(aciklama.Message, "Kullanıcı İşlemleri");
                baglan.Close();
            }
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanici_gor_panel.Visible = false;
            kullanici_gor_table.Visible = false;
            urun_goruntule_panel.Visible = true;
            gonderilecekUrun = null;
            urunGuncelle();
            this.Text = "Stok Görüntüle";
            urunEkle yeniUrun = new urunEkle(urungnc);
            yeniUrun.Show();

        }
        public int urungnc(int a)
        {
            urunGuncelle();
            return 1;
        }

        public int musterignc(int a)
        {
            musteriCek();
            return 1;
        }
        private void urunTabloOlustur()
        {
            veriAyarla = new DataSet();
            baglan.Open();
            genelAdaptor.Fill(veriAyarla, "urun_gor_table");
            baglan.Close();
            urun_gor_table.DataSource = veriAyarla.Tables["urun_gor_table"];
            urun_gor_table.Columns[0].HeaderText = "Stok No";
            urun_gor_table.Columns[1].HeaderText = "Ürün Adı";
            urun_gor_table.Columns[2].HeaderText = "Barkod No";
            urun_gor_table.Columns[3].HeaderText = "Ürün Grubu";
            urun_gor_table.Columns[4].HeaderText = "Grup Numarası";
            urun_gor_table.Columns[5].HeaderText = "Alış Fiyatı";
            urun_gor_table.Columns[6].HeaderText = "Satış Fiyatı";
            urun_gor_table.Columns[7].HeaderText = "KDV Oranı";
            urun_gor_table.Columns[8].HeaderText = "Birim Cinsi";
            urun_gor_table.Columns[9].HeaderText = "Ürün Miktarı";
        }

        public void urunGuncelle()
        {
            genelAdaptor = new OleDbDataAdapter("SELECT * FROM urunler", baglan);
            urunTabloOlustur();
        }

        private void sadeceSayi(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ürünGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Ürün İşlemleri";
            panelKapat();
            urun_goruntule_panel.Visible = true;
            this.Text = "Stok Görüntüle";
            urunGuncelle();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 girisEkrani = new Form1();
            girisEkrani.Show();
        }

        private void urun_ara_button_Click(object sender, EventArgs e)
        {
            if (urun_ara_ad.Text != "")
            {
                genelAdaptor = new OleDbDataAdapter("SELECT * FROM urunler WHERE urun_adi LIKE '%" + urun_ara_ad.Text + "%'", baglan);
                urunTabloOlustur();
            }
            else if (urun_ara_stok.Text != "")
            {
                genelAdaptor = new OleDbDataAdapter("SELECT * FROM urunler WHERE id=" + Convert.ToInt32(urun_ara_stok.Text), baglan);
                urunTabloOlustur();
            }
            else if (urun_ara_barkod.Text != "")
            {
                genelAdaptor = new OleDbDataAdapter("SELECT * FROM urunler WHERE barkod=" + Convert.ToInt32(urun_ara_barkod.Text), baglan);
                urunTabloOlustur();
            }
            else
            {
                urunGuncelle();
            }
        }

        public static string gonderilecekUrun;

        private void urunsec(object sender, DataGridViewCellEventArgs e)
        {
            if (Form1.yetkili == true)
            {
                gonderilecekUrun = urun_gor_table.CurrentRow.Cells[0].Value.ToString();
                urunEkle urundetay = new urunEkle(urungnc);
                urundetay.Show();
            }
            else
            {
                MessageBox.Show("Bunu yapmaya izniniz yok!", "Yetkisiz İşlem!");
            }
        }

        private void grup_ara_button_Click(object sender, EventArgs e)
        {
            if (grupara_ad.Text == "")
            {
                genelAdaptor = new OleDbDataAdapter("SELECT * FROM urungruplari ", baglan);
                grupCek();
            }
            else
            {
                genelAdaptor = new OleDbDataAdapter("SELECT * FROM urungruplari WHERE grup_ad LIKE '%" + grupara_ad.Text + "%'" , baglan);
                grupCek();
            }
        }

        private void grupCek()
        {
            
            veriAyarla = new DataSet();
            baglan.Open();
            genelAdaptor.Fill(veriAyarla, "grupgoruntule_table");
            baglan.Close();
            grupgoruntule_table.DataSource = veriAyarla.Tables["grupgoruntule_table"];
            grupgoruntule_table.Columns[0].Visible = false;
            grupgoruntule_table.Columns[1].HeaderText = "Grup Numarası";
            grupgoruntule_table.Columns[2].HeaderText = "Grup Adı";
        }

        private void grupekle_button_Click(object sender, EventArgs e)
        {
            baglan.Open();
            command = new OleDbCommand("INSERT INTO urungruplari (grup_no, grup_ad)VALUES(@grup_no, @grup_ad)", baglan);
            command.Parameters.AddWithValue("@grup_no", Convert.ToInt32(grupekle_kod.Text)) ;
            command.Parameters.AddWithValue("@grup_ad", grupekle_ad.Text.ToString());
            command.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Ürün grubu eklendi!", "İşlem Başarılı");
            grupCek();
        }

        private void grupYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Ürün Grubu İşlemleri";
            panelKapat();
            urungrup_panel.Visible = true;
            genelAdaptor = new OleDbDataAdapter("SELECT * FROM urungruplari", baglan);
            grupCek();
        }

        private void textboxTemizle()
        {
            foreach (Control c in groupBox3.Controls)
            {

                if (c is TextBox)
                    if (c.Text != "")
                    {
                        c.Text = "";
                    }
                        
            }
        }

        private void grupsec(object sender, DataGridViewCellEventArgs e)
        {
            grupekle_button.Text = "Güncelle";
            grupekle_button.Click -= grupekle_button_Click;
            grupekle_button.Click += grupguncelle;
            grupekle_kod.Text = grupgoruntule_table.CurrentRow.Cells[1].Value.ToString();
            grupekle_ad.Text = grupgoruntule_table.CurrentRow.Cells[2].Value.ToString();
            grupsil_button.Visible = true;
            gruptemizle_button.Visible = true;
        }

        private void grupguncelle(object sender, EventArgs e)
        {
            baglan.Open();
            command = new OleDbCommand("UPDATE urungruplari SET grup_no=@grup_no, grup_ad=@grup_ad WHERE id="+ grupgoruntule_table.CurrentRow.Cells[0].Value.ToString() , baglan);
            command.Parameters.AddWithValue("@grup_no", grupekle_kod.Text);
            command.Parameters.AddWithValue("@grup_ad", grupekle_ad.Text);
            command.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Ürün grubu güncellendi!", "İşlem Başarılı");
            grupCek();
        }

        private void grupsil_button_Click(object sender, EventArgs e)
        {
            baglan.Open();
            command = new OleDbCommand("DELETE FROM urungruplari WHERE id=" + grupgoruntule_table.CurrentRow.Cells[0].Value.ToString(), baglan);
            command.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Ürün grubu silindi!", "İşlem Başarılı");
            grupCek();
        }

        private void gruptemizle_button_Click(object sender, EventArgs e)
        {
            grupekle_ad.Text = "";
            grupekle_kod.Text = "";
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musteriGonder = null;
            musteriEkle yeniMusteri = new musteriEkle(musterignc);
            yeniMusteri.Show();
        }

        private void panelKapat()
        {
            foreach (Control c in Controls)
            {

                if (c is Panel)
                    if (c.Visible == true)
                    {
                        c.Visible = false;
                    }

            }
        }

        private void musteriCek()
        {
            baglan.Open();
            veriAyarla = new DataSet();
            genelAdaptor.Fill(veriAyarla, "musteri_table");
            baglan.Close();
            musteri_table.DataSource = veriAyarla.Tables["musteri_table"];
        }

        private void müşteriGörüntüleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "Müşteri İşlemleri";
            panelKapat();
            musteri_ara_panel.Visible = true;
            genelAdaptor = new OleDbDataAdapter("SELECT * FROM musteriler ", baglan);
            musteriCek();
        }

        private void musteri_ara_button_Click(object sender, EventArgs e)
        {
            if (musteri_araad.Text != "")
            {
                genelAdaptor = new OleDbDataAdapter("SELECT * FROM musteriler WHERE ad LIKE '%" + musteri_araad.Text + "%'", baglan);
                musteriCek();
            }
            else if (musteri_aratckn.Text != "")
            {
                genelAdaptor = new OleDbDataAdapter("SELECT * FROM musteriler WHERE tckno LIKE '%" + musteri_aratckn.Text + "%'" , baglan);
                musteriCek();
            }
            else if (musteri_aratelefon.Text != "")
            {
                genelAdaptor = new OleDbDataAdapter("SELECT * FROM musteriler WHERE telefon LIKE '%" + musteri_aratelefon.Text + "%'", baglan);
                musteriCek();
            }
            else if (musteri_aratip.SelectedIndex != 0)
            {
                genelAdaptor = new OleDbDataAdapter("SELECT * FROM musteriler WHERE tip LIKE '%" + musteri_aratip.SelectedItem + "%'", baglan);
                musteriCek();
            }
            else
            {
                genelAdaptor = new OleDbDataAdapter("SELECT * FROM musteriler ", baglan);
                musteriCek();
            }
        }

        public static string musteriGonder;

        private void musteri_table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Form1.yetkili==true)
            {
                musteriGonder = musteri_table.CurrentRow.Cells[0].Value.ToString();
                musteriEkle musteriDetay = new musteriEkle(musterignc);
                musteriDetay.Show();
            }
            else
            {
                MessageBox.Show("Bunu yapmaya izniniz yok!", "Yetkisiz İşlem!");
            }
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cikis; 
            cikis = MessageBox.Show("Çıkmak İstediğinize Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo); 
            if (cikis == DialogResult.Yes) 
            { 
                Form2.ActiveForm.Close(); 
            }

        }

        private void uygulamayıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
