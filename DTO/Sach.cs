using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        public Sach() { }
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public  string MaTheLoai { get; set; }
        public string MaTacGia { get; set; }
        public float SoLuong { get; set; }
   
        public string DonGiaNhap { get; set; }
        public string DonGiaXuat { get; set; }

        public string MaNhaXuatBan { get; set; }
        public string MaNhaCungCap { get; set; }
        public string Image { get; set; }

        public Sach(string maSach, string tenSach, string maTheLoai, string maTacGia, float soLuong, string donGiaNhap, string donGiaXuat, string maNhaXuatBan, string maNhaCungCap, string image)
        {
            MaSach = maSach;
            TenSach = tenSach;
            MaTheLoai = maTheLoai;
            MaTacGia = maTacGia;
            SoLuong = soLuong;
            DonGiaNhap = donGiaNhap;
            DonGiaXuat = donGiaXuat;
            MaNhaXuatBan = maNhaXuatBan;
            MaNhaCungCap = maNhaCungCap;
            Image = image;
        }
    }
}
