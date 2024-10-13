using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane
{
    internal class SqlBaglantisi
    {
        public SqlConnection baglanti() 
        {
            SqlConnection baglan = new SqlConnection("Data Source=Your Server Name;Initial Catalog=Hastane;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
