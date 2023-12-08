using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        public KhachHangBLL() { }
        public static List<KhachHangDTO> listKhachHang = null;
        public DataTable GetAllKhachHang()
        {
            return KhachHangDAL.GetAllKhachHang();
        }
        public DataTable GetKhachHangByMa(string matimkiem)
        {
            return KhachHangDAL.GetKhachHangByMa(matimkiem);
        }

        public List<KhachHangDTO> getKhachHang()
        {
            KhachHangDAL khachHangDAL = new KhachHangDAL();
            listKhachHang = khachHangDAL.GetKhachHang();
            if (listKhachHang != null)
            {
                return listKhachHang;
            }
            else return listKhachHang;
        }
        public Boolean themKhachHang(KhachHangDTO khachhang)
        {

            KhachHangDAL khachHangDAL = new KhachHangDAL();
            Boolean kt = khachHangDAL.themKhachHang(khachhang);
            return kt;
        }
        public Boolean suaKhachHang(KhachHangDTO khachhang)
        {

            KhachHangDAL khachHangDAL = new KhachHangDAL();
            Boolean kt = khachHangDAL.suaKhachHang(khachhang);

            if (kt)
            {
                return kt;
            }
            return false;
        }

        public Boolean xoaKhachHang(string maKhachHang)
        {

            KhachHangDAL khachHangDAL = new KhachHangDAL();
            Boolean kt = khachHangDAL.xoaKhachhang(maKhachHang);

            if (kt)
            {
                return kt;
            }
            return false;
        }

    }
}
