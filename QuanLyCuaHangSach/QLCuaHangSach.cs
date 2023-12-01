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
            if (nhanVien.ChucVu!=1)
            {
                BtnQLNhanVien.Hide();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QLCuaHangSach_Load(object sender, EventArgs e)
        {

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

    

        private void BtnQLNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLNhanVien());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }


        private void panel3_body_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btnQLMaKhuyenMai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLMaKhuyenMai());
        }

        private void btnThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKeDoanhThu());
        }

        private void btnThongKeBanChay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongKeSPBanChay());

        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoaDon());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLSach());
        }

        private void btnQLKhachHAng_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormQLKhachHang());
        }

        private void btnBanHang_Click_1(object sender, EventArgs e)
        {
           MuaHang formmuahang = new MuaHang();
            formmuahang.GetNhanVien(nhanvien);
            OpenChildForm(formmuahang);

        }

        private void btnQuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLQUyen());
        }
    }
}
