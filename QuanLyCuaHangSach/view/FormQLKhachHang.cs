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
    public partial class FormQLKhachHang : Form
    {
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        public FormQLKhachHang()
        {
            InitializeComponent();
        }

        public void LoadListKhachHang()
        {
            dtgvKhachHang.DataSource = khachHangBLL.GetAllKhachHang();
        }
    }
}
