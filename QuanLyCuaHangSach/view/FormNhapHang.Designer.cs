namespace QuanLyCuaHangSach
{
    partial class FormNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapHang));
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbxTongTien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxMaPhieuNhap = new System.Windows.Forms.ComboBox();
            this.lblMaHoaDonTimKiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuyPhieuNhap = new System.Windows.Forms.Button();
            this.btnLuuHang = new System.Windows.Forms.Button();
            this.cbxMaSach = new System.Windows.Forms.ComboBox();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.tbxTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxThanhTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnXoaHang = new System.Windows.Forms.Button();
            this.btnThemHang = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxTenNhanVien = new System.Windows.Forms.TextBox();
            this.cbxMaNhanVien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxMaNhaCungCap = new System.Windows.Forms.ComboBox();
            this.tbxDonGia = new System.Windows.Forms.TextBox();
            this.tbxTenSach = new System.Windows.Forms.TextBox();
            this.tbxSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgNhapHang = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tbxTongTien);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.cbxMaPhieuNhap);
            this.panel4.Controls.Add(this.lblMaHoaDonTimKiem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 553);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1448, 115);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // tbxTongTien
            // 
            this.tbxTongTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTongTien.Location = new System.Drawing.Point(1111, 22);
            this.tbxTongTien.Name = "tbxTongTien";
            this.tbxTongTien.ReadOnly = true;
            this.tbxTongTien.Size = new System.Drawing.Size(222, 26);
            this.tbxTongTien.TabIndex = 30;
            this.tbxTongTien.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1040, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 19);
            this.label12.TabIndex = 10;
            this.label12.Text = "Tổng tiền";
            // 
            // cbxMaPhieuNhap
            // 
            this.cbxMaPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaPhieuNhap.FormattingEnabled = true;
            this.cbxMaPhieuNhap.Location = new System.Drawing.Point(117, 26);
            this.cbxMaPhieuNhap.Name = "cbxMaPhieuNhap";
            this.cbxMaPhieuNhap.Size = new System.Drawing.Size(197, 27);
            this.cbxMaPhieuNhap.TabIndex = 8;
            this.cbxMaPhieuNhap.SelectedIndexChanged += new System.EventHandler(this.cbxMaPhieuNhap_SelectedIndexChanged);
            // 
            // lblMaHoaDonTimKiem
            // 
            this.lblMaHoaDonTimKiem.AutoSize = true;
            this.lblMaHoaDonTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDonTimKiem.Location = new System.Drawing.Point(12, 29);
            this.lblMaHoaDonTimKiem.Name = "lblMaHoaDonTimKiem";
            this.lblMaHoaDonTimKiem.Size = new System.Drawing.Size(99, 19);
            this.lblMaHoaDonTimKiem.TabIndex = 7;
            this.lblMaHoaDonTimKiem.Text = "&Mã phiếu nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(607, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(323, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sách";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.btnHuyPhieuNhap);
            this.panel1.Controls.Add(this.btnLuuHang);
            this.panel1.Controls.Add(this.cbxMaSach);
            this.panel1.Controls.Add(this.btnThemSach);
            this.panel1.Controls.Add(this.tbxTenNhaCungCap);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbxThanhTien);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnXoaHang);
            this.panel1.Controls.Add(this.btnThemHang);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxTenNhanVien);
            this.panel1.Controls.Add(this.cbxMaNhanVien);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbxMaPhieuNhap);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbxMaNhaCungCap);
            this.panel1.Controls.Add(this.tbxDonGia);
            this.panel1.Controls.Add(this.tbxTenSach);
            this.panel1.Controls.Add(this.tbxSoLuong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1448, 330);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHuyPhieuNhap
            // 
            this.btnHuyPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHuyPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPhieuNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuyPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyPhieuNhap.Image")));
            this.btnHuyPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyPhieuNhap.Location = new System.Drawing.Point(1160, 275);
            this.btnHuyPhieuNhap.Name = "btnHuyPhieuNhap";
            this.btnHuyPhieuNhap.Size = new System.Drawing.Size(139, 30);
            this.btnHuyPhieuNhap.TabIndex = 33;
            this.btnHuyPhieuNhap.Text = "&Hủy phiếu nhập";
            this.btnHuyPhieuNhap.UseVisualStyleBackColor = false;
            this.btnHuyPhieuNhap.Click += new System.EventHandler(this.btnHuyPhieuNhap_Click);
            // 
            // btnLuuHang
            // 
            this.btnLuuHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLuuHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLuuHang.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuHang.Image")));
            this.btnLuuHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHang.Location = new System.Drawing.Point(478, 275);
            this.btnLuuHang.Name = "btnLuuHang";
            this.btnLuuHang.Size = new System.Drawing.Size(110, 30);
            this.btnLuuHang.TabIndex = 32;
            this.btnLuuHang.Text = "&Lưu";
            this.btnLuuHang.UseVisualStyleBackColor = false;
            this.btnLuuHang.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxMaSach
            // 
            this.cbxMaSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaSach.FormattingEnabled = true;
            this.cbxMaSach.Location = new System.Drawing.Point(398, 86);
            this.cbxMaSach.Name = "cbxMaSach";
            this.cbxMaSach.Size = new System.Drawing.Size(222, 27);
            this.cbxMaSach.TabIndex = 31;
            this.cbxMaSach.SelectedIndexChanged += new System.EventHandler(this.cbxMaSach_SelectedIndexChanged);
            // 
            // btnThemSach
            // 
            this.btnThemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemSach.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSach.Image")));
            this.btnThemSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSach.Location = new System.Drawing.Point(712, 275);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(110, 30);
            this.btnThemSach.TabIndex = 30;
            this.btnThemSach.Text = "&Thêm sách";
            this.btnThemSach.UseVisualStyleBackColor = false;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // tbxTenNhaCungCap
            // 
            this.tbxTenNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenNhaCungCap.Location = new System.Drawing.Point(1111, 149);
            this.tbxTenNhaCungCap.Name = "tbxTenNhaCungCap";
            this.tbxTenNhaCungCap.ReadOnly = true;
            this.tbxTenNhaCungCap.Size = new System.Drawing.Size(222, 26);
            this.tbxTenNhaCungCap.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(992, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Tên nhà cung cấp";
            // 
            // tbxThanhTien
            // 
            this.tbxThanhTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxThanhTien.Location = new System.Drawing.Point(726, 204);
            this.tbxThanhTien.Multiline = true;
            this.tbxThanhTien.Name = "tbxThanhTien";
            this.tbxThanhTien.ReadOnly = true;
            this.tbxThanhTien.Size = new System.Drawing.Size(222, 26);
            this.tbxThanhTien.TabIndex = 27;
            this.tbxThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxThanhTien.TextChanged += new System.EventHandler(this.tbxThanhTien_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(649, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Thành tiền";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnXoaHang
            // 
            this.btnXoaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHang.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHang.Image")));
            this.btnXoaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHang.Location = new System.Drawing.Point(945, 275);
            this.btnXoaHang.Name = "btnXoaHang";
            this.btnXoaHang.Size = new System.Drawing.Size(137, 30);
            this.btnXoaHang.TabIndex = 3;
            this.btnXoaHang.Text = "&Xóa thông tin";
            this.btnXoaHang.UseVisualStyleBackColor = true;
            this.btnXoaHang.Click += new System.EventHandler(this.btnXoaHang_Click);
            // 
            // btnThemHang
            // 
            this.btnThemHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThemHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemHang.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHang.Image")));
            this.btnThemHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHang.Location = new System.Drawing.Point(126, 275);
            this.btnThemHang.Name = "btnThemHang";
            this.btnThemHang.Size = new System.Drawing.Size(110, 30);
            this.btnThemHang.TabIndex = 0;
            this.btnThemHang.Text = "&Tạo mới";
            this.btnThemHang.UseVisualStyleBackColor = false;
            this.btnThemHang.Click += new System.EventHandler(this.btnThemHang_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tên nhân viên";
            // 
            // tbxTenNhanVien
            // 
            this.tbxTenNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenNhanVien.Location = new System.Drawing.Point(108, 204);
            this.tbxTenNhanVien.Name = "tbxTenNhanVien";
            this.tbxTenNhanVien.ReadOnly = true;
            this.tbxTenNhanVien.Size = new System.Drawing.Size(197, 26);
            this.tbxTenNhanVien.TabIndex = 24;
            // 
            // cbxMaNhanVien
            // 
            this.cbxMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaNhanVien.FormattingEnabled = true;
            this.cbxMaNhanVien.Location = new System.Drawing.Point(108, 149);
            this.cbxMaNhanVien.Name = "cbxMaNhanVien";
            this.cbxMaNhanVien.Size = new System.Drawing.Size(197, 27);
            this.cbxMaNhanVien.TabIndex = 23;
            this.cbxMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbxMaNhanVien_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mã nhân viên";
            // 
            // tbxMaPhieuNhap
            // 
            this.tbxMaPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaPhieuNhap.Location = new System.Drawing.Point(114, 82);
            this.tbxMaPhieuNhap.Name = "tbxMaPhieuNhap";
            this.tbxMaPhieuNhap.ReadOnly = true;
            this.tbxMaPhieuNhap.Size = new System.Drawing.Size(197, 26);
            this.tbxMaPhieuNhap.TabIndex = 21;
            this.tbxMaPhieuNhap.TextChanged += new System.EventHandler(this.tbxMaPhieuNhap_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Mã phiếu nhập";
            // 
            // cbxMaNhaCungCap
            // 
            this.cbxMaNhaCungCap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaNhaCungCap.FormattingEnabled = true;
            this.cbxMaNhaCungCap.Location = new System.Drawing.Point(1111, 81);
            this.cbxMaNhaCungCap.Name = "cbxMaNhaCungCap";
            this.cbxMaNhaCungCap.Size = new System.Drawing.Size(222, 27);
            this.cbxMaNhaCungCap.TabIndex = 15;
            this.cbxMaNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.cbxMaNhaCungCap_SelectedIndexChanged_1);
            // 
            // tbxDonGia
            // 
            this.tbxDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDonGia.Location = new System.Drawing.Point(726, 82);
            this.tbxDonGia.Multiline = true;
            this.tbxDonGia.Name = "tbxDonGia";
            this.tbxDonGia.Size = new System.Drawing.Size(222, 26);
            this.tbxDonGia.TabIndex = 14;
            this.tbxDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxDonGia.TextChanged += new System.EventHandler(this.tbxDonGia_TextChanged);
            // 
            // tbxTenSach
            // 
            this.tbxTenSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTenSach.Location = new System.Drawing.Point(398, 142);
            this.tbxTenSach.Multiline = true;
            this.tbxTenSach.Name = "tbxTenSach";
            this.tbxTenSach.ReadOnly = true;
            this.tbxTenSach.Size = new System.Drawing.Size(222, 88);
            this.tbxTenSach.TabIndex = 11;
            this.tbxTenSach.TextChanged += new System.EventHandler(this.tbxTenSach_TextChanged);
            // 
            // tbxSoLuong
            // 
            this.tbxSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSoLuong.Location = new System.Drawing.Point(726, 151);
            this.tbxSoLuong.Name = "tbxSoLuong";
            this.tbxSoLuong.Size = new System.Drawing.Size(222, 26);
            this.tbxSoLuong.TabIndex = 10;
            this.tbxSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxSoLuong.TextChanged += new System.EventHandler(this.tbxSoLuong_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(656, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(664, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(329, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(992, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhà cung cấp";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtgNhapHang
            // 
            this.dtgNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgNhapHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgNhapHang.Location = new System.Drawing.Point(0, 330);
            this.dtgNhapHang.Name = "dtgNhapHang";
            this.dtgNhapHang.Size = new System.Drawing.Size(1434, 223);
            this.dtgNhapHang.TabIndex = 5;
            this.dtgNhapHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNhapHang_CellContentClick);
            // 
            // FormNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 668);
            this.Controls.Add(this.dtgNhapHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "FormNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNhapHang_FormClosing);
            this.Load += new System.EventHandler(this.FormNhapHang_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXoaHang;
        private System.Windows.Forms.Button btnThemHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxMaNhaCungCap;
        private System.Windows.Forms.TextBox tbxDonGia;
        private System.Windows.Forms.TextBox tbxTenSach;
        private System.Windows.Forms.TextBox tbxSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgNhapHang;
        private System.Windows.Forms.TextBox tbxMaPhieuNhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxThanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxTenNhanVien;
        private System.Windows.Forms.ComboBox cbxMaNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxTenNhaCungCap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxMaPhieuNhap;
        private System.Windows.Forms.Label lblMaHoaDonTimKiem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxTongTien;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.ComboBox cbxMaSach;
        private System.Windows.Forms.Button btnLuuHang;
        private System.Windows.Forms.Button btnHuyPhieuNhap;
    }
}