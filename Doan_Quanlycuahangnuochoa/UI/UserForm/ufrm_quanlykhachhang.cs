﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan_Quanlycuahangnuochoa.UI.UserForm
{
    public partial class ufrm_quanlykhachhang : UserControl
    {
        public ufrm_quanlykhachhang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tt_loaikh_Click(object sender, EventArgs e)
        {
            loaikhachhang loaikh = new loaikhachhang();
            this.Controls.Clear();
            this.Controls.Add(loaikh);
            loaikh.Dock = DockStyle.Fill;

        }

        private void tt_ttkhachhang_Click(object sender, EventArgs e)
        {
            thongtinkhachhang khachhang = new thongtinkhachhang();
            this.Controls.Clear();
            this.Controls.Add(khachhang);
            khachhang.Dock = DockStyle.Fill;


        }
    }
}
