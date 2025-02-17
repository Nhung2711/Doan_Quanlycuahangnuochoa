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
    public partial class ufrmquanlysanpham : UserControl
    {
        public ufrmquanlysanpham()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        
       

        private void tt_ttloaisp_Click_1(object sender, EventArgs e)
        {
            thongtinloaisanpham loaisp = new thongtinloaisanpham();
            this.Controls.Clear();
            this.Controls.Add(loaisp);
            loaisp.Dock = DockStyle.Fill;
        }

        private void tt_thongtinsp_Click(object sender, EventArgs e)
        {
            thongtinsanpham sp = new thongtinsanpham();
            this.Controls.Clear();
            this.Controls.Add(sp);
            sp.Dock = DockStyle.Fill;
        }
    }
}
