using BLL;
using DAL.DAL;
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
            loaikhachhangbll = new BLL_Loaikhachhang(new database().GetDatabase());
            LoadLoaiKh();
        }
        public void LoadLoaiKh()
        {
            try
            {
                dgv_loaikh.DataSource = loaikhachhangbll.GetDataLoaiKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:" + ex, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loaikhachhang_Load(object sender, EventArgs e)
        {

        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            ufrm_quanlykhachhang Quanlykh = new ufrm_quanlykhachhang();
            this.Controls.Add(Quanlykh);
            Quanlykh.Dock = DockStyle.Fill;
        }
        public void Clear()
        {

            txt_tenloaikh.Text = "";
            txt_giamgia.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                LoaiKH phanquyen = new LoaiKH
                {
                    TENLOAI = txt_tenloaikh.Text.Trim(),
                  
                    GIAMGIA = decimal.Parse(txt_giamgia.Text.Trim()),

                };
                loaikhachhangbll.themloaikhachhang(phanquyen);
                MessageBox.Show("Thêm loại khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaiKh();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin:" + ex, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_loaikh.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn loại tài khoản cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                LoaiKH lkh = new LoaiKH
                {
                    ID_LOAIKHACHHANG = Convert.ToInt32(dgv_loaikh.CurrentRow.Cells["ID_LOAIKHACHHANG"].Value),

                    TENLOAI = txt_tenloaikh.Text.Trim(),
                
                    GIAMGIA = decimal.Parse(txt_giamgia.Text.Trim()),
                };

                loaikhachhangbll.sualoaikhachhang(lkh);
                MessageBox.Show("Sửa loại khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaiKh();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_loaikh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = dgv_loaikh.Rows[e.RowIndex];


                txt_tenloaikh.Text = rowst.Cells["TENLOAI"]?.Value != DBNull.Value ? rowst.Cells["TENLOAI"].Value.ToString() : "";

                txt_giamgia.Text = rowst.Cells["GIAMGIA"]?.Value != DBNull.Value ? rowst.Cells["GIAMGIA"].Value.ToString() : "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_loaikh.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn loại khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int maloaikh = Convert.ToInt32(dgv_loaikh.CurrentRow.Cells["ID_LOAIKHACHHANG"].Value);
                loaikhachhangbll.xoaloaikhachhang(maloaikh);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaiKh();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_timkiem.Text.Trim();
            DataTable dt = loaikhachhangbll.timkiemloaikhachhang(keyword);
            dgv_loaikh.DataSource = dt;
        }

        private void btn_don_Click(object sender, EventArgs e)
        {
            txt_maloaikh.Text = "";
            txt_tenloaikh.Text = "";
            txt_giamgia.Text = "";
        }

        private void dgv_loaikh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
