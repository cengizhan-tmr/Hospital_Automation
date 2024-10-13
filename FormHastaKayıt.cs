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
    public partial class FormHastaKayıt : Form
    {

        SqlBaglantisi _SqlBaglantisi = new SqlBaglantisi();
        public FormHastaKayıt()
        {
            InitializeComponent();
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FormKontrol formKontrol = new FormKontrol();
            formKontrol.ShowDialog();

        }
        void temizle()
        {
            TxbAd.Text = "";
            TxbSoyad.Text = "";
            TxbTc.Text = "";
            TxbTel.Text = "";
            TbxAdres.Text = "";
            TbxMail.Text = "";
            RbErkek.Checked = false;
            RbKadın.Checked = false;
            TxbSifre.Text = "";
            CbKontrol.Checked = false;
        }

        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            if (TxbAd.Text == "" || TxbSoyad.Text == "" || TxbTc.Text == "" || TxbSifre.Text == "" || CbKontrol.Checked == false)
            {
                MessageBox.Show("Boş kalan alanları lütfen doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cinsiyet = RbErkek.Checked ? "Erkek" : RbKadın.Checked ? "Kadın" : null;

                if (cinsiyet == null)
                {
                    MessageBox.Show("Cinsiyet alanını lütfen seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string dogumTarihi = DtDogumTarihi.Value.ToString("yyyy-MM-dd");


                SqlCommand KayitEt = new SqlCommand("insert into Tbl_Hastalar (Ad, Soyad, TckimlikNo, DogumTarihi, Cinsiyet, Adres, Telefon, Mail, Sifre) VALUES (@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9)", _SqlBaglantisi.baglanti());
                KayitEt.Parameters.AddWithValue("@a1", TxbAd.Text);
                KayitEt.Parameters.AddWithValue("@a2", TxbSoyad.Text);
                KayitEt.Parameters.AddWithValue("@a3", TxbTc.Text);
                KayitEt.Parameters.AddWithValue("@a4", dogumTarihi);
                KayitEt.Parameters.AddWithValue("@a5", cinsiyet);
                KayitEt.Parameters.AddWithValue("@a6", TbxAdres.Text);
                KayitEt.Parameters.AddWithValue("@a7", TxbTel.Text);
                KayitEt.Parameters.AddWithValue("@a8", TbxMail.Text);
                KayitEt.Parameters.AddWithValue("@a9", TxbSifre.Text);

                try
                {
                    KayitEt.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    temizle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormHastaKayıt_Load(object sender, EventArgs e)
        {

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            FormHastaGiris formHastaGiris = new FormHastaGiris();
            formHastaGiris.Show();
            this.Hide();
        }
    }
}