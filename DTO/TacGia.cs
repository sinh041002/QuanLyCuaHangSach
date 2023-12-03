using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TacGia
    {
        private string maTacGia;
        private string tenTacGia;
        private string moTaTacGia;

        public TacGia() { }

        public TacGia(string maTacGia, string tenTacGia, string moTaTacGia)
        {
            this.maTacGia = maTacGia;
            this.tenTacGia = tenTacGia;
            this.moTaTacGia = moTaTacGia;
        }

        public string MaTacGia { get => maTacGia; set => maTacGia = value; }
        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public string MoTaTacGia { get => moTaTacGia; set => moTaTacGia = value; }
    }
}
