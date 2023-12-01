using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sach
    {
        private string maSach;
        private string tenSach;
        private float soLuong;
        private string image;
        private string donGiaNhap;
        private string donGiaXuat;

        public Sach(string maSach, string tenSach, float soLuong, string image, string donGiaNhap, string donGiaXuat)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.soLuong = soLuong;
            this.image = image;
            this.donGiaNhap = donGiaNhap;
            this.donGiaXuat = donGiaXuat;
        }

        public Sach()
        {

        }


        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public float SoLuong { get => soLuong; set => soLuong = value; }
        public string Image { get => image; set => image = value; }
        public string DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public string DonGiaXuat { get => donGiaXuat; set => donGiaXuat = value; }
    }
}
