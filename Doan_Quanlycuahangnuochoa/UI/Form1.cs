using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan_Quanlycuahangnuochoa
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        // hàm đổi màu nút
        private Button _currentButton = null;
        private void HighlightButton(Button selectedButton)
        {
            if (_currentButton != null)
            {

                // chưa chọn 
                _currentButton.BackColor = Color.FromArgb(255, 226, 226); // màu nút chưa chọn 
                _currentButton.ForeColor = Color.Black; // màu chữ 
                _currentButton.FlatAppearance.BorderSize = 0;
            }

            // hành động chọn 
            selectedButton.BackColor = Color.FromArgb(255, 207, 207);
            selectedButton.ForeColor = Color.White;
            _currentButton = selectedButton;
        }
        private void btn_thongke_Click(object sender, EventArgs e)
        {
            ufrm_thongke1.Visible = true;
            ufrm_quanlykhachhang1.Visible = false;
            ufrm_quanlynhanvien1.Visible = false;
            ufrm_phanquyen1.Visible = false;
            ufrmquanlysanpham1.Visible = false;
            ufrm_mataikhoan1.Visible = false;
            HighlightButton((Button)sender);
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            ufrm_thongke1.Visible = false;
            ufrm_quanlykhachhang1.Visible = true;
            ufrm_quanlynhanvien1.Visible = false;
            ufrm_phanquyen1.Visible = false;
            ufrmquanlysanpham1.Visible = false;
            ufrm_mataikhoan1.Visible = false;
            HighlightButton((Button)sender);
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            ufrm_thongke1.Visible = false;
            ufrm_quanlykhachhang1.Visible = false;
            ufrm_quanlynhanvien1.Visible = true;
            ufrm_phanquyen1.Visible = false;
            ufrmquanlysanpham1.Visible = false;
            ufrm_mataikhoan1.Visible = false;
            HighlightButton((Button)sender);
        }

        private void btn_qlphanquyen_Click(object sender, EventArgs e)
        {
            ufrm_thongke1.Visible = false;
            ufrm_quanlykhachhang1.Visible = false;
            ufrm_quanlynhanvien1.Visible = false;
            ufrm_phanquyen1.Visible = true;
            ufrmquanlysanpham1.Visible = false;
            ufrm_mataikhoan1.Visible = false;

            HighlightButton((Button)sender);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            ufrm_thongke1.Visible = false;
            ufrm_quanlykhachhang1.Visible = false;
            ufrm_quanlynhanvien1.Visible = false;
            ufrm_phanquyen1.Visible = false;
            ufrmquanlysanpham1.Visible = true;
            ufrm_mataikhoan1.Visible = false;
            HighlightButton((Button)sender);

        }

        private void ufrm_thongke1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_taikhoan_Click(object sender, EventArgs e)
        {
            ufrm_thongke1.Visible = false;
            ufrm_quanlykhachhang1.Visible = false;
            ufrm_quanlynhanvien1.Visible = false;
            ufrm_mataikhoan1.Visible = true;
            ufrm_phanquyen1.Visible = false;
            ufrmquanlysanpham1.Visible = false;
            HighlightButton((Button)sender);
        }
    }
}
