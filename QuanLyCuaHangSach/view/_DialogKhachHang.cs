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
    public partial class _DialogKhachHang : Form
    {

        public static string id;
        public static string ten;
        KhachHangBLL khachHangBLL = new KhachHangBLL();
        public _DialogKhachHang()
        {
            InitializeComponent();
            GetAllKhachHang();
        }
        public void GetAllKhachHang()
        {
            dgv3ChamUser.DataSource = khachHangBLL.GetAllKhachHang();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = dgv3ChamUser.CurrentRow.Index;
            if (i >= 0)
            {
                id = dgv3ChamUser.Rows[i].Cells[0].Value.ToString();
                ten = dgv3ChamUser.Rows[i].Cells[1].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
