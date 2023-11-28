using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class HoaDonDAO : GenericDAO
    {

        private static HoaDonDAO instance;
        private HoaDonDAO() { }

        private NhapHangDAO NhapHangDAO = new NhapHangDAO();

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            set { instance = value; }
        }

        public SqlCommand command { get; set; }
        public SqlDataAdapter adapter { get; set; }

        public DataTable executeQuery(string query)
        {

            using (SqlConnection sqlConnection = SqlConnectionData.Connect())
            {
                sqlConnection.Open();
                DataTable dataTable = new DataTable();
                command = new SqlCommand(query, getConnection());
                adapter = new SqlDataAdapter(command);
              //  adapter.Fill(dataTable);

                sqlConnection.Close();

                return dataTable;
            }
        }
           

        public KhachHangDTO getKhachHangDTO(string MaKhachHang)
        {
            KhachHangDTO khachHangDTO = new KhachHangDTO();

            string oString = "Select * from dbo.tbl_khachhang where MaKhachHang=@MaKhachHang";
            SqlCommand oCmd = new SqlCommand(oString, getConnection());
            oCmd.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);
            getConnection().Open();
            //SqlConnection conn = new SqlConnection();
            using (SqlDataReader oReader = oCmd.ExecuteReader())
            {
                while (oReader.Read())
                {
                    khachHangDTO.TenKhachHang = oReader.GetString(1);
                    khachHangDTO.DiaChi = oReader.GetString(2);
                    khachHangDTO.SoDienThoai = oReader.GetString(3);
                }

                getConnection().Close();
            }

            return khachHangDTO;
        }

        public NhanVienDTO getNhanVienDTO(string id)
        {
            NhanVienDTO nhanVienDTO = new NhanVienDTO();

            string query = "SELECT  HoTen FROM tbl_nhanvien WHERE MaNhanVien = @MaNhanVien";
            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaNhanVien", id);
            getConnection().Open();
            using (SqlDataReader oReader = command.ExecuteReader())
            {
                while (oReader.Read())
                {
                    nhanVienDTO.hoten = oReader.GetString(0);
                }
                getConnection().Close();

            }
            return nhanVienDTO;
        }

        public DataTable GetChiTietHoaDon(string MaHoaDon)
        {
            string query = "SELECT MaSach AS [Mã sách], SoLuong AS [Số lượng], DonGia AS [Đơn giá], ThanhTien AS [Thành tiền] FROM tbl_chitiethoadon WHERE MaHoaDon = @MaHoaDon";

            getConnection().Open();

            DataTable dataTable = new DataTable();
            command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            getConnection().Close();

            return dataTable;
        }

        public ChiTietHoaDonDTO LayChiTietHoaDon(string MaHoaDon, string MaSach)
        {
            string query = "SELECT * FROM tbl_chitiethoadon WHERE MaHoaDon = @MaHoaDon AND MaSach = @MaSach";
            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
            command.Parameters.AddWithValue("@MaSach", MaSach);


            ChiTietHoaDonDTO chiTietHoaDon = new ChiTietHoaDonDTO();

            getConnection().Open();

            using(SqlDataReader oReader = command.ExecuteReader())
            {
                while(oReader.Read())
                {
                    chiTietHoaDon.MaHoaDon = oReader.GetString(0);
                    chiTietHoaDon.MaSach = oReader.GetString(1);
                    chiTietHoaDon.SoLuong = oReader.GetDouble(2);
                    chiTietHoaDon.DonGia = oReader.GetDouble(3);
                    chiTietHoaDon.ThanhTien = oReader.GetDouble(4);
                }
            }


            getConnection().Close();

            return chiTietHoaDon;
        }

        public NhanVienDTOMaNhanVienHoTen GetDataNhanVienByMaHoaDon(string MaHoaDon)

        {
            string query = "  select nv.MaNhanVien as [Mã nhân viên],nv.HoTen as [Họ tên]" +
                "  from tbl_hoadon as hd, tbl_nhanvien as nv where hd.MaHoaDon = @MaHoaDon  and hd.MaNhanVien = nv.MaNhanVien";
            getConnection().Open();

            NhanVienDTOMaNhanVienHoTen nv = new NhanVienDTOMaNhanVienHoTen();

            command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
            using (SqlDataReader oReader = command.ExecuteReader())
            {
                while (oReader.Read())
                {
                    nv.MaNhanVien = oReader.GetString(0);
                    nv.HoTen = oReader.GetString(1);
                }
            }
            getConnection().Close();

            return nv;

        }

        public KhachHangDTO GetDataKhachHangByMaHoaDon(string MaHoaDon)
        {
            string query = "select kh.MaKhachHang as [Mã khách hàng], kh.TenKhachHang as [Tên khách hàng]," +
                " kh.DiaChi as [Địa chỉ], kh.SoDienThoai as [Điện thoại] from tbl_hoadon as hd, tbl_khachhang as kh " +
                "where hd.MaHoaDon = @MaHoaDon  and hd.MaKhachHang = kh.MaKhachHang";
            getConnection().Open();

            KhachHangDTO kh = new KhachHangDTO();

            command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
            using (SqlDataReader oReader = command.ExecuteReader())
            {
                while (oReader.Read())
                {
                    kh.MaKhachHang = oReader.GetString(0);
                    kh.TenKhachHang = oReader.GetString(1);
                    kh.DiaChi = oReader.GetString(2);
                    kh.SoDienThoai = oReader.GetString(3);
                }
            }
            getConnection().Close();

            return kh;

        }

        public DataTable GetAllMaSach()
        {

            string query = "SELECT MaSach from tbl_sach";
            getConnection().Open();

            DataTable dataTable = new DataTable();
            command = new SqlCommand(query, getConnection());

            adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            getConnection().Close();

            return dataTable;

        }

        public SachDTO GetDataSachByMaSach(string MaSach)
        {
            string query = "SELECT TenSach AS [Tên sách], SoLuong AS [Số lượng], DonGiaXuat AS [Đơn giá] FROM tbl_sach WHERE MaSach = @MaSach";

            getConnection().Open();

            SachDTO sach = new SachDTO();
            command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaSach", MaSach);

            using (SqlDataReader oReader = command.ExecuteReader())
            {
                while (oReader.Read())
                {
                    sach.TenSach = oReader.GetString(0);
                    sach.DonGia = oReader.GetString(2);
                    sach.SoLuong = oReader.GetDouble(1);


                }
            }

            getConnection().Close();

            return sach;
        }

        public int SaveHoaDon(HoaDonDTO hoaDonDTO)
        {
            string MaHoaDon = hoaDonDTO.MaHoaDon;
            string MaNhanVien = hoaDonDTO.MaNhanVien;
            string MaKhachHang = hoaDonDTO.MaKhachHang;
            DateTime NgayXuat = hoaDonDTO.NgayXuat;
            double TongTien = hoaDonDTO.TongTien;
            int result = -1;

            string query = "INSERT INTO tbl_hoadon (MaHoaDon, MaNhanVien, MaKhachHang, NgayXuat, TongTien)" +
                " VALUES(@MaHoaDon, @MaNhanVien, @MaKhachHang, @NgayXuat, @TongTien)";
            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
            command.Parameters.AddWithValue("@MaNhanVien", MaNhanVien);
            command.Parameters.AddWithValue("@MaKhachHang", MaKhachHang);
            command.Parameters.AddWithValue("@NgayXuat", NgayXuat);
            command.Parameters.AddWithValue("@TongTien", TongTien);

            getConnection().Open();
            result = command.ExecuteNonQuery();
            getConnection().Close();

            return result;
        }

        public int SaveChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {   
            string MaHoaDon = chiTietHoaDonDTO.MaHoaDon;
            string MaSach = chiTietHoaDonDTO.MaSach;
            double SoLuong = chiTietHoaDonDTO .SoLuong;
            double DonGia = chiTietHoaDonDTO.DonGia;
            double ThanhTien = chiTietHoaDonDTO.ThanhTien;
            int result = -1;

            string query = "INSERT INTO tbl_chitiethoadon (MaHoaDon, MaSach, SoLuong, DonGia, ThanhTien)" +
                " VALUES(@MaHoaDon, @MaSach, @SoLuong, @DonGia, @ThanhTien)";
            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
            command.Parameters.AddWithValue("@MaSach", MaSach);
            command.Parameters.AddWithValue("@SoLuong", SoLuong);
            command.Parameters.AddWithValue("@DonGia", DonGia);
            command.Parameters.AddWithValue("@ThanhTien", ThanhTien);
            getConnection().Open();
            result = command.ExecuteNonQuery();
            getConnection().Close();


            return result;

        }

        public int SaveTongTien(string MaHoaDon, double TongTien)
        {
            int result = -1;
            string query = "UPDATE tbl_hoadon SET TongTien = @TongTien WHERE MaHoaDon = @MaHoaDon";


            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@TongTien", TongTien);
            command.Parameters.AddWithValue("@MaHoaDon", MaHoaDon);
            
            getConnection().Open();
            result = command.ExecuteNonQuery();
            getConnection().Close();
            return result;
        }


        public List<string> GetAllMaHoaDonList()
        {
            List<string> MaHoaDonList = new List<string>();
            string query = "SELECT MaHoaDon FROM tbl_hoadon";
            SqlCommand command = new SqlCommand(query, getConnection());

            getConnection().Open();

            using(SqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    MaHoaDonList.Add(reader.GetString(0));
                }
            }


            getConnection().Close();

            return MaHoaDonList;
        }

        public int SuaThongTinChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {

            //lấy số lượng từ chi tiết hóa đơn cũ 
            ChiTietHoaDonDTO hoaDonCu = LayChiTietHoaDon(chiTietHoaDonDTO.MaHoaDon, chiTietHoaDonDTO.MaSach);
            //add vô lại số lượng sách
            CapNhatSoLuongSach(chiTietHoaDonDTO.MaSach, hoaDonCu.SoLuong,"cong");

            string query = "UPDATE tbl_chitiethoadon SET SoLuong = @SoLuong, ThanhTien = @ThanhTien " +
                "WHERE MaHoaDon = @MaHoaDon AND MaSach = @MaSach";
            int result = -1;

            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@SoLuong", chiTietHoaDonDTO.SoLuong);
            command.Parameters.AddWithValue("@ThanhTien", chiTietHoaDonDTO.ThanhTien);
            command.Parameters.AddWithValue("@MaHoaDon", chiTietHoaDonDTO.MaHoaDon);
            command.Parameters.AddWithValue("@MaSach", chiTietHoaDonDTO.MaSach);
            getConnection().Open();
            result = command.ExecuteNonQuery();
            getConnection().Close();

            // rồi trừ bằng cái chi tiết hóa đơn hiện tại    
            CapNhatSoLuongSach(chiTietHoaDonDTO.MaSach, chiTietHoaDonDTO.SoLuong);



            return result;
        }

        public int XoaThongTinChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            string query = "DELETE FROM tbl_chitiethoadon WHERE MaHoaDon = @MaHoaDon AND MaSach = @MaSach";
            int result = -1;

            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaHoaDon", chiTietHoaDonDTO.MaHoaDon);
            command.Parameters.AddWithValue("@MaSach", chiTietHoaDonDTO.MaSach);
            getConnection().Open();
            result = command.ExecuteNonQuery();
            getConnection().Close();

            CapNhatSoLuongSach(chiTietHoaDonDTO.MaSach, chiTietHoaDonDTO.SoLuong, "cong");

            return result;
        }

       

       
        public SachDTOSoLuong LayThongTinSoLuongSach(string MaSach)
        {
            string query = "SELECT SoLuong FROM tbl_sach WHERE MaSach = @MaSach";
            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaSach", MaSach);
            getConnection().Open();
            SachDTOSoLuong sachDTOSoLuong = new SachDTOSoLuong();
            using(SqlDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                  sachDTOSoLuong.SoLuong = reader.GetDouble(0);
                }
                getConnection().Close();
            }
           
            return sachDTOSoLuong;
        }

        //thao tác mặc định là trừ
        public void CapNhatSoLuongSach(string MaSach, double SoLuongMua, string thaotac = "tru")
        {
            string query = "UPDATE  tbl_sach SET SoLuong ";
            if(thaotac.Equals("tru"))
            {
                query += "-= ";
            } else
            {
                query += "+= ";
            }
            query += " @SoLuongMua WHERE MaSach = @MaSach";
            SqlCommand command = new SqlCommand(query, getConnection());
            command.Parameters.AddWithValue("@MaSach", MaSach);
            command.Parameters.AddWithValue("@SoLuongMua", SoLuongMua);
            getConnection().Open();
            command.ExecuteNonQuery();
            getConnection().Close();
        }

    }
        

  
}
