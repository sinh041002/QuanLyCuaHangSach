using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Reflection;

namespace BLL
{
    public class NhanVienBLL
    {
        public static List< NhanVien> listNhanVien = null;

        public DataTable GetAllNhanVien()
        {
            
            return NhanVienDAL.GetAllNhanVien();
        }
        public DataTable GetLichSuChinhSua()
        {
            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            return nhanVienDAL.getLichSuaChinhSua();
        }
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
            List<NhanVien> listNhanVien1 = new List<NhanVien>();
            listNhanVien1 = nhanVienDAL.getListNhanViens();
            for(int i = 0; i < listNhanVien1.Count; i++)
            {
                if (listNhanVien1[i].MaNhanVien.ToUpper().Contains(timkiem.ToUpper()))
                {
                    if (listNhanVien1[i] != null)
                    {
                        listNhanVienTimKiem.Add(listNhanVien1[i]);
                    }


                }
                else if (listNhanVien1[i].HoTen.ToUpper().Contains(timkiem.ToUpper()))
                {
                    NhanVien nv1 = new NhanVien();
                    nv1 = listNhanVien1[i];
                    listNhanVienTimKiem.Add(nv1);

                }

            }
            if (listNhanVienTimKiem != null)
            {
                return listNhanVienTimKiem;
            }
            else return listNhanVienTimKiem;
        }

        public DataTable getListTimLiemChinhSua(string timkiem)
        {
          
            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            DataTable dataTable = new DataTable();
            dataTable = nhanVienDAL.getLichSuaChinhSuaTimKiem(timkiem);
            return dataTable;



        }

        public Boolean themNhanVien(NhanVien nhanVien)
        {

            NhanVienDAL nhanVienDAL=new NhanVienDAL();
            Boolean kt = nhanVienDAL.themNhanVien(nhanVien);
           return kt;
        }
        public Boolean themLichSuChinhSuaNhanVien(LichSuChinhSuaDTO lichSuChinhSuaDTO)
        {

            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            Boolean kt = nhanVienDAL.ThemLichSuChinhSua(lichSuChinhSuaDTO);
            
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
