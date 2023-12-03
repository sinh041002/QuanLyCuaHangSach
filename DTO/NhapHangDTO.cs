using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapHangDTO
    {
        public string MaPhieuNhap { get; set; }
        public string MaNhanVien { get; set; }
        public DateTime NgayNhap { get; set; }
        public double TongTien { get; set; }
        public bool Enabled { get; set; }
    }
}
