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
    public class TheLoaiBLL
    {
        public DataTable GetAllTheLoai() 
        {
            return TheLoaiDAL.GetAllTheLoai();
        }
        public void UpdateTheLoai(TheLoai theLoai) 
        {
            TheLoaiDAL.UpdateTheLoai(theLoai);
        }
        public void DeleteTheloai(string ma)
        {
            TheLoaiDAL.DeleteTheLoai(ma);
        }
    }
}
