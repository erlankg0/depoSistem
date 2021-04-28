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
    public partial class musteriEkle : Form
    {
        private Func<int, int> _masterForm;
        public musteriEkle(Func<int, int> oncloseFunc)
        {
            InitializeComponent();
            _masterForm = oncloseFunc;

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            musteri_bireysel.BackColor = Color.Transparent;
            musteri_kurumsal.BackColor = Color.Transparent;
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\depootomasyon.accdb");
        OleDbCommand command;
        OleDbDataAdapter genelAdaptor;
        OleDbDataReader reader;
        string musteritipi;

        private void sadeceSayi(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void progressIlerle()
        {
            progressBar1.Maximum = 3;
            progressBar1.Value = 1;
            System.Threading.Thread.Sleep(1000);
            progressBar1.Value = 2;
            System.Threading.Thread.Sleep(1000);
            progressBar1.Value = 3;
            System.Threading.Thread.Sleep(1000);
        }

        private void gonder()
        {
            command.Parameters.AddWithValue("@ad", musteri_ad.Text);
            command.Parameters.AddWithValue("@vd", musteri_vd.Text);
            command.Parameters.AddWithValue("@tckno", musteri_tckno.Text);
            command.Parameters.AddWithValue("@tip", musteritipi);
            command.Parameters.AddWithValue("@ulke", musteri_ulke.Text);
            command.Parameters.AddWithValue("@sehir", musteri_sehir.Text);
            command.Parameters.AddWithValue("@ilce", musteri_ilce.Text);
            command.Parameters.AddWithValue("@adres", musteri_adres.Text);
            command.Parameters.AddWithValue("@yekili", musteri_yetkiliad.Text);
            command.Parameters.AddWithValue("@yetkilimail", musteri_yetkilimail.Text);
            command.Parameters.AddWithValue("@telefon", musteri_telefon.Text);
            command.Parameters.AddWithValue("@fax", musteri_fax.Text);
            command.Parameters.AddWithValue("@web", musteri_web.Text);
            command.ExecuteNonQuery();
            baglan.Close();
        }

        private void musteri_ekle_button_Click(object sender, EventArgs e)
        {
            progressIlerle();
            if (musteri_bireysel.Checked)
            {
                musteritipi = "Bireysel";
            }
            else
            {
                musteritipi = "Kurumsal";
            }

            try
            {
                baglan.Open();
                command = new OleDbCommand("INSERT INTO musteriler (ad, vd, tckno, tip, ulke, sehir, ilce, adres, web, yetkili, yetkilimail, telefon, fax)" +
                    " VALUES (@ad, @vd, @tckno, @tip, @ulke, @sehir, @ilce, @adres, @web, @yetkili, @yetkilimail, @telefon, @fax)", baglan);
                gonder();
                MessageBox.Show("Müşteri Eklendi", "İşlem Başarılı");
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "İşlem Başarısız!");
                baglan.Close();
            }
            _masterForm(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            _masterForm(1);
        }

        private void musteriEkle_Load(object sender, EventArgs e)
        {
            if (Form2.musteriGonder != null)
            {
                this.Text = "Müşteri Detay";
                command = new OleDbCommand("SELECT * FROM musteriler WHERE id=" + Form2.musteriGonder.ToString(), baglan);
                baglan.Open();
                reader = command.ExecuteReader();
                reader.Read();
                musteri_no.Text = Form2.musteriGonder;
                musteri_ad.Text = reader[1].ToString();
                musteri_vd.Text = reader[2].ToString();
                musteri_tckno.Text = reader[3].ToString();
                musteri_ulke.Text = reader[5].ToString();
                musteri_sehir.Text = reader[6].ToString();
                musteri_ilce.Text = reader[7].ToString();
                musteri_adres.Text = reader[8].ToString();
                musteri_yetkiliad.Text = reader[9].ToString();
                musteri_yetkilimail.Text = reader[10].ToString();
                musteri_telefon.Text = reader[11].ToString();
                musteri_fax.Text = reader[12].ToString();
                musteri_web.Text = reader[13].ToString();
                if (reader[4].ToString() == "Bireysel")
                {
                    musteri_bireysel.Checked = true;
                }
                else
                {
                    musteri_kurumsal.Checked = true;
                }
                baglan.Close();
                musteri_ekle_button.Text = "Müşteri Güncelle";
                musteri_ekle_button.Click -= musteri_ekle_button_Click;
                musteri_ekle_button.Click += musteriGuncelle;
                musteri_sil_button.Visible = true;

            }
        }
        private void musteriGuncelle(object sender, EventArgs e)
        {
            progressIlerle();
            if (musteri_bireysel.Checked)
            {
                musteritipi = "Bireysel";
            }
            else
            {
                musteritipi = "Kurumsal";
            }

            try
            {
                baglan.Open();
                command = new OleDbCommand("UPDATE musteriler SET ad=@ad, vd=@vd, tckno=@tckno, tip=@tip, ulke=@ulke, sehir=@sehir, ilce=@ilce, adres=@adres, yetkili=@yetkili, yetkilimail=@yetkilimail, telefon=@telefon, fax=@fax, web=@web WHERE id=" + musteri_no.Text.ToString(), baglan);
                gonder();
                MessageBox.Show("Müşteri Güncellendi", "İşlem Başarılı");
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "İşlem Başarısız!");
                baglan.Close();
            }
            _masterForm(1);
        }
        private void musteriSil(object sender, EventArgs e)
        {
            progressIlerle();
            try
            {
                baglan.Open();
                command = new OleDbCommand("DELETE FROM musteriler WHERE id=" + musteri_no.Text.ToString(), baglan);
                gonder();
                MessageBox.Show("Müşteri Silindi", "İşlem Başarılı");
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "İşlem Başarısız!");
                baglan.Close();
            }
            _masterForm(1);
        }
    }
}
