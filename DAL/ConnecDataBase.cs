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
            string strcon = "Data Source=LAPTOP-0HLAONAD\\DUCTAM;Initial Catalog=CuaHangSachV4;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
   
    internal class ConnecDataBase
    {
        
    }
}
