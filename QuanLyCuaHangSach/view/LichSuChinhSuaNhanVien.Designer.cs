namespace QuanLyCuaHangSach.view
{
    partial class LichSuChinhSuaNhanVien
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
            this.dataChinhSua = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiemLs = new System.Windows.Forms.Button();
            this.MaNhanVienThaoTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThaoTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataChinhSua)).BeginInit();
            this.SuspendLayout();
            // 
            // dataChinhSua
            // 
            this.dataChinhSua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChinhSua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVienThaoTac,
            this.ThaoTac,
            this.abc,
            this.time});
            this.dataChinhSua.Location = new System.Drawing.Point(119, 177);
            this.dataChinhSua.Name = "dataChinhSua";
            this.dataChinhSua.Size = new System.Drawing.Size(798, 540);
            this.dataChinhSua.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(312, 103);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(261, 26);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiemLs
            // 
            this.btnTimKiemLs.Location = new System.Drawing.Point(637, 93);
            this.btnTimKiemLs.Name = "btnTimKiemLs";
            this.btnTimKiemLs.Size = new System.Drawing.Size(93, 46);
            this.btnTimKiemLs.TabIndex = 2;
            this.btnTimKiemLs.Text = "Tìm";
            this.btnTimKiemLs.UseVisualStyleBackColor = true;
            this.btnTimKiemLs.Click += new System.EventHandler(this.btnTimKiemLs_Click);
            // 
            // MaNhanVienThaoTac
            // 
            this.MaNhanVienThaoTac.DataPropertyName = "MaNhanVienThaoTac";
            this.MaNhanVienThaoTac.HeaderText = "Mã Nhân Viên Thao Tác";
            this.MaNhanVienThaoTac.Name = "MaNhanVienThaoTac";
            this.MaNhanVienThaoTac.Width = 150;
            // 
            // ThaoTac
            // 
            this.ThaoTac.DataPropertyName = "ThaoTac";
            this.ThaoTac.HeaderText = "Thao Tác";
            this.ThaoTac.Name = "ThaoTac";
            this.ThaoTac.Width = 150;
            // 
            // abc
            // 
            this.abc.DataPropertyName = "MaNhanVienBiThaoTac";
            this.abc.HeaderText = "Mã Nhân Viên bị Thao tác";
            this.abc.Name = "abc";
            this.abc.Width = 200;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Thời Gian";
            this.time.Name = "time";
            this.time.Width = 250;
            // 
            // LichSuChinhSuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 785);
            this.Controls.Add(this.btnTimKiemLs);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dataChinhSua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LichSuChinhSuaNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LichSuChinhSuaNhanVien";
            this.Load += new System.EventHandler(this.LichSuChinhSuaNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataChinhSua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataChinhSua;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiemLs;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVienThaoTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThaoTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn abc;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
    }
}