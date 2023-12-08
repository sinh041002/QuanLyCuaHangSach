using BLL;
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
    public partial class _DialogKhuyenMai : Form
    {
        public static string SaleOff;
        public static DateTime TimeStart;
        public static DateTime TimeEnd;

        SaleBLL sale = new SaleBLL();
        public _DialogKhuyenMai()
        {
            InitializeComponent();
            GetSale();
        }
        public void GetSale()
        {
            dgvKhuyenMai.DataSource = sale.GetSales();
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = dgvKhuyenMai.CurrentRow.Index;
            if (i >= 0)
            {
                TimeStart = (DateTime)dgvKhuyenMai.Rows[i].Cells[2].Value;
                TimeEnd = (DateTime)dgvKhuyenMai.Rows[i].Cells[3].Value;
                if (TimeStart > DateTime.Now)
                {
                    MessageBox.Show("Khuyến mãi này chưa bắt đầu !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (TimeEnd < DateTime.Now)
                {
                    MessageBox.Show("Khuyến mãi đã kết thúc !!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                SaleOff = dgvKhuyenMai.Rows[i].Cells[4].Value.ToString();
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SaleOff = "0";
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            dgvKhuyenMai.DataSource = sale.GetSales();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
