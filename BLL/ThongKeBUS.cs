using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
        public long LayTongTienThang(int a , int nam)
        {
            long tong = 0;
            List < TKDoanhThuViewModel > listDoanhthuthang= new List<TKDoanhThuViewModel>();
            DateTime from = new DateTime(nam,a,1);
            DateTime aDateTime = new DateTime(nam, a, 1);

            // Cộng thêm 1 tháng và trừ đi một ngày.
            DateTime to = aDateTime.AddMonths(1).AddDays(-1);
            listDoanhthuthang = _dal.LayDoanhThu(from, to);
            for(int i = 0;listDoanhthuthang.Count > i; i++)
            {
                tong = tong + (long) listDoanhthuthang[i].DoanhThu;
            }
            return tong;
        }
    }
}
