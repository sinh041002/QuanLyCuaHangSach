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
using BLL;

namespace QuanLyCuaHangSach.view
{
    public partial class QLNhanVien : Form
    {
        public static List<NhanVien> listNhanVien = null;

        public static List<ChuVu> listChucVu = null;
        public QLNhanVien()
        {
            InitializeComponent();
        }

   
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private  List<string> getChucVu()
        {
            ChucVuBLL chucVuBLL = new ChucVuBLL();
            List<string> chucVu = new List<string>();
            listChucVu = chucVuBLL.getChucVu();
            if(listChucVu != null)
            {
                for(int i=0; i < listChucVu.Count(); i++)
                {
                    chucVu.Add(listChucVu[i].TenChucVu);
                }
        
            }
            
            return chucVu ;
        }
        private List<string> getGioiTinh()
        {
            List<string> chucVu = new List<string>() { "Nam", "Nữ" };
            return chucVu;
        }
        private void Load1()
        {
            comboBoxGioiTinh.DataSource = getGioiTinh();
            comboboxChucVu.DataSource = getChucVu();
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
           listNhanVien=  nhanVienBLL.getListNhanVien();

            if(listNhanVien.Count > 0 )
            {
                dataGridView1.DataSource= listNhanVien;
            }
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            Load1();
        }

      

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            txtMaNhanVien.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenNhanVien.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimeNgaySinh.Value =(DateTime) dataGridView1.CurrentRow.Cells[2].Value;
             comboBoxGioiTinh.SelectedItem = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            rTBGhiChu.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSoDienThoai.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           
            txtMatKhau.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            int indexChucVu = (int)dataGridView1.CurrentRow.Cells[9].Value;

            if (listChucVu != null)
            {
                for (int i = 0; i < listChucVu.Count(); i++)
                {
                    if (listChucVu[i].id == indexChucVu)
                    {
                        comboboxChucVu.SelectedIndex = i;
                    }
                }
            }
           
            
           
            a = (int)dataGridView1.CurrentRow.Cells[8].Value;
            if (a == 1)
            {
                radioTrangThai.Checked = true;
            }else radioTrangThai.Checked=false;
            
       

        }

        //sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            int maChucVu = 0;
            if (listChucVu != null)
            {
                for (int i = 0; i < listChucVu.Count(); i++)
                {
                    if (comboboxChucVu.SelectedIndex == i)
                    {
                        maChucVu = listChucVu[i].id;
                    }
                }
            }
          
          
            int trangThaiTaiKhoan = 0;

