using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SaleBLL
    {
        SaleDAL _dal = new SaleDAL();

        public SaleBLL()
        {

        }

        public List<Sale> GetSales()
        {
            return _dal.GetListSale();
        }

        public List<Sale> GetValidSales(DateTime current)
        {
            return _dal.GetValidListSale(current);
        }

        public bool Them(Sale sale)
        {
            return _dal.Them(sale);
        }

        public bool Sua(Sale sale)
        {
            return _dal.Sua(sale);
        }

        public bool Xoa(int Id)
        {
            return _dal.Xoa(Id);
        }

        public List<Sale> TimKiem(string w)
        {
            return _dal.TimKiem(w);
        }

        public Sale GetById(int Id)
        {
            return _dal.GetById(Id);
        }

        public bool TonTai(int Id)
        {
            return _dal.GetById(Id) != null;
        }
    }
}
