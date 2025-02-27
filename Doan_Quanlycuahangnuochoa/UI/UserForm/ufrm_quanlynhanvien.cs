using System;
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
    public partial class ufrm_quanlynhanvien : UserControl
    {
        public ufrm_quanlynhanvien()
        {
            InitializeComponent();
        }

        private void ts_calam_Click(object sender, EventArgs e)
        {
            thongtincalam calam = new thongtincalam();
            this.Controls.Clear();
            this.Controls.Add(calam);
            calam.Dock = DockStyle.Fill;

        }

        private void ts_ttnv_Click(object sender, EventArgs e)
        {
            thongtinnhanvien nhanvien = new thongtinnhanvien();
            this.Controls.Clear();
            this.Controls.Add(nhanvien);
            nhanvien.Dock = DockStyle.Fill;
        }

        private void btnadd_nv_Click(object sender, EventArgs e)
        {

        }

        private void tsphancongcalam_Click(object sender, EventArgs e)
        {
           Phancongcalam phancong = new Phancongcalam();
            this.Controls.Clear();
            this.Controls.Add(phancong);
            phancong.Dock = DockStyle.Fill;

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Chamconglamviec chamcong= new Chamconglamviec();
            this.Controls.Clear();
            this.Controls.Add(chamcong);
            chamcong.Dock = DockStyle.Fill;
        }

        private void ufrm_quanlynhanvien_Load(object sender, EventArgs e)
        {


        }
    }
}
