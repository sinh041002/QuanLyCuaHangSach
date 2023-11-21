using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class NhanVienDAL
    {
        public NhanVienDAL() { }

        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public List<NhanVien> NhanViens(string query)
        {

            List<NhanVien> nhanViens = new List<NhanVien>();
            using (SqlConnection sqlConnection = SqlConnectionData.Connect())
            {

                sqlConnection.Open();
                sqlCommand = new SqlCommand(query , sqlConnection);
                dataReader= sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    nhanViens.Add(new NhanVien(dataReader.GetString(0),dataReader.GetString(1),dataReader.GetDateTime(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetDateTime(6), dataReader.GetInt32(7), dataReader.GetString(8), dataReader.GetInt32(9)));
                }

                sqlConnection.Close();
            }

                return nhanViens;
        }
        public static string CheckLogin(NhanVien nhanVien)
        {
            string user = null;

            // conection toi csdl
            SqlConnection conn = SqlConnectionData.Connect();
            
            conn.Open();

            SqlCommand cmd = new SqlCommand("proc_login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNhanVien", nhanVien.MaNhanVien);
            cmd.Parameters.AddWithValue("@MatKhau", nhanVien.MatKhau);


            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {

                conn.Close();
                return "Tài khoản mật khẩu không chính xác";
            }



            return user;
        }
     }
}
