namespace QuanLyCuaHangSach
{
    partial class Form1
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
            this.QLCuaHangSach = new System.Windows.Forms.TabControl();
            this.BanHang = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QLKhachHang = new System.Windows.Forms.TabPage();
            this.QLHoaDon = new System.Windows.Forms.TabPage();
            this.QLNhapHang = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.QLQuyen = new System.Windows.Forms.TabPage();
            this.KhuyenMai = new System.Windows.Forms.TabPage();
            this.QLThongKe = new System.Windows.Forms.TabPage();
            this.QLCuaHangSach.SuspendLayout();
            this.BanHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // QLCuaHangSach
            // 
            this.QLCuaHangSach.Controls.Add(this.BanHang);
            this.QLCuaHangSach.Controls.Add(this.QLKhachHang);
            this.QLCuaHangSach.Controls.Add(this.QLHoaDon);
            this.QLCuaHangSach.Controls.Add(this.QLNhapHang);
            this.QLCuaHangSach.Controls.Add(this.tabPage5);
            this.QLCuaHangSach.Controls.Add(this.QLQuyen);
            this.QLCuaHangSach.Controls.Add(this.KhuyenMai);
            this.QLCuaHangSach.Controls.Add(this.QLThongKe);
            this.QLCuaHangSach.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLCuaHangSach.ItemSize = new System.Drawing.Size(100, 40);
            this.QLCuaHangSach.Location = new System.Drawing.Point(0, 0);
            this.QLCuaHangSach.Margin = new System.Windows.Forms.Padding(4);
            this.QLCuaHangSach.Name = "QLCuaHangSach";
            this.QLCuaHangSach.Padding = new System.Drawing.Point(10, 5);
            this.QLCuaHangSach.SelectedIndex = 0;
            this.QLCuaHangSach.Size = new System.Drawing.Size(1652, 900);
            this.QLCuaHangSach.TabIndex = 0;
            // 
            // BanHang
            // 
            this.BanHang.Controls.Add(this.button1);
            this.BanHang.Controls.Add(this.dataGridView1);
            this.BanHang.Location = new System.Drawing.Point(4, 44);
            this.BanHang.Margin = new System.Windows.Forms.Padding(4);
            this.BanHang.Name = "BanHang";
            this.BanHang.Padding = new System.Windows.Forms.Padding(4);
            this.BanHang.Size = new System.Drawing.Size(1600, 862);
            this.BanHang.TabIndex = 0;
            this.BanHang.Text = "Bán Hàng";
            this.BanHang.UseVisualStyleBackColor = true;
            this.BanHang.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1072, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Đăng Xuất";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1432, 437);
            this.dataGridView1.TabIndex = 0;
            // 
            // QLKhachHang
            // 
            this.QLKhachHang.Location = new System.Drawing.Point(4, 44);
            this.QLKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.QLKhachHang.Name = "QLKhachHang";
            this.QLKhachHang.Padding = new System.Windows.Forms.Padding(4);
            this.QLKhachHang.Size = new System.Drawing.Size(1644, 852);
            this.QLKhachHang.TabIndex = 1;
            this.QLKhachHang.Text = "Khách Hàng";
            this.QLKhachHang.UseVisualStyleBackColor = true;
            this.QLKhachHang.Click += new System.EventHandler(this.QLKhachHang_Click);
            // 
            // QLHoaDon
            // 
            this.QLHoaDon.Location = new System.Drawing.Point(4, 44);
            this.QLHoaDon.Name = "QLHoaDon";
            this.QLHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.QLHoaDon.Size = new System.Drawing.Size(1600, 862);
            this.QLHoaDon.TabIndex = 2;
            this.QLHoaDon.Text = "Hóa Đơn";
            this.QLHoaDon.UseVisualStyleBackColor = true;
            // 
            // QLNhapHang
            // 
            this.QLNhapHang.Location = new System.Drawing.Point(4, 44);
            this.QLNhapHang.Name = "QLNhapHang";
            this.QLNhapHang.Padding = new System.Windows.Forms.Padding(3);
            this.QLNhapHang.Size = new System.Drawing.Size(1600, 862);
            this.QLNhapHang.TabIndex = 3;
            this.QLNhapHang.Text = "Nhập Hàng";
            this.QLNhapHang.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1600, 862);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Sách";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // QLQuyen
            // 
            this.QLQuyen.Location = new System.Drawing.Point(4, 44);
            this.QLQuyen.Name = "QLQuyen";
            this.QLQuyen.Padding = new System.Windows.Forms.Padding(3);
            this.QLQuyen.Size = new System.Drawing.Size(1264, 525);
            this.QLQuyen.TabIndex = 5;
            this.QLQuyen.Text = "Quyền";
            this.QLQuyen.UseVisualStyleBackColor = true;
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.Location = new System.Drawing.Point(4, 44);
            this.KhuyenMai.Name = "KhuyenMai";
            this.KhuyenMai.Padding = new System.Windows.Forms.Padding(3);
            this.KhuyenMai.Size = new System.Drawing.Size(1264, 525);
            this.KhuyenMai.TabIndex = 6;
            this.KhuyenMai.Text = "Khuyến Mãi";
            this.KhuyenMai.UseVisualStyleBackColor = true;
            // 
            // QLThongKe
            // 
            this.QLThongKe.Location = new System.Drawing.Point(4, 44);
            this.QLThongKe.Name = "QLThongKe";
            this.QLThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.QLThongKe.Size = new System.Drawing.Size(1264, 525);
            this.QLThongKe.TabIndex = 7;
            this.QLThongKe.Text = "Thống Kê";
            this.QLThongKe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 903);
            this.Controls.Add(this.QLCuaHangSach);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "QLCuaHangSach";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.QLCuaHangSach.ResumeLayout(false);
            this.BanHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl QLCuaHangSach;
        private System.Windows.Forms.TabPage BanHang;
        private System.Windows.Forms.TabPage QLKhachHang;
        private System.Windows.Forms.TabPage QLHoaDon;
        private System.Windows.Forms.TabPage QLNhapHang;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage QLQuyen;
        private System.Windows.Forms.TabPage KhuyenMai;
        private System.Windows.Forms.TabPage QLThongKe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

