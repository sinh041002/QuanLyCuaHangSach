using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class NhanVienBLL
    {
        public static List< NhanVien> listNhanVien = null;
        public List<NhanVien> getListNhanVien()
        {
            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            listNhanVien = nhanVienDAL.getListNhanViens();
            if (listNhanVien != null)
            {
                return listNhanVien;
            }
            else return listNhanVien;
        }

        public Boolean themNhanVien(NhanVien nhanVien)
        {

            NhanVienDAL nhanVienDAL=new NhanVienDAL();
            Boolean kt = nhanVienDAL.themNhanVien(nhanVien);
           return kt;
        }
        public Boolean suaNhanVien(NhanVien nhanVien)
        {

            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            Boolean kt = nhanVienDAL.suaNhanVien(nhanVien);

            if (kt)
            {
                return kt;
            }    
            return false;
        }

        public Boolean xoaNhanVien(string manhanVien)
        {

            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            Boolean kt = nhanVienDAL.xoaNhanVien(manhanVien);

            if (kt)
            {
                return kt;
            }
            return false;
        }
    }
}
