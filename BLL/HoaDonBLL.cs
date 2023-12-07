using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        public HoaDonDAO HoaDonDAO { get; set; }

        public SaleDAL SaleDAL { get; set; } = new SaleDAL();


        public DataTable getData()
        {
            string query = "SELECT MAHOADON AS [Mã hóa đơn], MaNhanVien AS [Mã nhân viên], MaKhachHang AS [Mã khách hàng], NgayXuat AS [Ngày xuất], TongTien AS [Tổng tiền] FROM tbl_hoadon";

            return HoaDonDAO.Instance.executeQuery(query);
        }

        public DataTable getMaKhachHang()
        {
            string query = "SELECT MaKhachHang FROM tbl_khachhang";

            return HoaDonDAO.Instance.executeQuery(query);
        }

        public DataTable getMaSach()
        {
            string query = "SELECT MaSach FROM tbl_sach";

            return HoaDonDAO.Instance.executeQuery(query);
        }

        //public trả về list khách hàng


        public DataTable getDataNhanVien()
        {
            string query = "SELECT MaNhanVien, hoten FROM tbl_nhanvien";
            return HoaDonDAO.Instance.executeQuery(query);
        }

        //public DataTable

        public KhachHangDTO getKhachHangById(string id)
        {
            KhachHangDTO khachHangDTO = HoaDonDAO.Instance.getKhachHangDTO(id);

            return khachHangDTO;

        }

        public NhanVienDTO getNhanVienById(string id)
        {
            NhanVienDTO nhanVienDTO = HoaDonDAO.Instance.getNhanVienDTO(id);
            return nhanVienDTO;
        }

        public String CreateKey()
        {
            string key = "HDX_";
            DateTime now = DateTime.Now;
            string[] date = now.ToString("M/d/yyyy").Split('/');
            string[] time = now.ToString("hh:mm:ss").Split(':');
            date.Concat(time);
            foreach (var item in date)
            {
                key += item;
            }
            key += "_";

            foreach (var item in time)
            {
                key += item;
            }
            return key;
        }

        public bool IsBlank(string text)
        {
            return text.Length == 0 || text == null;
        }

        public DataTable GetAllMaHoaDon()
        {
            string query = "SELECT MaHoaDon FROM tbl_hoadon WHERE Enabled = 1";
            return HoaDonDAO.Instance.executeQuery(query);
        }

        public DataTable GetChiTietHoaDon(string MaHoaDon)
        {
            return HoaDonDAO.Instance.GetChiTietHoaDon(MaHoaDon);

        }

        public NhanVienDTOMaNhanVienHoTen GetDataNhanVienByMaHoaDon(string MaHoaDon)
        {
            return HoaDonDAO.Instance.GetDataNhanVienByMaHoaDon(MaHoaDon);
        }

        public KhachHangDTO GetDataKhachHangByMaHoaDon(string MaHoaDon)
        {
            return HoaDonDAO.Instance.GetDataKhachHangByMaHoaDon(MaHoaDon);
        }

        public DataTable GetAllMaSach()
        {
            return HoaDonDAO.Instance.GetAllMaSach();
        }

        public SachDTO GetDatSachByMaSach(string MaSach)
        {
            return HoaDonDAO.Instance.GetDataSachByMaSach(MaSach);
        }

        public int SaveHoaDon(HoaDonDTO hoaDonDTO)
        {
            return HoaDonDAO.Instance.SaveHoaDon(hoaDonDTO);
        }

        public int SaveChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            return HoaDonDAO.Instance.SaveChiTietHoaDon(chiTietHoaDonDTO);
        }

        public int SaveTongTien(string MaHoaDon, double TongTien)
        {
            return HoaDonDAO.Instance.SaveTongTien(MaHoaDon, TongTien);
        }

        public List<string> GetAllMaHoaDonList()
        {
            return HoaDonDAO.Instance.GetAllMaHoaDonList();
        }

        public void SuaThongTinChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            
            HoaDonDAO.Instance.SuaThongTinChiTietHoaDon(chiTietHoaDonDTO);
           

        }

        public int XoaThongTinChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDonDTO)
        {
            int result = -1;

            result = HoaDonDAO.Instance.XoaThongTinChiTietHoaDon(chiTietHoaDonDTO);           
            return result;
        }


        public SachDTOSoLuong LaySoLuongSach(string MaSach)
        {
            return HoaDonDAO.Instance.LayThongTinSoLuongSach(MaSach);
        }

        public void CapNhatSoLuongSach(string MaSach, double SoLuongMua)
        {
            HoaDonDAO.Instance.CapNhatSoLuongSach(MaSach, SoLuongMua);
        }

        public void HuyHoaDon(string MaHoaDon)
        {
            HoaDonDAO.Instance.HuyHoaDon(MaHoaDon);
        }

        public List<Sale> GetAllMaGiamGia()
        {
            return SaleDAL.GetListSale();
        }

        public DataTable LayThongTinTongTienVaGiamGiaTheoMaHoaDon(string MaHoaDon)
        {
            return HoaDonDAO.Instance.LayThongTinTongTienVaGiamGiaTheoMaHoaDon(MaHoaDon);
        }
        public int CapNhatTongTienMuaChoKhachHang(string MaKhachHang, double TongTien, string thaotac = "cong")
        {
            return HoaDonDAO.Instance.CapNhatTongTienMuaChoKhachHang(MaKhachHang, TongTien, thaotac);
        }


        public double LayTongTienTheoMaHoaDon(string MaHoaDon)
        {
            return HoaDonDAO.Instance.LayTongTienTheoMaHoaDon(MaHoaDon);
        }
        public string GetLastId()
        {
            return HoaDonDAO.GetLastID();

        }
        //public int getTrangThai(string MaHoaDon)
        //{
        //    HoaDonDAO dao = new HoaDonDAO();
        //    return dao.getTrangThai(MaHoaDon);
        //}
    }

}
