using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NXBDAL
    {
        public static DataTable GetAllNxb()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection())
            {
                con.Open();
                string query = "@select * from tbl_nhaxuatban";
                SqlCommand cmd = con.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }   
            return dt;
        }
    }
}
