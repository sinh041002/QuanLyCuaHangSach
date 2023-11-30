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
        public DataTable GetAllBook()
        {
            return SachDAL.GetAllBook();
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
