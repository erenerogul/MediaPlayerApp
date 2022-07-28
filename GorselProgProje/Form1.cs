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

namespace GorselProgProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.oledb.12.0;Data Source = mediaplayerdb.accdb");
        public static String kadi;
        private void girisyapButton_Click(object sender, EventArgs e)
        {
            //Kullanıcı giriş bilgileri alınıp açılma yapılıcak
            baglanti.Open();
            OleDbCommand giris = new OleDbCommand();
            giris.CommandText = "select * from kullanicilar where kullaniciadi = @kadi and sifre=@sifre";
            giris.Parameters.Add("@kadi",kadiText.Text);
            giris.Parameters.Add("@sifre",sifreText.Text);
            giris.Connection = baglanti;
            OleDbDataReader oku;
            oku = giris.ExecuteReader();
            if (oku.HasRows == true)
            {
                kadi = kadiText.Text;
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Parola Yanlış");
                kadiText.Clear();
                sifreText.Clear();
            }
            baglanti.Close();
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Üye Olma Formuna Yönlendiriyoruz
            tabControl1.SelectedTab = kayitOl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = giris;
            kadiText.Clear();
            sifreText.Clear();
            
        }

        private void gunaLinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = giris;
        }

        private void btn_kayitOl_Click(object sender, EventArgs e)
        {
            // E postadada @ arat mesela küçük şeyler sonra bakılabilecek şeyler 
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand();
            ekle.CommandText = "insert into kullanicilar values (@kullaniciadi,@sifre,@eposta)";
            ekle.Parameters.Add("@kullaniciadi",kayitol_kadiText.Text);
            ekle.Parameters.Add("@sifre", kayitol_sifreText.Text);
            ekle.Parameters.Add("@eposta", kayitol_epostaText.Text);
            ekle.Connection = baglanti;
            if(ekle.ExecuteNonQuery()>0)
            {
                MessageBox.Show("Kayıt işlemi başarılı");
                kayitol_kadiText.Clear();
                kayitol_sifreText.Clear();
                kayitol_epostaText.Clear();
                tabControl1.SelectedTab=giris;
            }
            else
            {
                MessageBox.Show("Kayıt işlemi başarısız.");
            }
            baglanti.Close();

        }
    }
}
