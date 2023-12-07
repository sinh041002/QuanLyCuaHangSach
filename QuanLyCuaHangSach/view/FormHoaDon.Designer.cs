namespace QuanLyCuaHangSach
{
    partial class FormHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.cbxMaHoaDon = new System.Windows.Forms.ComboBox();
            this.lblMaHoaDonTimKiem = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxMaKhachHang = new System.Windows.Forms.ComboBox();
            this.tbxDienThoai = new System.Windows.Forms.TextBox();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.tbxTenKhachHang = new System.Windows.Forms.TextBox();
            this.tbxTenNhanVien = new System.Windows.Forms.TextBox();
            this.cbxMaNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.tbxMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblNgayXuat = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMaGiamGia = new System.Windows.Forms.ComboBox();
            this.tbxTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgHoaDon = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();

            this.btnInHoaDon = new System.Windows.Forms.Button();

            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbxThanhTien = new System.Windows.Forms.TextBox();
            this.tbxDonGia = new System.Windows.Forms.TextBox();
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.cbxMaSach = new System.Windows.Forms.ComboBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxMaHoaDon
            // 
            this.cbxMaHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaHoaDon.FormattingEnabled = true;
            this.cbxMaHoaDon.Location = new System.Drawing.Point(147, 382);
            this.cbxMaHoaDon.Name = "cbxMaHoaDon";
            this.cbxMaHoaDon.Size = new System.Drawing.Size(299, 27);
            this.cbxMaHoaDon.TabIndex = 1;
            this.cbxMaHoaDon.SelectedIndexChanged += new System.EventHandler(this.cbxMaHoaDon_SelectedIndexChanged);
            // 
            // lblMaHoaDonTimKiem
            // 
            this.lblMaHoaDonTimKiem.AutoSize = true;
            this.lblMaHoaDonTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDonTimKiem.Location = new System.Drawing.Point(23, 390);
            this.lblMaHoaDonTimKiem.Name = "lblMaHoaDonTimKiem";
            this.lblMaHoaDonTimKiem.Size = new System.Drawing.Size(118, 19);
            this.lblMaHoaDonTimKiem.TabIndex = 0;
            this.lblMaHoaDonTimKiem.Text = "&Tìm kiếm hóa đơn";
            this.lblMaHoaDonTimKiem.Click += new System.EventHandler(this.lblMaHoaDonTimKiem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cbxMaHoaDon);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.lblMaHoaDonTimKiem);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1448, 713);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxMaKhachHang);
            this.groupBox1.Controls.Add(this.tbxDienThoai);
            this.groupBox1.Controls.Add(this.tbxDiaChi);
            this.groupBox1.Controls.Add(this.tbxTenKhachHang);
            this.groupBox1.Controls.Add(this.tbxTenNhanVien);
            this.groupBox1.Controls.Add(this.cbxMaNhanVien);
            this.groupBox1.Controls.Add(this.dtpNgayXuat);
            this.groupBox1.Controls.Add(this.tbxMaHoaDon);
            this.groupBox1.Controls.Add(this.lblTenKhachHang);
            this.groupBox1.Controls.Add(this.lblDiaChi);
            this.groupBox1.Controls.Add(this.lblDienThoai);
            this.groupBox1.Controls.Add(this.lblMaKhachHang);
            this.groupBox1.Controls.Add(this.lblTenNhanVien);
            this.groupBox1.Controls.Add(this.lblMaNhanVien);
            this.groupBox1.Controls.Add(this.lblNgayXuat);
            this.groupBox1.Controls.Add(this.lblMaHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1422, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cbxMaKhachHang
            // 
            this.cbxMaKhachHang.Enabled = false;
            this.cbxMaKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaKhachHang.FormattingEnabled = true;
            this.cbxMaKhachHang.Location = new System.Drawing.Point(1077, 37);
            this.cbxMaKhachHang.Name = "cbxMaKhachHang";
            this.cbxMaKhachHang.Size = new System.Drawing.Size(254, 27);
            this.cbxMaKhachHang.TabIndex = 16;
            this.cbxMaKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbxMaKhachHang_SelectedIndexChanged);
            // 
            // tbxDienThoai
            // 
            this.tbxDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDienThoai.Location = new System.Drawing.Point(1077, 198);
            this.tbxDienThoai.Name = "tbxDienThoai";
            this.tbxDienThoai.ReadOnly = true;
            this.tbxDienThoai.Size = new System.Drawing.Size(254, 26);
            this.tbxDienThoai.TabIndex = 15;
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiaChi.Location = new System.Drawing.Point(1077, 145);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.ReadOnly = true;
            this.tbxDiaChi.Size = new System.Drawing.Size(254, 26);
            this.tbxDiaChi.TabIndex = 14;
            // 
            // tbxTenKhachHang
            // 
            this.tbxTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenKhachHang.Location = new System.Drawing.Point(1077, 93);
            this.tbxTenKhachHang.Name = "tbxTenKhachHang";
            this.tbxTenKhachHang.ReadOnly = true;
            this.tbxTenKhachHang.Size = new System.Drawing.Size(254, 26);
            this.tbxTenKhachHang.TabIndex = 13;
            // 
            // tbxTenNhanVien
            // 
            this.tbxTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenNhanVien.Location = new System.Drawing.Point(150, 194);
            this.tbxTenNhanVien.Name = "tbxTenNhanVien";
            this.tbxTenNhanVien.ReadOnly = true;
            this.tbxTenNhanVien.Size = new System.Drawing.Size(254, 26);
            this.tbxTenNhanVien.TabIndex = 11;
            // 
            // cbxMaNhanVien
            // 
            this.cbxMaNhanVien.Enabled = false;
            this.cbxMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaNhanVien.FormattingEnabled = true;
            this.cbxMaNhanVien.Location = new System.Drawing.Point(150, 137);
            this.cbxMaNhanVien.Name = "cbxMaNhanVien";
            this.cbxMaNhanVien.Size = new System.Drawing.Size(254, 27);
            this.cbxMaNhanVien.TabIndex = 10;
            this.cbxMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbxMaNhanVien_SelectedIndexChanged);
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Enabled = false;
            this.dtpNgayXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXuat.Location = new System.Drawing.Point(150, 98);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(254, 26);
            this.dtpNgayXuat.TabIndex = 9;
            this.dtpNgayXuat.ValueChanged += new System.EventHandler(this.dtpNgayXuat_ValueChanged);
            // 
            // tbxMaHoaDon
            // 
            this.tbxMaHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaHoaDon.Location = new System.Drawing.Point(150, 49);
            this.tbxMaHoaDon.Name = "tbxMaHoaDon";
            this.tbxMaHoaDon.ReadOnly = true;
            this.tbxMaHoaDon.Size = new System.Drawing.Size(254, 26);
            this.tbxMaHoaDon.TabIndex = 8;
            this.tbxMaHoaDon.TextChanged += new System.EventHandler(this.tbxMaHoaDon_TextChanged);
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhachHang.Location = new System.Drawing.Point(945, 93);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(104, 19);
            this.lblTenKhachHang.TabIndex = 7;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(945, 146);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(51, 19);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.Location = new System.Drawing.Point(945, 199);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(70, 19);
            this.lblDienThoai.TabIndex = 5;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.Location = new System.Drawing.Point(945, 40);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(102, 19);
            this.lblMaKhachHang.TabIndex = 4;
            this.lblMaKhachHang.Text = "Mã khách hàng";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhanVien.Location = new System.Drawing.Point(26, 191);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(92, 19);
            this.lblTenNhanVien.TabIndex = 3;
            this.lblTenNhanVien.Text = "Tên nhân viên";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(26, 145);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(90, 19);
            this.lblMaNhanVien.TabIndex = 2;
            this.lblMaNhanVien.Text = "Mã nhân viên";
            // 
            // lblNgayXuat
            // 
            this.lblNgayXuat.AutoSize = true;
            this.lblNgayXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayXuat.Location = new System.Drawing.Point(26, 100);
            this.lblNgayXuat.Name = "lblNgayXuat";
            this.lblNgayXuat.Size = new System.Drawing.Size(71, 19);
            this.lblNgayXuat.TabIndex = 1;
            this.lblNgayXuat.Text = "Ngày xuất";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(26, 52);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(83, 19);
            this.lblMaHoaDon.TabIndex = 0;
            this.lblMaHoaDon.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(600, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxMaGiamGia);
            this.groupBox2.Controls.Add(this.tbxTongTien);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtgHoaDon);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1431, 373);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã giảm giá";
            // 
            // cbxMaGiamGia
            // 
            this.cbxMaGiamGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaGiamGia.FormattingEnabled = true;
            this.cbxMaGiamGia.Location = new System.Drawing.Point(159, 266);
            this.cbxMaGiamGia.Name = "cbxMaGiamGia";
            this.cbxMaGiamGia.Size = new System.Drawing.Size(254, 27);
            this.cbxMaGiamGia.TabIndex = 17;
            this.cbxMaGiamGia.SelectedIndexChanged += new System.EventHandler(this.cbxMaGiamGia_SelectedIndexChanged);
            // 
            // tbxTongTien
            // 
            this.tbxTongTien.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTongTien.Location = new System.Drawing.Point(1095, 263);
            this.tbxTongTien.Name = "tbxTongTien";
            this.tbxTongTien.ReadOnly = true;
            this.tbxTongTien.Size = new System.Drawing.Size(228, 32);
            this.tbxTongTien.TabIndex = 7;
            this.tbxTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(963, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng tiền:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dtgHoaDon
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHoaDon.Location = new System.Drawing.Point(0, 133);
            this.dtgHoaDon.Name = "dtgHoaDon";
            this.dtgHoaDon.ReadOnly = true;
            this.dtgHoaDon.RowHeadersWidth = 51;
            this.dtgHoaDon.Size = new System.Drawing.Size(1419, 118);
            this.dtgHoaDon.TabIndex = 3;
            this.dtgHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHoaDon_CellContentClick);
            // 
            // panel4
            // 

            this.panel4.Controls.Add(this.btnInHoaDon);

            this.panel4.Controls.Add(this.btnHuyHoaDon);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 308);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1425, 52);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 

            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.DarkCyan;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.Image")));
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(597, 16);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(115, 30);
            this.btnInHoaDon.TabIndex = 5;
            this.btnInHoaDon.Text = "&In hóa đơn";
            this.btnInHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 

            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHuyHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyHoaDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuyHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyHoaDon.Image")));
            this.btnHuyHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnHuyHoaDon.Location = new System.Drawing.Point(964, 16);

            this.btnHuyHoaDon.Location = new System.Drawing.Point(936, 22);

            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(115, 30);
            this.btnHuyHoaDon.TabIndex = 4;
            this.btnHuyHoaDon.Text = "&Hủy hóa đơn";
            this.btnHuyHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyHoaDon.UseVisualStyleBackColor = false;
            this.btnHuyHoaDon.Click += new System.EventHandler(this.btnXoaThongTin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbxThanhTien);
            this.panel3.Controls.Add(this.tbxDonGia);
            this.panel3.Controls.Add(this.tbxSoLuong);
            this.panel3.Controls.Add(this.cbxMaSach);
            this.panel3.Controls.Add(this.lblThanhTien);
            this.panel3.Controls.Add(this.lblDonGia);
            this.panel3.Controls.Add(this.lblSoLuong);
            this.panel3.Controls.Add(this.lblMaSach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(3, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1425, 100);
            this.panel3.TabIndex = 1;
            // 
            // tbxThanhTien
            // 
            this.tbxThanhTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxThanhTien.Location = new System.Drawing.Point(1092, 61);
            this.tbxThanhTien.Name = "tbxThanhTien";
            this.tbxThanhTien.ReadOnly = true;
            this.tbxThanhTien.Size = new System.Drawing.Size(254, 26);
            this.tbxThanhTien.TabIndex = 11;
            this.tbxThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxDonGia
            // 
            this.tbxDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDonGia.Location = new System.Drawing.Point(1092, 14);
            this.tbxDonGia.Name = "tbxDonGia";
            this.tbxDonGia.ReadOnly = true;
            this.tbxDonGia.Size = new System.Drawing.Size(254, 26);
            this.tbxDonGia.TabIndex = 10;
            this.tbxDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxDonGia.TextChanged += new System.EventHandler(this.tbxDonGia_TextChanged);
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Enabled = false;
            this.tbxSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSoLuong.Location = new System.Drawing.Point(156, 58);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.ReadOnly = true;
            this.tbxSoLuong.Size = new System.Drawing.Size(254, 26);
            this.tbxSoLuong.TabIndex = 7;
            this.tbxSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxSoLuong.TextChanged += new System.EventHandler(this.tbxSoLuong_TextChanged);
            // 
            // cbxMaSach
            // 
            this.cbxMaSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaSach.FormattingEnabled = true;
            this.cbxMaSach.Location = new System.Drawing.Point(156, 13);
            this.cbxMaSach.Name = "cbxMaSach";
            this.cbxMaSach.Size = new System.Drawing.Size(254, 27);
            this.cbxMaSach.TabIndex = 6;
            this.cbxMaSach.SelectedIndexChanged += new System.EventHandler(this.cbxMaSach_SelectedIndexChanged);
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(960, 59);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(71, 19);
            this.lblThanhTien.TabIndex = 5;
            this.lblThanhTien.Text = "Thành tiền";
            this.lblThanhTien.Click += new System.EventHandler(this.lblThanhTien_Click);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(960, 16);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(56, 19);
            this.lblDonGia.TabIndex = 4;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(32, 61);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(64, 19);
            this.lblSoLuong.TabIndex = 1;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.Location = new System.Drawing.Point(32, 21);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(61, 19);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã sách";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1425, 10);
            this.panel2.TabIndex = 0;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 713);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxMaHoaDon;
        private System.Windows.Forms.Label lblMaHoaDonTimKiem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNgayXuat;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.TextBox tbxDienThoai;
        private System.Windows.Forms.TextBox tbxDiaChi;
        private System.Windows.Forms.TextBox tbxTenKhachHang;
        private System.Windows.Forms.TextBox tbxTenNhanVien;
        private System.Windows.Forms.ComboBox cbxMaNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.TextBox tbxMaHoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox tbxThanhTien;
        private System.Windows.Forms.TextBox tbxDonGia;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.ComboBox cbxMaSach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgHoaDon;
        private System.Windows.Forms.TextBox tbxTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMaKhachHang;
        private System.Windows.Forms.Button btnHuyHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMaGiamGia;

        private System.Windows.Forms.Button btnInHoaDon;

    }
}