            if (radioTrangThai.Checked == false)
            {
                trangThaiTaiKhoan = 0;
            }
            else
            {
                trangThaiTaiKhoan = 1;
            }
            NhanVien nv1 = new NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, dateTimeNgaySinh.Value, comboBoxGioiTinh.SelectedItem.ToString(), txtSoDienThoai.Text, rTBGhiChu.Text, DateTime.Now, maChucVu, txtMatKhau.Text, trangThaiTaiKhoan);


            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            Boolean ktra = nhanVienBLL.suaNhanVien(nv1);
            if (ktra)
            {
                MessageBox.Show("Sửa Thành công");
                Load1();
            }
            else
            {
                MessageBox.Show("Sửa không thành công");
            }
            Load1();
        }
            
        //thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
             string MaNhanVien = txtMaNhanVien.Text;
             string HoTen = txtTenNhanVien.Text;
            DateTime NgaySinh = dateTimeNgaySinh.Value;
         
            string SoDienThoai = txtSoDienThoai.Text;
            string DiaChi = rTBGhiChu.Text;

            string MatKhau = txtMatKhau.Text;
           
             int ChucVu = comboboxChucVu.SelectedIndex;


            if (MaNhanVien.Trim() == "") { MessageBox.Show("Vui lòng nhập Mã Nhân Viên "); }
            else if (HoTen.Trim() == "") { MessageBox.Show("Vui lòng nhập Họ Và Tên "); }
            else if (NgaySinh == null) { MessageBox.Show("Vui lòng chọn ngày sinh "); }
            
            else if (MatKhau.Trim() == "") { MessageBox.Show("Vui lòng nhập Mật Khẩu "); }
            else if (SoDienThoai.Trim() == "") { MessageBox.Show("Vui lòng nhập số điênh thoại "); }
       
            

            else
            {
                int maChucVu = 0;
                if (listChucVu != null)
                {
                    for (int i = 0; i < listChucVu.Count(); i++)
                    {
                        if (comboboxChucVu.SelectedIndex == i)
                        {
                            maChucVu = listChucVu[i].id;
                        }
                    }
                }

                int trangThaiTaiKhoan = 0;

                if(radioTrangThai.Checked == false)
                {
                    trangThaiTaiKhoan = 0;
                }
                else
                {
                    trangThaiTaiKhoan = 1;
                }
                NhanVien nv = new NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, dateTimeNgaySinh.Value, comboBoxGioiTinh.SelectedItem.ToString(), txtSoDienThoai.Text, rTBGhiChu.Text, DateTime.Now, maChucVu, txtMatKhau.Text, trangThaiTaiKhoan);


                NhanVienBLL nhanVienBLL = new NhanVienBLL();
                Boolean ktra = nhanVienBLL.themNhanVien(nv);
                if (ktra)
                {
                    MessageBox.Show("Thêm Thành công");
                    Load1();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }


           
            
            //nv.MaNhanVien=txtMaNhanVien.Text;
            //nv.ChucVu = comboboxChucVu.SelectedIndex;
            //nv.DiaChi = rTBGhiChu.Text;
            //nv.Gioitinh=comboBoxGioiTinh.SelectedText;
            //nv.MatKhau=txtMatKhau.Text;
            //nv.HoTen = txtTenNhanVien.Text;
            //nv.NgaySinh = dateTimeNgaySinh.Value;
            //nv.NgayLamViec = DateTime.Now;
            //nv.TrangThai = 0;
            //nv.SoDienThoai = txtSoDienThoai.Text;


        }

        //xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Boolean ktra = false;
            string manhanvien = txtMaNhanVien.Text;
            NhanVienBLL nhanVienBLL= new NhanVienBLL();
            ktra=nhanVienBLL.xoaNhanVien(manhanvien);
            if (ktra)
            {
                MessageBox.Show("Xóa Thành Công");
                Load1();
            }
            else
            {
                MessageBox.Show("Xóa Không Thành Công");
            } 
                
           
        }

       
        private void comboboxChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioTrangThai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text =null ;
            txtTenNhanVien.Text = null;
            dateTimeNgaySinh.Value = DateTime.Now;
            comboBoxGioiTinh.SelectedItem =1;
            rTBGhiChu.Text = null;
            txtSoDienThoai.Text = null;

            txtMatKhau.Text = null;
            comboboxChucVu.SelectedIndex = 0;

           
            radioTrangThai.Checked = false;
            Load1();
        }
        //Tìm Kiếm
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string stringtimkiem=txtTimKiem.Text;
            NhanVienBLL nhanVienBLL = new NhanVienBLL();
            dataGridView1.DataSource = nhanVienBLL.getListTimKiem(stringtimkiem);
        }

        public void ExportFile(DataTable dataTable, string sheetName, string title)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã nhân viên";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Họ tên";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Ngày sinh";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Giới tính";

            cl4.ColumnWidth = 10.5;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Số Điện Thoại";

            cl5.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Địa Chỉ";

            cl6.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Chức vụ";

            cl7.ColumnWidth = 13.5;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        private void BtnExport_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1= new DataColumn("Mã Nhân Viên");
            DataColumn col2 = new DataColumn("Tên nhân Viên");
            DataColumn col3 = new DataColumn("Ngày Sinh");
            DataColumn col4 = new DataColumn("Giới Tính ");
            DataColumn col5 = new DataColumn("Số Điện Thoại");
            DataColumn col6 = new DataColumn("Địa Chỉ");
            DataColumn col7 = new DataColumn("Chức Vụ");


            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);    
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);


            foreach (DataGridViewRow dtgvRow in dataGridView1.Rows)
            {
                DataRow dataRow = dataTable.NewRow();

                dataRow[0] = dtgvRow.Cells[0].Value;
                dataRow[1] = dtgvRow.Cells[1].Value;
                dataRow[2] = dtgvRow.Cells[2].Value;
                dataRow[3] = dtgvRow.Cells[3].Value;
                dataRow[4] = dtgvRow.Cells[4].Value;
                dataRow[5] = dtgvRow.Cells[5].Value;
              
                if(dtgvRow.Cells[9].Value != null)
                {
                    ChucVuBLL chucVuBLL = new ChucVuBLL();
                    string chucVu = "";
                    listChucVu = chucVuBLL.getChucVu();
                    if (listChucVu != null)
                    {          
                        for (int i = 0; i < listChucVu.Count(); i++)
                        {
                            if ((int)dtgvRow.Cells[9].Value == listChucVu[i].id)
                            {
                                chucVu = listChucVu[i].TenChucVu;
                            }
                        }
                        dataRow[6] = chucVu;
                    }
                }
               
                dataTable.Rows.Add(dataRow);
            }

            ExportFile(dataTable, "Danh Sách", "Danh Sách Nhân Viên");
        }
    }
}
