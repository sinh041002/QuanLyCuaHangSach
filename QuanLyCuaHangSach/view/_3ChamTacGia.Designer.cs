using System.Windows.Forms;

namespace QuanLyCuaHangSach.view
{
    partial class _3ChamTacGia
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
            this.dgv3ChamTacGia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3ChamTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv3ChamTacGia
            // 
            this.dgv3ChamTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3ChamTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv3ChamTacGia.Location = new System.Drawing.Point(62, 58);
            this.dgv3ChamTacGia.Name = "dgv3ChamTacGia";
            this.dgv3ChamTacGia.ReadOnly = true;
            this.dgv3ChamTacGia.RowHeadersWidth = 51;
            this.dgv3ChamTacGia.RowTemplate.Height = 25;
            this.dgv3ChamTacGia.Size = new System.Drawing.Size(549, 150);
            this.dgv3ChamTacGia.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaTacGia";
            this.Column1.HeaderText = "Mã Tác Giả";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenTacGia";
            this.Column2.HeaderText = "Tên Tác Giả";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MoTaTacGia";
            this.Column3.HeaderText = "Mô Tả ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(346, 253);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(66, 34);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChon.Location = new System.Drawing.Point(209, 253);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(73, 34);
            this.btnChon.TabIndex = 8;
            this.btnChon.Text = "Chọn";
            this.btnChon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // _3ChamTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dgv3ChamTacGia);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "_3ChamTacGia";
            this.Text = "Tác Giả";
            ((System.ComponentModel.ISupportInitialize)(this.dgv3ChamTacGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv3ChamTacGia;
        private Button btnHuy;
        private Button btnChon;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}