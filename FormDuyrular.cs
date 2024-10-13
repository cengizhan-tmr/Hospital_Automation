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
    public partial class FormDuyrular : Form
    {
        public FormDuyrular()
        {
            InitializeComponent();
        }
        SqlBaglantisi _SqlBaglantisi = new SqlBaglantisi();
        public string doktorTc;

        private void FormDuyrular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select DuyruMetni as Duyrular From Tbl_Duyrular", _SqlBaglantisi.baglanti());
            da.Fill(dt);
            dGVDuyrular.DataSource = dt;

        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            FormDoktorDetaylari formDoktorDetaylari=new FormDoktorDetaylari();
            formDoktorDetaylari.doktorTc = doktorTc;
            formDoktorDetaylari.Show();
            this.Close();
        }
    }
}
