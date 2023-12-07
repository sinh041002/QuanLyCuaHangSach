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
    public partial class _3ChamNCC : Form
    {
        NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
        public static string id, name;
        public _3ChamNCC()
        {
            InitializeComponent();
        }
        public void GetAllNcc()
        {
            dgv3ChamNCC.DataSource = nhaCungCapBLL.GetAllNcc();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = dgv3ChamNCC.CurrentRow.Index;
            if (i >=0&&i!=null)
            {
                id = dgv3ChamNCC.Rows[i].Cells[0].Value.ToString();
                name = dgv3ChamNCC.Rows[i].Cells[1].Value.ToString();
                this.Close();
            }
            else 
            {
                MessageBox.Show("Hình như bạn chưa chọn vào danh mục", "Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Stop);               
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
