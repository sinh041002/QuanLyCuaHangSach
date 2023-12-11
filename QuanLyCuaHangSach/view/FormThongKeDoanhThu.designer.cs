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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComBoBoxThongKE = new System.Windows.Forms.ComboBox();
            this.rdoTrongNgay = new System.Windows.Forms.RadioButton();
            this.rdo15NgayTruoc = new System.Windows.Forms.RadioButton();
            this.rdoThangTruoc = new System.Windows.Forms.RadioButton();
            this.rdoThangNay = new System.Windows.Forms.RadioButton();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.chartDoanhThu);
            this.groupBox2.Location = new System.Drawing.Point(9, 144);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1490, 693);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông Kê Doanh Thu Theo Ngày";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 616);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ngay";
            this.Column2.HeaderText = "Ngày";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SLDonHang";
            this.Column3.HeaderText = "Số Lượng đơn hàng";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DoanhThu";
            this.Column4.HeaderText = "Doanh Thu";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // chartDoanhThu
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(642, 15);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Biểu Đồ Cột";
            series1.Name = "CharCot";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(846, 676);
            this.chartDoanhThu.TabIndex = 1;
            this.chartDoanhThu.Text = "Thông Kê Theo Tháng";
            this.chartDoanhThu.Click += new System.EventHandler(this.chartDoanhThu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ComBoBoxThongKE);
            this.groupBox1.Controls.Add(this.rdoTrongNgay);
            this.groupBox1.Controls.Add(this.rdo15NgayTruoc);
            this.groupBox1.Controls.Add(this.rdoThangTruoc);
            this.groupBox1.Controls.Add(this.rdoThangNay);
            this.groupBox1.Controls.Add(this.btnBatDau);
            this.groupBox1.Controls.Add(this.dtDenNgay);
            this.groupBox1.Controls.Add(this.dtTuNgay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1487, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // ComBoBoxThongKE
            // 
            this.ComBoBoxThongKE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBoBoxThongKE.FormattingEnabled = true;
            this.ComBoBoxThongKE.Items.AddRange(new object[] {
            "2023",
            "2022",
            "2021"});
            this.ComBoBoxThongKE.Location = new System.Drawing.Point(1050, 81);
            this.ComBoBoxThongKE.Name = "ComBoBoxThongKE";
            this.ComBoBoxThongKE.Size = new System.Drawing.Size(121, 27);
            this.ComBoBoxThongKE.TabIndex = 6;
            this.ComBoBoxThongKE.SelectedIndexChanged += new System.EventHandler(this.ComBoBoxThongKE_SelectedIndexChanged);
            // 
            // rdoTrongNgay
            // 
            this.rdoTrongNgay.AutoSize = true;
            this.rdoTrongNgay.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rdoTrongNgay.Location = new System.Drawing.Point(666, 81);
            this.rdoTrongNgay.Margin = new System.Windows.Forms.Padding(2);
            this.rdoTrongNgay.Name = "rdoTrongNgay";
            this.rdoTrongNgay.Size = new System.Drawing.Size(113, 25);
            this.rdoTrongNgay.TabIndex = 5;
            this.rdoTrongNgay.TabStop = true;
            this.rdoTrongNgay.Text = "Trong ngày";
            this.rdoTrongNgay.UseVisualStyleBackColor = true;
            this.rdoTrongNgay.CheckedChanged += new System.EventHandler(this.rdoTrongNgay_CheckedChanged);
            // 
            // rdo15NgayTruoc
            // 
            this.rdo15NgayTruoc.AutoSize = true;
            this.rdo15NgayTruoc.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rdo15NgayTruoc.Location = new System.Drawing.Point(523, 81);
            this.rdo15NgayTruoc.Margin = new System.Windows.Forms.Padding(2);
            this.rdo15NgayTruoc.Name = "rdo15NgayTruoc";
            this.rdo15NgayTruoc.Size = new System.Drawing.Size(131, 25);
            this.rdo15NgayTruoc.TabIndex = 5;
            this.rdo15NgayTruoc.TabStop = true;
            this.rdo15NgayTruoc.Text = "15 ngày trước";
            this.rdo15NgayTruoc.UseVisualStyleBackColor = true;
            this.rdo15NgayTruoc.CheckedChanged += new System.EventHandler(this.rdo15NgayTruoc_CheckedChanged);
            // 
            // rdoThangTruoc
            // 
            this.rdoThangTruoc.AutoSize = true;
            this.rdoThangTruoc.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rdoThangTruoc.Location = new System.Drawing.Point(263, 81);
            this.rdoThangTruoc.Margin = new System.Windows.Forms.Padding(2);
            this.rdoThangTruoc.Name = "rdoThangTruoc";
            this.rdoThangTruoc.Size = new System.Drawing.Size(120, 25);
            this.rdoThangTruoc.TabIndex = 5;
            this.rdoThangTruoc.TabStop = true;
            this.rdoThangTruoc.Text = "Tháng trước";
            this.rdoThangTruoc.UseVisualStyleBackColor = true;
            this.rdoThangTruoc.CheckedChanged += new System.EventHandler(this.rdoThangTruoc_CheckedChanged);
            // 
            // rdoThangNay
            // 
            this.rdoThangNay.AutoSize = true;
            this.rdoThangNay.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rdoThangNay.Location = new System.Drawing.Point(398, 81);
            this.rdoThangNay.Margin = new System.Windows.Forms.Padding(2);
            this.rdoThangNay.Name = "rdoThangNay";
            this.rdoThangNay.Size = new System.Drawing.Size(106, 25);
            this.rdoThangNay.TabIndex = 5;
            this.rdoThangNay.TabStop = true;
            this.rdoThangNay.Text = "Tháng này";
            this.rdoThangNay.UseVisualStyleBackColor = true;
            this.rdoThangNay.CheckedChanged += new System.EventHandler(this.rdoThangNay_CheckedChanged);
            // 
            // btnBatDau
            // 
            this.btnBatDau.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.btnBatDau.Location = new System.Drawing.Point(689, 15);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(82, 38);
            this.btnBatDau.TabIndex = 4;
            this.btnBatDau.Text = "Bắt đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            this.btnBatDau.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtDenNgay.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(436, 24);
            this.dtDenNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(214, 29);
            this.dtDenNgay.TabIndex = 2;
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgay.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(103, 25);
            this.dtTuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(215, 29);
            this.dtTuNgay.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label4.Location = new System.Drawing.Point(348, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đến ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.label3.Location = new System.Drawing.Point(18, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Từ ngày";
            // 
            // FormThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 846);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormThongKeDoanhThu";
            this.Text = "THỐNG KÊ DOANH THU";
            this.Load += new System.EventHandler(this.FormThongKeDoanhThu_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.ComboBox ComBoBoxThongKE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}