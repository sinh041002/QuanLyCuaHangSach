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
    public partial class Form1 : Form
    {
        bool isThoat = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isThoat = false;
           
            dangnhap formDangnhap = new dangnhap();

            formDangnhap.ShowDialog();
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            {
                System.Windows.Forms.Application.Exit();

            }
        }

<<<<<<< HEAD
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

=======
>>>>>>> c27d100f22b820e2a23d8b7b0b65e7f276c2f06c
        private void QLKhachHang_Click(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thoát chương trình", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
=======
>>>>>>> c27d100f22b820e2a23d8b7b0b65e7f276c2f06c
    }
}
