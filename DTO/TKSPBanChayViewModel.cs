using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TKSPBanChayViewModel
    {
        public TKSPBanChayViewModel()
        {

        }

        public TKSPBanChayViewModel(string maSach, string tenSach, double sLBan)
        {
            MaSach = maSach;
            TenSach = tenSach;
            SLBan = sLBan;
        }

        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public double SLBan { get; set; }
    }
}
