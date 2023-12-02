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
        // Phú
<<<<<<< HEAD
        //private static string ConnectionString = "Data Source=DESKTOP-K50G8NB\\CSDL;Initial Catalog=cuahangsach;Integrated Security=True";
=======
        private static string ConnectionString = "Data Source=DESKTOP-2869SNJ\\MANHPHU;Initial Catalog=cuahangsachh;Integrated Security=True";
>>>>>>> 63992458dc9aa212b79417c072eaaf9fc97ba4e6

        //Sinh
        private static string ConnectionString = "Data Source=DESKTOP-MT4HM91\\SQLEXPRESS;Initial Catalog=cuahangsach;Integrated Security=True";
       
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
