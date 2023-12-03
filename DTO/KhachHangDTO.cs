using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public KhachHangDTO() { }
      
        public string getMa()
        {
            Random rd = new Random();
            int ma = rd.Next(1000,9999);
            string a = "KH"+ ma + "";
            
           
            return a;
        }
        public string MaKhachHang { get; set; }
        public string  TenKhachHang { get; set; }

        public string  DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

        public string HoiVien { get; set; }

        public float TongTienMua { get; set; }

        public KhachHangDTO(string maKhachHang, string tenKhachHang, string diaChi, string soDienThoai, string email, string hoiVien, float tongTienMua)
        {
            MaKhachHang = maKhachHang;
            TenKhachHang = tenKhachHang;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
            HoiVien = hoiVien;
            TongTienMua = tongTienMua;
        }
    }
}
