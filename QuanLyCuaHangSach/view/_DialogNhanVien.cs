using BLL;
using DTO;
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
    public partial class _DialogNhanVien : Form
    {
        public static string id;
        public static string ten;

        public static List<NhanVien> listNhanVien = null;
        NhanVienBLL nhanVienBLL = new NhanVienBLL();
        public _DialogNhanVien()
        {
            InitializeComponent();
            GetAllNV();
        }
        public void GetAllNV()
        {
            listNhanVien = nhanVienBLL.getListNhanVien();

            if (listNhanVien.Count > 0)
            {
                dgv3DialogStaff.DataSource = listNhanVien;
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = dgv3DialogStaff.CurrentRow.Index; 
            if (i >= 0) 
            {
                id = dgv3DialogStaff.Rows[i].Cells[0].Value.ToString();
                ten = dgv3DialogStaff.Rows[i].Cells[1].Value.ToString();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Bạn chưa chọn nhân viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập từ khóa !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string stringtimkiem = txtSearch.Text;
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            dgv3DialogStaff.DataSource = nhanVienBLL.getListTimKiem(stringtimkiem);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            GetAllNV();
        }
    }
}
