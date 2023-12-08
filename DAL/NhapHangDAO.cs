using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class NhapHangDAO : GenericDAO
    {

        private static NhapHangDAO instance;
        private NhapHangDAO() { }

        public static NhapHangDAO Instance
        {
            get { if (instance == null) instance = new NhapHangDAO(); return instance; }
            set { instance = value; }
        }
        public SqlCommand command { get; set; }
        public SqlDataAdapter adapter { get; set; }

        public DataTable executeQuery(string query)
        {
            getConnection().Open();

            DataTable dataTable = new DataTable();
            command = new SqlCommand(query, getConnection());
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            getConnection().Close();

            return dataTable;
        }

        public DataTable LayThongTinPhieuNhapTheoMa(string MaPhieuNhap)
        {
            string query = "SELECT MaPhieuNhap AS[Mã phiếu nhập], MaSach AS [Mã sách]," +
                " SoLuong AS [Số lượng], DonGia AS [Đơn giá], ThanhTien AS [Thành tiền]," +
                " MaNhaCungCap AS [Mã nhà cung cấp] FROM tbl_chitietnhap WHERE MaPhieuNhap = @MaPhieuNhap";
            getConnection().Open();

            DataTable dataTable = new DataTable();
            command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaPhieuNhap", MaPhieuNhap);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            getConnection().Close();
            return dataTable;
        }

        public List<string> LayDanhSachMaPhieuNhap(string field, string query)
        {
            List<string> list = new List<string>();
            SqlCommand command = new SqlCommand(query, getConnection());
            getConnection().Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
            }
            getConnection().Close();
            return list;
        }

        public DataTable LayDanhSachMaSach()
        {
            DataTable data = new DataTable();
            string query = "SELECT MaSach, TenSach FROM tbl_sach";
            SqlCommand command = new SqlCommand(query, getConnection());
            getConnection().Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            getConnection().Close();
            return data;
        }

        public int SavePhieuNhap(NhapHangDTO nhapHangDTO)
        {
            int result = -1;
            string maPhieuNhap = nhapHangDTO.MaPhieuNhap;
            string maNhanVien = nhapHangDTO.MaNhanVien;
            DateTime ngayNhap = nhapHangDTO.NgayNhap;
            int enabled = 1;
            string query = "INSERT INTO tbl_phieunhap (MaPhieuNhap, MaNhanVien, NgayNhap, Enabled)" +
                " VALUES(@MaPhieuNhap, @MaNhanVien, @NgayNhap, @Enabled)";
            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
            command.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
            command.Parameters.AddWithValue("@NgayNhap", ngayNhap);

            command.Parameters.AddWithValue("@Enabled", enabled);

            getConnection().Open();
            result = command.ExecuteNonQuery();
            getConnection().Close();

            return result;
        }

        public int LuuThongTinChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            int result = -1;
            string maPhieuNhap = chiTietPhieuNhapDTO.MaPhieuNhap;
            string maSach = chiTietPhieuNhapDTO.MaSach;
            string maNhaCungCap = chiTietPhieuNhapDTO.MaNhaCungCap;
            double soLuong = chiTietPhieuNhapDTO.SoLuong;
            double donGia = chiTietPhieuNhapDTO.DonGia;
            double thanhTien = chiTietPhieuNhapDTO.ThanhTien;


            string query = "INSERT INTO tbl_chitietnhap (MaPhieuNhap, MaSach, SoLuong, DonGia, ThanhTien, MaNhaCungCap)" +
                " VALUES(@MaPhieuNhap, @MaSach, @SoLuong, @DonGia, @ThanhTien, @MaNhaCungCap)";
            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaPhieuNhap", maPhieuNhap);
            command.Parameters.AddWithValue("@MaSach", maSach);
            command.Parameters.AddWithValue("@SoLuong", soLuong);
            command.Parameters.AddWithValue("@DonGia", donGia);
            command.Parameters.AddWithValue("@ThanhTien", thanhTien);
            command.Parameters.AddWithValue("@MaNhaCungCap", maNhaCungCap);

            getConnection().Open();
            result = command.ExecuteNonQuery();
            getConnection().Close();
            if (updateSoLuong(maSach, soLuong)!=true)
            {
                result = 0;
            }


            return result;

        }
        public Boolean updateSoLuong(string masach,double soluong)
        {
            Boolean kt=false;
            double tong = soluong;
            string query = "Select *from dbo.tbl_sach WHERE MaSach = '" + masach + "'; ";
            using (SqlConnection sqlConnection = SqlConnectionData.Connect())
            {

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Double a = dataReader.GetDouble(4) ;
                    tong = tong + a;
                    kt = true;
                }

                sqlConnection.Close();
            }

            string query1 = "UPDATE dbo.tbl_sach\r\n" +
            "SET SoLuong = " + tong + "" +
                "\r\nWHERE MaSach = '" + masach + "';";


            using (SqlConnection sqlConnection = SqlConnectionData.Connect())
            {

                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query1, sqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                sqlConnection.Close();

            }


            return kt;
        }
        

        public DataTable LayThongTinChiTietPhieuNhap(string MaPhieuNhap)
        {
            string query = "SELECT MaPhieuNhap AS [Mã phiếu nhập], MaSach AS [Mã sách]," +
                " SoLuong AS [Số lượng], DonGia AS [DonGia], ThanhTien AS [Thành tiền]," +
                " MaNhaCungCap AS [Mã nhà cung cấp] FROM tbl_chitietnhap WHERE MaPhieuNhap = @MaPhieuNhap";
            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaPhieuNhap", MaPhieuNhap);
            DataTable table = new DataTable();

            getConnection().Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            getConnection().Close();
            return table;
        }

        public int LuuTongTien(string MaPhieuNhap, double TongTien)
        {
            int result = -1;
            string query = "UPDATE tbl_phieunhap SET TongTien = @TongTien " +
                "WHERE MaPhieuNhap = @MaPhieuNhap";
            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@TongTien", TongTien);
            command.Parameters.AddWithValue("@MaPhieuNhap", MaPhieuNhap);
            getConnection().Open();

            result = command.ExecuteNonQuery();
            getConnection().Close();

            return result;
        }

        public List<string> LayDanhSachMaPhieuNhap()
        {
            List<string> list = new List<string>();
            string query = "SELECT MaPhieuNhap FROM tbl_phieunhap";
            SqlCommand command = new SqlCommand(query, getConnection());
            getConnection().Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(reader.GetString(0));
                }
            }
            getConnection().Close();
            return list;
        }

        public void HuyPhieuNhap(string MaPhieuNhap)
        {
            string query = "UPDATE tbl_phieunhap SET Enabled = 0 WHERE MaPhieuNhap = @MaPhieuNhap";
            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaPhieuNhap", MaPhieuNhap);
            getConnection().Open();
            command.ExecuteNonQuery();
            getConnection().Close();
        }

        public string LayMaNhanVienTheoMaPhieuNhap(string MaPhieuNap)
        {
            string query = "SELECT MaNhanVien FROM tbl_phieunhap WHERE MaPhieuNhap = @MaPhieuNhap";
            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaPhieuNhap", MaPhieuNap);
            string maNhanVien = null;
            getConnection().Open();
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    maNhanVien += reader.GetString(0);
                }
            }
            getConnection().Close();    
            return maNhanVien;
        }

    


    }
}

