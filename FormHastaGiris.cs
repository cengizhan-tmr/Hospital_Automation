using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class FormHastaGiris : Form
    {
        SqlBaglantisi _SqlBaglantisi = new SqlBaglantisi();
        public FormHastaGiris()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FormKontrol formKontrol = new FormKontrol();
            formKontrol.ShowDialog();
        }

        private void LnkKayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaKayıt formHastaKayıt = new FormHastaKayıt();
            formHastaKayıt.Show();
            this.Close();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (TxtTc.Text == "" || TxtSifre.Text == "" || checkBox1.Checked == false)
            {
                MessageBox.Show("Boş kalan alanları lütfen doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komutgiris = new SqlCommand("SELECT * FROM Tbl_Hastalar WHERE TcKimlikNo=@p1 AND Sifre=@p2",_SqlBaglantisi.baglanti());
                komutgiris.Parameters.AddWithValue("@p1", TxtTc.Text);
                komutgiris.Parameters.AddWithValue("@p2", TxtSifre.Text);

                try
                {
                    
                    SqlDataReader dr = komutgiris.ExecuteReader();
                    if (dr.Read())
                    {
                        FormHastaDetay frmhasta = new FormHastaDetay();
                        frmhasta.hastatc = TxtTc.Text;
                        frmhasta.Show();
                        _SqlBaglantisi.baglanti().Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("TC Kimlik No veya Şifre hatalı, lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    _SqlBaglantisi.baglanti().Close();
                }
            }
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();            
        }

        private void FormHastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
