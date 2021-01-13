using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _20200504_Yurt_Otomasyonu
{
    public class SqlBaglantiAdresi
    {
        public SqlConnection connection()
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = DBYURTOTOMASYONU; Integrated Security = True");
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
