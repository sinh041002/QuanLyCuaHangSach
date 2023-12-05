using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class TheLoaiDAL
    {
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public static DataTable GetAllTheLoai()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"select * from dbo.tbl_theloai";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public static void UpdateTheLoai(TheLoai theLoai)
        {
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"update tbl_theloai set 
                                TenTheLoai = @tentheloai,
                                MoTaTheLoai = @motatheloai
                                where matheloai = @matheloai";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@tentheloai", SqlDbType.NVarChar).Value = theLoai.TenTheLoai;
                command.Parameters.Add("@motatheloai", SqlDbType.NVarChar).Value = theLoai.MoTaTheLoai;
                command.Parameters.Add("@matheloai", SqlDbType.NVarChar).Value = theLoai.MaTheLoai;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public static void DeleteTheLoai(string ma)
        {
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"delete from tbl_theloai where matheloai = @matheloai";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@matheloai", SqlDbType.NVarChar).Value = ma;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public Boolean themTheLoai(TheLoai theloai)
        {
            Boolean ktra = false;
            try
            {
                string query = "INSERT INTO dbo.tbl_theloai (MaTheLoai,TenTheLoai,MoTaTheLoai)" +
                    "\r\nVALUES (N'" + theloai.MaTheLoai + "',N'" + theloai.TenTheLoai + "',N'" + theloai.MoTaTheLoai + "');\r\n\r\n";
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
