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
using System.IO;



namespace GorselProgProje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        public static OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.oledb.12.0;Data Source = mediaplayerdb.accdb");
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void sesTrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            //Görüntü olarak Sespicturebox resim değişimleri ve müzik sesi ayarlamaları 
            sesTrackbar.Minimum = 0;
            sesTrackbar.Maximum = 100;
            axWindowsMediaPlayer1.settings.volume = sesTrackbar.Value;
            if(sesTrackbar.Value >75)
            {
                sesPicturebox.ImageLocation = @"iconssound/speaker_32px.png";
            }
            else if(sesTrackbar.Value > 50)
            {
                sesPicturebox.ImageLocation = @"iconssound/sound_32px.png";
            }
            else if(sesTrackbar.Value > 25)
            {
                sesPicturebox.ImageLocation = @"iconssound/voice_32px.png";
            }
            else if(sesTrackbar.Value == 0)
            {
                sesPicturebox.ImageLocation = @"iconssound/mute_32px.png";
            }
        }

        private void btn_anasayfa_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = anasayfa;
        }

        private void btn_listem_Click(object sender, EventArgs e)
        {
            //Liste Sayfasına girerken Listemeleme işlemleri yapılacak
            tabControl1.SelectedTab = listem;
            muzikListele();
            
        }

        private void btn_hakkimizda_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = hakkimizda;
        }

        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            ayarlarPanel.Visible = true;
            
        }
        /* void muzikListele()
         {
             baglanti.Open();
             OleDbCommand listele = new OleDbCommand();
             listele.CommandText = "Select * from listem";
             listele.Connection = baglanti;
             OleDbDataReader oku;
             oku = listele.ExecuteReader();
             DataTable tablo = new DataTable();
             tablo.Columns.Add("#");
             tablo.Columns.Add("Resim");
             tablo.Columns.Add("Şarkıcı");
             tablo.Columns.Add("Albüm");
             tablo.Columns.Add("Tarih");
             tablo.Columns.Add("Süre");
             tablo.Columns.Add("Müzik Yolu");
             DataRow satir;
             while(oku.Read())
             {
                 satir = tablo.NewRow();
                 satir[0] = oku[0];
                 satir[1] = oku[1];
                 satir[2] = oku[2];
                 satir[3] = oku[3];
                 satir[4] = oku[4];
                 satir[5] = oku[5];
                 satir[6] = oku[6];
                 tablo.Rows.Add(satir); 
                 listem_dgw.DataSource = tablo;
             }

             baglanti.Close();
         }
        */
        void muzikListele()
        {
            baglanti.Open();
            OleDbCommand listele = new OleDbCommand();
            listele.CommandText = "Select * from listem";
            listele.Connection = baglanti;
            DataSet ds  = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter(listele);
            adp.Fill(ds, "liste");
            /*listem_dgw.Columns.Add("Resim", Type.GetType("System.Byte[]"));
            foreach(DataRow drow in ds.Tables["liste"].Rows)
            {
                drow["Resim"] = File.ReadAllBytes(drow["resim"].ToString());
            }*/
            listem_dgw.DataSource = ds.Tables["liste"];
           
            baglanti.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            ayarlarPanel.Visible = false;
            guncellePanel.Visible = false;
            hosgeldinizLabel.Text = Form1.kadi;
            hosgeldinizLabel2.Text = Form1.kadi;

        }

        private void btnn_geri_Click(object sender, EventArgs e)
        {
            ayarlarPanel.Visible =false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Simge Durumuna Küçültme
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_muzikekle_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = muzikekleTabpage;
            muziksilPanel.Visible = false;
            guncellePanel.Visible = false;
            baglanti.Open();
            sqlListele();
        }

        private void btn_resimdialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lütfen Dosya Seçiniz";
            openFileDialog1.Filter = "JPEG File |*.jpeg|JPG File |*.jpg|PNG File |*.png|BITMAP File |*.bmp";
            openFileDialog1.ShowDialog();
            resimyoluText.Text = openFileDialog1.FileName;
        }

        private void btn_muzikdialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lütfen Dosya Seçiniz";
            openFileDialog1.Filter = "MP3 File |*.mp3";
            openFileDialog1.ShowDialog();
            muzikyoluText.Text = openFileDialog1.FileName;
        }

        private void btn_muzikeklesql_Click(object sender, EventArgs e)
        {
            //Veritabanına müzik kayıt etme 
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand();
            ekle.CommandText = "Insert into listem(resim,sarkiismi,sarkici,tarih,sure,muzikyolu) Values(@resimyolu,@sarkiismi,@sarkici,@tarih,@sure,@muzikyolu)";
            ekle.Connection = baglanti;
            ekle.Parameters.AddWithValue("@resimyolu", resimyoluText.Text);
            ekle.Parameters.AddWithValue("@sarkiismi",sarkiismiText.Text);
            ekle.Parameters.AddWithValue("@sarkici", sarkiciText.Text);
            ekle.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            axWindowsMediaPlayer1.URL = muzikyoluText.Text;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string sure = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
            ekle.Parameters.AddWithValue("@sure",sure);
            ekle.Parameters.AddWithValue("@muzikyolu", muzikyoluText.Text);
            if(ekle.ExecuteNonQuery()>0)
            {
                MessageBox.Show("Kayıt işlemi başarılı");
                sqlListele();
                resimyoluText.Clear();
                sarkiismiText.Clear();
                sarkiciText.Clear();
                muzikyoluText.Clear();
            }
            else
            {
                MessageBox.Show("Kayıt işlemi başarısız.");
            }
            baglanti.Close();
        }
        int secilen_satir;
        private void listem_dgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            timer1.Start();
            secilen_satir = listem_dgw.CurrentRow.Index;
            muzikPicturebox.ImageLocation = listem_dgw.Rows[secilen_satir].Cells["resim"].Value.ToString();
            sarkiLabel.Text = listem_dgw.Rows[secilen_satir].Cells["sarkiismi"].Value.ToString();
            sarkiciLabel.Text = listem_dgw.Rows[secilen_satir].Cells["sarkici"].Value.ToString();
            
            axWindowsMediaPlayer1.URL = listem_dgw.Rows[secilen_satir].Cells["muzikyolu"].Value.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            //Bir sonraki Müzik
            
            int satir = listem_dgw.CurrentRow.Index + 1;
            listem_dgw.Rows[satir].Selected = true;
            timer1.Start();
            muzikPicturebox.ImageLocation = listem_dgw.Rows[satir].Cells["resim"].Value.ToString();
            sarkiLabel.Text = listem_dgw.Rows[satir].Cells["sarkiismi"].Value.ToString();
            sarkiciLabel.Text = listem_dgw.Rows[satir].Cells["sarkici"].Value.ToString();
            axWindowsMediaPlayer1.URL = listem_dgw.Rows[satir].Cells["muzikyolu"].Value.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            //Bir önceki Müzik
            int satir = listem_dgw.CurrentRow.Index - 1;
            listem_dgw.Rows[satir].Selected = true;
            timer1.Start();
            muzikPicturebox.ImageLocation = listem_dgw.Rows[satir].Cells["resim"].Value.ToString();
            sarkiLabel.Text = listem_dgw.Rows[satir].Cells["sarkiismi"].Value.ToString();
            sarkiciLabel.Text = listem_dgw.Rows[satir].Cells["sarkici"].Value.ToString();
            axWindowsMediaPlayer1.URL = listem_dgw.Rows[satir].Cells["muzikyolu"].Value.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Barın ilerlemesi için gerekli 
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                muzikTrackbar.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                muzikTrackbar.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;//İlerleme komutu
                sureLabel.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                bitisLabel.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
                btn_durdurbaslat.BackgroundImage = Properties.Resources._2;
            }else
            {
                btn_durdurbaslat.BackgroundImage = Properties.Resources._1;
            }
        }

        private void btn_cikisyap_Click(object sender, EventArgs e)
        {
            //Oturum kapatma ekranı 
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btn_durdurbaslat_Click(object sender, EventArgs e)
        {
            //Müziği Durdurup başlatmak
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
               axWindowsMediaPlayer1.Ctlcontrols.pause(); 
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        void sqlListele()
        {
            
            OleDbCommand listele = new OleDbCommand();
            listele.CommandText = "Select * from listem";
            listele.Connection = baglanti;
            DataSet ds = new DataSet();
            OleDbDataAdapter adp = new OleDbDataAdapter(listele);
            adp.Fill(ds, "liste");
            muzikekle_dgw.DataSource = ds.Tables["liste"];
            baglanti.Close();
        }

        private void muzikTrackbar_Scroll(object sender, ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = muzikTrackbar.Value;
        }

        private void btn_muziksil_Click(object sender, EventArgs e)
        {
            muziksilPanel.Visible = true;
            guncellePanel.Visible = false;
            tabControl1.SelectedTab = muzikekleTabpage;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //Müzik silme 
            int secili_satir = muzikekle_dgw.CurrentRow.Index;

            baglanti.Open();
            OleDbCommand sil = new OleDbCommand();
            sil.CommandText = "delete from listem where sarkiismi=@isim and sarkici=@sarkici";
            sil.Connection = baglanti;
            sil.Parameters.AddWithValue("@isim",muzikekle_dgw.Rows[secilen_satir].Cells[2].Value.ToString());
            sil.Parameters.AddWithValue("@sarkici", muzikekle_dgw.Rows[secilen_satir].Cells[3].Value.ToString());
            DialogResult ds = MessageBox.Show("Bu müziği listeden silmek istediğinze emin misiniz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (ds == DialogResult.Yes)
            {
                if(sil.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("Silme işlemi başarılı");
                    sqlListele();

                }else
                {
                    MessageBox.Show("Silme işlemi başarısız.");
                }
            }
            baglanti.Close();
        }

        private void btn_muzikguncelle_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = muzikekleTabpage;
            guncellePanel.Visible = true;
            muziksilPanel.Visible = false;
            sqlListele();
        }

        private void muzikguncellebtn_Click(object sender, EventArgs e)
        {
            //guncelle 
            baglanti.Open();
            OleDbCommand guncelle = new OleDbCommand();
            guncelle.CommandText = "update listem set resim=@resim,sarkiismi=@isim,sarkici=@sarkici,muzikyolu=@muzik,sure=@sure where sarkiismi=@isim and sarkici=@sarkic";
            guncelle.Connection = baglanti;
            guncelle.Parameters.AddWithValue("@resim", resimyoluguncelleText.Text);
            guncelle.Parameters.AddWithValue("@isim", sarkiguncelleText.Text);
            guncelle.Parameters.AddWithValue("@sarkici", sarkiciguncelleText.Text);
            guncelle.Parameters.AddWithValue("@muzik", muzikyoluguncelleText.Text);
            axWindowsMediaPlayer1.URL = muzikyoluguncelleText.Text;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            string sure =axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString;
            guncelle.Parameters.AddWithValue("@sure", sure);
            guncelle.Parameters.AddWithValue("@isim", sarkiguncelleText.Text);
            guncelle.Parameters.AddWithValue("@sarkic", sarkiciguncelleText.Text);
            if(guncelle.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Güncelleme işlemi başarılı.");
                sqlListele();
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi başarısız.");
            }
            baglanti.Close();
        }

        private void resimdialog2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lütfen Dosya Seçiniz";
            openFileDialog1.Filter = "JPEG File |*.jpeg|JPG File |*.jpg|PNG File |*.png|BITMAP File |*.bmp";
            openFileDialog1.ShowDialog();
            resimyoluguncelleText.Text = openFileDialog1.FileName;
        }

        private void muzikdialog2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lütfen Dosya Seçiniz";
            openFileDialog1.Filter = "MP3 File |*.mp3";
            openFileDialog1.ShowDialog();
            muzikyoluguncelleText.Text = openFileDialog1.FileName;
        }

        private void muzikekle_dgw_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //update için çek
            int updatesatir = muzikekle_dgw.CurrentRow.Index;
            sarkiguncelleText.Text = muzikekle_dgw.Rows[updatesatir].Cells[2].Value.ToString();
            sarkiciguncelleText.Text = muzikekle_dgw.Rows[updatesatir].Cells[3].Value.ToString();
            resimyoluguncelleText.Text = muzikekle_dgw.Rows[updatesatir].Cells[1].Value.ToString();
            muzikyoluguncelleText.Text = muzikekle_dgw.Rows[updatesatir].Cells[6].Value.ToString();
        }
    }
}
