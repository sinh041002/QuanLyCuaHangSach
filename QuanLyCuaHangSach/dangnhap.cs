using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace QuanLyCuaHangSach
{
    public partial class dangnhap : Form
    {
        public static NhanVien NhanVien = null;
        public dangnhap()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.Hide();
            FormHoaDon form =  new FormHoaDon();
            form.ShowDialog();
            this.Show();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
=======
            string tenTK = TxtTaiKhoan.Text;
            string MatKhau = TxtMatKhau.Text;

            if (tenTK.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản "); }
            else if (MatKhau.Trim() == "") { MessageBox.Show("Vui lòng nhập Mật Khẩu "); }

            else
            {
                DangNhapBLL dangNhapBLL = new DangNhapBLL();
                NhanVien = dangNhapBLL.getLogin(tenTK, MatKhau);
                if (NhanVien == null)
                {
                    MessageBox.Show("Nhập sai tên tài khoản hoặc mật khẩu");

                }
                else
                {
                    MessageBox.Show("đăng nhập thành công");
                    this.Hide();
                    QLCuaHangSach form1 = new QLCuaHangSach();
                    form1.phanquyen(NhanVien);
                    form1.StartPosition = FormStartPosition.CenterScreen;
                    form1.ShowDialog();
                    
                    this.Close();
                }
            }
          
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
>>>>>>> c27d100f22b820e2a23d8b7b0b65e7f276c2f06c
        {

        }

<<<<<<< HEAD
=======
        private void TextBox2_TextChanged(object sender, EventArgs e)
       {

        }

>>>>>>> c27d100f22b820e2a23d8b7b0b65e7f276c2f06c
        private void label1_Click(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
=======

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
>>>>>>> c27d100f22b820e2a23d8b7b0b65e7f276c2f06c
    }
}
