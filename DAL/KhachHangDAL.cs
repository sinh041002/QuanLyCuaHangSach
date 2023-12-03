using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Collections;
using System.Data.Common;

namespace DAL
{
    public class KhachHangDAL
    {

        SqlCommand sqlCommand;
        SqlDataReader dataReader;
        public static DataTable GetAllKhachHang()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"select * from dbo.tbl_khachhang";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public  List<KhachHangDTO> GetKhachHang()
        {
            string query = "Select *from dbo.tbl_khachhang";
            List<KhachHangDTO> khachHangs = new List<KhachHangDTO>();
           
                using (SqlConnection sqlConnection = SqlConnectionData.Connect())
                {
                   
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(query, sqlConnection);
                    dataReader = sqlCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                    khachHangs.Add(new KhachHangDTO(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetFloat(6)));
                    }
                    sqlConnection.Close();
                }
            


            return khachHangs;
        }

        public Boolean themKhachHang(KhachHangDTO khachhang)
        {
            Boolean ktra = false;
            try
            {
                string query = "INSERT INTO dbo.tbl_khachhang (MaKhachHang,TenKhachHang,DiaChi,SoDienThoai,Email,HoiVien,TongTienMua)" +
                    "\r\nVALUES (N'" + khachhang.MaKhachHang + "',N'" + khachhang.TenKhachHang + "',N'" + khachhang.DiaChi + "',N'" + khachhang.SoDienThoai + "'" +
                         ",N'" + khachhang.Email + "',N'Khách hàng lẻ',N'" + khachhang.TongTienMua + "');\r\n\r\n";
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


    }
}
