using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class SachBLL
    {


        public Boolean themSach(Sach sach)
        {

            SachDAL sachDAL = new SachDAL();
            Boolean kt = sachDAL.themSach(sach);
            return kt;
        }
        public Boolean suaSach(Sach sach)
        {

            SachDAL sachDAL = new SachDAL();
            Boolean kt = sachDAL.themSach(sach);

            if (kt)
            {
                return kt;
            }
            return false;
        }

        public Boolean xoaKhachHang(string maSach)
        {

            SachDAL sachDAL = new SachDAL();
            Boolean kt = true;

            if (kt)
            {
                return kt;
            }
            return false;
        }

        public DataTable GetAllBook()
        {
            return SachDAL.GetAllBook();
        }
        public DataTable GetAllBookQL()
        {
            return SachDAL.GetAllBookQL();
        }
        public DataTable GetAllBookByName(string name)
        {
            return SachDAL.GetAllBookByName(name);
        }
        public DataTable GetAllBookByCategory(string name)
        {
            return SachDAL.GetAllBookByName(name);
        }
        public DataTable AddBook() 
        { 
            return SachDAL.AddBook();
        }
        public void UpdateBook(Sach sach) 
        {
             SachDAL.UpdateBook(sach);
        }
        public void DeleteBook(string ma) 
        {
            SachDAL.DeleteBook(ma);
        }
    }
}
