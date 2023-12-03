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

namespace QuanLyCuaHangSach
{
    public partial class FormHuyHoaDon : Form
    {
        HoaDonBLL hoaDon = new HoaDonBLL();
        public FormHuyHoaDon()
        {
            InitializeComponent();
            cbxMaHoaDon.SelectedIndex = -1;
            cbxMaHoaDon.DisplayMember = "MaHoaDon";
            cbxMaHoaDon.ValueMember = "MaHoaDon";
            cbxMaHoaDon.DataSource = hoaDon.GetAllMaHoaDon();
        }

        private void FormHuyHoaDon_Load(object sender, EventArgs e)
        {
            
        }

        private void btnXoaPhieuNhap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xóa hóa đơn", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                hoaDon.HuyHoaDon(cbxMaHoaDon.Text);

                KhachHangDTO khachHangDTO =
                    hoaDon.GetDataKhachHangByMaHoaDon(cbxMaHoaDon.Text);
                double TongTien = hoaDon.LayTongTienTheoMaHoaDon(cbxMaHoaDon.Text);
                hoaDon.CapNhatTongTienMuaChoKhachHang(khachHangDTO.MaKhachHang, TongTien, "tru");
            }
            MessageBox.Show("Hủy phiếu nhập thành công", "Hủy thành công", MessageBoxButtons.OK);
            this.Close();


        }
    }
}
