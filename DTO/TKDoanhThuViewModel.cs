using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TKDoanhThuViewModel
    {
        public TKDoanhThuViewModel(DateTime ngay, int sLDonHang, double doanhThu)
        {
            Ngay = ngay;
            SLDonHang = sLDonHang;
            DoanhThu = doanhThu;
        }

        public DateTime Ngay { get; set; }
        public int SLDonHang { get; set; } = 0;
        public double DoanhThu { get; set; } = 0;
    }
}
