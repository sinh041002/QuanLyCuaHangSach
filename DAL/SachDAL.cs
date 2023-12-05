using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Data.Common;

namespace DAL
{
    public class SachDAL
    {
        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public static DataTable GetAllBook()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"select tbl_sach.MaSach,tbl_sach.TenSach, tbl_theloai.TenTheLoai, tbl_sach.SoLuong, tbl_sach.DonGiaXuat, Image
	                            from tbl_sach 
	                            inner join tbl_theloai on tbl_sach.MaTheLoai = tbl_theloai.MaTheLoai
	                            inner join tbl_tacgia on tbl_sach.MaTacGia = tbl_tacgia.MaTacGia";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static DataTable GetAllBookQL()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"select * from dbo.tbl_sach";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static DataTable GetAllBookByName(string name)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                string query = $@"select tbl_sach.MaSach,tbl_sach.TenSach, tbl_theloai.TenTheLoai, tbl_sach.SoLuong, tbl_sach.DonGiaXuat, Image
                                from tbl_sach 
                                INNER JOIN tbl_theloai on tbl_sach.MaTheLoai = tbl_theloai.MaTheLoai
                                WHERE TenSach LIKE '%{name}%'";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static DataTable GetAllBookByCategory(string name)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                string query = $@"select tbl_sach.MaSach,tbl_sach.TenSach, tbl_theloai.TenTheLoai, tbl_sach.SoLuong, tbl_sach.DonGiaXuat, Image
                                from tbl_sach 
                                INNER JOIN tbl_theloai on tbl_sach.MaTheLoai = tbl_theloai.MaTheLoai
                                WHERE TenTheLoai LIKE '%{name}%'";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }

        public static DataTable AddBook()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                string query = @"select tbl_sach.MaSach,tbl_sach.TenSach, tbl_theloai.TenTheLoai, tbl_sach.SoLuong, tbl_sach.DonGiaXuat, Image
                                from tbl_sach";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public static void UpdateBook(Sach sach)
        {           

            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"UPDATE tbl_sach SET
                                TenSach = @TenSach,
                                SoLuong = @SoLuong,
                                DonGiaNhap = @DonGiaNhap,
                                DonGiaXuat = @DonGiaXuat,
                                Image = @Image
                                WHERE MaSach = @MaSach";
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@TenSach", SqlDbType.NVarChar).Value = sach.TenSach;
                command.Parameters.Add("@SoLuong", SqlDbType.Float).Value = sach.SoLuong;
                command.Parameters.Add("@DonGiaNhap", SqlDbType.NVarChar).Value = sach.DonGiaNhap;
                command.Parameters.Add("@DonGiaXuat", SqlDbType.NVarChar).Value = sach.DonGiaXuat;
                command.Parameters.Add("@Image", SqlDbType.NVarChar).Value = sach.Image;
                command.Parameters.Add("@MaSach", SqlDbType.NVarChar).Value = sach.MaSach;
                command.ExecuteNonQuery();
                connection.Close();
            }           
        }
        public static void DeleteBook(string ma)
        {
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"delete from tbl_sach where masach = @masach";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@masach", SqlDbType.NVarChar).Value = ma;
                command.ExecuteNonQuery();
                connection.Close();
            }    
        }

        public Boolean themSach(Sach sach)
        {
            Boolean ktra = false;
            try
            {
                string query = "INSERT INTO dbo.tbl_sach (MaSach,TenSach,MaTheLoai,MaTacGia,SoLuong,DonGiaNhap,DonGiaXuat,MaNhaXuatBan,MaNhaCungCap,Image)" +
                    "\r\nVALUES (N'" + sach.MaSach + "',N'" + sach.TenSach + "',N'" + sach.MaTheLoai + "',N'" + sach.MaTacGia + "'" +
                         ",N'" + sach.SoLuong + "',N'" + sach.DonGiaNhap + "',N'" + sach.DonGiaXuat + "'," +
                         "N'" + sach.MaNhaXuatBan + "',N'" + sach.MaNhaCungCap + "',N'" + sach.Image + "');\r\n\r\n";
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

        public Boolean suaKhachHang(KhachHangDTO khachhang)
        {
            Boolean ktra = false;
            try
            {
                string query = "UPDATE dbo.tbl_khachhang\r\n" +
               "SET TenKhachHang = N'" + khachhang.TenKhachHang + "',DiaChi = N'" + khachhang.DiaChi + "',SoDienThoai = N'" + khachhang.SoDienThoai + "',Email = N'" + khachhang.Email + "'" +
               ",TongTienMua = " + khachhang.TongTienMua + " " +
               "\r\nWHERE MaKhachHang = '" + khachhang.MaKhachHang + "';";


                using (SqlConnection sqlConnection = SqlConnectionData.Connect())
                {

                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    dataReader = sqlCommand.ExecuteReader();

                    ktra = true;
                    sqlConnection.Close();

                }
            }
            catch (Exception ex)
            {
                ktra = false;
            }

            return ktra;
        }

        public Boolean xoaKhachhang(string makhachhang)
        {
            Boolean ktra = false;
            try
            {
                string query = "DELETE FROM dbo.tbl_khachhang WHERE MaKhachHang = '" + makhachhang + "' ;";
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

        public static void MinusStockBook( String ma, double soluong )
        {
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = $"UPDATE tbl_sach set SoLuong = SoLuong - @SoLuong WHERE MaSach = @MaSach";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soluong;
                cmd.Parameters.Add("@MaSach", SqlDbType.NVarChar).Value = ma;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
