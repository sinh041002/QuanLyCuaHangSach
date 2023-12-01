using DAL;
using DTO;
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
    public class TacGiaBLL
    {
        public DataTable GetAllTacGia()
        {
            return TacGiaDAL.GetAllTacGia();
        }
        public void UpdateTacGia(TacGia tacGia)
        {
            TacGiaDAL.UpdateTacGia(tacGia);
        }
        public void DeleteTacGia(string ma)
        {
            TacGiaDAL.XoaTacGia(ma);
        }
    }
}
