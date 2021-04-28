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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            
            
            textBox1.BorderStyle = BorderStyle.None;
            textBox2.BorderStyle = BorderStyle.None;

            
            
        }
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\depootomasyon.accdb");
        public static string girisİsim;
        public static bool yetkili = false;



        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("Kullanıcı adı boş bırakılamaz!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Şifre boş bırakılamaz!");
            }
            else
            {
                baglan.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT * FROM  kullanicilar " +
                    " WHERE " +
                    " kullanici_adi=@kullanici_adi" +
                    " AND sifre=@sifre ", baglan);
                command.Parameters.AddWithValue("@kullanici_adi", textBox1.Text);
                command.Parameters.AddWithValue("@sifre", textBox2.Text);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader[4].ToString() == "True")
                    {
                        yetkili = true;
                        girisİsim = reader[1].ToString();
                        Form2 f2 = new Form2();
                        this.Visible = false;
                        f2.ShowDialog();
                        this.Visible = true;
                    }
                    else
                    {
                        yetkili = false;
                        girisİsim = reader[1].ToString();
                        Form2 f2 = new Form2();
                        this.Visible = false;
                        f2.ShowDialog();
                        this.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı kayıtlı değil", "Hatalı Kullanıcı!");
                }
                baglan.Close();
            }
        }
        

        private void kul_giris(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                label1.Visible = false;
            }
            else
                label1.Visible = true;
        }

        private void kul_giris_sifre(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                label2.Visible = false;
            }
            else
                label2.Visible = true;
        }

        private void kapat(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
