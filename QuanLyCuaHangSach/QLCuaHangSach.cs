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
    public partial class QLCuaHangSach : Form
    {
        public static NhanVien nhanvien=null;
        public QLCuaHangSach()
        {
            InitializeComponent();
        }
         public void setNhanVien(NhanVien nv)
        {   if(nv != null)
            {
                nhanvien=nv;
            }
           
        }
        public void phanquyen(NhanVien nhanVien)
        {
            QuyenDTO items = new QuyenDTO();
            QuyenBLL quyenBLL = new QuyenBLL();
            items = quyenBLL.GetItemQuyen(nhanVien.ChucVu);
            
            if (items.QLKhachHang != 1)
            {
                btnQLKhachHang.Hide();
            }

            if (items.QLNhanVien != 1)
            {
                BtnQLNhanVien.Hide();
            }

            if (items.QLQuyen != 1)
            {
                btnQuyen.Hide();
            }

            if (items.QLKhuyenMai != 1)
            {
                btnQLMaKhuyenMai.Hide();
            }
             
            if (items.QLSach != 1)
            {
                btnQLSach.Hide();
                btnQLNhapHang.Hide();
            }
            if (items.QLHoaDon != 1)
            {
                btnHoaDon.Hide();
            }

            if (items.BanHang != 1)
            {
                btnBanHang.Hide();
            }

            if (items.QLThongKe != 1)
            {
                btnThongKeBanChay.Hide();
                btnThongKeDoanhThu.Hide();
            }

           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QLCuaHangSach_Load(object sender, EventArgs e)
        {
            lbMaNhanVien.Text = nhanvien.MaNhanVien;
            lbTenNhanVien.Text=nhanvien.HoTen.ToUpper();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle=FormBorderStyle.None;
            ChildForm.Dock= DockStyle.Fill;
            panel3_body.Controls.Add(ChildForm);
            panel3_body.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

    

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }


      
  

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            MuaHang formmuahang = new MuaHang();
            formmuahang.GetNhanVien(nhanvien);
            OpenChildForm(formmuahang);

        }

        private void btnQLKhachHang_Click_1(object sender, EventArgs e)
        {
           
           
            OpenChildForm(new QLKhachHang());
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLSach());
        }

        private void btnQLMaKhuyenMai_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLMaKhuyenMai());
        }

        private void BtnQLNhanVien_Click(object sender, EventArgs e)
        {
            QLNhanVien qLNhanVien = new QLNhanVien();
            qLNhanVien.AnHienXemMatKhau(nhanvien.ChucVu);
           
            OpenChildForm(qLNhanVien);
        }

        private void btnQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLQUyen());
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoaDon());
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKeDoanhThu());
        }

        private void btnThongKeBanChay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKeSPBanChay());
        }

        private void ptrTrangChu_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn đăng xuất hay không", "Quản Lý cửa hàng sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                dangnhap formdangnhap = new dangnhap();
                formdangnhap.StartPosition = FormStartPosition.CenterScreen;
                formdangnhap.ShowDialog();

                this.Close();
            }
          
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát khỏi chương trình hay không", "Quản Lý cửa hàng sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLNhanVien());
        }

        private void btnQLNhapHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhapHang());
        }
    }
}
