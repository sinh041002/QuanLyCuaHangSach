using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaXuatBan
    {
        private string maNhaXuatBan;
        private string tenNhaXuatBan;
        private string moTaNXB;


        public NhaXuatBan(string maNhaXuatBan, string tenNhaXuatBan, string moTaNXB)
        {
            this.MaNhaXuatBan = maNhaXuatBan;
            this.TenNhaXuatBan = tenNhaXuatBan;
            this.MoTaNXB = moTaNXB;
        }
        public NhaXuatBan() { }

        public string MaNhaXuatBan { get => maNhaXuatBan; set => maNhaXuatBan = value; }
        public string TenNhaXuatBan { get => tenNhaXuatBan; set => tenNhaXuatBan = value; }
        public string MoTaNXB { get => moTaNXB; set => moTaNXB = value; }
    }
}
