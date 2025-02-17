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
    public partial class thongtinloaisanpham : UserControl
    {
        public thongtinloaisanpham()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_don_Click(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void dgv_loaikhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_giamgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tenloaikhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_maloaikhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrmquanlysanpham Quanlysanpham = new ufrmquanlysanpham();
            this.Controls.Add(Quanlysanpham);
            Quanlysanpham.Dock = DockStyle.Fill;
        }
    }
}
