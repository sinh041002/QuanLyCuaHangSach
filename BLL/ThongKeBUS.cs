using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBUS
    {
        ThongKeDAL _dal = new ThongKeDAL();

        public List<TKDoanhThuViewModel> LayDoanhThu(DateTime from, DateTime to)
        {
           return _dal.LayDoanhThu(from, to);
        }

        public List<TKSPBanChayViewModel> LaySPBanChay(DateTime from, DateTime to)
        {
            return _dal.LaySPBanChay(from, to);
        }
    }
}
