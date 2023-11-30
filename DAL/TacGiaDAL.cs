using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TacGiaDAL
    {
        public static DataTable GetAllTacGia()
        {
            DataTable dt = new DataTable();
            using(SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"select * from tbl_tacgia";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }
    }
}
