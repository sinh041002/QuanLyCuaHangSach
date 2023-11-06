namespace QuanLyCuaHangSach.view
{
    partial class FormThongKeDoanhThu
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTrongNgay = new System.Windows.Forms.RadioButton();
            this.rdo15NgayTruoc = new System.Windows.Forms.RadioButton();
            this.rdoThangTruoc = new System.Windows.Forms.RadioButton();
            this.rdoThangNay = new System.Windows.Forms.RadioButton();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridData);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1021, 504);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // gridData
            // 
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5});
            this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridData.Location = new System.Drawing.Point(3, 18);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 51;
            this.gridData.RowTemplate.Height = 24;
            this.gridData.Size = new System.Drawing.Size(1015, 483);
            this.gridData.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTrongNgay);
            this.groupBox1.Controls.Add(this.rdo15NgayTruoc);
            this.groupBox1.Controls.Add(this.rdoThangTruoc);
            this.groupBox1.Controls.Add(this.rdoThangNay);
            this.groupBox1.Controls.Add(this.btnBatDau);
            this.groupBox1.Controls.Add(this.dtDenNgay);
            this.groupBox1.Controls.Add(this.dtTuNgay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdoTrongNgay
            // 
            this.rdoTrongNgay.AutoSize = true;
            this.rdoTrongNgay.Location = new System.Drawing.Point(750, 78);
            this.rdoTrongNgay.Name = "rdoTrongNgay";
            this.rdoTrongNgay.Size = new System.Drawing.Size(97, 20);
            this.rdoTrongNgay.TabIndex = 5;
            this.rdoTrongNgay.TabStop = true;
            this.rdoTrongNgay.Text = "Trong ngày";
            this.rdoTrongNgay.UseVisualStyleBackColor = true;
            // 
            // rdo15NgayTruoc
            // 
            this.rdo15NgayTruoc.AutoSize = true;
            this.rdo15NgayTruoc.Location = new System.Drawing.Point(601, 78);
            this.rdo15NgayTruoc.Name = "rdo15NgayTruoc";
            this.rdo15NgayTruoc.Size = new System.Drawing.Size(107, 20);
            this.rdo15NgayTruoc.TabIndex = 5;
            this.rdo15NgayTruoc.TabStop = true;
            this.rdo15NgayTruoc.Text = "15 ngày trước";
            this.rdo15NgayTruoc.UseVisualStyleBackColor = true;
            // 
            // rdoThangTruoc
            // 
            this.rdoThangTruoc.AutoSize = true;
            this.rdoThangTruoc.Location = new System.Drawing.Point(344, 78);
            this.rdoThangTruoc.Name = "rdoThangTruoc";
            this.rdoThangTruoc.Size = new System.Drawing.Size(99, 20);
            this.rdoThangTruoc.TabIndex = 5;
            this.rdoThangTruoc.TabStop = true;
            this.rdoThangTruoc.Text = "Tháng trước";
            this.rdoThangTruoc.UseVisualStyleBackColor = true;
            // 
            // rdoThangNay
            // 
            this.rdoThangNay.AutoSize = true;
            this.rdoThangNay.Location = new System.Drawing.Point(466, 78);
            this.rdoThangNay.Name = "rdoThangNay";
            this.rdoThangNay.Size = new System.Drawing.Size(92, 20);
            this.rdoThangNay.TabIndex = 5;
            this.rdoThangNay.TabStop = true;
            this.rdoThangNay.Text = "Tháng này";
            this.rdoThangNay.UseVisualStyleBackColor = true;
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(885, 21);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(109, 47);
            this.btnBatDau.TabIndex = 4;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(572, 31);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(284, 22);
            this.dtDenNgay.TabIndex = 2;
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(137, 31);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(285, 22);
            this.dtTuNgay.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Từ ngày";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số lượng đơn hàng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Doanh Thu";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // FormThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 656);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormThongKeDoanhThu";
            this.Text = "THỐNG KÊ DOANH THU";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTrongNgay;
        private System.Windows.Forms.RadioButton rdo15NgayTruoc;
        private System.Windows.Forms.RadioButton rdoThangTruoc;
        private System.Windows.Forms.RadioButton rdoThangNay;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}