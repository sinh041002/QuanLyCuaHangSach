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
            string strcon = "Data Source=DESKTOP-MT4HM91\\SQLEXPRESS;Initial Catalog=cuahangsach1;Integrated Security=True";
=======
            string strcon = "Data Source=LAPTOP-0HLAONAD\\DUCTAM;Initial Catalog=CuaHangSachV4;Integrated Security=True";

            //Sinh
            //string strcon = "Data Source=DESKTOP-MT4HM91\\SQLEXPRESS;Initial Catalog=cuahangsach;Integrated Security=True";
>>>>>>> b6756061f9e79476bbf185685fbf5dc119327f53
            

            //string strcon = "Data Source=DESKTOP-MT4HM91\\SQLEXPRESS;Initial Catalog=cuahangsach;Integrated Security=True";
          // string strcon = "Data Source=DESKTOP-K50G8NB\\CSDL;Initial Catalog=cuahangsach;Integrated Security=True";

<<<<<<< HEAD
          //  string strcon = "Data Source=DESKTOP-2869SNJ\\MANHPHU;Initial Catalog=cuahangsachh;Integrated Security=True";
=======
           // string strcon = "Data Source=DESKTOP-2869SNJ\\MANHPHU;Initial Catalog=cuahangsachh;Integrated Security=True";
>>>>>>> b6756061f9e79476bbf185685fbf5dc119327f53
          //  string strcon = "Data Source=DESKTOP-K50G8NB\\CSDL;Initial Catalog=cuahangsach;Integrated Security=True";

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
