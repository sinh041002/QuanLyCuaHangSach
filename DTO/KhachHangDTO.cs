using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public string MaKhachHang { get; set; }
        public string  TenKhachHang { get; set; }

        public string  DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

        public string HoiVien { get; set; }

        public float TongTienMua { get; set; }
    }
}
