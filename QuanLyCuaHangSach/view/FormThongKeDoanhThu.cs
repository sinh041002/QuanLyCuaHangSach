using BLL;
using DTO;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCuaHangSach.view
{
    public partial class FormThongKeDoanhThu : Form
    {
        public FormThongKeDoanhThu()
        {
            InitializeComponent();
        }

        ThongKeBUS _bus = new ThongKeBUS();
        List<TKDoanhThuViewModel> listdoanhThu = new List<TKDoanhThuViewModel>();
        BindingSource _src = new BindingSource();

        private void btnBatDau_Click(object sender, EventArgs e)
        {


            listdoanhThu = _bus.LayDoanhThu(dtTuNgay.Value, dtDenNgay.Value);

            dataGridView1.DataSource = listdoanhThu;


        }

        private void FormThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            dtTuNgay.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtDenNgay.Value = DateTime.Now;
            rdoThangTruoc.Checked = false;
            rdoThangNay.Checked = false;
            rdo15NgayTruoc.Checked = false;
            rdoTrongNgay.Checked = false;
           


        }

        public void loadbieuDo(int nam)
           
        {
            
                chartDoanhThu.Series.Clear();
                chartDoanhThu.Series.Add("CharCot");

            for(int i = 1; i < 13; i++)
            {

                long tongDoanhthu = _bus.LayTongTienThang(i,nam);
                chartDoanhThu.Series["CharCot"].Points.Add(tongDoanhthu);
                string mysitrn=tongDoanhthu.ToString();
                chartDoanhThu.Series["CharCot"].Points[i-1].Label= mysitrn;
                chartDoanhThu.Series["CharCot"].Points[i-1].Color = Color.Blue;
                chartDoanhThu.Series["CharCot"].Points[i-1].AxisLabel = "Tháng " + i;
            }
            
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

        private void gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComBoBoxThongKE_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a= ComBoBoxThongKE.SelectedItem.ToString();
            loadbieuDo(Int32.Parse(a));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
