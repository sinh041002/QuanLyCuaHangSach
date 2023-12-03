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
    public class NxbBLL
    {
        public DataTable GetAllNXB()
        {
            return NhaXuatBanDAL.GetAllNhaXuatBan();
        }
        public void UpdateNhaXuatBan(NhaXuatBan nhaxuatban)
        {
           
            NhaXuatBanDAL.UpdateNhaXuatBan(nhaxuatban);
        }
        public void DeleteNhaXuatBan(string ma)
        {
            NhaXuatBanDAL.XoaNhaXuatBan(ma);
        }

        public Boolean themNhaXuatBan(NhaXuatBan nhaxuatban)
        {

            NhaXuatBanDAL nhaXuatBanDAL = new NhaXuatBanDAL();
            Boolean kt = nhaXuatBanDAL.themNhaXuatBan(nhaxuatban);
            return kt;
        }
    }
}
