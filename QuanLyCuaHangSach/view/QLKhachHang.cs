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
    public partial class QLKhachHang: Form
    {
        List<KhachHangDTO> khachHangs = new List<KhachHangDTO>();
        public QLKhachHang()
        {
        
            InitializeComponent();
        }

        private void dtgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Load1()
        {
            DataTable dataTable = new DataTable();
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            dataTable = khachHangBLL.GetAllKhachHang();

            //khachHangs = khachHangBLL.getKhachHang();
            dataKhachHang.DataSource = dataTable;

            //KhachHangBLL khachHangBLL = new KhachHangBLL();
            //khachHangs = khachHangBLL.getKhachHang();

            //if (khachHangs.Count > 0 && khachHangs!=null)
            //{
            //    dataKhachHang.DataSource = khachHangs;
            //}
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            //DataTable dataTable = new DataTable();
            //KhachHangBLL khachHangBLL = new KhachHangBLL();
            //dataTable = khachHangBLL.GetAllKhachHang();
            //dataKhachHang.DataSource = dataTable;
           Load1();
        }

        private void dataKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataKhachHang.CurrentRow.Index;
            if (i >= 0 && dataKhachHang.Rows[i].Cells[0].ToString() != "")
            {
                txtMaKhachHang.Text = dataKhachHang.Rows[i].Cells[0].Value.ToString();
                txtTenKhachHang.Text = dataKhachHang.Rows[i].Cells[1].Value.ToString();
                txtDiaChi.Text = dataKhachHang.Rows[i].Cells[2].Value.ToString();
                txtSoDienThoai.Text = dataKhachHang.Rows[i].Cells[3].Value.ToString();
                txtEmail.Text = dataKhachHang.Rows[i].Cells[4].Value.ToString();
                txtTongTien.Text = dataKhachHang.Rows[i].Cells[6].Value.ToString();

            }
        }

        private void btxThem_Click(object sender, EventArgs e)
        {
            KhachHangDTO khachHang = new KhachHangDTO();
            khachHang.MaKhachHang = khachHang.getMa();
            khachHang.TenKhachHang=txtTenKhachHang.Text;
            khachHang.DiaChi=txtDiaChi.Text;
            khachHang.Email=txtEmail.Text;
            khachHang.TongTienMua = 0;
            khachHang.SoDienThoai=txtSoDienThoai.Text;
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            Boolean a= khachHangBLL.themKhachHang(khachHang);
            if (a == true)
            {
                Load1();
                MessageBox.Show("Thêm Thành công");
            }
            else
            {
                MessageBox.Show("Thêm Thất bại");

            }
        }

        private void btxSua_Click(object sender, EventArgs e)
        {
            KhachHangDTO khachHang = new KhachHangDTO();
            khachHang.MaKhachHang = txtMaKhachHang.Text;
            khachHang.TenKhachHang = txtTenKhachHang.Text;
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.Email = txtEmail.Text;
            khachHang.TongTienMua =float.Parse( txtTongTien.Text);
            khachHang.SoDienThoai = txtSoDienThoai.Text;
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            Boolean a = khachHangBLL.suaKhachHang(khachHang);
            if (a == true)
            {
                Load1();
                MessageBox.Show("Sửa Thành công");
            }
            else
            {
                MessageBox.Show("Sửa Thất bại");

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
              txtMaKhachHang.Text=null;
              txtTenKhachHang.Text = null;
              txtDiaChi.Text = null;
              txtEmail.Text = null;
              txtTongTien.Text = "0";
              txtSoDienThoai.Text = null;
        }   

        private void btxXoa_Click(object sender, EventArgs e)
        {
            KhachHangBLL khachHangBLL = new KhachHangBLL();
            Boolean a = khachHangBLL.xoaKhachHang(txtMaKhachHang.Text);
            if (a == true)
            {
                Load1();
                MessageBox.Show("Xóa Thành công");
            }
            else
            {
                MessageBox.Show("Xóa Thất bại");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
            string tentimkiem=txtTimKiem.Text;
            KhachHangBLL khachHangBLL=new KhachHangBLL();
            dataKhachHang.DataSource= khachHangBLL.GetKhachHangByMa(tentimkiem);


        }
    }
}
