using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChucVuBLL
    {
        public ChucVuBLL() { } 

        public List<ChuVu> getChucVu()
        {
           
            ChucVuDAL chucVuDAL = new ChucVuDAL();
            List<ChuVu> chucvu = new List<ChuVu>();
            chucvu = chucVuDAL.getListChucVu();
          
            return chucvu;
        }
    }
}
