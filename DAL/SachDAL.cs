using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SachDAL
    {
        public static DataTable GetAllBook()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = SqlConnectionData.Connect())
            {
                connection.Open();
                string query = @"select tbl_sach.MaSach,tbl_sach.TenSach, tbl_theloai.TenTheLoai, tbl_sach.SoLuong, tbl_sach.DonGiaXuat, Image
                                     from tbl_sach 
                                     INNER JOIN tbl_theloai on tbl_sach.MaTheLoai = tbl_theloai.MaTheLoai";
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
    }
}
