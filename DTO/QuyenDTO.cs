using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuyenDTO
    {
        public QuyenDTO() { }
        public int MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public int QLKhachHang { get; set; }
        public int QLNhanVien    { get; set; }

        public int QLQuyen { get; set; }
        public int QLKhuyenMai { get; set; }
        public int QLSach { get; set; }


        public int QLHoaDon { get; set; }
        public int BanHang { get; set; }
   
        public int QLThongKe { get; set; }

        public QuyenDTO(int maQuyen, string tenQuyen, int qLKhachHang, int qLNhanVien, int qLQuyen, int qLKhuyenMai, int qLSach, int qLHoaDon, int banHang, int qLThongKe)
        {
            MaQuyen = maQuyen;
            TenQuyen = tenQuyen;
            QLKhachHang = qLKhachHang;
            QLNhanVien = qLNhanVien;
            QLQuyen = qLQuyen;
            QLKhuyenMai = qLKhuyenMai;
            QLSach = qLSach;
            QLHoaDon = qLHoaDon;
            BanHang = banHang;
            QLThongKe = qLThongKe;
        }
    }
}
