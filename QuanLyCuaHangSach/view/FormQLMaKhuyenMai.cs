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
    public partial class FormQLMaKhuyenMai : Form
    {
        public FormQLMaKhuyenMai()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            tbMaKM.Text = "";
            dtNgayBD.Value = DateTime.Now;
            dtNgayKT.Value = DateTime.Now;
            tbValue.Text = "";
        }

        SaleBLL _bll = new SaleBLL();
        BindingSource _src = new BindingSource();
        private void FormQLMaKhuyenMai_Load(object sender, EventArgs e)
        {
            gridData.AllowUserToAddRows = false;
            gridData.ReadOnly = true;
            gridData.AllowUserToResizeRows = false;
            gridData.DataSource = _src;
            LoadGridData();
        }

        private void LoadGridData()
        {
            _src.DataSource = _bll.GetSales();
            _src.ResetBindings(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbMaKM.Text, out int _maKM))
            {
                MessageBox.Show("Mã khuyến mại không hợp lệ ! Giá trị phải là kiểu số nguyên !");
                return;
            }

            if (_bll.TonTai(_maKM))
            {
                MessageBox.Show("Mã khuyến mại đã tồn tại !");
                return;
            }

            if (dtNgayKT.Value < dtNgayBD.Value)
            {
                MessageBox.Show("Ngày kết thúc khuyến mại phải lớn hơn ngày bắt đầu !");
                return;
            }

            if (!int.TryParse(tbValue.Text, out int _value))
            {
                MessageBox.Show("Giá trị khuyến mại không hợp lệ ! Giá trị phải là kiểu số nguyên !");
                return;
            }

            Sale obj = new Sale(
                _maKM, tbMoTa.Text, dtNgayBD.Value, dtNgayKT.Value, _value
            ); 

            bool result = _bll.Them(obj);
            
            if (result)
            {
                MessageBox.Show("Thêm mới mã khuyến mại thành công !");
                LoadGridData();
                return;
            }

            MessageBox.Show("Thêm mới mã khuyến mại không thành công !");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbMaKM.Text, out int _maKM))
            {
                MessageBox.Show("Mã khuyến mại không hợp lệ ! Giá trị phải là kiểu số nguyên !");
                return;
            }

            if (!_bll.TonTai(_maKM))
            {
                MessageBox.Show("Mã khuyến mại không tồn tại ! Vui lòng kiểm tra lại !");
                return;
            }

            if (dtNgayKT.Value < dtNgayBD.Value)
            {
                MessageBox.Show("Ngày kết thúc khuyến mại phải lớn hơn ngày bắt đầu !");
                return;
            }

            if (!int.TryParse(tbValue.Text, out int _value))
            {
                MessageBox.Show("Giá trị khuyến mại không hợp lệ ! Giá trị phải là kiểu số nguyên !");
                return;
            }

            Sale obj = new Sale(
                _maKM, tbMoTa.Text, dtNgayBD.Value, dtNgayKT.Value, _value
            );

            bool result = _bll.Sua(obj);

            if (result)
            {
                MessageBox.Show("Sửa thông tin mã khuyến mại thành công !");
                LoadGridData();
                return;
            }

            MessageBox.Show("Sửa thông tin mã khuyến mại không thành công !");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbMaKM.Text, out int _maKM))
            {
                MessageBox.Show("Mã khuyến mại không hợp lệ ! Giá trị phải là kiểu số nguyên !");
                return;
            }
            
            if (!_bll.TonTai(_maKM))
            {
                MessageBox.Show("Mã khuyến mại không tồn tại ! Vui lòng kiểm tra lại !");
                return;
            }

            if (MessageBox.Show("Bạn muốn xoá giá trị khuyến mại ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool result = _bll.Xoa(_maKM);

                if (result)
                {
                    MessageBox.Show("Xoá mã khuyến mại thành công !");
                    LoadGridData();
                    return;
                }

                MessageBox.Show("Xoá mã khuyến mại không thành công !");
            }     
        }

        private void gridData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridData.CurrentRow == null || gridData.CurrentRow.IsNewRow)
                return;
            Sale obj = gridData.CurrentRow.DataBoundItem as Sale;
            if (obj == null)
                return;
            Display(obj);
        }

        private void Display(Sale obj)
        {
            tbMaKM.Text = obj.Id.ToString();
            dtNgayBD.Value = obj.TimeStart;
            dtNgayKT.Value = obj.TimeEnd;
            tbValue.Text = obj.SaleOff.ToString();
        }
    }
}
