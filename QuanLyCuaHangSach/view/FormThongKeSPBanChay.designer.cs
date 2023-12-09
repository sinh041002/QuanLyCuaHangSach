namespace QuanLyCuaHangSach.view
{
    partial class FormThongKeSPBanChay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharPie)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1524, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rdoTrongNgay
            // 
            this.rdoTrongNgay.AutoSize = true;
            this.rdoTrongNgay.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.rdoTrongNgay.Location = new System.Drawing.Point(640, 83);
            this.rdoTrongNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.rdo15NgayTruoc.Location = new System.Drawing.Point(492, 83);
            this.rdo15NgayTruoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.rdoThangTruoc.Location = new System.Drawing.Point(242, 83);
            this.rdoThangTruoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.rdoThangNay.Location = new System.Drawing.Point(367, 83);
            this.rdoThangNay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnBatDau.Location = new System.Drawing.Point(664, 17);
            this.btnBatDau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.dtDenNgay.Location = new System.Drawing.Point(428, 25);
            this.dtDenNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.dtTuNgay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CharPie);
            this.groupBox2.Controls.Add(this.gridData);
            this.groupBox2.Location = new System.Drawing.Point(9, 152);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(1524, 643);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // gridData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridData.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridData.Location = new System.Drawing.Point(2, 15);
            this.gridData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridData.Name = "gridData";
            this.gridData.RowHeadersWidth = 51;
            this.gridData.RowTemplate.Height = 24;
            this.gridData.Size = new System.Drawing.Size(687, 626);
            this.gridData.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSach";
            this.Column1.HeaderText = "Mã Sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSach";
            this.Column2.HeaderText = "Tên Sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SLBan";
            this.Column3.HeaderText = "SL Bán";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // CharPie
            // 
            chartArea1.Name = "ChartArea1";
            this.CharPie.ChartAreas.Add(chartArea1);
            this.CharPie.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.CharPie.Legends.Add(legend1);
            this.CharPie.Location = new System.Drawing.Point(694, 15);
            this.CharPie.Name = "CharPie";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CharPie.Series.Add(series1);
            this.CharPie.Size = new System.Drawing.Size(828, 626);
            this.CharPie.TabIndex = 1;
            this.CharPie.Text = "chart1";
            // 
            // FormThongKeSPBanChay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 803);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormThongKeSPBanChay";
            this.Text = "THỐNG KÊ SẢN PHẨM BÁN CHẠY";
            this.Load += new System.EventHandler(this.FormThongKeSPBanChay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharPie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.RadioButton rdoTrongNgay;
        private System.Windows.Forms.RadioButton rdo15NgayTruoc;
        private System.Windows.Forms.RadioButton rdoThangTruoc;
        private System.Windows.Forms.RadioButton rdoThangNay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataVisualization.Charting.Chart CharPie;
    }
}