using BLL;
using DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCuaHangSach.view
{
    public partial class FormThongKeSPBanChay : Form
    {
        public FormThongKeSPBanChay()
        {
            InitializeComponent();
        }

        ThongKeBUS _bus = new ThongKeBUS();
        BindingSource _src = new BindingSource();

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            _src.DataSource = _bus.LaySPBanChay(dtTuNgay.Value, dtDenNgay.Value);
            _src.ResetBindings(true);
            LoadCharPie();
        }

        private void LoadCharPie()
        {

            Dictionary<string, Double> tags = new Dictionary<string, Double>();
            List<TKSPBanChayViewModel> listThongkeSanPham=new List<TKSPBanChayViewModel>();
            CharPie.Series[0].Points.Clear();
            CharPie.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            listThongkeSanPham = _bus.LaySPBanChay(dtTuNgay.Value, dtDenNgay.Value);
            for (int i = 0; listThongkeSanPham.Count > i; i++)
            {
                var n1 = listThongkeSanPham[i].MaSach;
                var n2 = listThongkeSanPham[i].SLBan;

                CharPie.Series[0].Points.AddXY(n1, n2);

              

            }

        }

        private void FormThongKeSPBanChay_Load(object sender, EventArgs e)
        {
            dtTuNgay.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtDenNgay.Value = DateTime.Now;
            rdoThangTruoc.Checked = false;
            rdoThangNay.Checked = false;
            rdo15NgayTruoc.Checked = false;
            rdoTrongNgay.Checked = false;
            gridData.DataSource = _src;

        }

        private void rdoThangTruoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThangTruoc.Checked)
            {
                DateTime pre = DateTime.Now.AddMonths(-1);
                DateTime firstDayOfPrev = new DateTime(pre.Year, pre.Month, 1);
                DateTime lastDayOfPrev = firstDayOfPrev.AddMonths(1).AddDays(-1);
                dtTuNgay.Value = firstDayOfPrev;
                dtDenNgay.Value = lastDayOfPrev;
            }
        }

        private void rdoThangNay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoThangNay.Checked)
            {
                DateTime pre = DateTime.Now;
                DateTime firstDayOfPrev = new DateTime(pre.Year, pre.Month, 1);
                DateTime lastDayOfPrev = DateTime.Now;
                dtTuNgay.Value = firstDayOfPrev;
                dtDenNgay.Value = lastDayOfPrev;
            }
        }

        private void rdo15NgayTruoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo15NgayTruoc.Checked)
            {
                DateTime firstDayOfPrev = DateTime.Now.AddDays(-15);
                DateTime lastDayOfPrev = DateTime.Now;
                dtTuNgay.Value = firstDayOfPrev;
                dtDenNgay.Value = lastDayOfPrev;
            }
        }

        private void rdoTrongNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTrongNgay.Checked)
            {
                DateTime firstDayOfPrev = DateTime.Now;
                DateTime lastDayOfPrev = DateTime.Now;
                dtTuNgay.Value = firstDayOfPrev;
                dtDenNgay.Value = lastDayOfPrev;
            }
        }
    }
}
