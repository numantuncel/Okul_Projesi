using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul_Projesi
{
    internal class SqlBaglantı
    {
        public SqlConnection baglanti()
        {
            SqlConnection  baglan=new SqlConnection("Data Source=numantuncel\\MSSQLSERVER01;Initial Catalog=OkulDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
