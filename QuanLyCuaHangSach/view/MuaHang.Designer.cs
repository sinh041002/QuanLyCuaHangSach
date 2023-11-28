using System.Windows.Forms;

namespace QuanLyCuaHangSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
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
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Controls.Add(this.txtMoTa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoLuongConLai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenSanPham);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbSanPham);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(31, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaSanPham.Location = new System.Drawing.Point(375, 28);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.ReadOnly = true;
            this.txtMaSanPham.Size = new System.Drawing.Size(361, 25);
            this.txtMaSanPham.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label15.Location = new System.Drawing.Point(243, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 19);
            this.label15.TabIndex = 13;
            this.label15.Text = "Mã Sản Phẩm";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMoTa.Location = new System.Drawing.Point(178, 223);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.Size = new System.Drawing.Size(558, 166);
            this.txtMoTa.TabIndex = 10;
            this.txtMoTa.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(64, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mô Tả";
            // 
            // txtTenHang
            // 
            this.txtTenHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenHang.Location = new System.Drawing.Point(375, 152);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(361, 25);
            this.txtTenHang.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(242, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hãng Sản Phẩm";
            // 
            // txtSoLuongConLai
            // 
            this.txtSoLuongConLai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoLuongConLai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoLuongConLai.Location = new System.Drawing.Point(375, 121);
            this.txtSoLuongConLai.Name = "txtSoLuongConLai";
            this.txtSoLuongConLai.ReadOnly = true;
            this.txtSoLuongConLai.Size = new System.Drawing.Size(361, 25);
            this.txtSoLuongConLai.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(242, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số Lượng Còn Lại";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDonGia.Location = new System.Drawing.Point(375, 90);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(361, 25);
            this.txtDonGia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(242, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đơn Giá";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenSanPham.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenSanPham.Location = new System.Drawing.Point(375, 59);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.ReadOnly = true;
            this.txtTenSanPham.Size = new System.Drawing.Size(361, 25);
            this.txtTenSanPham.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(242, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // pbSanPham
            // 
            this.pbSanPham.Location = new System.Drawing.Point(17, 19);
            this.pbSanPham.Name = "pbSanPham";
            this.pbSanPham.Size = new System.Drawing.Size(180, 180);
            this.pbSanPham.TabIndex = 0;
            this.pbSanPham.TabStop = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoLuong.Location = new System.Drawing.Point(358, 522);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(232, 25);
            this.txtSoLuong.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(189, 525);
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
            this.groupBox2.Location = new System.Drawing.Point(793, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 703);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Giao Hàng";
            // 
            // txtTongTienKM
            // 
            this.txtTongTienKM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTongTienKM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTongTienKM.Location = new System.Drawing.Point(173, 494);
            this.txtTongTienKM.Name = "txtTongTienKM";
            this.txtTongTienKM.ReadOnly = true;
            this.txtTongTienKM.Size = new System.Drawing.Size(442, 25);
            this.txtTongTienKM.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label16.Location = new System.Drawing.Point(6, 497);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 19);
            this.label16.TabIndex = 33;
            this.label16.Text = "Tổng Tiền Đã K/M (VND)";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(161, 177);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(188, 25);
            this.dtpNgayTao.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.Location = new System.Drawing.Point(21, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Ngày Tạo";
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKhuyenMai.Location = new System.Drawing.Point(639, 145);
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Size = new System.Drawing.Size(26, 25);
            this.btnKhuyenMai.TabIndex = 30;
            this.btnKhuyenMai.Text = "...";
            this.btnKhuyenMai.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKhachHang.Location = new System.Drawing.Point(638, 83);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(26, 25);
            this.btnKhachHang.TabIndex = 29;
            this.btnKhachHang.Text = "...";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNhanVien.Location = new System.Drawing.Point(639, 21);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(26, 25);
            this.btnNhanVien.TabIndex = 28;
            this.btnNhanVien.Text = "...";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTongTien.Location = new System.Drawing.Point(173, 463);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(442, 25);
            this.txtTongTien.TabIndex = 27;
            // 
            // zzzz
            // 
            this.zzzz.AutoSize = true;
            this.zzzz.BackColor = System.Drawing.Color.Transparent;
            this.zzzz.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.zzzz.Location = new System.Drawing.Point(7, 463);
            this.zzzz.Name = "zzzz";
            this.zzzz.Size = new System.Drawing.Size(114, 19);
            this.zzzz.TabIndex = 26;
            this.zzzz.Text = "Tổng Tiền (VND) ";
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMuaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuaHang.Location = new System.Drawing.Point(463, 593);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.Size = new System.Drawing.Size(89, 25);
            this.btnMuaHang.TabIndex = 25;
            this.btnMuaHang.Text = "Mua Hàng";
            this.btnMuaHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMuaHang.UseVisualStyleBackColor = true;
            // 
            // btnXoaGioHang
            // 
            this.btnXoaGioHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnXoaGioHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaGioHang.Location = new System.Drawing.Point(173, 593);
            this.btnXoaGioHang.Name = "btnXoaGioHang";
            this.btnXoaGioHang.Size = new System.Drawing.Size(57, 25);
            this.btnXoaGioHang.TabIndex = 24;
            this.btnXoaGioHang.Text = "Xóa";
            this.btnXoaGioHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaGioHang.UseVisualStyleBackColor = true;
            // 
            // dgvGio
            // 
            this.dgvGio.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvGio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGio.Location = new System.Drawing.Point(4, 223);
            this.dgvGio.MultiSelect = false;
            this.dgvGio.Name = "dgvGio";
            this.dgvGio.ReadOnly = true;
            this.dgvGio.RowHeadersWidth = 51;
            this.dgvGio.RowTemplate.Height = 25;
            this.dgvGio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGio.Size = new System.Drawing.Size(675, 198);
            this.dgvGio.TabIndex = 23;
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKhuyenMai.Location = new System.Drawing.Point(161, 146);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.ReadOnly = true;
            this.txtKhuyenMai.Size = new System.Drawing.Size(454, 25);
            this.txtKhuyenMai.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(21, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Khuyến Mãi";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKhachHang.Location = new System.Drawing.Point(161, 115);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.ReadOnly = true;
            this.txtKhachHang.Size = new System.Drawing.Size(454, 25);
            this.txtKhachHang.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(21, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tên Khách Hàng";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaKhachHang.Location = new System.Drawing.Point(161, 84);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(454, 25);
            this.txtMaKhachHang.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(21, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã Khách Hàng";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNhanVien.Location = new System.Drawing.Point(161, 53);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(454, 25);
            this.txtNhanVien.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(21, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tên Nhân Viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaNhanVien.Location = new System.Drawing.Point(161, 22);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(454, 25);
            this.txtMaNhanVien.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(21, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã Nhân Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSanPham);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox3.Location = new System.Drawing.Point(22, 595);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 140);
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
            this.description,
            this.stock,
            this.CategoryName,
            this.Img,
            this.Status});
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(3, 19);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 25;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(759, 118);
            this.dgvSanPham.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 108;
            // 
            // productname
            // 
            this.productname.DataPropertyName = "NameProduct";
            this.productname.HeaderText = "Tên Sản Phẩm";
            this.productname.MinimumWidth = 6;
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            this.productname.Width = 108;
            // 
            // category
            // 
            this.category.DataPropertyName = "CategoryName";
            this.category.HeaderText = "Loại";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 107;
            // 
            // description
            // 
            this.description.DataPropertyName = "Description";
            this.description.HeaderText = "Mô tả";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 108;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "Stock";
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
            this.Img.HeaderText = "Ảnh";
            this.Img.MinimumWidth = 6;
            this.Img.Name = "Img";
            this.Img.ReadOnly = true;
            this.Img.Visible = false;
            this.Img.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Column3";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.Location = new System.Drawing.Point(124, 568);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 19);
            this.label11.TabIndex = 31;
            this.label11.Text = "Lọc";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNameSearch.Location = new System.Drawing.Point(497, 565);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(148, 25);
            this.txtNameSearch.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label12.Location = new System.Drawing.Point(432, 569);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 19);
            this.label12.TabIndex = 33;
            this.label12.Text = "Từ Khóa";
            // 
            // cbbLoc
            // 
            this.cbbLoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLoc.FormattingEnabled = true;
            this.cbbLoc.Items.AddRange(new object[] {
            "Tất Cả",
            "Tên Sản Phẩm",
            "Danh Mục"});
            this.cbbLoc.Location = new System.Drawing.Point(160, 566);
            this.cbbLoc.Name = "cbbLoc";
            this.cbbLoc.Size = new System.Drawing.Size(152, 25);
            this.cbbLoc.TabIndex = 35;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(669, 564);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(55, 25);
            this.btnLoc.TabIndex = 36;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThemVaoGio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemVaoGio.Location = new System.Drawing.Point(282, 750);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(209, 25);
            this.btnThemVaoGio.TabIndex = 37;
            this.btnThemVaoGio.Text = "Thêm Sản Phẩm Vào Giỏ Hàng";
            this.btnThemVaoGio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemVaoGio.UseVisualStyleBackColor = true;
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
            this.label17.Location = new System.Drawing.Point(647, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(195, 40);
            this.label17.TabIndex = 38;
            this.label17.Text = "Cửa Hàng";
            // 
            // MuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
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
        private TextBox txtTenHang;
        private Label label4;
        private TextBox txtSoLuongConLai;
        private Label label3;
        private TextBox txtDonGia;
        private Label label2;
        private RichTextBox txtMoTa;
        private Label label5;
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
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn CategoryName;
        private DataGridViewTextBoxColumn Img;
        private DataGridViewTextBoxColumn Status;
    }
}