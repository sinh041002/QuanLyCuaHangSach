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
        string urlImg, urlCopy;
        string url = Application.StartupPath;
        public FormQLSach()
        {
            InitializeComponent();
            GetAllBook();
            GetAllTheLoai();
        }

        public void GetAllBook()
        {
            dgvListBook.DataSource = sachBLL.GetAllBook();
        }

        public void GetAllTheLoai()
        {
            dgvListTheLoai.DataSource = theLoaiBLL.GetAllTheLoai();
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
                dgvListBook.DataSource = sachBLL.GetAllBook();
            }
        }

        private void dgvListBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvListBook.CurrentRow.Index;
            if (i >= 0 && dgvListBook.Rows[i].Cells[0].Value.ToString() != "")
            {
                urlImg = dgvListBook.Rows[i].Cells[6].Value.ToString();
                Bitmap bm = new Bitmap(url + urlImg);
                pbSanPham.Image = bm;

                txtMaSach.Text = dgvListBook.Rows[i].Cells[0].Value.ToString();
                txtTenSach.Text = dgvListBook.Rows[i].Cells[1].Value.ToString();
                txtTacGia.Text = dgvListBook.Rows[i].Cells[7].Value.ToString();
                txtTheLoai.Text = dgvListBook.Rows[i].Cells[2].Value.ToString();
                txtSoLuong.Text = dgvListBook.Rows[i].Cells[3].Value.ToString();
                txtDonGiaNhap.Text = dgvListBook.Rows[i].Cells[4].Value.ToString();
                txtDonGiaXuat.Text = dgvListBook.Rows[i].Cells[5].Value.ToString();
            }
        }

        private void dgvListTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvListTheLoai.CurrentRow.Index;
            if (i >= 0 && dgvListTheLoai.Rows[i].Cells[0].ToString() != "") 
            {
                txtMaTheLoai.Text = dgvListTheLoai.Rows[i].Cells[0].Value.ToString();
                txtTenTheLoai.Text = dgvListTheLoai.Rows[i].Cells[1].Value.ToString();
                txtMoTa.Text = dgvListTheLoai.Rows[i].Cells[2].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "")
            {
                MessageBox.Show("Sản phẩm đã có trong dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            txtTacGia.Text = "";
            txtTheLoai.Text = "";
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
            txtMoTa.Text = "";
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
            GetAllBook();
        }

        private void btnSuaTheLoai_Click(object sender, EventArgs e)
        {
            if (txtTenTheLoai.Text == "" || txtMoTa.Text == "")
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
                theLoai.MoTaTheLoai = txtMoTa.Text;
                theLoaiBLL.UpdateTheLoai(theLoai);
                MessageBox.Show("Sửa thông tin thành công", "Thành Công", MessageBoxButtons.OK);
                GetAllTheLoai();
            }
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaTacGia_Click(object sender, EventArgs e)
        {

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
