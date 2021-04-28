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
    public partial class urunEkle : Form
    {

        private Func<int,int> _masterForm;
        public urunEkle(Func<int,int> oncloseFunc)
        {
            InitializeComponent();
            _masterForm = oncloseFunc;

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\depootomasyon.accdb");
        OleDbCommand command;
        OleDbDataAdapter genelAdaptor;
        OleDbDataReader reader;
        DataSet veriAyarla;

        private void sadeceSayi(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textboxKontrol()
        {
            foreach (Control c in groupBox1.Controls)
            {

                if (c is TextBox)
                    if (c.Text != "")
                    {
                        c.Text = "";
                    }

            }
        }

        private void grupAl()
        {
            baglan.Open();
            genelAdaptor = new OleDbDataAdapter("SELECT * FROM urungruplari", baglan);
            DataTable dt = new DataTable();
            genelAdaptor.Fill(dt);
            detay_grupAd.ValueMember = "grup_ad";
            detay_grupAd.DisplayMember = "grup_ad";
            detay_grupAd.DataSource = dt;
            detay_grupAd.Text = "Ürün grubu seçin";
            grup_ad.ValueMember = "grup_ad";
            grup_ad.DisplayMember = "grup_ad";
            grup_ad.DataSource = dt;
            grup_ad.Text = "Ürün grubu seçin";

            baglan.Close();

        }

        private void gonder()
        {
            command.Parameters.AddWithValue("@urun_adi", detay_ad.Text);
            command.Parameters.AddWithValue("@barkod", Convert.ToInt32(detay_barkod.Text));
            command.Parameters.AddWithValue("@urun_grup", detay_grupAd.Text);
            command.Parameters.AddWithValue("@urun_grupkod", Convert.ToInt32(detay_grupKod.Text));
            command.Parameters.AddWithValue("@alis_fiyat", Convert.ToInt32(detay_alis.Text));
            command.Parameters.AddWithValue("@satis_fiyat", Convert.ToInt32(detay_satis.Text));
            command.Parameters.AddWithValue("@kdv", Convert.ToInt32(detay_kdv.Text));
            command.Parameters.AddWithValue("@birim", detay_birim.Text);
            command.Parameters.AddWithValue("@miktar", Convert.ToInt32(detay_miktar.Text));
            command.ExecuteNonQuery();
            baglan.Close();
        }

        private void detay_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                command = new OleDbCommand("INSERT INTO urunler (urun_adi, barkod, urun_grup, urun_grupkod, alis_fiyat, satis_fiyat, kdv, birim, miktar)" +
               " VALUES (@urun_adi, @barkod, @urun_grup, @urun_grupkod, @alis_fiyat, @satis_fiyat, @kdv, @birim, @miktar)", baglan);
                gonder();
                MessageBox.Show("Ürün Başarıyla Eklendi", "Ürün Eklendi");
                _masterForm(1);
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Ürün Ekleme Başarısız!");
                baglan.Close();
            }
           
        }

        private void detay_vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void urunGuncelle(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                command = new OleDbCommand("UPDATE urunler SET urun_adi=@urun_adi, barkod=@barkod, urun_grup=@urun_grup, urun_grupkod=@urun_grupkod, alis_fiyat=@alis_fiyat, satis_fiyat=@satis_fiyat, kdv=@kdv, birim=@birim, miktar=@miktar WHERE id=" + Convert.ToInt32(detay_stok.Text), baglan);
                gonder();
                MessageBox.Show("Ürün Başarıyla Güncellendi", "Güncelleme Başarılı");
                _masterForm(1);
            }
            catch (Exception aciklama)
            {
                MessageBox.Show(aciklama.Message, "Güncelleme Başarısız!");
                baglan.Close();
            }
        }

        private void urunEkle_Load(object sender, EventArgs e)
        {
            if (Form2.gonderilecekUrun != null)
            {
                this.Text = "Ürün Detay";
                detay_stok.Text = Form2.gonderilecekUrun;
                grupAl();
                baglan.Open();
                command = new OleDbCommand("SELECT * FROM urunler WHERE id=" + Form2.gonderilecekUrun, baglan);
                reader = command.ExecuteReader();
                reader.Read();
                detay_ad.Text = reader[1].ToString();
                detay_barkod.Text = reader[2].ToString();
                detay_grupAd.Text = reader[3].ToString();
                detay_grupKod.Text = reader[4].ToString();
                detay_alis.Text = reader[5].ToString();
                detay_satis.Text = reader[6].ToString();
                detay_kdv.Text = reader[7].ToString();
                detay_birim.Text = reader[8].ToString();
                detay_miktar.Text = reader[9].ToString();
                baglan.Close();
                detay_kaydet.Text = "Güncelle";
                detay_kaydet.Click += urunGuncelle;
                detay_sil.Visible = true;
                detay_grupAd.SelectedIndexChanged += grupKodAl;
            }
            else
            {
                detay_kaydet.Click += detay_kaydet_Click;
                grupAl();
                detay_grupAd.SelectedIndexChanged += grupKodAl;
            }
        }

        private void detay_sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            command = new OleDbCommand("DELETE FROM urunler WHERE id=" + Form2.gonderilecekUrun, baglan);
            gonder();
            baglan.Close();
            MessageBox.Show("Ürün başarıyla silindi.", "Silme Başarılı !");
            _masterForm(1);
            this.Close();
        }

        private void grupKodAl(object sender, EventArgs e)
        {
            baglan.Open();
            command = new OleDbCommand("SELECT * FROM urungruplari WHERE grup_ad LIKE '%" + detay_grupAd.SelectedValue + "%'", baglan);
            reader = command.ExecuteReader();
            reader.Read();
            detay_grupKod.Text = reader[1].ToString();
            baglan.Close();
        }
    }
}
