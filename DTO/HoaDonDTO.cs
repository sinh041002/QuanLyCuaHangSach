using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public HoaDonDTO(string maHoaDon, string maNhanVien, string maKhachHang, DateTime ngayXuat, double tongTien)
        {
            MaHoaDon = maHoaDon;
            MaNhanVien = maNhanVien;
            MaKhachHang = maKhachHang;
            NgayXuat = ngayXuat;
            TongTien = tongTien;
        }
         public HoaDonDTO() { } 

        public string MaHoaDon { get; set; }
        public string  MaNhanVien { get; set; }
        public string  MaKhachHang { get; set; }
        public DateTime NgayXuat { get; set; }
        public double TongTien { get; set; }

        public double GiamGia { get; set; }
    }
}
