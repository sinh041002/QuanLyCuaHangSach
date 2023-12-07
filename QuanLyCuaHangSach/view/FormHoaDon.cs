using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using DGVPrinterHelper;

namespace QuanLyCuaHangSach
{
    public partial class FormHoaDon : Form
    {
        HoaDonBLL hoadon = new HoaDonBLL();

        public FormHoaDon()
        {
            InitializeComponent();
            cbxMaNhanVien.SelectedIndex = -1;
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {


            cbxMaHoaDon.DisplayMember = "MaHoaDon";
            cbxMaHoaDon.ValueMember = "MaHoaDon";
            cbxMaHoaDon.DataSource = hoadon.GetAllMaHoaDon();



            //dtgHoaDon.DataSource = hoadon.getData();
<<<<<<< HEAD


=======
        
>>>>>>> a055a2137ae414ac7dd39040e14828bf77f07b00
        }

        private void FormHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
<<<<<<< HEAD




=======
>>>>>>> a055a2137ae414ac7dd39040e14828bf77f07b00
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayXuat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbxMaKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaNhanVien.SelectedIndex != -1)
            {
                tbxTenNhanVien.Text = cbxMaNhanVien.SelectedValue.ToString();

            }

        }

        private void cbxMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaKhachHang.SelectedIndex != -1)
            {
                string id = cbxMaKhachHang.SelectedValue.ToString();
                KhachHangDTO khachHangDTO = hoadon.getKhachHangById(id);
                tbxDiaChi.Text = khachHangDTO.DiaChi;
                tbxDienThoai.Text = khachHangDTO.SoDienThoai;
                tbxTenKhachHang.Text = khachHangDTO.TenKhachHang;

            }
        }

        private void dtgHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgHoaDon.Rows[e.RowIndex];
                cbxMaSach.Text = row.Cells["Mã sách"].Value.ToString();
                //Đơn giá phải set trước thằng số lượng vì trong số lượng có làm luôn phần thành tiền
                //tính bằng đơn giá và thành tiền, nếu set số lượng trước thì đơn giá bằng null và throw exception
                tbxDonGia.Text = row.Cells["Đơn giá"].Value.ToString();
                tbxSoLuong.Text = row.Cells["Số lượng"].Value.ToString();
                tbxThanhTien.Text = row.Cells["Thành tiền"].Value.ToString();

            }
        }



        private void tbxMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            tbxMaHoaDon.Text = hoadon.CreateKey();
<<<<<<< HEAD

=======
          
