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

        public List<NhanVien> getListTimKiem0(string timkiem)
        {
            List<NhanVien> listNhanVienTimKiem = new List<NhanVien>();
            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            listNhanVienTimKiem = nhanVienDAL.getListNhanVienTimKiem(timkiem);
           
            if (listNhanVienTimKiem != null)
            {
                return listNhanVienTimKiem;
            }
            else return listNhanVienTimKiem;
        }
        public List<NhanVien> getListTimKiem(string timkiem)
        {
           List<NhanVien> listNhanVienTimKiem = new List<NhanVien>();
             NhanVienDAL nhanVienDAL = new NhanVienDAL();
            listNhanVien = nhanVienDAL.getListNhanViens();
            for(int i = 0; i < listNhanVien.Count; i++)
            {
               if( listNhanVien[i].MaNhanVien.ToUpper().Contains(timkiem.ToUpper()))
                {
                    if (listNhanVien[i]!=null)
                    {
                        listNhanVienTimKiem.Add(listNhanVien[i]);
                    }
                    
                    
                }
                if (listNhanVien[i].HoTen.ToUpper().Contains(timkiem.ToUpper()))
                {
                    NhanVien nv1 = new NhanVien();
                    nv1 = listNhanVien[i];
                    listNhanVienTimKiem.Add(nv1);
                    //NhanVien nv1 = new NhanVien();
                    //nv1 = listNhanVien[i];
                    //listNhanVienTimKiem.Add(nv1);
                }
            }
            if (listNhanVienTimKiem != null)
            {
                return listNhanVienTimKiem;
            }
            else return listNhanVienTimKiem;
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
