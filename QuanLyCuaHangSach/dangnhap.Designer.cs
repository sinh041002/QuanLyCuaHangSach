namespace QuanLyCuaHangSach
{
    partial class dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangnhap));
            this.BtnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDangNhap = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.ptrHienMatKhau = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptrHienMatKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(255, 270);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(130, 61);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Đăng Nhập";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.MediumPurple;
            this.lblUsername.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(189, 145);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(170, 26);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Tên đăng nhập ";
            this.lblUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumPurple;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDangNhap.Location = new System.Drawing.Point(368, 142);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(255, 35);
            this.txtDangNhap.TabIndex = 1;
            this.txtDangNhap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(440, 270);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 61);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(368, 195);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(255, 35);
            this.txtMatkhau.TabIndex = 2;
            // 
            // ptrHienMatKhau
            // 
            this.ptrHienMatKhau.BackColor = System.Drawing.Color.White;
            this.ptrHienMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("ptrHienMatKhau.Image")));
            this.ptrHienMatKhau.Location = new System.Drawing.Point(584, 203);
            this.ptrHienMatKhau.Name = "ptrHienMatKhau";
            this.ptrHienMatKhau.Size = new System.Drawing.Size(26, 23);
            this.ptrHienMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrHienMatKhau.TabIndex = 52;
            this.ptrHienMatKhau.TabStop = false;
            this.ptrHienMatKhau.Click += new System.EventHandler(this.ptrHienMatKhau_Click_1);
            // 
            // dangnhap
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(808, 451);
            this.Controls.Add(this.ptrHienMatKhau);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtDangNhap);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLogin);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrHienMatKhau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDangNhap;
      
   
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.PictureBox ptrHienMatKhau;
    }
}