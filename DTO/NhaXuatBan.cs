using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaXuatBan
    {
        private string maNhaXuatBan { get; set; }
        private string tenNhaXuatBan { get;set; }
        private string moTaNhaXuatBan { get; set; } 

        NhaXuatBan() { }

        public NhaXuatBan(string maNhaXuatBan, string tenNhaXuatBan, string moTaNhaXuatBan)
        {
            this.maNhaXuatBan = maNhaXuatBan;
            this.tenNhaXuatBan = tenNhaXuatBan;
            this.moTaNhaXuatBan = moTaNhaXuatBan;
        }
    }
}
