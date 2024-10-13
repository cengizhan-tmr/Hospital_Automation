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
    public partial class FormDoktorGuncelle : Form
    {
        public FormDoktorGuncelle()
        {
            InitializeComponent();
        }
        SqlBaglantisi _SqlBaglantisi = new SqlBaglantisi();
        public string doktortc;

        private void FormDoktorGuncelle_Load(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select Ad, Soyad, Brans, Telefon, Mail, Sifre From Tbl_Doktorlar where TckimlikNo=@p1", _SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", doktortc);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                TxbAd.Text = dr["Ad"].ToString();
                TxbSoyad.Text = dr["Soyad"].ToString();
                CmbBrans.Text = dr["Brans"].ToString();
                TxbTel.Text = dr["Telefon"].ToString();
                TbxMail.Text = dr["Mail"].ToString();
                TxbSifre.Text = dr["Sifre"].ToString();
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _SqlBaglantisi.baglanti().Close();

            //Branşları listeleme
            SqlCommand komut2 = new SqlCommand("SELECT BransAdı FROM Tbl_Branslar", _SqlBaglantisi.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2["BransAdı"].ToString());
            }
            _SqlBaglantisi.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            // Formdaki gerekli alanların dolu olduğunu kontrol et
            if (string.IsNullOrWhiteSpace(TxbAd.Text) ||
                string.IsNullOrWhiteSpace(TxbSoyad.Text) ||
                string.IsNullOrWhiteSpace(TxbSifre.Text) ||
                !CbKontrol.Checked)
            {
                MessageBox.Show("Boş kalan alanları lütfen doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Veritabanı bağlantısı ve komut oluşturma
            using (SqlConnection connection = _SqlBaglantisi.baglanti())
            {
                string updateQuery = "UPDATE Tbl_Doktorlar " +
                                     "SET Ad = @Ad, " +
                                     "    Soyad = @Soyad, " +
                                     "    Brans = @Brans, " +
                                     "    Telefon = @Telefon, " +
                                     "    Mail = @Mail, " +
                                     "    Sifre = @Sifre " +
                                     "WHERE TcKimlikNo = @TcKimlikNo";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@Ad", TxbAd.Text);
                    command.Parameters.AddWithValue("@Soyad", TxbSoyad.Text);
                    command.Parameters.AddWithValue("@Brans", CmbBrans.Text);
                    command.Parameters.AddWithValue("@Telefon", TxbTel.Text);
                    command.Parameters.AddWithValue("@Mail", TbxMail.Text);
                    command.Parameters.AddWithValue("@Sifre", TxbSifre.Text);
                    command.Parameters.AddWithValue("@TcKimlikNo", doktortc);

                    try
                    {
                        // Komutu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Güncelleme başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Exit();
                        }
                        else
                        {
                            MessageBox.Show("Güncellenen kayıt bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Exit()
        {

            FormDoktorDetaylari formDoktorDetaylari = new FormDoktorDetaylari();
            formDoktorDetaylari.doktorTc = doktortc;
            formDoktorDetaylari.Show();
            this.Close();
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
    }
}
