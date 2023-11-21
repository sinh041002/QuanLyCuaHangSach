using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DangNhapDAL
    {
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public NhanVien getTaiKhoan(string tenTK,string MatKhau )
        {
           NhanVien nhanVien = new NhanVien();
            string query = "Select *from dbo.tbl_nhanvien where MaNhanVien='" + tenTK + "'and MatKhau='"+ MatKhau + "' ";
            using (SqlConnection sqlConnection = SqlConnectionData.Connect())
            {

                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    NhanVien nv= new NhanVien(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetDateTime(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetDateTime(6), dataReader.GetInt32(7), dataReader.GetString(8), dataReader.GetInt32(9));
                    nhanVien = nv;
                    // nhanViens.Add(new NhanVien(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetDateTime(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetDateTime(6), dataReader.GetInt32(7), dataReader.GetString(8), dataReader.GetInt32(9)));
                }

                sqlConnection.Close();
               
            }
            return nhanVien;

        }
        public DangNhapDAL() { }
    }
}
