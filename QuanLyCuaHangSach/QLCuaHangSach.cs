using QuanLyCuaHangSach.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangSach
{
    public partial class QLCuaHangSach : Form
    {
        public QLCuaHangSach()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void QLCuaHangSach_Load(object sender, EventArgs e)
        {

        }
        private Form currentFormChild;
        private void OpenChildForm(Form ChildForm)
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle=FormBorderStyle.None;
            ChildForm.Dock= DockStyle.Fill;
            panel3_body.Controls.Add(ChildForm);
            panel3_body.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MuaHang());
        }

        private void BtnQLNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLNhanVien());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void panel3_body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
