using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hastane
{
    public partial class FormDoktorDetaylari : Form
    {
        public FormDoktorDetaylari()
        {
            InitializeComponent();
        }

        SqlBaglantisi _SqlBaglantisi = new SqlBaglantisi();
        public string doktorTc;

        private void FormDoktorDetaylari_Load(object sender, EventArgs e)
        {
            int doktorID = GetDoktorIDByTc(doktorTc);
            if (doktorID == -1)
            {
                MessageBox.Show("Doktor bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ad Soyad çekme
            using (SqlCommand komut = new SqlCommand("SELECT Ad, Soyad, Brans FROM Tbl_Doktorlar WHERE TcKimlikNo = @tc", _SqlBaglantisi.baglanti()))
            {
                komut.Parameters.AddWithValue("@tc", doktorTc);
                using (SqlDataReader dr = komut.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        LblAd.Text = dr["Ad"].ToString();
                        LblSoyad.Text = dr["Soyad"].ToString();
                        LblBrans.Text = dr["Brans"].ToString();
                    }
                }
                _SqlBaglantisi.baglanti().Close();
            }

            RandevuAktifListele(doktorID);
        }

        void RandevuAktifListele(int doktorID)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT r.RandevuHastaTc, r.RandevuTarihi, r.RandevuSaati, r.Sikayet, r.Durum, " +
                "b.BransAdı, d.Ad AS Doktor_Adı, d.Soyad AS Doktor_Soyadı " +
                "FROM Tbl_Randevular r " +
                "JOIN Tbl_Doktorlar d ON r.DoktorID = d.DoktorID " +
                "JOIN Tbl_Branslar b ON r.BransID = b.BransID " +
                "WHERE d.DoktorID = @doktorID AND r.RandevuTarihi >= @today",
                _SqlBaglantisi.baglanti()))
            {
                da.SelectCommand.Parameters.AddWithValue("@doktorID", doktorID);
                da.SelectCommand.Parameters.AddWithValue("@today", DateTime.Now.Date);
                da.Fill(dt);
            }
            dataGridView1.DataSource = dt;
        }

        private int GetDoktorIDByTc(string Tc)
        {
            int doktorID = -1;
            using (SqlCommand komut = new SqlCommand("SELECT DoktorID FROM Tbl_Doktorlar WHERE TcKimlikNo = @tc", _SqlBaglantisi.baglanti()))
            {
                komut.Parameters.AddWithValue("@tc", Tc);
                using (SqlDataReader dr = komut.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        doktorID = Convert.ToInt32(dr["DoktorID"]);
                    }
                }
                _SqlBaglantisi.baglanti().Close();
            }
            return doktorID;
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Geçerli bir hücre seçilip seçilmediğini kontrol edin
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Seçilen satırı al
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Şikayet sütununun adını kullanarak hücreyi al ve null kontrolü yap
                var cellValue = selectedRow.Cells["Sikayet"].Value;
                if (cellValue != null)
                {
                    RchSikayet.Text = cellValue.ToString();
                }
                else
                {
                    RchSikayet.Text = "No complaint available.";
                }
            }
        }
        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Close();
        }

        private void BtnDuyuru_Click(object sender, EventArgs e)
        {
            FormDuyrular formDuyrular = new FormDuyrular();
            formDuyrular.doktorTc = doktorTc;
            formDuyrular.Show();
            this.Close();
        }

        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FormDoktorGuncelle formDoktorGuncelle=new FormDoktorGuncelle();
            formDoktorGuncelle.doktortc=doktorTc;
            formDoktorGuncelle.Show();
            this.Close();
        }
    }
}
