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
    public partial class FormHastaGuncelle : Form
    {
        public FormHastaGuncelle()
        {
            InitializeComponent();
        }
        SqlBaglantisi _SqlBaglantisi = new SqlBaglantisi();

        public string tcno;


        private void BtnGuncelle_Click(object sender, EventArgs e)
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

                SqlCommand Guncelle = new SqlCommand("UPDATE Tbl_Hastalar SET Ad = @a1, Soyad = @a2, DogumTarihi = @a3, Cinsiyet = @a4, Adres = @a5, Telefon = @a6, Mail = @a7, Sifre = @a8 WHERE TckimlikNo = @a9", _SqlBaglantisi.baglanti());
                Guncelle.Parameters.AddWithValue("@a1", TxbAd.Text);
                Guncelle.Parameters.AddWithValue("@a2", TxbSoyad.Text);
                Guncelle.Parameters.AddWithValue("@a3", dogumTarihi);
                Guncelle.Parameters.AddWithValue("@a4", cinsiyet);
                Guncelle.Parameters.AddWithValue("@a5", TbxAdres.Text);
                Guncelle.Parameters.AddWithValue("@a6", TxbTel.Text);
                Guncelle.Parameters.AddWithValue("@a7", TbxMail.Text);
                Guncelle.Parameters.AddWithValue("@a8", TxbSifre.Text);
                Guncelle.Parameters.AddWithValue("@a9", TxbTc.Text);

                try
                {
                    Guncelle.ExecuteNonQuery();
                    MessageBox.Show("Güncelleme başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Exit();
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

        private void Exit()
        {

            FormHastaDetay formHastaDetay = new FormHastaDetay();
            formHastaDetay.hastatc = tcno;
            formHastaDetay.Show();
            this.Close();
        }
        private void FormHastaGuncelle_Load(object sender, EventArgs e)
        {

            TxbTc.Text = tcno;
            SqlCommand komut = new SqlCommand("Select Ad, Soyad, TckimlikNo, DogumTarihi, Cinsiyet, Adres, Telefon, Mail, Sifre From Tbl_Hastalar where TckimlikNo=@p1", _SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", TxbTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                TxbAd.Text = dr["Ad"].ToString();
                TxbSoyad.Text = dr["Soyad"].ToString();
                TxbTc.Text = dr["TckimlikNo"].ToString();
                DtDogumTarihi.Value = Convert.ToDateTime(dr["DogumTarihi"]);

                if (dr["Cinsiyet"].ToString() == "Erkek")
                {
                    RbErkek.Checked = true;
                }
                else if (dr["Cinsiyet"].ToString() == "Kadın")
                {
                    RbKadın.Checked = true;
                }
                TbxAdres.Text = dr["Adres"].ToString();
                TxbTel.Text = dr["Telefon"].ToString();
                TbxMail.Text = dr["Mail"].ToString();
                TxbSifre.Text = dr["Sifre"].ToString();
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _SqlBaglantisi.baglanti().Close();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void CbKontrol_CheckedChanged(object sender, EventArgs e)
        {
            FormKontrol formKontrol = new FormKontrol();
            formKontrol.ShowDialog();
        }

        private void DtDogumTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxbSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbxAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TbxMail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxbSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
