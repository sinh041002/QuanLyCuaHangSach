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
<<<<<<< HEAD
            //Sinh
            string strcon = "Data Source=DESKTOP-MT4HM91\\SQLEXPRESS;Initial Catalog=cuahangsach;Integrated Security=True";
            

            //string strcon = "Data Source=DESKTOP-MT4HM91\\SQLEXPRESS;Initial Catalog=cuahangsach;Integrated Security=True";
          // string strcon = "Data Source=DESKTOP-K50G8NB\\CSDL;Initial Catalog=cuahangsach;Integrated Security=True";
=======
            string strcon = "Data Source=DESKTOP-2869SNJ\\MANHPHU;Initial Catalog=cuahangsachh;Integrated Security=True";
          //  string strcon = "Data Source=DESKTOP-K50G8NB\\CSDL;Initial Catalog=cuahangsach;Integrated Security=True";
>>>>>>> 63992458dc9aa212b79417c072eaaf9fc97ba4e6
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
