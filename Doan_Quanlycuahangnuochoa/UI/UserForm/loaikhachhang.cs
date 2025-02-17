using BLL;
using DAL.DATABASE;
using DAL.MODEL;
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
    public partial class loaikhachhang : UserControl
    {
        database db = new database();
        private BLL_Loaikhachhang loaikhachhangbll;
        public loaikhachhang()
        {
            InitializeComponent();
            loaikhachhangbll= new BLL_Loaikhachhang(new database().GetDatabase());
            LoadLoaikhachhang();
        }
        public void LoadLoaikhachhang()
        {
            try 
            {
                dgv_loaikhachhang.DataSource = loaikhachhangbll.GetDataLoaiKhachHang();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
           ufrm_quanlykhachhang quanlykhachhang = new ufrm_quanlykhachhang();
            this.Controls.Add(quanlykhachhang);
            quanlykhachhang.Dock = DockStyle.Fill;
        }
        public void Clear()
        {
            txt_maloaikhachhang.Text = "";
            txt_tenloaikhachhang.Text = "";
            txt_giamgia.Text = "";
           
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiKH lkh = new LoaiKH
                {
                    TENLOAI = txt_tenloaikhachhang.Text.Trim(),
                    GIAMGIA = decimal.Parse(txt_giamgia.Text.Trim()),

                };
                loaikhachhangbll.themloaikhachhang(lkh);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaikhachhang();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("vui long nhap du thong tin:" + ex, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
