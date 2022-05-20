using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Yonetim_ve_Randevu_Sistemi
{
    class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Hastane_Otomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
