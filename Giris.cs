using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void BtnHasta_Click(object sender, EventArgs e)
        {
            FormHastaGiris formHastaGiris = new FormHastaGiris();
            formHastaGiris.Show();
            this.Hide();
        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        {
            FromDoktorGiris fromDoktorGiris = new FromDoktorGiris();
            fromDoktorGiris.Show();
            this.Hide();
        }
    }
}
