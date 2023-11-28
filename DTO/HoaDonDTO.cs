using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public string MaHoaDon { get; set; }
        public string  MaNhanVien { get; set; }
        public string  MaKhachHang { get; set; }
        public DateTime NgayXuat { get; set; }
        public double TongTien { get; set; }
    }
}
