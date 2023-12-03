using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.Common;

namespace DAL
{
    public class NhaXuatBanDAL
    {
        public static DataTable GetAllNhaXuatBan()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"select * from tbl_nhaxuatban";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        public static void UpdateNhaXuatBan(NhaXuatBan nhaxuatban)
        {
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"update tbl_nhaxuatban set
                                TenNhaXuatBan = @tentacgia,
                                MoTaNhaXuatBan = @motatacgia
                                where MaNhaXuatBan = @matacgia";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@tentacgia", SqlDbType.NVarChar).Value = nhaxuatban.tenNhaXuatBan;
                command.Parameters.Add("@motatacgia", SqlDbType.NVarChar).Value = nhaxuatban.moTaNhaXuatBan;
                command.Parameters.Add("@matacgia", SqlDbType.NVarChar).Value = nhaxuatban.maNhaXuatBan;
                command.ExecuteNonQuery();
            }
        }
        public static void XoaNhaXuatBan(string ma)
        {
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = "delete from tbl_nhaxuatban where MaNhaXuatBan = @matacgia";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.Add("@matacgia", SqlDbType.NVarChar).Value = ma;
                sqlCommand.ExecuteNonQuery();
            }
        }
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public Boolean themNhaXuatBan(NhaXuatBan nhaxuatban)
        {
            Boolean ktra = false;
            try
            {
                string query = "INSERT INTO dbo.tbl_nhaxuatban (MaNhaXuatBan,TenNhaXuatBan,MoTaNhaXuatBan)" +
                    "\r\nVALUES (N'" + nhaxuatban.maNhaXuatBan + "',N'" + nhaxuatban.tenNhaXuatBan + "',N'" + nhaxuatban.moTaNhaXuatBan + "');\r\n\r\n";
                using (SqlConnection sqlConnection = SqlConnectionData.Connect())
                {

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    dataReader = sqlCommand.ExecuteReader();

                    ktra = true;
                    sqlConnection.Close();

                }
            }
            catch
            {
                ktra = false;
            }

            return ktra;
        }
    }
}
