using System.Windows.Forms;

namespace QuanLyCuaHangSach.view
{
    partial class MuaHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuaHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoLuongConLai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSanPham = new System.Windows.Forms.PictureBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTongTienKM = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnKhuyenMai = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.zzzz = new System.Windows.Forms.Label();
            this.btnMuaHang = new System.Windows.Forms.Button();
            this.btnXoaGioHang = new System.Windows.Forms.Button();
            this.dgvGio = new System.Windows.Forms.DataGridView();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbLoc = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSanPham)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGio)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaSanPham);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtTenLoai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoLuongConLai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenSanPham);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbSanPham);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(130, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaSanPham.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtMaSanPham.Location = new System.Drawing.Point(375, 28);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.ReadOnly = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(239, 26);
            this.txtMaSanPham.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(243, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 19);
            this.label15.TabIndex = 13;
            this.label15.Text = "Mã Sản Phẩm";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenLoai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTenLoai.Location = new System.Drawing.Point(375, 152);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.ReadOnly = true;
            this.txtTenLoai.Size = new System.Drawing.Size(239, 26);
            this.txtTenLoai.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(242, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại Sản Phẩm";
            // 
            // txtSoLuongConLai
            // 
            this.txtSoLuongConLai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoLuongConLai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSoLuongConLai.Location = new System.Drawing.Point(375, 121);
            this.txtSoLuongConLai.Name = "txtSoLuongConLai";
            this.txtSoLuongConLai.ReadOnly = true;
            this.txtSoLuongConLai.Size = new System.Drawing.Size(239, 26);
            this.txtSoLuongConLai.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(242, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Lượng Còn Lại";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtDonGia.Location = new System.Drawing.Point(375, 90);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(239, 26);
            this.txtDonGia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(242, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn Giá";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenSanPham.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTenSanPham.Location = new System.Drawing.Point(375, 59);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.ReadOnly = true;
            this.txtTenSanPham.Size = new System.Drawing.Size(239, 26);
            this.txtTenSanPham.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(242, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // pbSanPham
            // 
            this.pbSanPham.Location = new System.Drawing.Point(22, 28);
            this.pbSanPham.Name = "pbSanPham";
            this.pbSanPham.Size = new System.Drawing.Size(190, 228);
            this.pbSanPham.TabIndex = 0;
            this.pbSanPham.TabStop = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtSoLuong.Location = new System.Drawing.Point(457, 332);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(147, 26);
            this.txtSoLuong.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(288, 335);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 19);
            this.label14.TabIndex = 11;
            this.label14.Text = "Số Lượng Muốn Mua";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTongTienKM);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.dtpNgayTao);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnKhuyenMai);
            this.groupBox2.Controls.Add(this.btnKhachHang);
            this.groupBox2.Controls.Add(this.btnNhanVien);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.zzzz);
            this.groupBox2.Controls.Add(this.btnMuaHang);
            this.groupBox2.Controls.Add(this.btnXoaGioHang);
            this.groupBox2.Controls.Add(this.dgvGio);
            this.groupBox2.Controls.Add(this.txtKhuyenMai);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtKhachHang);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMaKhachHang);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNhanVien);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMaNhanVien);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(793, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 670);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Giao Hàng";
            // 
            // txtTongTienKM
            // 
            this.txtTongTienKM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTongTienKM.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTongTienKM.Location = new System.Drawing.Point(245, 537);
            this.txtTongTienKM.Name = "txtTongTienKM";
            this.txtTongTienKM.ReadOnly = true;
            this.txtTongTienKM.Size = new System.Drawing.Size(310, 26);
            this.txtTongTienKM.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label16.Location = new System.Drawing.Point(70, 540);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(173, 19);
            this.label16.TabIndex = 33;
            this.label16.Text = "Tổng Tiền Đã K/M (VND)";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(228, 184);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(188, 26);
            this.dtpNgayTao.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label13.Location = new System.Drawing.Point(70, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Ngày Tạo";
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnKhuyenMai.Location = new System.Drawing.Point(524, 153);
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Size = new System.Drawing.Size(32, 25);
            this.btnKhuyenMai.TabIndex = 30;
            this.btnKhuyenMai.Text = "...";
            this.btnKhuyenMai.UseVisualStyleBackColor = true;
            this.btnKhuyenMai.Click += new System.EventHandler(this.btnKhuyenMai_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnKhachHang.Location = new System.Drawing.Point(523, 91);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(32, 25);
            this.btnKhachHang.TabIndex = 29;
            this.btnKhachHang.Text = "...";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnNhanVien.Location = new System.Drawing.Point(524, 29);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(32, 25);
            this.btnNhanVien.TabIndex = 28;
            this.btnNhanVien.Text = "...";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTongTien.Location = new System.Drawing.Point(245, 488);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(310, 26);
            this.txtTongTien.TabIndex = 27;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // zzzz
            // 
            this.zzzz.AutoSize = true;
            this.zzzz.BackColor = System.Drawing.Color.Transparent;
            this.zzzz.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.zzzz.Location = new System.Drawing.Point(71, 488);
            this.zzzz.Name = "zzzz";
            this.zzzz.Size = new System.Drawing.Size(121, 19);
            this.zzzz.TabIndex = 26;
            this.zzzz.Text = "Tổng Tiền (VND) ";
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnMuaHang.Image = ((System.Drawing.Image)(resources.GetObject("btnMuaHang.Image")));
            this.btnMuaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuaHang.Location = new System.Drawing.Point(373, 605);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.Size = new System.Drawing.Size(104, 31);
            this.btnMuaHang.TabIndex = 25;
            this.btnMuaHang.Text = "Mua Hàng";
            this.btnMuaHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMuaHang.UseVisualStyleBackColor = true;
            this.btnMuaHang.Click += new System.EventHandler(this.btnMuaHang_Click);
            // 
            // btnXoaGioHang
            // 
            this.btnXoaGioHang.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnXoaGioHang.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaGioHang.Image")));
            this.btnXoaGioHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaGioHang.Location = new System.Drawing.Point(185, 605);
            this.btnXoaGioHang.Name = "btnXoaGioHang";
            this.btnXoaGioHang.Size = new System.Drawing.Size(67, 31);
            this.btnXoaGioHang.TabIndex = 24;
            this.btnXoaGioHang.Text = "Xóa";
            this.btnXoaGioHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaGioHang.UseVisualStyleBackColor = true;
            this.btnXoaGioHang.Click += new System.EventHandler(this.btnXoaGioHang_Click);
            // 
            // dgvGio
            // 
            this.dgvGio.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGio.Location = new System.Drawing.Point(47, 239);
            this.dgvGio.MultiSelect = false;
            this.dgvGio.Name = "dgvGio";
            this.dgvGio.ReadOnly = true;
            this.dgvGio.RowHeadersWidth = 51;
            this.dgvGio.RowTemplate.Height = 25;
            this.dgvGio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGio.Size = new System.Drawing.Size(539, 225);
            this.dgvGio.TabIndex = 23;
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKhuyenMai.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtKhuyenMai.Location = new System.Drawing.Point(228, 153);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.ReadOnly = true;
            this.txtKhuyenMai.Size = new System.Drawing.Size(276, 26);
            this.txtKhuyenMai.TabIndex = 20;
            this.txtKhuyenMai.TextChanged += new System.EventHandler(this.txtKhuyenMai_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label10.Location = new System.Drawing.Point(70, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Khuyến Mãi";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtKhachHang.Location = new System.Drawing.Point(228, 122);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.ReadOnly = true;
            this.txtKhachHang.Size = new System.Drawing.Size(276, 26);
            this.txtKhachHang.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label9.Location = new System.Drawing.Point(70, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tên Khách Hàng";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtMaKhachHang.Location = new System.Drawing.Point(228, 91);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(276, 26);
            this.txtMaKhachHang.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label8.Location = new System.Drawing.Point(70, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã Khách Hàng";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtNhanVien.Location = new System.Drawing.Point(228, 60);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(276, 26);
            this.txtNhanVien.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label7.Location = new System.Drawing.Point(70, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên Nhân Viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtMaNhanVien.Location = new System.Drawing.Point(228, 29);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(276, 26);
            this.txtMaNhanVien.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label6.Location = new System.Drawing.Point(70, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã Nhân Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSanPham);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(126, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(618, 248);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Sản Phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.productname,
            this.category,
            this.Price,
            this.stock,
            this.CategoryName,
            this.Img});
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(3, 22);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 25;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(612, 223);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "MaSach";
            this.id.HeaderText = "Mã sách";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 108;
            // 
            // productname
            // 
            this.productname.DataPropertyName = "TenSach";
            this.productname.HeaderText = "Tên Sản Phẩm";
            this.productname.MinimumWidth = 6;
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            this.productname.Width = 108;
            // 
            // category
            // 
            this.category.DataPropertyName = "TenTheLoai";
            this.category.HeaderText = "Loại";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "DonGiaXuat";
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 107;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "SoLuong";
            this.stock.HeaderText = "Số lượng còn lại";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 108;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryName.DataPropertyName = "Id1";
            this.CategoryName.HeaderText = "Tên Hãng";
            this.CategoryName.MinimumWidth = 6;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // Img
            // 
            this.Img.DataPropertyName = "Image";
            this.Img.HeaderText = "Image";
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label11.Location = new System.Drawing.Point(223, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "Lọc";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtNameSearch.Location = new System.Drawing.Point(495, 374);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(148, 26);
            this.txtNameSearch.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label12.Location = new System.Drawing.Point(430, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 19);
            this.label12.TabIndex = 33;
            this.label12.Text = "Từ Khóa";
            // 
            // cbbLoc
            // 
            this.cbbLoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbbLoc.FormattingEnabled = true;
            this.cbbLoc.Items.AddRange(new object[] {
            "Tất Cả",
            "Tên Sản Phẩm",
            "Danh Mục"});
            this.cbbLoc.Location = new System.Drawing.Point(259, 376);
            this.cbbLoc.Name = "cbbLoc";
            this.cbbLoc.Size = new System.Drawing.Size(152, 27);
            this.cbbLoc.TabIndex = 35;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(663, 373);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(63, 28);
            this.btnLoc.TabIndex = 36;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnThemVaoGio.Image = ((System.Drawing.Image)(resources.GetObject("btnThemVaoGio.Image")));
            this.btnThemVaoGio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemVaoGio.Location = new System.Drawing.Point(308, 675);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(235, 34);
            this.btnThemVaoGio.TabIndex = 37;
            this.btnThemVaoGio.Text = "Thêm Sản Phẩm Vào Giỏ Hàng";
            this.btnThemVaoGio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVaoGio.UseVisualStyleBackColor = true;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Giá";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Verdana", 24.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(704, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(195, 40);
            this.label17.TabIndex = 38;
            this.label17.Text = "Cửa Hàng";
            // 
            // MuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 769);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnThemVaoGio);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cbbLoc);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MuaHang";
            this.Text = "MuaHang";
            this.Load += new System.EventHandler(this.MuaHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSanPham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGio)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTenSanPham;
        private Label label1;
        private PictureBox pbSanPham;
        private TextBox txtTenLoai;
        private Label label4;
        private TextBox txtSoLuongConLai;
        private Label label3;
        private TextBox txtDonGia;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dgvGio;
        private TextBox txtKhuyenMai;
        private Label label10;
        private TextBox txtKhachHang;
        private Label label9;
        private TextBox txtMaKhachHang;
        private Label label8;
        private TextBox txtNhanVien;
        private Label label7;
        private TextBox txtMaNhanVien;
        private Label label6;
        private GroupBox groupBox3;
        private Button btnKhuyenMai;
        private Button btnKhachHang;
        private Button btnNhanVien;
        private TextBox txtTongTien;
        private Label zzzz;
        private Button btnMuaHang;
        private Button btnXoaGioHang;
        private DataGridView dgvSanPham;
        private Label label11;
        private TextBox txtNameSearch;
        private Label label12;
        private ComboBox cbbLoc;
        private Button btnLoc;
        private DateTimePicker dtpNgayTao;
        private Label label13;
        private Button btnThemVaoGio;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox txtSoLuong;
        private Label label14;
        private TextBox txtMaSanPham;
        private Label label15;
        private TextBox txtTongTienKM;
        private Label label16;
        private Label label17;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn productname;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Img;
    }
}