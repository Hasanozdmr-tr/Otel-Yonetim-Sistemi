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
    public partial class FrmAdminGiris : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source = METASIS-DYL1ZP1\SQLEXPRESS;Initial Catalog = AycicegiPansiyon; Integrated Security = True;");

        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * from AdminGiris where Kullanici=@Kullaniciadi and Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("Kullaniciadi", txtKullaniciAdi.Text);
                SqlParameter prm2 = new SqlParameter("Sifresi", txtSifre.Text);
                SqlCommand command = new SqlCommand(sql, baglanti);
                command.Parameters.Add(prm1);
                command.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);

                if(dt.Rows.Count>0)
                {
                    frmAnaSayfa frm = new frmAnaSayfa();
                    frm.Show();
                    frm.Hide();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }
               
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            frmAnaSayfa fr = new frmAnaSayfa();
            fr.Show();
            this.Hide();
        }
    }
}
