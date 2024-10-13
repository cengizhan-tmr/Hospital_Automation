using Hastane;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Hastane
{
    public partial class FormHastaDetay : Form
    {
        public FormHastaDetay()
        {
            InitializeComponent();
        }

        SqlBaglantisi _SqlBaglantisi = new SqlBaglantisi();
        public string hastatc;

        void RandevuGecmisListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT r.RandevuID, r.RandevuHastaTc, r.RandevuTarihi, r.RandevuSaati, r.Sikayet, r.Durum, " +
                "b.BransAdı, d.Ad AS Doktor_Adı, d.Soyad AS Doktor_Soyadı, d.Telefon AS Doktor_tel " +
                "FROM Tbl_Randevular r " +
                "JOIN Tbl_Doktorlar d ON r.DoktorID = d.DoktorID " +
                "JOIN Tbl_Branslar b ON r.BransID = b.BransID " +
                "WHERE r.RandevuHastaTc = @tc AND  r.RandevuTarihi < @today  ",
                _SqlBaglantisi.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@tc", LblTc.Text);
            da.SelectCommand.Parameters.AddWithValue("@today", DateTime.Now.Date);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void RandevuAktifListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT r.RandevuHastaTc, r.RandevuTarihi, r.RandevuSaati, r.Sikayet, r.Durum, " +
                "b.BransAdı, d.Ad AS Doktor_Adı, d.Soyad AS Doktor_Soyadı " +
                "FROM Tbl_Randevular r " +
                "JOIN Tbl_Doktorlar d ON r.DoktorID = d.DoktorID " +
                "JOIN Tbl_Branslar b ON r.BransID = b.BransID " +
                "WHERE r.RandevuHastaTc = @tc AND r.RandevuTarihi >= @today",
                _SqlBaglantisi.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@tc", LblTc.Text);
            da.SelectCommand.Parameters.AddWithValue("@today", DateTime.Now.Date);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }


        private void FormHastaDetay_Load(object sender, EventArgs e)
        {
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
                    LblDogumTarihi.Text = $"{dr["DogumTarihi"]}";
                }
                _SqlBaglantisi.baglanti().Close();
            }

            RandevuGecmisListele();
            RandevuAktifListele();           
        }
       
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            FormHastaGiris formHastaGiris = new FormHastaGiris();   
            formHastaGiris.Show();
            this.Close();

        }

        private void BtnKisiselBilgiler_Click(object sender, EventArgs e)
        {
            FormHastaGuncelle formHastaGuncelle = new FormHastaGuncelle();
            formHastaGuncelle.tcno = hastatc;
            formHastaGuncelle.Show();
            this.Close();
        }

        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            FormHastaRandevuAlma _formHastaRandevuAlma=new FormHastaRandevuAlma();
            _formHastaRandevuAlma.hastatc = hastatc;
            _formHastaRandevuAlma.Show();
            this.Close();
        }

        private void BtnCikis_Click_1(object sender, EventArgs e)
        {
            FormHastaGiris formHastaGiris=new FormHastaGiris();
            formHastaGiris.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
