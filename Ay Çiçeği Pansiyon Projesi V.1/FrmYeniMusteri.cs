using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Ay_Çiçeği_Pansiyon_Projesi_V._1
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection
            (@"Data Source = METASIS-DYL1ZP1\SQLEXPRESS; Initial Catalog = AycicegiPansiyon; Integrated Security = True");

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "101";
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "102";
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "103";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "104";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "105";
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "106";
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "107";
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "108";
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "109";
        }

        private void btnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mavi Renkli Odalar Boş Odaları Gösterir.");
        }

        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Odalar Dolu Odaları Gösterir.");
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            lblToplamGun.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(lblToplamGun.Text)*50;
            txtUcret.Text = Convert.ToString(Ucret);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) VALUES ('" + txtAdi.Text + "', '"+ txtSoyadi.Text +"','"+ cmbCinsiyet.Text + "','" + mskTxtTelefon.Text + "','" + txtMail.Text + "','" + txtKimlikNo.Text + "','" + txtOdaNumarasi.Text + "','" + txtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' )", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();

            SqlCommand command = new SqlCommand("Select top 1 MusteriID from MusteriEkle order by MusteriID desc", baglanti);
            
            SqlDataReader dr = command.ExecuteReader();

            dr.Read();

                lblIDNo.Text =dr["MusteriID"].ToString();

            dr.Close();

            
            //SqlCommand komutkaydet = new SqlCommand("Select MusteriID from MusteriEkle where Adi='txtAdi.Text' and Soyadi='txtSoyadi.Text'",baglanti);
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.SelectCommand = komutkaydet;
            //int a = komutkaydet.ExecuteNonQuery();
            //lblIDNo.Text = Convert.ToString(a);

            //SqlCommand ID = new SqlCommand("Select MusteriID from MusteriEkle where Adi='txtAdi.Text' and Soyadi=txtSoyadi.Text ");
            //SqlDataReader Aydi = ID.ExecuteReader();
            //lblIDNo.Text = Aydi.GetString




            if (txtOdaNumarasi.Text == "101")
                {
                    SqlCommand komut1 = new SqlCommand("insert into Oda101 (Adi,Soyadi,Halakaliyormu,MusteriID) VALUES ('" + txtAdi.Text + "', '" + txtSoyadi.Text + "','1','"+ lblIDNo.Text + "')", baglanti);
                    komut1.ExecuteNonQuery();
                }
                ///
                if (txtOdaNumarasi.Text == "102")
                {
                    SqlCommand komut2 = new SqlCommand("insert into Oda102 (Adi,Soyadi,Halakaliyormu,MusteriID) VALUES ('" + txtAdi.Text + "', '" + txtSoyadi.Text + "','1','" + lblIDNo.Text + "')", baglanti);
                    komut2.ExecuteNonQuery();
                }
                ///
                if (txtOdaNumarasi.Text == "103")
                {
                    SqlCommand komut3 = new SqlCommand("insert into Oda103 (Adi,Soyadi,Halakaliyormu,MusteriID) VALUES ('" + txtAdi.Text + "', '" + txtSoyadi.Text + "','1','" + lblIDNo.Text + "')", baglanti);
                    komut3.ExecuteNonQuery();
                }
                ///
                if (txtOdaNumarasi.Text == "104")
                {
                    SqlCommand komut4 = new SqlCommand("insert into Oda104 (Adi,Soyadi,Halakaliyormu,MusteriID) VALUES ('" + txtAdi.Text + "', '" + txtSoyadi.Text + "','1','" + lblIDNo.Text + "')", baglanti);
                    komut4.ExecuteNonQuery();
                }
                ///
                if (txtOdaNumarasi.Text == "105")
                {
                    SqlCommand komut5 = new SqlCommand("insert into Oda105 (Adi,Soyadi,Halakaliyormu,MusteriID) VALUES ('" + txtAdi.Text + "', '" + txtSoyadi.Text + "','1','" + lblIDNo.Text + "')", baglanti);
                    komut5.ExecuteNonQuery();
                }
                ///
                if (txtOdaNumarasi.Text == "106")
                {
                    SqlCommand komut6 = new SqlCommand("insert into Oda106 (Adi,Soyadi,Halakaliyormu,MusteriID) VALUES ('" + txtAdi.Text + "', '" + txtSoyadi.Text + "','1','" + lblIDNo.Text + "')", baglanti);
                    komut6.ExecuteNonQuery();
                }
                ///
                if (txtOdaNumarasi.Text == "107")
                {
                    SqlCommand komut7 = new SqlCommand("insert into Oda107 (Adi,Soyadi,Halakaliyormu,MusteriID) VALUES ('" + txtAdi.Text + "', '" + txtSoyadi.Text + "','1','" + lblIDNo.Text + "')", baglanti);
                    komut7.ExecuteNonQuery();
                }
                ///
                if (txtOdaNumarasi.Text == "108")
                {
                    SqlCommand komut8 = new SqlCommand("insert into Oda108 (Adi,Soyadi,Halakaliyormu,MusteriID) VALUES ('" + txtAdi.Text + "', '" + txtSoyadi.Text + "','1','" + lblIDNo.Text + "')", baglanti);
                    komut8.ExecuteNonQuery();
                }
                ///
                if (txtOdaNumarasi.Text == "109")
                {
                    SqlCommand komut9 = new SqlCommand("insert into Oda109 (Adi,Soyadi,Halakaliyormu,MusteriID) VALUES ('" + txtAdi.Text + "', '" + txtSoyadi.Text + "','1','" + lblIDNo.Text + "')", baglanti);
                    komut9.ExecuteNonQuery();
                
            }
            

            
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Tamamlanmıştır.");

        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * from Oda101 where halakaliyormu=1", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btnOda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnOda101.Text != "101")
            {
                btnOda101.BackColor = Color.Red;
                btnOda101.Enabled = false;
            }

            /////
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btnOda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnOda102.Text != "102")
            {
                btnOda102.BackColor = Color.Red;
                btnOda102.Enabled = false;
            }

            ////////

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btnOda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnOda103.Text != "103")
            {
                btnOda103.BackColor = Color.Red;
                btnOda103.Enabled = false;
            }
            ///////

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btnOda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnOda104.Text != "104")
            {
                btnOda104.BackColor = Color.Red;
                btnOda104.Enabled = false;
            }

            /////
            ///
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                btnOda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnOda105.Text != "105")
            {
                btnOda105.BackColor = Color.Red;
                btnOda105.Enabled = false;
            }
            /////
            ///
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                btnOda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnOda106.Text != "106")
            {
                btnOda106.BackColor = Color.Red;
                btnOda106.Enabled = false;
            }

            /////

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                btnOda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnOda107.Text != "107")
            {
                btnOda107.BackColor = Color.Red;
                btnOda107.Enabled = false;
            }
            //////
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("Select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                btnOda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnOda108.Text != "108")
            {
                btnOda108.BackColor = Color.Red;
                btnOda108.Enabled = false;
            }
            //////

            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("Select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                btnOda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnOda109.Text != "109")
            {
                btnOda109.BackColor = Color.Red;
                btnOda109.Enabled = false;
            }
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmAnaSayfa fr = new frmAnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void lblIDNo_Click(object sender, EventArgs e)
        {
         

        }
    }
}
