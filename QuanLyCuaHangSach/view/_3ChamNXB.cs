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
    public partial class _3ChamNXB : Form
    {
        public static string id, name;
        NxbBLL nxbBLL = new NxbBLL();
        public _3ChamNXB()
        {
            InitializeComponent();
            GetAllNXB();
        }
        public void GetAllNXB()
        {
            dgv3ChamNXB.DataSource =  nxbBLL.GetAllNXB();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = dgv3ChamNXB.CurrentRow.Index;
            if (i >= 0)
            {
                id = dgv3ChamNXB.Rows[i].Cells[0].Value.ToString();
                name = dgv3ChamNXB.Rows[i].Cells[1].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hình như bạn chưa chọn vào danh mục", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
