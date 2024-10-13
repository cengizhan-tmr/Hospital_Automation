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
    public partial class FormHastaRandevuAlma : Form
    {
        public FormHastaRandevuAlma()
        {
            InitializeComponent();
        }
        SqlBaglantisi _SqlBaglantisi = new SqlBaglantisi();
        public string hastatc;

       

        private void FormHastaRandevuAlma_Load(object sender, EventArgs e)
        {
            AddTimeSlots();
            LblTc.Text = hastatc;

            // Ad Soyad çekme
            using (SqlCommand komut = new SqlCommand("SELECT Ad, Soyad,DogumTarihi FROM Tbl_Hastalar WHERE TcKimlikNo = @d1", _SqlBaglantisi.baglanti()))
            {
                komut.Parameters.AddWithValue("@d1", LblTc.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    LblAd.Text = $"{dr["Ad"]}";
                    LblSoyad.Text = $"{dr["Soyad"]}";
                }
                _SqlBaglantisi.baglanti().Close();
            }


            SqlCommand komut2 = new SqlCommand("SELECT BransAdı FROM Tbl_Branslar", _SqlBaglantisi.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2["BransAdı"].ToString());
            }
            _SqlBaglantisi.baglanti().Close();

        }
        private void AddTimeSlots()
        {
            TimeSpan startTime = new TimeSpan(8, 15, 0); // Başlangıç zamanı: 08:15
            TimeSpan endTime = new TimeSpan(16, 45, 0); // Bitiş zamanı: 16:45
            TimeSpan interval = new TimeSpan(0, 15, 0); // Zaman aralığı: 15 dakika

            // İstisnai zaman dilimleri aralığı
            TimeSpan exceptionStart = new TimeSpan(12, 30, 0);
            TimeSpan exceptionEnd = new TimeSpan(13, 30, 0);

            for (TimeSpan time = startTime; time <= endTime; time = time.Add(interval))
            {
                if (time < exceptionStart || time >= exceptionEnd)
                {
                    this.cBRandevuSaati.Items.Add(time.ToString(@"hh\:mm"));
                }
            }
        }
        // Branş seçtikten sonra combobox'a o branştaki doktorları ekledik
        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CmbDoktor.Text = "";
            CmbDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select Ad,Soyad From Tbl_Doktorlar where Brans=@b1", _SqlBaglantisi.baglanti());
            komut3.Parameters.AddWithValue("@b1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3["Ad"].ToString() + " " + dr3["Soyad"].ToString());
            }
            _SqlBaglantisi.baglanti().Close();
        }

        private void Exit() {

            FormHastaDetay formHastaDetay = new FormHastaDetay();
            formHastaDetay.hastatc = hastatc;
            formHastaDetay.Show();
            this.Close();
        }
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            if (DtRandevuTarihi.Text == "" || cBRandevuSaati.Text == "" || CmbBrans.SelectedIndex == -1 || CmbDoktor.SelectedIndex == -1 || string.IsNullOrEmpty(RchSikayet.Text))
            {
                MessageBox.Show("Boş kalan alanları lütfen doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {           
                    // 1. Hasta Tc'den Hasta ID'yi almak
                    int hastaID = GetHastaIDByTc(LblTc.Text);
                    if (hastaID == -1)
                    {
                        MessageBox.Show("Hasta bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 2. Doktor adından Doktor ID'yi almak
                    int doktorID = GetDoktorIDByAdSoyad(CmbDoktor.Text);
                    if (doktorID == -1)
                    {
                        MessageBox.Show("Doktor bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Randevu tarihini almak
                    string randevuTarihi = DtRandevuTarihi.Value.ToString("yyyy-MM-dd");

                    try
                    {
                        // 3. Randevu kaydını oluşturmak
                        SqlCommand KayitEt = new SqlCommand("INSERT INTO Tbl_Randevular (HastaID, DoktorID, RandevuTarihi, RandevuSaati, Sikayet, Durum, BransID, RandevuHastaTc) VALUES (@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8)", _SqlBaglantisi.baglanti());

                        KayitEt.Parameters.AddWithValue("@a1", hastaID);
                        KayitEt.Parameters.AddWithValue("@a2", doktorID);
                        KayitEt.Parameters.AddWithValue("@a3", randevuTarihi);
                        KayitEt.Parameters.AddWithValue("@a4", TimeSpan.Parse(cBRandevuSaati.Text));
                        KayitEt.Parameters.AddWithValue("@a5", RchSikayet.Text);
                        KayitEt.Parameters.AddWithValue("@a6", "Planlandı"); // Durum varsayılan olarak 'Planlandı'
                        KayitEt.Parameters.AddWithValue("@a7", GetBransIDByAd(CmbBrans.Text));
                        KayitEt.Parameters.AddWithValue("@a8", LblTc.Text);

                        KayitEt.ExecuteNonQuery();
                        MessageBox.Show("Randevu başarılı bir şekilde kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Exit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
        private int GetHastaIDByTc(string tc)
        {
            SqlCommand komut = new SqlCommand("SELECT HastaID FROM Tbl_Hastalar WHERE TcKimlikNo = @tc", _SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@tc", tc);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                return Convert.ToInt32(dr["HastaID"]);
            }
            else
            {
                return -1; // Bulunamadı
            }
        }

        private int GetDoktorIDByAdSoyad(string adSoyad)
        {
            SqlCommand komut = new SqlCommand("SELECT DoktorID FROM Tbl_Doktorlar WHERE CONCAT(Ad, ' ', Soyad) = @adSoyad", _SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@adSoyad", adSoyad);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                return Convert.ToInt32(dr["DoktorID"]);
            }
            else
            {
                return -1; // Bulunamadı
            }
        }

        private int GetBransIDByAd(string bransAd)
        {
            SqlCommand komut = new SqlCommand("SELECT BransID FROM Tbl_Branslar WHERE BransAdı = @bransAd", _SqlBaglantisi.baglanti());
            komut.Parameters.AddWithValue("@bransAd", bransAd);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                return Convert.ToInt32(dr["BransID"]);
            }
            else
            {
                return -1; // Bulunamadı
            }
        }


    }
}
