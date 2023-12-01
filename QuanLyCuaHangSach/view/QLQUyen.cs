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
    public partial class QLQUyen : Form
    {
        public static List<QuyenDTO> listQuyen = null;
        public QLQUyen()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Load1()
        {
           
            QuyenBLL nhanVienBLL = new QuyenBLL();
            listQuyen = nhanVienBLL.getListQuyen();

            if (listQuyen.Count > 0)
            {
                dataQuyen.DataSource = listQuyen;
            }

        }
        private void QLQUyen_Load(object sender, EventArgs e)
        {
           Load1();

        }

        private void dataQuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaQuyen.Text = dataQuyen.CurrentRow.Cells[0].Value.ToString();
            TenQuyen.Text = dataQuyen.CurrentRow.Cells[1].Value.ToString();
            if((int)dataQuyen.CurrentRow.Cells[2].Value==1)
            {
                cBQLKhachHang.Checked = true;
            }
            if ((int)dataQuyen.CurrentRow.Cells[3].Value == 1)
            {
                cBQLNhanVien.Checked = true;
            }
            if ((int)dataQuyen.CurrentRow.Cells[4].Value == 1)
            {
                cBQLQuyen.Checked = true;
            }
            if ((int)dataQuyen.CurrentRow.Cells[5].Value == 1)
            {
                cBQLKhuyenMai.Checked = true;
            }
            if ((int)dataQuyen.CurrentRow.Cells[6].Value == 1)
            {
                cBQLSach.Checked = true;
            }
            if ((int)dataQuyen.CurrentRow.Cells[7].Value == 1)
            {
                cBQLHoaDon.Checked = true;
            }
            if ((int)dataQuyen.CurrentRow.Cells[8].Value == 1)
            {
                cBBanHang.Checked = true;
            }
            if ((int)dataQuyen.CurrentRow.Cells[9].Value == 1)
            {cBQLThongKe.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
