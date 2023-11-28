using System.Windows.Forms;

namespace QuanLyCuaHangSach.view
{
    partial class _DialogNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_DialogNhanVien));
            this.dgv3ChamStaff = new System.Windows.Forms.DataGridView();
            this.txt_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3ChamStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv3ChamStaff
            // 
            this.dgv3ChamStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3ChamStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_ID,
            this.txt_FirstName,
            this.txt_LastName,
            this.txt_GioiTinh,
            this.txt_ChucVu});
            this.dgv3ChamStaff.Location = new System.Drawing.Point(69, 100);
            this.dgv3ChamStaff.Name = "dgv3ChamStaff";
            this.dgv3ChamStaff.ReadOnly = true;
            this.dgv3ChamStaff.RowHeadersWidth = 51;
            this.dgv3ChamStaff.RowTemplate.Height = 25;
            this.dgv3ChamStaff.Size = new System.Drawing.Size(540, 150);
            this.dgv3ChamStaff.TabIndex = 7;
            // 
            // txt_ID
            // 
            this.txt_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_ID.DataPropertyName = "Id";
            this.txt_ID.HeaderText = "ID";
            this.txt_ID.MinimumWidth = 6;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_FirstName.DataPropertyName = "FirstName";
            this.txt_FirstName.HeaderText = "Họ";
            this.txt_FirstName.MinimumWidth = 6;
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.ReadOnly = true;
            // 
            // txt_LastName
            // 
            this.txt_LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_LastName.DataPropertyName = "LastName";
            this.txt_LastName.HeaderText = "Tên";
            this.txt_LastName.MinimumWidth = 6;
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.ReadOnly = true;
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_GioiTinh.DataPropertyName = "GioiTinh";
            this.txt_GioiTinh.HeaderText = "Giới Tính";
            this.txt_GioiTinh.MinimumWidth = 6;
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.ReadOnly = true;
            // 
            // txt_ChucVu
            // 
            this.txt_ChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txt_ChucVu.DataPropertyName = "PhoneNumber";
            this.txt_ChucVu.HeaderText = "Số Điện Thoại";
            this.txt_ChucVu.MinimumWidth = 6;
            this.txt_ChucVu.Name = "txt_ChucVu";
            this.txt_ChucVu.ReadOnly = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(478, 48);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(74, 34);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(371, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Tìm Kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(236, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 26);
            this.txtSearch.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm Kiếm :";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(392, 273);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(66, 34);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Image = ((System.Drawing.Image)(resources.GetObject("btnChon.Image")));
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.Location = new System.Drawing.Point(221, 273);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(73, 34);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = "Chọn";
            this.btnChon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // _DialogNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dgv3ChamStaff);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "_DialogNhanVien";
            this.Text = "Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgv3ChamStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv3ChamStaff;
        private Button btnReset;
        private Button button1;
        private TextBox txtSearch;
        private Label label1;
        private Button btnHuy;
        private Button btnChon;
        private DataGridViewTextBoxColumn txt_ID;
        private DataGridViewTextBoxColumn txt_FirstName;
        private DataGridViewTextBoxColumn txt_LastName;
        private DataGridViewTextBoxColumn txt_GioiTinh;
        private DataGridViewTextBoxColumn txt_ChucVu;
    }
}