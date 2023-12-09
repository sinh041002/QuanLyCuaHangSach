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

        public DataTable getListTimLiemChinhSua(string timkiem)
        {
            List<LichSuChinhSuaDTO> listlichSuChinhSua= new List<LichSuChinhSuaDTO>();
            NhanVienDAL nhanVienDAL = new NhanVienDAL();
            DataTable dataTable = new DataTable();
            dataTable = nhanVienDAL.getLichSuaChinhSua();


            string stringExpression = "MaNhanVienThaoTac like '"+timkiem+"'";

            
            //Dữ liệu lọc ra là một mảng các đối tượng DataRow
            DataRow[] rows = dataTable.Select(stringExpression);
            //Chuyển đổi các dòng dữ liệu rows thành DataTable với method CopyToDataTable()
            if (rows != null)
            {
                DataTable filterData = rows.CopyToDataTable();

                return filterData;
            }
            else return null;
            
            ////tìm kiếm
            //for (int i = 0; i < listlichSuChinhSua.Count; i++)
            //{
            //    if (listlichSuChinhSua[i].MaNhanVienBiThaoTac.ToUpper().Contains(timkiem.ToUpper()))
            //    {
            //        if (listlichSuChinhSua[i] != null)
            //        {
            //            listlichSuChinhSua.Add(listlichSuChinhSua[i]);
            //        }


            //    }
            //    if (listlichSuChinhSua[i].MaNhanVienThaoTac.ToUpper().Contains(timkiem.ToUpper()))
            //    {
            //        LichSuChinhSuaDTO obj1 = new LichSuChinhSuaDTO();
            //        obj1 = listlichSuChinhSua[i];
            //        listlichSuChinhSua.Add(obj1);
            //        //NhanVien nv1 = new NhanVien();
            //        //nv1 = listNhanVien[i];
            //        //listNhanVienTimKiem.Add(nv1);
            //    }
            //}
            //if (listlichSuChinhSua != null)
            //{
            //    return listlichSuChinhSua;
            //}
            //else return listlichSuChinhSua;
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
