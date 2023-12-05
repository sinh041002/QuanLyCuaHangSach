using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaXuatBan
    {
        public string getMa()
        {
            Random rd = new Random();
            int ma = rd.Next(1000, 9999);
            string a = "NXB" + ma + "";


            return a;
        }
        public NhaXuatBan() { }
        public string maNhaXuatBan { get; set; }
        public string tenNhaXuatBan { get;set; }
        public string moTaNhaXuatBan { get; set; } 

       


        public NhaXuatBan(string maNhaXuatBan, string tenNhaXuatBan, string moTaNhaXuatBan)
        {
            this.maNhaXuatBan = maNhaXuatBan;
            this.tenNhaXuatBan = tenNhaXuatBan;
            this.moTaNhaXuatBan = moTaNhaXuatBan;
        }
    }
}
