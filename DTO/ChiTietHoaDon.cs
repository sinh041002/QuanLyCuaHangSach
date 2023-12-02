using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        public ChiTietHoaDon(string maHoaDon, string maSach, float soLuong, float donGia, float thanhTien)
        {
            MaHoaDon = maHoaDon;
            MaSach = maSach;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
        }
        public ChiTietHoaDon() { }

        public string MaHoaDon { get; set; } 
        public string MaSach { get; set;}
        public float SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }

    }
}
