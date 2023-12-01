using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoai
    {
        private string maTheLoai;
        private string tenTheLoai;
        private string moTaTheLoai;

        public TheLoai(string maTheLoai, string tenTheLoai, string moTaTheLoai)
        {
            this.maTheLoai = maTheLoai;
            this.tenTheLoai = tenTheLoai;
            this.moTaTheLoai = moTaTheLoai;
        }
        public TheLoai() { }

        public string MaTheLoai { get => maTheLoai; set => maTheLoai = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }
        public string MoTaTheLoai { get => moTaTheLoai; set => moTaTheLoai = value; }
    }
}
