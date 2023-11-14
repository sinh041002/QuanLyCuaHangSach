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
        public static SqlConnection Connecct()
        {
            string strcon = "Data Source=DESKTOP-MT4HM91\\SQLEXPRESS;Initial Catalog=QuanLyCuaHangSach;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }
   
    internal class ConnecDataBase
    {
        
    }
}
