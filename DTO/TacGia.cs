using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TacGia
    {
        private string maTacGia { get; set; }
        private string tenTacGia { get; set; }
        private string moTaTacGia { get; set; } 

        public TacGia() { }

        public TacGia(string maTacGia, string tenTacGia, string moTaTacGia)
        {
            this.maTacGia = maTacGia;
            this.tenTacGia = tenTacGia;
            this.moTaTacGia = moTaTacGia;
        }
    }
}
