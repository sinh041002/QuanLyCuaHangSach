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
    public partial class LichSuChinhSuaNhanVien : Form
    {
        public LichSuChinhSuaNhanVien()
        {
            InitializeComponent();
        }

        private void Load1()
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            DataTable dt = new DataTable();
            dt = nhanVienBLL.GetLichSuChinhSua();
            dataChinhSua.DataSource = dt;
        }
        private void LichSuChinhSuaNhanVien_Load(object sender, EventArgs e)
        {
           Load1();
        }

        private void btnTimKiemLs_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimKiem.Text;
            Load1();
            //NhanVienBLL nhanVienBLL = new NhanVienBLL();
            //dataChinhSua.DataSource = nhanVienBLL.getListTimLiemChinhSua(timkiem);
            String searchValue = timkiem;
            int rowIndex = -1;
           
            foreach (DataGridViewRow row in dataChinhSua.Rows)
            {
                if (row.Cells["MaNhanVienThaoTac"].Value != null) // Need to check for null if new row is exposed
                {
                    if (row.Cells["MaNhanVienThaoTac"].Value.ToString().Contains(searchValue)==false && row.Cells["abc"].Value.ToString().Contains(searchValue) == false)
                    {
                        rowIndex = row.Index;
                  
                        dataChinhSua.Rows.RemoveAt(row.Index);
                       
                    }
                }
             
            }

            //foreach (DataGridViewRow row in dataChinhSua.Rows)
            //{
            //    if (row.Cells["abc"].Value != null) // Need to check for null if new row is exposed
            //    {
            //        if (row.Cells["abc"].Value.ToString().Contains(searchValue) == false)
            //        {
            //            rowIndex = row.Index;

            //            dataChinhSua.Rows.RemoveAt(rowIndex);

            //        }
            //    }

            //}
         
        }

       
    }
}
