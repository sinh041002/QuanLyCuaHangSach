using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace QuanLyCuaHangSach.view
{
    public partial class MuaHang : Form
    {
        DataTable tbGioHang = new DataTable();
        SachBLL sachBLL = new SachBLL();
        HoaDonBLL hoaDonBLL = new HoaDonBLL();
        public MuaHang()
        {
            InitializeComponent();
            GetAllBook();
        }
        
        public void GetAllBook()
        {
            dgvSanPham.DataSource = sachBLL.GetAllBook();
        }
        public void GetNhanVien(NhanVien nv)
        {
            if (nv != null) {
                txtMaNhanVien.Text = nv.MaNhanVien;
                txtNhanVien.Text = nv.HoTen;
            }
           
        }
        private void MuaHang_Load(object sender, EventArgs e)
        {
            tbGioHang.Columns.Add("Mã Sản Phẩm");
            tbGioHang.Columns.Add("Tên Sản Phẩm");
            tbGioHang.Columns.Add("Giá Tiền");
            tbGioHang.Columns.Add("Số Lượng");
            tbGioHang.Columns.Add("Thành Tiền");
            dgvGio.DataSource = tbGioHang;
            dgvGio.DefaultCellStyle.Font = new Font("Times New Roman", 12);
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSanPham.CurrentRow.Index;
            if (i >= 0 && dgvSanPham.Rows[i].Cells[1].Value.ToString() != "")
            {
                txtMaSanPham.Text = dgvSanPham.Rows[i].Cells[1].Value.ToString();
                txtTenSanPham.Text = dgvSanPham.Rows[i].Cells[2].Value.ToString();
                txtTenLoai.Text = dgvSanPham.Rows[i].Cells[3].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[i].Cells[5].Value.ToString();
                txtSoLuongConLai.Text = dgvSanPham.Rows[i].Cells[4].Value.ToString();

                string url = Application.StartupPath;
                url = Directory.GetParent(url).Parent.Parent.FullName;
                url += @"\ImgSach\";
                if (dgvSanPham.Rows[i].Cells[6].Value.ToString() != "")
                {
                    string urlImg = dgvSanPham.Rows[i].Cells[6].Value.ToString();

                    pbSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                    Bitmap bm = new Bitmap(url + urlImg);
                    pbSanPham.Image = bm;
                }
               
            }
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void BtnThemVaoGio_Click(object sender, EventArgs e)
        {
            if (txtTenSanPham.Text == "")
            {
                MessageBox.Show("Chưa chọn sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsNumber(txtSoLuong.Text))
            {
                MessageBox.Show("Nhập số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.Parse(txtSoLuong.Text) <= 0)
            {
                MessageBox.Show("Nhập số lượng không được nhỏ hơn hoặc bằng 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (int.Parse(txtSoLuong.Text) > int.Parse(txtSoLuongConLai.Text))
            {
                MessageBox.Show("Số lượng không được lớn hơn số lượng còn lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataRow row in tbGioHang.Rows)
            {
                if (row["Tên Sản Phẩm"].ToString().Equals(txtTenSanPham.Text))
                {
                    row["Số Lượng"] = int.Parse(txtSoLuong.Text) + int.Parse(row["Số Lượng"].ToString());
                    row["Thành Tiền"] = (double.Parse(row["Giá Tiền"].ToString()) * int.Parse(row["Số Lượng"].ToString()));
                    goto C1;
                }
            }
            DataRow r = tbGioHang.NewRow();
            r["Mã Sản Phẩm"] = txtMaSanPham.Text;
            r["Tên Sản Phẩm"] = txtTenSanPham.Text;
            r["Giá Tiền"] = txtDonGia.Text;
            r["Số Lượng"] = txtSoLuong.Text;    
            r["Thành Tiền"] = (double.Parse(txtDonGia.Text) * double.Parse(txtSoLuong.Text)).ToString();
            tbGioHang.Rows.Add(r);

        C1: decimal sum = 0;
            foreach (DataRow row in tbGioHang.Rows)
            {
                sum += decimal.Parse(row["Thành tiền"].ToString());
            }
            txtTongTien.Text = sum.ToString();  

            for (int i = 0; i < dgvSanPham.Rows.Count; i++) 
            {
                if (dgvSanPham.Rows[i].Cells[2].Value.ToString().Equals(txtTenSanPham.Text))
                {
                    dgvSanPham.Rows[i].Cells[4].Value = int.Parse(txtSoLuongConLai.Text) - int.Parse(txtSoLuong.Text);
                    txtMaSanPham.Clear();
                    txtTenSanPham.Clear();
                    txtDonGia.Clear();
                    txtSoLuong.Clear();
                    txtSoLuongConLai.Clear();
                    txtTenLoai.Clear();
                    return; 
                }
            }
        }

        private void btnXoaGioHang_Click(object sender, EventArgs e)
        {
            int k = dgvGio.CurrentRow.Index;
            if (k < 0) 
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < dgvSanPham.Rows.Count; i++)
            {
                if (dgvSanPham.Rows[i].Cells[2].Value.ToString().Equals(dgvGio.Rows[k].Cells[1].Value.ToString()))
                {
                    dgvSanPham.Rows[i].Cells[4].Value = int.Parse(dgvSanPham.Rows[i].Cells[4].Value.ToString()) + int.Parse(dgvGio.Rows[k].Cells[3].Value.ToString());
                    decimal sum = decimal.Parse(txtTongTien.Text);
                    sum -= decimal.Parse(dgvGio.Rows[k].Cells[4].Value.ToString());
                    txtTongTien.Text = sum.ToString();
                    dgvGio.Rows.RemoveAt(k);
                    MessageBox.Show("Xóa thành công");
                    return;
                }
            }
        }

        private void BtnMuaHang_Click(object sender, EventArgs e)
        {
            if (dgvGio.Rows.Count == 1)
            {
                MessageBox.Show("Bạn chưa thêm sản phẩm nào vào giỏ hàng !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên bán hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Có chắc chắn là bạn mua hàng chứ ?", "Mua Hàng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) 
            {
                HoaDonDTO hoadon = new HoaDonDTO();        
                hoadon.MaHoaDon = hoaDonBLL.CreateKey();
                hoadon.MaNhanVien = txtMaNhanVien.Text.Trim();
                hoadon.MaKhachHang = txtMaKhachHang.Text.Trim(); 
                hoadon.NgayXuat = (DateTime)dtpNgayTao.Value;
                hoadon.TongTien = double.Parse(txtTongTienKM.Text.Trim());
                if (txtKhuyenMai.Text.Trim()=="")
                {
                    hoadon.GiamGia = 0;
                }
                else
                {
                    hoadon.GiamGia = double.Parse(txtKhuyenMai.Text.Trim());
                }
             
                hoaDonBLL.SaveHoaDon(hoadon);
                SaveChiTietHoaDon();
            }
            else
            {
                MessageBox.Show("Hủy mua hàng thành công");
            }
        }

        public void SaveChiTietHoaDon() 
        {
                
            foreach (DataRow row in tbGioHang.Rows)
            {
                ChiTietHoaDonDTO chiTietHoaDonDTO = new ChiTietHoaDonDTO();
                string ma = row["Mã Sản Phẩm"].ToString().Trim();
                double soluong = double.Parse(row["Số Lượng"].ToString().Trim());
                chiTietHoaDonDTO.MaHoaDon = hoaDonBLL.CreateKey();
                chiTietHoaDonDTO.MaSach = row["Mã Sản Phẩm"].ToString().Trim();
                chiTietHoaDonDTO.DonGia = double.Parse(row["Giá Tiền"].ToString().Trim());
                chiTietHoaDonDTO.SoLuong = int.Parse(row["Số Lượng"].ToString().Trim());
                chiTietHoaDonDTO.ThanhTien = double.Parse(row["Thành Tiền"].ToString().Trim());


                hoaDonBLL.SaveChiTietHoaDon(chiTietHoaDonDTO);

                sachBLL.MinusStockBook(ma, soluong);
            }
            MessageBox.Show("Mua Hàng Thành Công !!");
            tbGioHang.Clear();
            txtMaNhanVien.Text = "";
            txtNhanVien.Text = "";
            txtMaKhachHang.Text = "";
            txtKhachHang.Text = "";
            txtKhuyenMai.Text = "";
            txtTongTien.Text = "0";
            txtTongTienKM.Text = "0";
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            _DialogNhanVien DialogNhanVien = new _DialogNhanVien();
            DialogNhanVien.ShowDialog();
            txtMaNhanVien.Text = _DialogNhanVien.id;
            txtNhanVien.Text = _DialogNhanVien.ten;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            _DialogKhachHang dialogKhachHang = new _DialogKhachHang();
            dialogKhachHang.ShowDialog();
            txtMaKhachHang.Text = _DialogKhachHang.id;
            txtKhachHang.Text = _DialogKhachHang.ten;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string item = cbbLoc.GetItemText(cbbLoc.SelectedItem);
            string name = txtNameSearch.Text.Trim();
            if (item == "" && name == "")
            {
                MessageBox.Show("Vui lòng chọn các lựa chọn để lọc!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (item == "Tên Sản Phẩm")
            {
                dgvSanPham.DataSource = sachBLL.GetAllBookByName(name);
            }
            else if (item == "Danh Mục")
            {
                dgvSanPham.DataSource = sachBLL.GetAllBookByCategory(name);
            }else if (item == "Tất Cả")
            {
                dgvSanPham.DataSource = sachBLL.GetAllBook();
            }
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            if (dgvGio.RowCount <= 1)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm vào giỏ hàng trước khi chọn khuyến mãi !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _DialogKhuyenMai DialogKhuyenMai = new _DialogKhuyenMai();
                DialogKhuyenMai.ShowDialog();
                txtKhuyenMai.Text = _DialogKhuyenMai.SaleOff;
                if (txtKhuyenMai.Text == "")
                {
                    txtTongTienKM.Text = (double.Parse(txtTongTien.Text.Trim())).ToString();
                }
                else
                {
                    txtTongTienKM.Text = (double.Parse(txtTongTien.Text.Trim()) - (double.Parse(txtTongTien.Text.Trim()) * ((double.Parse(txtKhuyenMai.Text) / 100)))).ToString();
                }
            }
           
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            if (txtKhuyenMai.Text == "")
            {
                txtTongTienKM.Text = (double.Parse(txtTongTien.Text.Trim())).ToString();
            }
            else
            {
                txtTongTienKM.Text = (double.Parse(txtTongTien.Text.Trim()) - (double.Parse(txtTongTien.Text.Trim()) * ((double.Parse(txtKhuyenMai.Text) / 100)))).ToString();
            }
        }

        private void txtKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            if (txtTongTien.Text != "")
            {
                txtTongTienKM.Text = (double.Parse(txtTongTien.Text.Trim()) - ((double.Parse(txtTongTien.Text.Trim()) *( double.Parse(txtTongTienKM.Text) / 100)))).ToString();
            }
        }

        private void txtTongTienKM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

