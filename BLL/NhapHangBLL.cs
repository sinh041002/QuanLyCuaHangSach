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
    public class NhapHangBLL
    { 
        public String CreateKey()
        {
            string key = "HDN_";
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

        public DataTable LayThongTin(string query)
        {
            return NhapHangDAO.Instance.executeQuery(query);
        }

        public DataTable LayThongTinNhanVien()
        {
            string query = "SELECT MaNhanVien, hoten FROM tbl_nhanvien";
            return LayThongTin(query);
        }

        public DataTable LayThongTinNhaCungCap()
        {
            string query = "SELECT MaNhaCungCap, TenNhaCungCap FROM tbl_nhacungcap";
            return LayThongTin(query);
        }


        public DataTable LayThongTinPhieuNhapTheoMa(string MaPhieuNhap)
        {
            return NhapHangDAO.Instance.LayThongTinPhieuNhapTheoMa(MaPhieuNhap);
        }

        public DataTable GetAllMaPhieuNhap()
        {
            string query = "SELECT MaPhieuNhap FROM tbl_phieunhap WHERE Enabled = 1";
            return NhapHangDAO.Instance.executeQuery(query);
        }

        public T Change<T>(T value)
        {

            return value;
        }

        public DataTable LayDanhSachMaSach()
        {
            return NhapHangDAO.Instance.LayDanhSachMaSach();
        }

        //public DataTable LayThongTinSach(string MaSach)
        //{
        //    return NhapHangDAO.Instance.LayThongTinSach(MaSach);
        //}

        public int LuuThongTinPhieuNhap(NhapHangDTO nhapHangDTO)
        {
            return NhapHangDAO.Instance.SavePhieuNhap(nhapHangDTO);
        }

        public int LuuThongTinChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhapDTO)
        {
            return NhapHangDAO.Instance.LuuThongTinChiTietPhieuNhap(chiTietPhieuNhapDTO);
        }

        public DataTable LayThongTinChiTietPhieuNhap(string MaPhieuNhap)
        {
            return NhapHangDAO.Instance.LayThongTinChiTietPhieuNhap(MaPhieuNhap);
        }        

        public int LuuTongTien(string MaPhieuNhap, double TongTien)
        {
            return NhapHangDAO.Instance.LuuTongTien(MaPhieuNhap, TongTien);
        }

        public List<string> LayDanhSachMaPhieuNhap()
        {
            return NhapHangDAO.Instance.LayDanhSachMaPhieuNhap();
        }

        public void HuyPhieuNhap(string MaPhieuNhap)
        {
            NhapHangDAO.Instance.HuyPhieuNhap(MaPhieuNhap);
        }

        public string LayMaNhanVienTheoMaPhieuNhap(string MaPhieuNhap)
        {
            return NhapHangDAO.Instance.LayMaNhanVienTheoMaPhieuNhap(MaPhieuNhap);
        }

       
    }
}
