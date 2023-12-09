using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSuChinhSuaDTO
    {
        public LichSuChinhSuaDTO() { }
        public string MaNhanVienThaoTac { get; set; }
        public string ThaoTac { get; set; }
        public string MaNhanVienBiThaoTac { get; set; }
        public DateTime Time { get; set; }

        public LichSuChinhSuaDTO(string maNhanVienThaoTac, string thaoTac, string maNhanVienBiThaoTac, DateTime time)
        {
            MaNhanVienThaoTac = maNhanVienThaoTac;
            ThaoTac = thaoTac;
            MaNhanVienBiThaoTac = maNhanVienBiThaoTac;
            Time = time;
        }
    }
}
