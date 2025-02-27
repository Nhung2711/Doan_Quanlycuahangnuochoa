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
    public partial class thongtinloaisanpham : UserControl
    {
        database db = new database();
        private BLL_Loaisanpham loaispbll;
        public thongtinloaisanpham()
        {
            InitializeComponent();
            loaispbll = new BLL_Loaisanpham(new database().GetDatabase());
            LoadLoaisp();
        }
        public void LoadLoaisp()
        {
            try
            {
                dgv_loaisanpham.DataSource = loaispbll.GetDataLoaisp();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_don_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_timkiem.Text.Trim();
            DataTable dt = loaispbll.timkiemloaisp(keyword);
            dgv_loaisanpham.DataSource = dt;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_loaisanpham.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int maloaisp = Convert.ToInt32(dgv_loaisanpham.CurrentRow.Cells["ID_LOAISP"].Value);
                loaispbll.xoaloasp(maloaisp);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaisp();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_loaisanpham.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn phân cần sua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Loaisp loaisp = new Loaisp
                {
                    ID_LOAISP = Convert.ToInt32(dgv_loaisanpham.CurrentRow.Cells["ID_LOAISP"].Value),

                    TENLOAISP = txt_tenloaisanpham.Text.Trim(),
                };

                loaispbll.sualoaisp(loaisp);
                MessageBox.Show("Sua thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaisp();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Clear()
        {

            txt_tenloaisanpham.Text = "";
        }
           
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                Loaisp loaisp = new Loaisp
                {
                    TENLOAISP = txt_tenloaisanpham.Text.Trim(),

                };
                loaispbll.themloaisp(loaisp);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoaisp();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("vui long nhap du thong tin:" + ex, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void thongtinloaisanpham_Load(object sender, EventArgs e)
        {

        }

        private void dgv_loaisanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = dgv_loaisanpham.Rows[e.RowIndex];


                txt_tenloaisanpham.Text = rowst.Cells["TENLOAISP"]?.Value != DBNull.Value ? rowst.Cells["TENLOAISP"].Value.ToString() : "";

               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
