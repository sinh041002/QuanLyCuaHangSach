using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangSach.view
{
    public partial class LichSuChinhSuaNhanVien : Form
    {
        public LichSuChinhSuaNhanVien()
        {
            InitializeComponent();
        }

        private void Load1()
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            DataTable dt = new DataTable();
            dt = nhanVienBLL.GetLichSuChinhSua();
            dataChinhSua.DataSource = dt;
        }
        private void LichSuChinhSuaNhanVien_Load(object sender, EventArgs e)
        {
           Load1();
        }

        private void btnTimKiemLs_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimKiem.Text;
           
            NhanVienBLL nhanvienbll = new NhanVienBLL();
            dataChinhSua.DataSource = nhanvienbll.getListTimLiemChinhSua(timkiem);



        }


    }
}
