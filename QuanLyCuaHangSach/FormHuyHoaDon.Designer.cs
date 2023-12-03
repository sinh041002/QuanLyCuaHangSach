namespace QuanLyCuaHangSach
{
    partial class FormHuyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHuyHoaDon));
            this.cbxMaHoaDon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaPhieuNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxMaHoaDon
            // 
            this.cbxMaHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMaHoaDon.FormattingEnabled = true;
            this.cbxMaHoaDon.Location = new System.Drawing.Point(260, 189);
            this.cbxMaHoaDon.Name = "cbxMaHoaDon";
            this.cbxMaHoaDon.Size = new System.Drawing.Size(213, 27);
            this.cbxMaHoaDon.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btnXoaPhieuNhap
            // 
            this.btnXoaPhieuNhap.BackColor = System.Drawing.Color.White;
            this.btnXoaPhieuNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieuNhap.Image")));
            this.btnXoaPhieuNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaPhieuNhap.Location = new System.Drawing.Point(491, 183);
            this.btnXoaPhieuNhap.Name = "btnXoaPhieuNhap";
            this.btnXoaPhieuNhap.Size = new System.Drawing.Size(95, 36);
            this.btnXoaPhieuNhap.TabIndex = 5;
            this.btnXoaPhieuNhap.Text = "Xóa";
            this.btnXoaPhieuNhap.UseVisualStyleBackColor = false;
            this.btnXoaPhieuNhap.Click += new System.EventHandler(this.btnXoaPhieuNhap_Click);
            // 
            // FormHuyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoaPhieuNhap);
            this.Controls.Add(this.cbxMaHoaDon);
            this.Controls.Add(this.label1);
            this.Name = "FormHuyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHuyHoaDon";
            this.Load += new System.EventHandler(this.FormHuyHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaPhieuNhap;
        private System.Windows.Forms.ComboBox cbxMaHoaDon;
        private System.Windows.Forms.Label label1;
    }
}