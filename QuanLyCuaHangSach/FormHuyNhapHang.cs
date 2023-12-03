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

namespace QuanLyCuaHangSach
{
    public partial class FormHuyNhapHang : Form
    {
        NhapHangBLL nhapHang = new NhapHangBLL();
        public FormHuyNhapHang()
        {
            InitializeComponent();

            cbxMaPhieuNhap.DisplayMember = "MaPhieuNhap";
            cbxMaPhieuNhap.ValueMember = "MaPhieuNhap";
            cbxMaPhieuNhap.DataSource = nhapHang.GetAllMaPhieuNhap();
            cbxMaPhieuNhap.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này?", "Xóa phiếu nhập", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                nhapHang.HuyPhieuNhap(cbxMaPhieuNhap.Text);
            }
            MessageBox.Show("Hủy phiếu nhập thành công", "Hủy thành công", MessageBoxButtons.OK );

            this.Visible = false;
        }
    }
}
