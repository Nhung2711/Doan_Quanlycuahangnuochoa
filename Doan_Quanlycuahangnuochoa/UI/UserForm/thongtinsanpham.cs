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
    public partial class thongtinsanpham : UserControl
    {
        public thongtinsanpham()
        {
            InitializeComponent();
        }

        private void thongtinsanpham_Load(object sender, EventArgs e)
        {

        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrmquanlysanpham Quanlysanpham = new ufrmquanlysanpham();
            this.Controls.Add(Quanlysanpham);
            Quanlysanpham.Dock = DockStyle.Fill;
        }

        private void btn_don_Click(object sender, EventArgs e)
        {

        }
    }
}
