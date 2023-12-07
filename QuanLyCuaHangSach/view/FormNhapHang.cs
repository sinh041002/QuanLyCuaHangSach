using BLL;
using DTO;
using QuanLyCuaHangSach.view;
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
    public partial class FormNhapHang : Form
    {
        NhapHangBLL nhapHangBLL = new NhapHangBLL();
        public FormNhapHang()
        {
            InitializeComponent();
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            cbxMaPhieuNhap.DisplayMember = "MaPhieuNhap";
            cbxMaPhieuNhap.ValueMember = "MaPhieuNhap";

            cbxMaPhieuNhap.SelectedIndex = -1;
            cbxMaPhieuNhap.DataSource = nhapHangBLL.GetAllMaPhieuNhap();

            btnLuuHang.Enabled = false;
            btnXoaHang.Enabled = false;
            btnThemSach.Enabled = false;

        }

        private void FormNhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbxGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgNhapHang.Rows[e.RowIndex];
                tbxMaPhieuNhap.Text = row.Cells["Mã phiếu nhập"].Value.ToString();
                cbxMaSach.Text = row.Cells["Mã sách"].Value.ToString();
                //Đơn giá phải set trước thằng số lượng vì trong số lượng có làm luôn phần thành tiền
                //tính bằng đơn giá và thành tiền, nếu set số lượng trước thì đơn giá bằng null và throw exception
                tbxDonGia.Text = row.Cells["Đơn giá"].Value.ToString();
                tbxSoLuong.Text = row.Cells["Số lượng"].Value.ToString();
                tbxThanhTien.Text = row.Cells["Thành tiền"].Value.ToString();
                cbxMaNhaCungCap.Text = row.Cells["Mã nhà cung cấp"].Value.ToString();
                //luồng đi: bấm vào cell content -> enabled cái nút sửa thông tin     
                btnThemHang.Enabled = true;
                btnXoaHang.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMoHinhAnh_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void cbxMaNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxMaPhieuNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            btnThemHang.Enabled = false;

            tbxMaPhieuNhap.Text = nhapHangBLL.CreateKey();

            cbxMaNhanVien.DisplayMember = "MaNhanVien";
            cbxMaNhanVien.ValueMember = "hoten";
            cbxMaNhanVien.DataSource = nhapHangBLL.LayThongTinNhanVien();

            cbxMaNhaCungCap.DisplayMember = "MaNhaCungCap";
            cbxMaNhaCungCap.ValueMember = "TenNhaCungCap";
            cbxMaNhaCungCap.DataSource = nhapHangBLL.LayThongTinNhaCungCap();

            cbxMaSach.DisplayMember = "MaSach";
            cbxMaSach.ValueMember = "TenSach";
            cbxMaSach.DataSource = nhapHangBLL.LayDanhSachMaSach();

            dtgNhapHang.DataSource = null;

            btnLuuHang.Enabled = true;
            btnXoaHang.Enabled = true;
            btnThemSach.Enabled = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbxMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxTenNhanVien.Text = cbxMaNhanVien.SelectedValue.ToString();
        }

        private void cbxMaNhaCungCap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tbxTenNhaCungCap.Text = cbxMaNhaCungCap.SelectedValue.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void cbxMaPhieuNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaPhieuNhap.Text != null)
            {
                tbxMaPhieuNhap.Text = cbxMaPhieuNhap.SelectedValue.ToString();
                dtgNhapHang.DataSource =
                    nhapHangBLL.LayThongTinPhieuNhapTheoMa(cbxMaPhieuNhap.SelectedValue.ToString());
                double totalPrice = 0;
                foreach (DataGridViewRow row in dtgNhapHang.Rows)
                {
                    if (row.Cells["Thành tiền"].Value != null)
                    {
                        totalPrice += double.Parse(row.Cells["Thành tiền"].Value.ToString());
                    }


                }
                tbxTongTien.Text = totalPrice.ToString();
                cbxMaNhanVien.Text = nhapHangBLL.LayMaNhanVienTheoMaPhieuNhap(cbxMaPhieuNhap.SelectedValue.ToString());
               
            
            }

        }

        private void tbxMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaSach.SelectedIndex != -1)
            {
                tbxTenSach.Text = cbxMaSach.SelectedValue.ToString();

            }
        }

        private void tbxTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxSoLuong_TextChanged(object sender, EventArgs e)
        {
            double donGia = 0;
            if (tbxDonGia.Text != "" && !tbxDonGia.Text.Contains('-'))
            {
                donGia = double.Parse(tbxDonGia.Text);
                
            }
            double soLuong = 0;
            if (tbxSoLuong.Text != "" && !tbxSoLuong.Text.Contains('-'))
            {
                soLuong = double.Parse(tbxSoLuong.Text);
            }
            double thanhTien = donGia * soLuong;
            if(thanhTien <= 0)
            {
                tbxThanhTien.Text = "";
            } else
            {
                tbxThanhTien.Text = thanhTien.ToString();
            }
            
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void ResetValue()
        {
            cbxMaNhaCungCap.Text = "";
            tbxTenNhaCungCap.Text = "";
            cbxMaNhanVien.Text = "";
            tbxTenNhanVien.Text = "";
            cbxMaSach.Text = "";
            tbxTenSach.Text = "";
            tbxDonGia.Text = "";
            tbxSoLuong.Text = "";
            tbxThanhTien.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // xử lý validate tbxDonGia và tbxSoLuong
            if (tbxSoLuong.Text.Equals("") || tbxDonGia.Text.Equals("")
                || tbxSoLuong.Text.Contains('-') || tbxDonGia.Text.Contains('-'))
            { 
                MessageBox.Show("Một hoặc nhiều hơn trường dữ liệu không hợp lệ!!!", "Trường dữ liệu không hợp lệ", MessageBoxButtons.OK);
               
                
            } else
            {
                List<string> danhSachMaPhieuNhap = nhapHangBLL.LayDanhSachMaPhieuNhap();
                string maPhieuNhap = tbxMaPhieuNhap.Text;
                if(!danhSachMaPhieuNhap.Contains(maPhieuNhap))
                {
                    //lưu thông tin phiếu nhập
                    NhapHangDTO nhapHangDTO = new NhapHangDTO();
                    nhapHangDTO.MaPhieuNhap = tbxMaPhieuNhap.Text;
                    nhapHangDTO.MaNhanVien = cbxMaNhanVien.Text;
                    nhapHangDTO.NgayNhap = DateTime.Now;
                    nhapHangBLL.LuuThongTinPhieuNhap(nhapHangDTO);
                }
                

                //lưu thông tin chi tiết phiếu nhập
                ChiTietPhieuNhapDTO chiTietPhieuNhapDTO = new ChiTietPhieuNhapDTO();
                chiTietPhieuNhapDTO.MaPhieuNhap = tbxMaPhieuNhap.Text;
                chiTietPhieuNhapDTO.MaSach = cbxMaSach.Text;
                chiTietPhieuNhapDTO.MaNhaCungCap = cbxMaNhaCungCap.Text;
                chiTietPhieuNhapDTO.DonGia = double.Parse(tbxDonGia.Text);
                chiTietPhieuNhapDTO.SoLuong = double.Parse(tbxSoLuong.Text);
                chiTietPhieuNhapDTO.ThanhTien = double.Parse(tbxThanhTien.Text);
                nhapHangBLL.LuuThongTinChiTietPhieuNhap(chiTietPhieuNhapDTO);

                //hiển thị thông tin chi tiết phiếu nhập vừa lưu
                dtgNhapHang.DataSource = nhapHangBLL.LayThongTinPhieuNhapTheoMa(maPhieuNhap);

                double totalPrice = 0;
                foreach (DataGridViewRow row in dtgNhapHang.Rows)
                {
                    if (row.Cells["Thành tiền"].Value != null)
                    {
                        totalPrice += double.Parse(row.Cells["Thành tiền"].Value.ToString());
                    }


                }
                tbxTongTien.Text = totalPrice.ToString();
                //lưu lại tổng tiền
                nhapHangBLL.LuuTongTien(tbxMaPhieuNhap.Text, totalPrice);

                //load lại danh sách
                cbxMaPhieuNhap.DisplayMember = "MaPhieuNhap";
                cbxMaPhieuNhap.DataSource = nhapHangBLL.GetAllMaPhieuNhap();
                tbxMaPhieuNhap.Text = maPhieuNhap;
                cbxMaPhieuNhap.SelectedValue = maPhieuNhap;

                //cập nhật số lượng và thành tiền bằng empty
                tbxSoLuong.Text = "";
                tbxThanhTien.Text = "";
                tbxDonGia.Text = "";
            }
           
        }

        private void btnHuyPhieuNhap_Click(object sender, EventArgs e)
        {
            Form child = new FormHuyNhapHang();
            child.ShowDialog(this);
            cbxMaPhieuNhap.Text = "";
            Reset();
            dtgNhapHang.DataSource = null;
            cbxMaPhieuNhap.DataSource = nhapHangBLL.LayDanhSachMaPhieuNhap();
        }

        private void Reset()
        {
            tbxMaPhieuNhap.Text = "";
            tbxDonGia.Text = "";
            tbxSoLuong.Text = "";
            cbxMaSach.Text = "";
            cbxMaNhanVien.Text = "";
            cbxMaNhaCungCap.Text = "";
            tbxTenNhaCungCap.Text = "";
            tbxThanhTien.Text = "";
            tbxTenNhanVien.Text = "";
            tbxTenSach.Text = "";

        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            var child = new FormQLSach();
<<<<<<< HEAD

            child.ShowDialog(this);

=======
            child.FormBorderStyle = FormBorderStyle.Sizable;
>>>>>>> a055a2137ae414ac7dd39040e14828bf77f07b00
            child.ShowDialog();

        }
    }
}
