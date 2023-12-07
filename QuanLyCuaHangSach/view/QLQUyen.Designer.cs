namespace QuanLyCuaHangSach.view
{
    partial class QLQUyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBQLKhachHang = new System.Windows.Forms.CheckBox();
            this.TenQuyen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataQuyen = new System.Windows.Forms.DataGridView();
            this.cBQLNhanVien = new System.Windows.Forms.CheckBox();
            this.cBQLQuyen = new System.Windows.Forms.CheckBox();
            this.cBQLKhuyenMai = new System.Windows.Forms.CheckBox();
            this.cBQLSach = new System.Windows.Forms.CheckBox();
            this.cBQLHoaDon = new System.Windows.Forms.CheckBox();
            this.cBBanHang = new System.Windows.Forms.CheckBox();
            this.cBQLThongKe = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaQuyen = new System.Windows.Forms.TextBox();
            this.MaQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQuyen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLQuyen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BanHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLThongKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(658, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Quyền";
            // 
            // cBQLKhachHang
            // 
            this.cBQLKhachHang.AutoSize = true;
            this.cBQLKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBQLKhachHang.Location = new System.Drawing.Point(583, 166);
            this.cBQLKhachHang.Name = "cBQLKhachHang";
            this.cBQLKhachHang.Size = new System.Drawing.Size(161, 23);
            this.cBQLKhachHang.TabIndex = 1;
            this.cBQLKhachHang.Text = "Quản Lý Khách Hàng";
            this.cBQLKhachHang.UseVisualStyleBackColor = true;
            // 
            // TenQuyen
            // 
            this.TenQuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenQuyen.Location = new System.Drawing.Point(940, 91);
            this.TenQuyen.Name = "TenQuyen";
            this.TenQuyen.Size = new System.Drawing.Size(200, 26);
            this.TenQuyen.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(829, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên quyền";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataQuyen
            // 
            this.dataQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaQuyen,
            this.TenQuyen1,
            this.QLKhachHang,
            this.QLNhanVien,
            this.QLQuyen1,
            this.Column1,
            this.Column2,
            this.Column3,
            this.BanHang,
            this.QLThongKe});
            this.dataQuyen.Location = new System.Drawing.Point(226, 510);
            this.dataQuyen.Name = "dataQuyen";
            this.dataQuyen.Size = new System.Drawing.Size(1099, 224);
            this.dataQuyen.TabIndex = 12;
            this.dataQuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataQuyen_CellContentClick);
            // 
            // cBQLNhanVien
            // 
            this.cBQLNhanVien.AutoSize = true;
            this.cBQLNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBQLNhanVien.Location = new System.Drawing.Point(835, 166);
            this.cBQLNhanVien.Name = "cBQLNhanVien";
            this.cBQLNhanVien.Size = new System.Drawing.Size(149, 23);
            this.cBQLNhanVien.TabIndex = 13;
            this.cBQLNhanVien.Text = "Quản Lý Nhân Viên";
            this.cBQLNhanVien.UseVisualStyleBackColor = true;
            // 
            // cBQLQuyen
            // 
            this.cBQLQuyen.AutoSize = true;
            this.cBQLQuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBQLQuyen.Location = new System.Drawing.Point(583, 231);
            this.cBQLQuyen.Name = "cBQLQuyen";
            this.cBQLQuyen.Size = new System.Drawing.Size(125, 23);
            this.cBQLQuyen.TabIndex = 14;
            this.cBQLQuyen.Text = "Quản Lý Quyền";
            this.cBQLQuyen.UseVisualStyleBackColor = true;
            // 
            // cBQLKhuyenMai
            // 
            this.cBQLKhuyenMai.AutoSize = true;
            this.cBQLKhuyenMai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBQLKhuyenMai.Location = new System.Drawing.Point(835, 231);
            this.cBQLKhuyenMai.Name = "cBQLKhuyenMai";
            this.cBQLKhuyenMai.Size = new System.Drawing.Size(160, 23);
            this.cBQLKhuyenMai.TabIndex = 15;
            this.cBQLKhuyenMai.Text = "Quản Lý Khuyến Mãi";
            this.cBQLKhuyenMai.UseVisualStyleBackColor = true;
            // 
            // cBQLSach
            // 
            this.cBQLSach.AutoSize = true;
            this.cBQLSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBQLSach.Location = new System.Drawing.Point(583, 288);
            this.cBQLSach.Name = "cBQLSach";
            this.cBQLSach.Size = new System.Drawing.Size(115, 23);
            this.cBQLSach.TabIndex = 16;
            this.cBQLSach.Text = "Quản Lý Sách";
            this.cBQLSach.UseVisualStyleBackColor = true;
            // 
            // cBQLHoaDon
            // 
            this.cBQLHoaDon.AutoSize = true;
            this.cBQLHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBQLHoaDon.Location = new System.Drawing.Point(835, 288);
            this.cBQLHoaDon.Name = "cBQLHoaDon";
            this.cBQLHoaDon.Size = new System.Drawing.Size(141, 23);
            this.cBQLHoaDon.TabIndex = 17;
            this.cBQLHoaDon.Text = "Quản Lý Hóa Đơn";
            this.cBQLHoaDon.UseVisualStyleBackColor = true;
            // 
            // cBBanHang
            // 
            this.cBBanHang.AutoSize = true;
            this.cBBanHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBBanHang.Location = new System.Drawing.Point(583, 352);
            this.cBBanHang.Name = "cBBanHang";
            this.cBBanHang.Size = new System.Drawing.Size(145, 23);
            this.cBBanHang.TabIndex = 18;
            this.cBBanHang.Text = "Quản Lý Bán Hàng";
            this.cBBanHang.UseVisualStyleBackColor = true;
            // 
            // cBQLThongKe
            // 
            this.cBQLThongKe.AutoSize = true;
            this.cBQLThongKe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBQLThongKe.Location = new System.Drawing.Point(835, 352);
            this.cBQLThongKe.Name = "cBQLThongKe";
            this.cBQLThongKe.Size = new System.Drawing.Size(146, 23);
            this.cBQLThongKe.TabIndex = 19;
            this.cBQLThongKe.Text = "Quản Lý Thống Kê";
            this.cBQLThongKe.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Danh Sách Quyền";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(920, 405);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 41);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Làm Mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(554, 405);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 41);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(802, 405);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXoa.Size = new System.Drawing.Size(75, 41);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(682, 405);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 41);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mã Quyền";
            // 
            // txtMaQuyen
            // 
            this.txtMaQuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaQuyen.Location = new System.Drawing.Point(548, 91);
            this.txtMaQuyen.Name = "txtMaQuyen";
            this.txtMaQuyen.Size = new System.Drawing.Size(200, 26);
            this.txtMaQuyen.TabIndex = 25;
            // 
            // MaQuyen
            // 
            this.MaQuyen.DataPropertyName = "MaQuyen";
            this.MaQuyen.HeaderText = "Mã Quyền";
            this.MaQuyen.Name = "MaQuyen";
            // 
            // TenQuyen1
            // 
            this.TenQuyen1.DataPropertyName = "TenQuyen";
            this.TenQuyen1.HeaderText = "Tên Quyền";
            this.TenQuyen1.Name = "TenQuyen1";
            // 
            // QLKhachHang
            // 
            this.QLKhachHang.DataPropertyName = "QLKhachHang";
            this.QLKhachHang.HeaderText = "QLKhachHang";
            this.QLKhachHang.Name = "QLKhachHang";
            this.QLKhachHang.Visible = false;
            // 
            // QLNhanVien
            // 
            this.QLNhanVien.DataPropertyName = "QLNhanVien";
            this.QLNhanVien.HeaderText = "QLNhanVien";
            this.QLNhanVien.Name = "QLNhanVien";
            this.QLNhanVien.Visible = false;
            // 
            // QLQuyen1
            // 
            this.QLQuyen1.DataPropertyName = "QLQuyen";
            this.QLQuyen1.HeaderText = "QLQuyen";
            this.QLQuyen1.Name = "QLQuyen1";
            this.QLQuyen1.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "QLKhuyenMai";
            this.Column1.HeaderText = "QLKhuyenMai";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "QLSach";
            this.Column2.HeaderText = "QLSach";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "QLHoaDon";
            this.Column3.HeaderText = "QLHoaDon";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // BanHang
            // 
            this.BanHang.DataPropertyName = "BanHang";
            this.BanHang.HeaderText = "BanHang";
            this.BanHang.Name = "BanHang";
            this.BanHang.Visible = false;
            // 
            // QLThongKe
            // 
            this.QLThongKe.DataPropertyName = "QLThongKe";
            this.QLThongKe.HeaderText = "QLThongKe";
            this.QLThongKe.Name = "QLThongKe";
            this.QLThongKe.Visible = false;
            // 
            // QLQUyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1534, 746);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaQuyen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBQLThongKe);
            this.Controls.Add(this.cBBanHang);
            this.Controls.Add(this.cBQLHoaDon);
            this.Controls.Add(this.cBQLSach);
            this.Controls.Add(this.cBQLKhuyenMai);
            this.Controls.Add(this.cBQLQuyen);
            this.Controls.Add(this.cBQLNhanVien);
            this.Controls.Add(this.dataQuyen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TenQuyen);
            this.Controls.Add(this.cBQLKhachHang);
            this.Controls.Add(this.label1);
            this.Name = "QLQUyen";
            this.Text = "QLQUyen";
            this.Load += new System.EventHandler(this.QLQUyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBQLKhachHang;
        private System.Windows.Forms.TextBox TenQuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataQuyen;
        private System.Windows.Forms.CheckBox cBQLNhanVien;
        private System.Windows.Forms.CheckBox cBQLQuyen;
        private System.Windows.Forms.CheckBox cBQLKhuyenMai;
        private System.Windows.Forms.CheckBox cBQLSach;
        private System.Windows.Forms.CheckBox cBQLHoaDon;
        private System.Windows.Forms.CheckBox cBBanHang;
        private System.Windows.Forms.CheckBox cBQLThongKe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQuyen1;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLQuyen1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn BanHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLThongKe;
    }
}