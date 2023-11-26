using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sale
    {
        public Sale(int id
            , string nameSale
            , DateTime timeStart
            , DateTime timeEnd
            , int saleOff)
        {
            Id = id;
            NameSale = nameSale;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            SaleOff = saleOff;
        }

        public int Id { get;set;}
        public string NameSale { get;set;}
        public DateTime TimeStart { get;set;}
        public DateTime TimeEnd { get;set;}
        public int SaleOff { get;set;}
    }
}
