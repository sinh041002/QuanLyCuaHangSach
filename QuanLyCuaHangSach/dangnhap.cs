﻿using System;
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
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            
            form.ShowDialog();
           
        }
    }
}
