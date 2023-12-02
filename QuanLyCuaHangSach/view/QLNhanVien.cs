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
using BLL;

namespace QuanLyCuaHangSach.view
{
    public partial class QLNhanVien : Form
    {
        public static List<NhanVien> listNhanVien = null;

        public static List<ChuVu> listChucVu = null;
        public QLNhanVien()
        {
            InitializeComponent();
        }

   
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private  List<string> getChucVu()
        {
            ChucVuBLL chucVuBLL = new ChucVuBLL();
            List<string> chucVu = new List<string>();
            listChucVu = chucVuBLL.getChucVu();
            if(listChucVu != null)
            {
                for(int i=0; i < listChucVu.Count(); i++)
                {
                    chucVu.Add(listChucVu[i].TenChucVu);
                }
        
            }
            
            return chucVu ;
        }
        private List<string> getGioiTinh()
        {
            List<string> chucVu = new List<string>() { "Nam", "Nữ" };
            return chucVu;
        }
        private void Load1()
        {
            comboBoxGioiTinh.DataSource = getGioiTinh();
            comboboxChucVu.DataSource = getChucVu();
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
           listNhanVien=  nhanVienBLL.getListNhanVien();

            if(listNhanVien.Count > 0 )
            {
                dataGridView1.DataSource= listNhanVien;
            }
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            Load1();
        }

      

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            txtMaNhanVien.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenNhanVien.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimeNgaySinh.Value =(DateTime) dataGridView1.CurrentRow.Cells[2].Value;
             comboBoxGioiTinh.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            rTBGhiChu.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSoDienThoai.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           
            txtMatKhau.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            int indexChucVu = (int)dataGridView1.CurrentRow.Cells[9].Value;

            comboboxChucVu.SelectedIndex =indexChucVu-1;
           
            a = (int)dataGridView1.CurrentRow.Cells[8].Value;
            if (a == 1)
            {
                radioTrangThai.Checked = true;
            }else radioTrangThai.Checked=false;
            
       

        }

        //sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            int maChucVu = 0;
            if (listChucVu != null)
            {
                for (int i = 0; i < listChucVu.Count(); i++)
                {
                    if (comboboxChucVu.SelectedIndex == i)
                    {
                        maChucVu = listChucVu[i].id;
                    }
                }
            }
          
          
            int trangThaiTaiKhoan = 0;

            if (radioTrangThai.Checked == false)
            {
                trangThaiTaiKhoan = 0;
            }
            else
            {
                trangThaiTaiKhoan = 1;
            }
            NhanVien nv1 = new NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, dateTimeNgaySinh.Value, comboBoxGioiTinh.SelectedItem.ToString(), txtSoDienThoai.Text, rTBGhiChu.Text, DateTime.Now, maChucVu, txtMatKhau.Text, trangThaiTaiKhoan);


            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            Boolean ktra = nhanVienBLL.suaNhanVien(nv1);
            if (ktra)
            {
                MessageBox.Show("Sửa Thành công");
                Load1();
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
            Load1();
        }
            
        //thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
             string MaNhanVien = txtMaNhanVien.Text;
             string HoTen = txtTenNhanVien.Text;
            DateTime NgaySinh = dateTimeNgaySinh.Value;
         
            string SoDienThoai = txtSoDienThoai.Text;
            string DiaChi = rTBGhiChu.Text;

            string MatKhau = txtMatKhau.Text;
           
             int ChucVu = comboboxChucVu.SelectedIndex;


            if (MaNhanVien.Trim() == "") { MessageBox.Show("Vui lòng nhập Mã Nhân Viên "); }
            else if (HoTen.Trim() == "") { MessageBox.Show("Vui lòng nhập Họ Và Tên "); }
            else if (NgaySinh == null) { MessageBox.Show("Vui lòng chọn ngày sinh "); }
            
            else if (MatKhau.Trim() == "") { MessageBox.Show("Vui lòng nhập Mật Khẩu "); }
            else if (SoDienThoai.Trim() == "") { MessageBox.Show("Vui lòng nhập số điênh thoại "); }
       
            

            else
            {
                int maChucVu = 0;
                if (listChucVu != null)
                {
                    for (int i = 0; i < listChucVu.Count(); i++)
                    {
                        if (comboboxChucVu.SelectedIndex == i)
                        {
                            maChucVu = listChucVu[i].id;
                        }
                    }
                }

                int trangThaiTaiKhoan = 0;

                if(radioTrangThai.Checked == false)
                {
                    trangThaiTaiKhoan = 0;
                }
                else
                {
                    trangThaiTaiKhoan = 1;
                }
                NhanVien nv = new NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, dateTimeNgaySinh.Value, comboBoxGioiTinh.SelectedItem.ToString(), txtSoDienThoai.Text, rTBGhiChu.Text, DateTime.Now, maChucVu, txtMatKhau.Text, trangThaiTaiKhoan);


                NhanVienBLL nhanVienBLL = new NhanVienBLL();
                Boolean ktra = nhanVienBLL.themNhanVien(nv);
                if (ktra)
                {
                    MessageBox.Show("Thêm Thành công");
                    Load1();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }


           
            
            //nv.MaNhanVien=txtMaNhanVien.Text;
            //nv.ChucVu = comboboxChucVu.SelectedIndex;
            //nv.DiaChi = rTBGhiChu.Text;
            //nv.Gioitinh=comboBoxGioiTinh.SelectedText;
            //nv.MatKhau=txtMatKhau.Text;
            //nv.HoTen = txtTenNhanVien.Text;
            //nv.NgaySinh = dateTimeNgaySinh.Value;
            //nv.NgayLamViec = DateTime.Now;
            //nv.TrangThai = 0;
            //nv.SoDienThoai = txtSoDienThoai.Text;


        }

        //xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Boolean ktra = false;
            string manhanvien = txtMaNhanVien.Text;
            NhanVienBLL nhanVienBLL= new NhanVienBLL();
            ktra=nhanVienBLL.xoaNhanVien(manhanvien);
            if (ktra)
            {
                MessageBox.Show("Xóa Thành Công");
                Load1();
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công");
            } 
                
           
        }

       
        private void comboboxChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioTrangThai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text =null ;
            txtTenNhanVien.Text = null;
            dateTimeNgaySinh.Value = DateTime.Now;
            comboBoxGioiTinh.SelectedItem =1;
            rTBGhiChu.Text = null;
            txtSoDienThoai.Text = null;

            txtMatKhau.Text = null;
            comboboxChucVu.SelectedIndex = 0;

           
            radioTrangThai.Checked = false;
            Load1();
        }
        //Tìm Kiếm
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string stringtimkiem=txtTimKiem.Text;
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            dataGridView1.DataSource = nhanVienBLL.getListTimKiem(stringtimkiem);
        }
    }
}
