using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string getMa()
        {
            Random rd = new Random();
            int ma = rd.Next(1000, 9999);
            string a = "NV" + ma + "";


            return a;
        }
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Gioitinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayLamViec { get; set; }
        public string MatKhau { get; set; }
        public int TrangThai { get; set; }
        public int ChucVu { get; set; }

        public NhanVien(string maNhanVien, string hoTen, DateTime ngaySinh, string gioitinh, string soDienThoai, string diaChi, DateTime ngayLamViec, int chucVu, string matKhau,  int trangThai)
        {
           
            MaNhanVien = maNhanVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            Gioitinh = gioitinh;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
            NgayLamViec=ngayLamViec;
            MatKhau = matKhau;
            ChucVu = chucVu;
            TrangThai = trangThai;
        }

        

        public NhanVien() { }
    }
}
