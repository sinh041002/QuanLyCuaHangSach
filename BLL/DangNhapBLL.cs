using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class DangNhapBLL
    {
        public static NhanVien taiKhoanLogin = null;
        public NhanVien getLogin(string TenTK,string MatKhau )
        {
                     
           
            DangNhapDAL dangNhapDAL = new DangNhapDAL();
            taiKhoanLogin = dangNhapDAL.getTaiKhoan(TenTK, MatKhau);

            if( taiKhoanLogin == null )
            {
                return null;
            }else
            {
                return taiKhoanLogin;
            }    
            
            
        }
    }
}
