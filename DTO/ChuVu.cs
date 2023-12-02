using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuVu
    {
        public ChuVu() { }
        public int id { get; set; }
        public string TenChucVu { get; set; }

        public ChuVu(int id, string tenChucVu)
        {
            this.id = id;
            TenChucVu = tenChucVu;
        }
    }
}
