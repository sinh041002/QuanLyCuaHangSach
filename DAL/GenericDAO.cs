using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GenericDAO
    {
        private static SqlConnection connection;
        private static string ConnectionString = "Data Source=LAPTOP-0HLAONAD\\DUCTAM;Initial Catalog=CuaHangSach;Integrated Security=True";
        

        public static SqlConnection getConnection()
        {

            if(connection == null)
            {
                connection = new SqlConnection(ConnectionString);
            }

            return connection;
        }
    }
}
