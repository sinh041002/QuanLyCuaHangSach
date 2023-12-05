using BLL;
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
using DTO;
using System.Windows.Forms.VisualStyles;

namespace QuanLyCuaHangSach.view
{
    public partial class FormQLSach : Form
    {
        SachBLL sachBLL = new SachBLL();
        TheLoaiBLL theLoaiBLL = new TheLoaiBLL();
        TacGiaBLL tacGiaBLL = new TacGiaBLL();
        NhaXuatBanBLL nhaXuatBanBLL = new NhaXuatBanBLL();
        string urlImg, urlCopy;
        string url = Application.StartupPath;
        public FormQLSach()
        {
            InitializeComponent();
            GetAllBook();
            GetAllTheLoai();
            LoadListTacGia();
            LoadListNhaXuatBan();
        }

        public void GetAllBook()
        {
            dgvListBook.DataSource = sachBLL.GetAllBookQL();
        }

        public void GetAllTheLoai()
        {
            dgvListTheLoai.DataSource = theLoaiBLL.GetAllTheLoai();
        }

        public void LoadListTacGia()
        {
            dgvListTacGia.DataSource = tacGiaBLL.GetAllTacGia();
        }

        public void LoadListNhaXuatBan()
        {
            dtgvNhaXuatBan.DataSource = nhaXuatBanBLL.GetAllNhaXuatBan();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string item = cbbLoc.GetItemText(cbbLoc.SelectedItem);
            string name = txtNameSearch.Text.Trim();
            if (item == "" && name == "")
            {
                MessageBox.Show("Vui lòng chọn các lựa chọn để lọc!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (item == "Tên Sản Phẩm")
            {
                dgvListBook.DataSource = sachBLL.GetAllBookByName(name);
            }
            else if (item == "Danh Mục")
            {
                dgvListBook.DataSource = sachBLL.GetAllBookByCategory(name);
            }
            else if (item == "Tất Cả")
            {
                dgvListBook.DataSource = sachBLL.GetAllBookQL();
            }
        }

        private void dgvListBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvListBook.CurrentRow.Index;
            if (i >= 0 )
            {
                urlImg = dgvListBook.Rows[i].Cells[9].Value.ToString();
                Bitmap bm = new Bitmap(url + urlImg);
                pbSanPham.Image = bm;

                txtMaSach.Text = dgvListBook.Rows[i].Cells[0].Value.ToString();
                txtTenSach.Text = dgvListBook.Rows[i].Cells[1].Value.ToString();

                txtMaTheLoaiForm1.Text = dgvListBook.Rows[i].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvListBook.Rows[i].Cells[4].Value.ToString();
                txtDonGiaXuat.Text = dgvListBook.Rows[i].Cells[6].Value.ToString();
                txtDonGiaNhap.Text = dgvListBook.Rows[i].Cells[5].Value.ToString();
                txtMaTGForm1.Text = dgvListBook.Rows[i].Cells[3].Value.ToString();
                txtTenAnh.Text = dgvListBook.Rows[i].Cells[9].Value.ToString();
                txtMaNhaXuatBanform1.Text = dgvListBook.Rows[i].Cells[7].Value.ToString();

                txtMaNhaCungcapform1.Text = dgvListBook.Rows[i].Cells[8].Value.ToString();
                
                
                
                
            }
        }

        private void dgvListTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvListTheLoai.CurrentRow.Index;
            if (i >= 0 && dgvListTheLoai.Rows[i].Cells[0].ToString() != "") 
            {
                txtMaTheLoai.Text = dgvListTheLoai.Rows[i].Cells[0].Value.ToString();
                txtTenTheLoai.Text = dgvListTheLoai.Rows[i].Cells[1].Value.ToString();
                txtMoTaTheLoai.Text = dgvListTheLoai.Rows[i].Cells[2].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                Sach sach = new Sach();
                sach.MaSach = txtMaSach.Text;
                sach.TenSach= txtTenSach.Text;
                sach.MaTacGia= txtMaTGForm1.Text;
                sach.DonGiaNhap= txtDonGiaNhap.Text;
                sach.DonGiaXuat=    txtDonGiaXuat.Text;
                sach.MaNhaCungCap= txtMaNhaCungcapform1.Text;
                sach.MaNhaXuatBan = txtMaNhaXuatBanform1.Text;
                sach.Image = txtTenAnh.Text;
                sach.SoLuong =float.Parse (txtSoLuong.Text);
                sach.MaTheLoai= txtMaTheLoaiForm1.Text;
                SachBLL sachbll = new SachBLL();
                Boolean a = sachbll.themSach(sach);
                if (a == true)
                {
                    GetAllBook();
                    MessageBox.Show("Thêm Thành công");
                }
                else
                {
                    MessageBox.Show("Thêm Thất bại");

                }

            }

        }

