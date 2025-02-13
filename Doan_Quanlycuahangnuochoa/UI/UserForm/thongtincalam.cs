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
    public partial class thongtincalam : UserControl
    {
        public thongtincalam()
        {
            InitializeComponent();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_quanlynhanvien Quanlynhanvien = new ufrm_quanlynhanvien();
            this.Controls.Add(Quanlynhanvien);
            Quanlynhanvien.Dock = DockStyle.Fill;
        }
    }
}
