using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Module9Assessment1.Data_Access_Layer
{
    class ConnectionManager
    {
        public static SqlConnection DatabaseConnection()
        {
            //Database Connection string
            string connectionString = "Data Source=LAPTOP-T82J2AHP\\SQLEXPRESS; Initial Catalog=Acme; User ID=sa; Password=sqlexpress";
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