        private void FormQLSach_Load(object sender, EventArgs e)
        {
            url = Directory.GetParent(url).Parent.Parent.FullName;
            url += @"\ImgSach\";
            pbSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                FileName = "",
                Filter = "Image Files(*.PNG;*.JPG;*.JFIF)|*.PNG;*.JPG;*.JFIF",
                Title = "Select Image"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    urlImg = openFileDialog.FileName;
                    urlCopy = urlImg;

                    string str = urlImg;
                    txtTenAnh.Text =str.Substring(25) ;
                    Bitmap bm = new Bitmap(urlImg);
                    pbSanPham.Image = bm;
                    pbSanPham.SizeMode = PictureBoxSizeMode.StretchImage;
                    urlImg = Path.GetFileName(urlImg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtTacGiaForm1.Text = "";
            txtTheLoaiForm1.Text = "";
            txtSoLuong.Text = "";
            txtDonGiaNhap.Text = "";
            pbSanPham.Image = null;
            txtDonGiaXuat.Text = "";
            GetAllBook();
        }

        private void btnResetTheLoai_Click(object sender, EventArgs e)
        {
            txtMaTheLoai.Text = "";
            txtTenTheLoai.Text = "";
            txtMoTaTheLoai.Text = "";
            GetAllTheLoai();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không","Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                sachBLL.DeleteBook(txtMaSach.Text);                
            }
            MessageBox.Show("Xóa thành công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.None);
            GetAllBook();
        }

        private void btnDeleteTheLoai_Click(object sender, EventArgs e)
        {
            if (txtMaTheLoai.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này không", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                theLoaiBLL.DeleteTheloai(txtMaTheLoai.Text);    
            }
            MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            GetAllTheLoai();
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            if (txtTenTheLoai.Text == "" || txtMoTaTheLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa sản phẩm này không?", "Sản Phẩm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TheLoai theLoai = new TheLoai();
                theLoai.MaTheLoai = txtMaTheLoai.Text;
                theLoai.TenTheLoai = txtTenTheLoai.Text;
                theLoai.MoTaTheLoai = txtMoTaTheLoai.Text;
                theLoaiBLL.UpdateTheLoai(theLoai);
                MessageBox.Show("Sửa thông tin thành công", "Thành Công", MessageBoxButtons.OK);
                GetAllTheLoai();
            }
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            if (txtTenTacGia.Text == "" || txtMoTaTacGIa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TacGiaBLL tacgiabll = new TacGiaBLL();
            TacGia tacgia = new TacGia();
            tacgia.MaTacGia = tacgia.getMa();
            tacgia.TenTacGia = txtTenTacGia.Text;
            tacgia.MoTaTacGia = txtMoTaTacGIa.Text;
            Boolean a = tacgiabll.themTacGia(tacgia);
            if (a == true)
            {
                LoadListTacGia();
                MessageBox.Show("Thêm Thành công", " Thành công", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm thông tin Thất bại", "Thất bại", MessageBoxButtons.OK);
            }
        }

        private void btnSuaTacGia_Click(object sender, EventArgs e)
        {
            if (txtTenTacGia.Text == "" || txtMoTaTacGIa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa tác giả này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                TacGia tacGia = new TacGia();
                tacGia.MaTacGia = txtMaTacGia.Text;
                tacGia.TenTacGia = txtTenTacGia.Text;
                tacGia.MoTaTacGia = txtMoTaTacGIa.Text;
                tacGiaBLL.UpdateTacGia(tacGia);
                MessageBox.Show("Sửa thông tin thành công", "Thành Công", MessageBoxButtons.OK);
                LoadListTacGia();
            }
        }

        private void btnXoaTacGia_Click(object sender, EventArgs e)
        {
            if (txtMaTacGia.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tác giả trước khi xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này?","Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                TacGiaBLL abc=new TacGiaBLL();
                abc.DeleteTacGia(txtMaTacGia.Text);
            }
            MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
           LoadListTacGia();
        }

        private void btn3ChamTacGia_Click(object sender, EventArgs e)
        {
            _3ChamTacGia formtacgia = new _3ChamTacGia();
            formtacgia.ShowDialog();
            txtTacGiaForm1.Text = _3ChamTacGia.name;
            txtMaTGForm1.Text = _3ChamTacGia.id;
        }

        private void btn3ChamTheLoai_Click(object sender, EventArgs e)
        {
            _3ChamTheLoai formtheloai = new _3ChamTheLoai();
            formtheloai.ShowDialog();
            txtTheLoaiForm1.Text = _3ChamTheLoai.name;
            txtMaTheLoai.Text= _3ChamTheLoai.id;
        }

        private void btn3ChamNCC_Click(object sender, EventArgs e)
        {
            _3ChamNCC formNCC = new _3ChamNCC();
            formNCC.ShowDialog();
            txtNhaCungCap.Text = _3ChamNCC.name;
            txtMaNhaCungcapform1.Text = _3ChamNCC.id;
        }

        private void btn3ChamNxb_Click(object sender, EventArgs e)
        {
            _3ChamNXB formNxb = new _3ChamNXB();
            formNxb.ShowDialog();
            txtMaNhaXuatBanform1.Text = _3ChamNXB.id;
            txtNhaXuatBan.Text= _3ChamNXB.name;
        }

        private void dtgvListTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemTheLoai_Click(object sender, EventArgs e)
        {
            if (txtTenTheLoai.Text == "" || txtMoTaTheLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
                TheLoaiBLL theLoaiBLL =new TheLoaiBLL();
                TheLoai theloai = new TheLoai();
                theloai.MaTheLoai = theloai.getMa();
                theloai.TenTheLoai = txtTenTheLoai.Text;
                theloai.MoTaTheLoai = txtMoTaTheLoai.Text;
                Boolean a= theLoaiBLL.themTheLoai(theloai);
                if (a == true)
                {
                    GetAllTheLoai();
                
                }
                else
                {
                    MessageBox.Show("Thêm thông tin Thất bại", "Thất bại", MessageBoxButtons.OK);
                }
               
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dgvListBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvListTheLoai.CurrentRow.Index;
            if (i >= 0)
            {
              txtMaTheLoai.Text   = dgvListTheLoai.Rows[i].Cells[0].Value.ToString();

                txtTenTheLoai.Text = dgvListTheLoai.Rows[i].Cells[1].Value.ToString();
                txtMoTaTheLoai.Text= dgvListTheLoai.Rows[i].Cells[2].Value.ToString();




            }
        }

        private void dgvListTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvListTacGia.CurrentRow.Index;
            if (i >= 0)
            {
                txtMaTacGia.Text = dgvListTacGia.Rows[i].Cells[0].Value.ToString();

                txtTenTacGia.Text = dgvListTacGia.Rows[i].Cells[1].Value.ToString();
                txtMoTaTacGIa.Text = dgvListTacGia.Rows[i].Cells[2].Value.ToString();




            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtgvNhaXuatBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgvNhaXuatBan.CurrentRow.Index;
            if (i >= 0)
            {
                txtMaNhaXuatbanf4.Text = dtgvNhaXuatBan.Rows[i].Cells[0].Value.ToString();

                txtTenNhaXuatBanF4.Text = dtgvNhaXuatBan.Rows[i].Cells[1].Value.ToString();
                txtMoTaNhaXuatBanf4.Text = dtgvNhaXuatBan.Rows[i].Cells[2].Value.ToString();




            }
        }

        private void btnThemNhaXB_Click(object sender, EventArgs e)
        {
            if (txtTenNhaXuatBanF4.Text == "" || txtMoTaNhaXuatBanf4.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NhaXuatBan nhaXuatBan = new NhaXuatBan();
            nhaXuatBan.maNhaXuatBan = nhaXuatBan.getMa();
            nhaXuatBan.tenNhaXuatBan = txtTenNhaXuatBanF4.Text;
            nhaXuatBan.moTaNhaXuatBan = txtMoTaNhaXuatBanf4.Text;
            NxbBLL nxbBLL = new NxbBLL();
        
            Boolean a = nxbBLL.themNhaXuatBan(nhaXuatBan);
            if (a == true)
            {
                LoadListNhaXuatBan();

                MessageBox.Show("Thêm thông tin thành công", "Thành Công", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Thêm thông tin Thất bại", "Thất bại", MessageBoxButtons.OK);
            }
        }

        private void BtnSuaNhaXB_Click(object sender, EventArgs e)
        {
            if (txtTenNhaXuatBanF4.Text == "" || txtMoTaNhaXuatBanf4.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa tác giả này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                NhaXuatBan nhaXuatBan = new NhaXuatBan();
                nhaXuatBan.maNhaXuatBan = txtMaNhaXuatbanf4.Text;
                nhaXuatBan.tenNhaXuatBan = txtTenNhaXuatBanF4.Text;
                nhaXuatBan.moTaNhaXuatBan = txtMoTaNhaXuatBanf4.Text;
                NxbBLL nxbBLL = new NxbBLL();
                nxbBLL.UpdateNhaXuatBan(nhaXuatBan);
                MessageBox.Show("Sửa thông tin thành công", "Thành Công", MessageBoxButtons.OK);
                LoadListNhaXuatBan();
            }
        }

        private void btnResetNhaXB_Click(object sender, EventArgs e)
        {
            txtMaNhaXuatbanf4.Text = null; 

            txtTenNhaXuatBanF4.Text =null;
            txtMoTaNhaXuatBanf4.Text = null;

        }

        private void btnXoaNXB_Click(object sender, EventArgs e)
        {
            if (txtMaNhaXuatbanf4.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tác giả trước khi xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả này?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NxbBLL nxbBLL = new NxbBLL();
                nxbBLL.DeleteNhaXuatBan(txtMaNhaXuatbanf4.Text);
            }
            MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            LoadListNhaXuatBan();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn sửa !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenSach.Text == "" || txtDonGiaNhap.Text == "" || txtDonGiaXuat.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsNumber(txtSoLuong.Text) || !IsNumber(txtDonGiaNhap.Text) || !IsNumber(txtDonGiaXuat.Text))
            {
                MessageBox.Show("Đơn giá hoặc số lượng phải là số !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa sản phẩm này không?", "Sản Phẩm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Sach sach = new Sach();
                sach.MaSach = txtMaSach.Text;
                sach.TenSach = txtTenSach.Text.Trim();
                sach.SoLuong = float.Parse(txtSoLuong.Text);
                sach.Image = urlImg;
                sach.DonGiaNhap = txtDonGiaNhap.Text.Trim();
                sach.DonGiaXuat = txtDonGiaXuat.Text.Trim();

                sachBLL.UpdateBook(sach);
                MessageBox.Show("Sửa thông tin thành công", "Thành Công", MessageBoxButtons.OK);
                GetAllBook();
            }
        }
    }
}
