using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        public static DataTable GetAllKhachHang()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"select * from tbl_khachhang";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }


    }
}