>>>>>>> a055a2137ae414ac7dd39040e14828bf77f07b00

            cbxMaNhanVien.DisplayMember = "MaNhanVien";
            cbxMaNhanVien.ValueMember = "hoten";
            cbxMaNhanVien.DataSource = hoadon.getDataNhanVien();

            cbxMaKhachHang.DisplayMember = "MaKhachHang";
            cbxMaKhachHang.ValueMember = "MaKhachHang";
            cbxMaKhachHang.DataSource = hoadon.getMaKhachHang();

            cbxMaSach.DisplayMember = "MaSach";
            cbxMaSach.ValueMember = "MaSach";
            cbxMaSach.DataSource = hoadon.getMaSach();

            dtgHoaDon.DataSource = null;
            tbxTongTien.Text = "";
            cbxMaNhanVien.SelectedIndex = -1;
            tbxTenNhanVien.Text = "";
            cbxMaKhachHang.SelectedIndex = -1;
            tbxDiaChi.Text = "";
            tbxDienThoai.Text = "";
            tbxTenKhachHang.Text = "";

            cbxMaGiamGia.DataSource = null;
            cbxMaGiamGia.DisplayMember = "SaleOff";
            cbxMaGiamGia.ValueMember = "SaleOff";
            cbxMaGiamGia.DataSource = hoadon.GetAllMaGiamGia();


        }

        private void cbxMaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgHoaDon.Enabled = true;
            dtgHoaDon.DataSource = hoadon.GetChiTietHoaDon(cbxMaHoaDon.SelectedValue.ToString());

            tbxMaHoaDon.Text = cbxMaHoaDon.SelectedValue.ToString();

            //query thông tin hóa đơn gồm mã nhân viên, mã khách
            NhanVienDTOMaNhanVienHoTen nv = hoadon.GetDataNhanVienByMaHoaDon(cbxMaHoaDon.SelectedValue.ToString());
            cbxMaNhanVien.Text = nv.MaNhanVien;
            tbxTenNhanVien.Text = nv.HoTen;

            //query thông tin khách hàng
            KhachHangDTO kh = hoadon.GetDataKhachHangByMaHoaDon(cbxMaHoaDon.SelectedValue.ToString());
            cbxMaKhachHang.Text = kh.MaKhachHang;
            tbxTenKhachHang.Text = kh.TenKhachHang;
            tbxDiaChi.Text = kh.DiaChi;
            tbxDienThoai.Text = kh.SoDienThoai;

            cbxMaGiamGia.DataSource = hoadon.LayThongTinTongTienVaGiamGiaTheoMaHoaDon(cbxMaHoaDon.SelectedValue.ToString());
            cbxMaGiamGia.DisplayMember = "GiamGia";
            cbxMaGiamGia.ValueMember = "TongTien";

            //HoaDonBLL hoaDonBLL = new HoaDonBLL();
            //if (hoaDonBLL.getTrangThai(cbxMaHoaDon.SelectedValue.ToString() ) == 1)
            //{
            //    btnLuu.Enabled = false;
            //}

            tbxTongTien.Text = cbxMaGiamGia.SelectedValue.ToString();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMaSach.SelectedIndex != -1)
            {
                string MaSach = cbxMaSach.SelectedValue.ToString();
                SachDTO sach = hoadon.GetDatSachByMaSach(MaSach);
                int soluong = int.Parse(sach.SoLuong.ToString());

                tbxDonGia.Text = sach.DonGia;
            }

        }

        private void tbxSoLuong_TextChanged(object sender, EventArgs e)
        {

            if (hoadon.IsBlank(tbxSoLuong.Text) || tbxSoLuong.Text.Contains("-"))
            {

                MessageBox.Show("Trường số lượng không hợp lệ", "Không hợp lệ", MessageBoxButtons.OKCancel);
                tbxSoLuong.Text = "";
            }
            else
            {
                double price = double.Parse(tbxSoLuong.Text) * double.Parse(tbxDonGia.Text);
                tbxThanhTien.Text = price.ToString();
            }


        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            HoaDonDTO hoaDonDTO = new HoaDonDTO();
            ChiTietHoaDonDTO chiTietHoaDonDTO = new ChiTietHoaDonDTO();


            //get all mã hóa đơn
            //nếu trùng thì không cần khởi tạo

            List<string> MaHoaDonList = hoadon.GetAllMaHoaDonList();
            string MaHoaDon = tbxMaHoaDon.Text;
            if (!MaHoaDonList.Contains(MaHoaDon))
            {
                //tạo hóa  đơn
                hoaDonDTO.MaHoaDon = MaHoaDon;
                hoaDonDTO.MaNhanVien = cbxMaNhanVien.Text;
                hoaDonDTO.MaKhachHang = cbxMaKhachHang.Text;
                hoaDonDTO.NgayXuat = dtpNgayXuat.Value;
                hoaDonDTO.GiamGia = double.Parse(cbxMaGiamGia.SelectedValue.ToString());
                hoadon.SaveHoaDon(hoaDonDTO);
            }

            //lấy số lượng từ tbl_sach, nếu số lượng bé hơn thì throw message box
            SachDTOSoLuong sachDTOSoLuong = hoadon.LaySoLuongSach(cbxMaSach.Text);
            if (sachDTOSoLuong.SoLuong < double.Parse(tbxSoLuong.Text))
            {
                MessageBox.Show("Trường số lượng lớn hơn số lượng sách trong kho là " + sachDTOSoLuong.SoLuong.ToString()
                    , "Không hợp lệ", MessageBoxButtons.OK);

            }
            else
            {
                hoadon.CapNhatSoLuongSach(cbxMaSach.Text, double.Parse(tbxSoLuong.Text));
            }

            //tạo chi tiết hóa đơn
            chiTietHoaDonDTO.MaHoaDon = MaHoaDon;
            chiTietHoaDonDTO.MaSach = cbxMaSach.Text;
            chiTietHoaDonDTO.DonGia = double.Parse(tbxDonGia.Text);
            chiTietHoaDonDTO.SoLuong = double.Parse(tbxSoLuong.Text);
            chiTietHoaDonDTO.ThanhTien = double.Parse(tbxThanhTien.Text);
            hoadon.SaveChiTietHoaDon(chiTietHoaDonDTO);
            //show lại thông tin hóa đơn vừa thêm
            dtgHoaDon.DataSource = hoadon.GetChiTietHoaDon(MaHoaDon);

            double totalPrice = 0;
            foreach (DataGridViewRow row in dtgHoaDon.Rows)
            {
                if (row.Cells["Thành tiền"].Value != null)
                {
                    totalPrice += double.Parse(row.Cells["Thành tiền"].Value.ToString());
                }


            }
            tbxTongTien.Text = totalPrice.ToString();
            //lưu lại tổng tiền
            hoadon.SaveTongTien(MaHoaDon, totalPrice);
            tbxThanhTien.Text = "";

            //load lại mã hóa đơn
            cbxMaHoaDon.DisplayMember = "MaHoaDon";
            cbxMaHoaDon.DataSource = hoadon.GetAllMaHoaDon();
            tbxMaHoaDon.Text = MaHoaDon;
            cbxMaHoaDon.SelectedValue = MaHoaDon;

        }

        private void Reset()
        {
            tbxMaHoaDon.Clear();
            tbxTenKhachHang.Clear();
            tbxTongTien.Clear();
            tbxDiaChi.Clear();
            cbxMaNhanVien.Text = string.Empty;
            cbxMaKhachHang.Text = string.Empty;
            cbxMaSach.Text = string.Empty;
            tbxTenNhanVien.Clear();
            tbxDienThoai.Clear();

            tbxSoLuong.Clear();
            tbxDonGia.Clear();
            tbxThanhTien.Clear();
<<<<<<< HEAD

=======
          
>>>>>>> a055a2137ae414ac7dd39040e14828bf77f07b00
        }

        private void btnHuyDoanDon_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnSuaThongTIn_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaThongTin_Click(object sender, EventArgs e)
        {
            var child = new FormHuyHoaDon();
            child.ShowDialog(this);
            cbxMaHoaDon.Text = "";
            Reset();
            dtgHoaDon.DataSource = null;
            cbxMaHoaDon.DataSource = hoadon.GetAllMaHoaDon();
        }

        private void tbxDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMaHoaDonTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!hoadon.IsBlank(tbxTongTien.Text))
            {

            }
        }

        private void cbxMaGiamGia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblThanhTien_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {



            double saleOff = double.Parse(cbxMaGiamGia.Text) / 100;
            double discountPrice = double.Parse(tbxTongTien.Text) * saleOff;
            double price = double.Parse(tbxTongTien.Text);
            double totalPrice = price - discountPrice;
            //cập nhật lại tổng tiền
            hoadon.SaveTongTien(tbxMaHoaDon.Text, totalPrice);

            //cập nhật tổng tiền mua cho khách
            hoadon.CapNhatTongTienMuaChoKhachHang(cbxMaKhachHang.Text, totalPrice);


            MessageBox.Show("Lưu thành công", "Lưu thành công", MessageBoxButtons.OK);
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void printPdf()
        {
            if (dtgHoaDon.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = cbxMaHoaDon.Text;
                bool exist = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        exist = true;
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch
                        {

                            MessageBox.Show("In không thành công, vui lòng kiểm tra lại");

                        }
                    }
                    if (exist == false)
                    {   
                       DGVPrinter printer = new DGVPrinter();
                        printer.Title = "MÃ HÓA ĐƠN: " + cbxMaHoaDon.Text;
                        printer.SubTitle = "Ngày xuất: " + DateTime.Now + "\n" + "Nhân viên: "
                            + tbxTenNhanVien.Text + "\n" + "Khách hàng: " + tbxTenKhachHang.Text;
                        printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                        printer.PageNumbers = true;
                        printer.PageNumberInHeader = false;
                        printer.PorportionalColumns = true;
                        printer.HeaderCellAlignment = StringAlignment.Near;
                        printer.Footer = "CỬA HÀNG SÁCH UY TÍN SỐ 1 VIỆT NAM";
                        printer.PartText = "hehe";
                        DataTable table = (DataTable) dtgHoaDon.DataSource;
                        DataRow row = table.NewRow();
                        DataRow dr = table.NewRow();
                        dr["Mã sách"] = "Giảm giá (%)";
                        dr["Số lượng"] = cbxMaGiamGia.Text;
                        table.Rows.Add(dr);

                        row["Mã sách"] = "Tổng tiền";
                        row["Số lượng"] = tbxTongTien.Text;
                        table.Rows.Add(row);
                        table.AcceptChanges();  
                        printer.PrintDataGridView(dtgHoaDon);
 



                        
                 
                      
                        MessageBox.Show("In hóa đơn thành công");
                    }
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            printPdf();
        }
    }
}
