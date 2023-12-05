using BLL;
using Microsoft.Reporting.WinForms;
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
    public partial class PrintNhanVien : Form
    {
        
        public PrintNhanVien()
        {
            InitializeComponent();
        }

        private void Print_Load(object sender, EventArgs e)
        {
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            DataTable ds = nhanVienBLL.GetAllNhanVien();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds;
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

          
        }
    }
}
