using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SqlConnectionData
    {

        //Tạo chuỗi kết nối databasse 
        public static SqlConnection Connect()
        {
            string strcon = "Data Source=DESKTOP-K50G8NB\\CSDL;Initial Catalog=cuahangsach;Integrated Security=True";
            //DESKTOP-2869SNJ\\MANHPHU
            //DESKTOP-K50G8NB\\CSDL
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
   
    internal class ConnecDataBase
    {
        
    }
}
