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
    public partial class thongtinkhachhang : UserControl
    {
        public thongtinkhachhang()
        {
            InitializeComponent();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_quanlykhachhang quanlykhachhang = new ufrm_quanlykhachhang();
            this.Controls.Add(quanlykhachhang);
            quanlykhachhang.Dock = DockStyle.Fill;
        }
    }
}
