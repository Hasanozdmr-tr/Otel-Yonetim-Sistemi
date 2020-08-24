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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source = METASIS-DYL1ZP1\SQLEXPRESS;Initial Catalog = AycicegiPansiyon; Integrated Security = True;");

        public void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());
                ekle.SubItems.Add(oku["MusteriID"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            txtAdi.Text=listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNumarasi.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
            lblIDNo.Text= listView1.SelectedItems[0].SubItems[11].Text;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where MusteriID=("+ id + ")",baglanti);
            komut.ExecuteNonQuery();

            if (txtOdaNumarasi.Text == "101")
            {
                SqlCommand komut1 = new SqlCommand("delete from oda101 where MusteriID=(" + id + ")", baglanti);
                komut1.ExecuteNonQuery();
            }
            if (txtOdaNumarasi.Text == "102")
            {
                SqlCommand komut2 = new SqlCommand("delete from oda102 where MusteriID=(" + id + ")", baglanti);
                komut2.ExecuteNonQuery();
            }
            //
            if (txtOdaNumarasi.Text == "103")
            {
                SqlCommand komut3 = new SqlCommand("delete from oda103 where MusteriID=(" + id + ")", baglanti);
                komut3.ExecuteNonQuery();
            }
            //
            if (txtOdaNumarasi.Text == "104")
            {
                SqlCommand komut4 = new SqlCommand("delete from oda104 where MusteriID=(" + id + ")", baglanti);
                komut4.ExecuteNonQuery();
            }
            //
            if (txtOdaNumarasi.Text == "105")
            {
                SqlCommand komut5 = new SqlCommand("delete from oda105 where MusteriID=(" + id + ")", baglanti);
                komut5.ExecuteNonQuery();
            }
            //
            if (txtOdaNumarasi.Text == "106")
            {
                SqlCommand komut6 = new SqlCommand("delete from oda106 where MusteriID=(" + id + ")", baglanti);
                komut6.ExecuteNonQuery();
            }
            //
            if (txtOdaNumarasi.Text == "107")
            {
                SqlCommand komut7 = new SqlCommand("delete from oda107 where MusteriID=(" + id + ")", baglanti);
                komut7.ExecuteNonQuery();
            }
            //
                 if (txtOdaNumarasi.Text == "108")
            {
                SqlCommand komut8 = new SqlCommand("delete from oda108 where MusteriID=(" + id + ")", baglanti);
                komut8.ExecuteNonQuery();
            }
                 //
            if (txtOdaNumarasi.Text == "109")
            {
                SqlCommand komut9 = new SqlCommand("delete from oda109 where MusteriID=(" + id + ")", baglanti);
                komut9.ExecuteNonQuery();
            }
            baglanti.Close();
            verilerigoster();


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            cmbCinsiyet.Text = "";
            mskTxtTelefon.Clear();
            txtMail.Clear();
            txtKimlikNo.Clear();
            txtOdaNumarasi.Clear();
            txtUcret.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='" + txtAdi.Text + "',Soyadi='" + txtSoyadi.Text + "',Cinsiyet='" + cmbCinsiyet.Text + "', Telefon='" + mskTxtTelefon.Text + "', Mail='" + txtMail.Text + "', TC='" + txtKimlikNo.Text + "', OdaNo='" + txtOdaNumarasi.Text + "', Ucret='" + txtUcret.Text + "', GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "', CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "' where MusteriID=(" + id + ")", baglanti);
            komut.ExecuteNonQuery(); //parametreler üzerinde değişiklik yap demek bu.
            baglanti.Close();
            verilerigoster();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from MusteriEkle where Adi like '%"+txtArama.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {

            frmAnaSayfa fr = new frmAnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void lblIDNo_Click(object sender, EventArgs e)
        {
            int ID;

        }

        private void btnAyriliyor_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            if (txtOdaNumarasi.Text == "101")
            {
                SqlCommand komut1 = new SqlCommand("update Oda101 set halakaliyormu=0 where MusteriID=(" + id + ")", baglanti);
                komut1.ExecuteNonQuery();
            }

            if (txtOdaNumarasi.Text == "102")
            {
                SqlCommand komut2 = new SqlCommand("update Oda102 set halakaliyormu=0 where MusteriID=(" + id + ")", baglanti);
                komut2.ExecuteNonQuery();
            }

            if (txtOdaNumarasi.Text == "103")
            {
                SqlCommand komut3 = new SqlCommand("update Oda103 set halakaliyormu=0 where MusteriID=(" + id + ")", baglanti);
                komut3.ExecuteNonQuery();
            }

            if (txtOdaNumarasi.Text == "104")
            {
                SqlCommand komut4 = new SqlCommand("update Oda104 set halakaliyormu=0 where MusteriID=(" + id + ")", baglanti);
                komut4.ExecuteNonQuery();
            }

            if (txtOdaNumarasi.Text == "105")
            {
                SqlCommand komut5 = new SqlCommand("update Oda105 set halakaliyormu=0 where MusteriID=(" + id + ")", baglanti);
                komut5.ExecuteNonQuery();
            }

            if (txtOdaNumarasi.Text == "106")
            {
                SqlCommand komut6 = new SqlCommand("update Oda106 set halakaliyormu=0 where MusteriID=(" + id + ")", baglanti);
                komut6.ExecuteNonQuery();
            }

            if (txtOdaNumarasi.Text == "107")
            {
                SqlCommand komut7 = new SqlCommand("update Oda107 set halakaliyormu=0 where MusteriID=(" + id + ")", baglanti);
                komut7.ExecuteNonQuery();
            }

            if (txtOdaNumarasi.Text == "108")
            {
                SqlCommand komut8 = new SqlCommand("update Oda108 set halakaliyormu=0 where MusteriID=(" + id + ")", baglanti);
                komut8.ExecuteNonQuery();
            }

            if (txtOdaNumarasi.Text == "109")
            {
                SqlCommand komut9 = new SqlCommand("update Oda109 set halakaliyormu=0 where MusteriID=(" + id + ")", baglanti);
                komut9.ExecuteNonQuery();
            }
            baglanti.Close();
            verilerigoster();
        }
    }
}



//Data Source = METASIS - DYL1ZP1\SQLEXPRESS;Initial Catalog = AycicegiPansiyon; Integrated Security = True;

