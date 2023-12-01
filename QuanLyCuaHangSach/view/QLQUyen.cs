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

        //public QuyenDTO getItemQuyen(int maQuyen)
        //{
        //    QuyenDTO items = new QuyenDTO();
        //    QuyenBLL quyenBLL = new QuyenBLL();
        //    items=quyenBLL.GetItemQuyen(maQuyen);
        //    return items;
        //}
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
            else
            {
                cBQLKhachHang.Checked =false;
            }
            if ((int)dataQuyen.CurrentRow.Cells[3].Value == 1)
            {
                cBQLNhanVien.Checked = true;
            }
            else { cBQLNhanVien.Checked = false; }
            if ((int)dataQuyen.CurrentRow.Cells[4].Value == 1)
            {
                cBQLQuyen.Checked = true;
            }
            else { cBQLQuyen.Checked = false; }
            if ((int)dataQuyen.CurrentRow.Cells[5].Value == 1)
            {
                cBQLKhuyenMai.Checked = true;
            }
            else { cBQLKhuyenMai.Checked = false; }
            if ((int)dataQuyen.CurrentRow.Cells[6].Value == 1)
            {
                cBQLSach.Checked = true;
            }
            else { cBQLSach.Checked = false; }
            if ((int)dataQuyen.CurrentRow.Cells[7].Value == 1)
            {
                cBQLHoaDon.Checked = true;
            }
            else { cBQLHoaDon.Checked = false; }
            if ((int)dataQuyen.CurrentRow.Cells[8].Value == 1)
            {
                cBBanHang.Checked = true;
            }
            else { cBBanHang.Checked = false; }
            if ((int)dataQuyen.CurrentRow.Cells[9].Value == 1)
            {
                cBQLThongKe.Checked = true;
            }
            else { cBQLThongKe.Checked = false; }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuyenDTO quyenDTO = new QuyenDTO();
            quyenDTO.MaQuyen = int.Parse(txtMaQuyen.Text);
            QuyenBLL nhanVienBLL = new QuyenBLL();
            listQuyen = nhanVienBLL.getListQuyen();
            for(int i = 0; i < listQuyen.Count(); i++)
            {
               if( quyenDTO.MaQuyen == listQuyen[i].MaQuyen)
                {
                    MessageBox.Show("MÃ quyền đã tồn tại");
                    return;
                }    
            }
           
            quyenDTO.TenQuyen= TenQuyen.Text ;
            TenQuyen.Text = dataQuyen.CurrentRow.Cells[1].Value.ToString();
            if (cBQLKhachHang.Checked == true )
            {
                quyenDTO.QLKhachHang = 1;
            }else
            {
                quyenDTO.QLKhachHang = 0;
            }
            if (cBQLNhanVien.Checked == true)
            {
                quyenDTO.QLNhanVien = 1;
            }
            else
            {
                quyenDTO.QLNhanVien = 0;
            }
            if (cBQLQuyen.Checked == true)
            {
                quyenDTO.QLQuyen = 1;
            }
            else
            {
                quyenDTO.QLQuyen = 0;
            }
            if (cBQLKhuyenMai.Checked == true)
            {
                quyenDTO.QLKhuyenMai = 1;
            }
            else
            {
                quyenDTO.QLKhuyenMai = 0;
            }
            if (cBQLSach.Checked == true)
            {
                quyenDTO.QLSach = 1;
            }
            else
            {
                quyenDTO.QLSach = 0;
            }
            if (cBQLHoaDon.Checked == true)
            {
                quyenDTO.QLHoaDon = 1;
            }
            else
            {
                quyenDTO.QLHoaDon = 0;
            }
            if (cBBanHang.Checked == true)
            {
                quyenDTO.BanHang = 1;
            }
            else
            {
                quyenDTO.BanHang = 0;
            }
            if (cBQLThongKe.Checked == true)
            {
                quyenDTO.QLThongKe = 1;
            }
            else
            {
                quyenDTO.QLThongKe = 0;
            }

            QuyenBLL quyenBLL = new QuyenBLL();
           Boolean a=  quyenBLL.themQuyen(quyenDTO);

            if (a == true)
            {
                MessageBox.Show("Thêm Thành công");
                Load1();
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QuyenDTO quyenDTO = new QuyenDTO();
            quyenDTO.MaQuyen = int.Parse(txtMaQuyen.Text);
            QuyenBLL nhanVienBLL = new QuyenBLL();
            listQuyen = nhanVienBLL.getListQuyen();
           

            quyenDTO.TenQuyen = TenQuyen.Text;
            TenQuyen.Text = dataQuyen.CurrentRow.Cells[1].Value.ToString();
            if (cBQLKhachHang.Checked == true)
            {
                quyenDTO.QLKhachHang = 1;
            }
            else
            {
                quyenDTO.QLKhachHang = 0;
            }
            if (cBQLNhanVien.Checked == true)
            {
                quyenDTO.QLNhanVien = 1;
            }
            else
            {
                quyenDTO.QLNhanVien = 0;
            }
            if (cBQLQuyen.Checked == true)
            {
                quyenDTO.QLQuyen = 1;
            }
            else
            {
                quyenDTO.QLQuyen = 0;
            }
            if (cBQLKhuyenMai.Checked == true)
            {
                quyenDTO.QLKhuyenMai = 1;
            }
            else
            {
                quyenDTO.QLKhuyenMai = 0;
            }
            if (cBQLSach.Checked == true)
            {
                quyenDTO.QLSach = 1;
            }
            else
            {
                quyenDTO.QLSach = 0;
            }
            if (cBQLHoaDon.Checked == true)
            {
                quyenDTO.QLHoaDon = 1;
            }
            else
            {
                quyenDTO.QLHoaDon = 0;
            }
            if (cBBanHang.Checked == true)
            {
                quyenDTO.BanHang = 1;
            }
            else
            {
                quyenDTO.BanHang = 0;
            }
            if (cBQLThongKe.Checked == true)
            {
                quyenDTO.QLThongKe = 1;
            }
            else
            {
                quyenDTO.QLThongKe = 0;
            }

            QuyenBLL quyenBLL = new QuyenBLL();
            Boolean a = quyenBLL.suaQuyen(quyenDTO);

            if (a == true)
            {
                MessageBox.Show("Sửa Thành công");
                Load1();
            }
            else
            {
                MessageBox.Show("Sửa Thất Bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuyenBLL quyenBLL   =new QuyenBLL();
            int maquyen = int.Parse(txtMaQuyen.Text);
           Boolean kt=  quyenBLL.xoaQuyen(maquyen);
            if(kt == true)
            {
                MessageBox.Show("Xóa Thành Công ");
                Load1();

            }
            else
            {
                MessageBox.Show("Xóa Thất Bại ");
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaQuyen.Text = null;
            TenQuyen.Text = null;
            cBBanHang.Checked = false;
            cBQLKhachHang.Checked = false;
            cBQLNhanVien.Checked = false;
            cBQLQuyen.Checked = false;
            cBQLKhuyenMai.Checked = false;
            cBQLSach.Checked = false;
            cBQLHoaDon.Checked = false;
            cBQLThongKe.Checked = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
