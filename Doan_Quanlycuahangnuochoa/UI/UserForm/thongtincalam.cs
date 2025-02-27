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
    public partial class thongtincalam : UserControl
    {
        database db = new database();
        private BLL_Calam calamBLL;
       
        public thongtincalam()
        {
            InitializeComponent();
            calamBLL = new BLL_Calam(new database().GetDatabase());
            LoadCalam();
        }
        public void LoadCalam()
        {
            try
            {
                dgv_calam.DataSource = calamBLL.GetDataCalam();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_quanlynhanvien Quanlynhanvien = new ufrm_quanlynhanvien();
            this.Controls.Add(Quanlynhanvien);
            Quanlynhanvien.Dock = DockStyle.Fill;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_timkiem.Text.Trim();
            DataTable dt = calamBLL.timkiemcalam(keyword);
            dgv_calam.DataSource = dt;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_calam.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn ca lam cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int macalam = Convert.ToInt32(dgv_calam.CurrentRow.Cells["ID_CALAM"].Value);
                calamBLL.xoacalam(macalam);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCalam();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Clear()
        {
            txt_tencalam.Text = "";
            time_batDau.Text = "";
            time_KetThuc.Text = "";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan batDau = time_batDau.Value.TimeOfDay;
                TimeSpan ketThuc = time_KetThuc.Value.TimeOfDay;

                if (dgv_calam.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng ca lam cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Calamviec calam = new Calamviec
                {
                    ID_CALAM = Convert.ToInt32(dgv_calam.CurrentRow.Cells["ID_CALAM"].Value),

                    TENCA = txt_tencalam.Text.Trim(),
                    GIOBATDAU = batDau,
                    GIOKETTHUC = ketThuc,

                };

                calamBLL.suacalam(calam);
                MessageBox.Show("Sua thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCalam();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
               TimeSpan batDau = time_batDau.Value.TimeOfDay;
                TimeSpan ketThuc = time_KetThuc.Value.TimeOfDay;

                Calamviec calamnv = new Calamviec
               {
                   TENCA = txt_tencalam.Text.Trim(),
                   GIOBATDAU = batDau,
                   GIOKETTHUC = ketThuc,
               };
                calamBLL.themcalam(calamnv);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCalam();
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:" + ex, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_calam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_tencalam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_giobatdau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_gioketthuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_macalam_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_don_Click(object sender, EventArgs e)
        {

        }

        private void thongtincalam_Load(object sender, EventArgs e)
        {
            time_batDau.Format = DateTimePickerFormat.Custom;
            time_batDau.CustomFormat = "HH:mm";
            time_batDau.ShowUpDown = true;
            time_KetThuc.Format = DateTimePickerFormat.Custom;
            time_KetThuc.CustomFormat = "HH:mm";
            time_KetThuc.ShowUpDown = true;
        }

        private void dgv_calam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = dgv_calam.Rows[e.RowIndex];


                txt_tencalam.Text = rowst.Cells["TENCA"]?.Value != DBNull.Value ? rowst.Cells["TENCA"].Value.ToString() : "";

                time_batDau.Text = rowst.Cells["GIOBATDAU"]?.Value != DBNull.Value ? rowst.Cells["GIOBATDAU"].Value.ToString() : "";

                time_KetThuc.Text = rowst.Cells["GIOKETTHUC"]?.Value != DBNull.Value ? rowst.Cells["GIOKETTHUC"].Value.ToString() : "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void time_batDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void time_KetThuc_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
