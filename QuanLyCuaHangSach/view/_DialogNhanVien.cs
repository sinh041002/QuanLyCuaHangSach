using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace QuanLyCuaHangSach.view
{
    public partial class _DialogNhanVien : Form
    {
        NhanVienBLL nvBLL = new NhanVienBLL();
        
        public static string id;
        public static string ho;
        public static string ten;

        public _DialogNhanVien()
        {
            InitializeComponent();
            GetAllNhanVien();
        }
        public void GetAllNhanVien() 
        {
            dgv3ChamStaff.DataSource = nvBLL.getListNhanVien();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Bạn phải nhập từ khóa để tìm kiếm !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            GetAllNhanVien();
        }

    }
}
