using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private string maKhachHang {  get; set; }
        private string tenKhachHang { get; set; }
        private string diaChi { get; set; }
        private string soDienThoai { get; set; }
        private string email { get; set; }
        private string tongTienMua { get; set; }

        public KhachHang() { }
        public KhachHang(string maKhachHang, string tenKhachHang, string diaChi, string soDienThoai, string email, string tongTienMua)
        {
            this.maKhachHang = maKhachHang;
            this.tenKhachHang = tenKhachHang;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.tongTienMua = tongTienMua;
        }
    }
}
