using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        public Boolean themTacGia(TacGia tacGia)
        {

            TacGiaDAL tacGiaDAL = new TacGiaDAL();
            Boolean kt = tacGiaDAL.themKhachHang(tacGia);
            return kt;
        }
    }
}
