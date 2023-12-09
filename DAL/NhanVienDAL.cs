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
        public static DataTable GetAllNhanVien()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"select * from tbl_nhanvien";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }
        public List<NhanVien> getListNhanViens()
        {
            string query = "Select * from dbo.tbl_nhanvien";

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

        public List<NhanVien> getListNhanVienTimKiem(string timkiem)
        {
            string query = "Select *from dbo.tbl_nhanvien WHERE MaNhanVien = '" + timkiem + "'; ";

            List<NhanVien> nhanVienTimKiems = new List<NhanVien>();
            try
            {
                using (SqlConnection sqlConnection = SqlConnectionData.Connect())
                {

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    dataReader = sqlCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        nhanVienTimKiems.Add(new NhanVien(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetDateTime(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetDateTime(6), dataReader.GetInt32(7), dataReader.GetString(8), dataReader.GetInt32(9)));
                    }

                    sqlConnection.Close();
                }
            }catch (Exception ex)
            {
                nhanVienTimKiems = null;
            }

            return nhanVienTimKiems;
        }

        public Boolean themNhanVien(NhanVien nhanvien)
        {
            Boolean ktra=false;
            try
            {
                string query = "INSERT INTO dbo.tbl_nhanvien (MaNhanVien, HoTen, NgaySinh, Gioitinh,SoDienThoai,DiaChi,NgayLamViec,ChucVu" +
               ",MatKhau,TrangThai)\r\nVALUES (N'" + nhanvien.MaNhanVien + "',N'" + nhanvien.HoTen + "',N'" + nhanvien.NgaySinh + "',N'" + nhanvien.Gioitinh + "'" +
            ",N'" + nhanvien.SoDienThoai + "',N'" + nhanvien.DiaChi + "',N'" + nhanvien.NgayLamViec + "',N'" + nhanvien.ChucVu + "',N'" + nhanvien.MatKhau + "','" + nhanvien.TrangThai + "');\r\n\r\n";
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
                ktra=false;
            }

            return ktra;
        }

        public Boolean suaNhanVien(NhanVien nhanvien)
        {
            Boolean ktra = false;
            try
            {
                string query = "UPDATE dbo.tbl_nhanvien\r\n" +
               "SET HoTen = N'" + nhanvien.HoTen + "',NgaySinh = N'" + nhanvien.NgaySinh + "',Gioitinh = N'" + nhanvien.Gioitinh + "',SoDienThoai = N'" + nhanvien.SoDienThoai + "'," +
               "DiaChi = N'" + nhanvien.DiaChi + "',NgayLamViec = N'" + nhanvien.NgayLamViec + "',ChucVu = N'" + nhanvien.ChucVu + "',MatKhau = N'" + nhanvien.MatKhau + "'," +
               "TrangThai = N'" + nhanvien.TrangThai + "' " +
               "\r\nWHERE MaNhanVien = '" + nhanvien.MaNhanVien + "';";


                using (SqlConnection sqlConnection = SqlConnectionData.Connect())
                {

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    dataReader = sqlCommand.ExecuteReader();

                    ktra = true;
                    sqlConnection.Close();

                }
            }catch(Exception ex)
            {
                ktra= false;
            }

            return ktra;
        }

        public Boolean xoaNhanVien(string manhanVien)
        {
            Boolean ktra = false;
            try
            {
                string query = "DELETE FROM dbo.tbl_nhanvien WHERE MaNhanVien = '" + manhanVien + "' ;";
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


        public  DataTable getLichSuaChinhSua()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"select * from tbl_lichsuchinhsua";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        public Boolean ThemLichSuChinhSua(LichSuChinhSuaDTO lichSuChinhSuaDTO)
        {
            Boolean ktra = false;
            try
            {
                string query = "INSERT INTO tbl_lichsuchinhsua (MaNhanVienThaoTac,ThaoTac,MaNhanVienBiThaoTac,Time)" +
                    "\r\nVALUES ('" + lichSuChinhSuaDTO.MaNhanVienThaoTac + "',N'" + lichSuChinhSuaDTO.ThaoTac + "','" + lichSuChinhSuaDTO.MaNhanVienBiThaoTac + "','" + lichSuChinhSuaDTO.Time + "');\r\n\r\n";
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
