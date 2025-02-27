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
    public partial class ufrm_phanquyen : UserControl
    {
        database db = new database();
        private BLL_Phanquyen phanquyenbll;

        public ufrm_phanquyen()
        {
            InitializeComponent();
            phanquyenbll = new BLL_Phanquyen(new database().GetDatabase());
            LoadPhanQuyen();
        }
        public void LoadPhanQuyen()
        {
            try
            {
                dgv_phanquyen.DataSource = phanquyenbll.GetDataPhanQuyen();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:"+ex.Message,"Thông báo ",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Clear()
        {
           
            txt_tenphanquyen.Text = "";
            txt_mota.Text = "";
            txt_mucluonglamviec.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                Phanquyen phanquyen = new Phanquyen
                {
                    TENQUYEN = txt_tenphanquyen.Text.Trim(),
                    MoTa = txt_mota.Text.Trim(),
                    MUCLUONGLAMVIEC = decimal.Parse(txt_mucluonglamviec.Text.Trim()),

                };
                phanquyenbll.themPhanquyen(phanquyen);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhanQuyen();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhâppj đầy đủ thông tin!"+ex, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_phanquyen_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_phanquyen.Columns[e.ColumnIndex].Name == "MUCLUONGLAMVIEC" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal mucLuong))
                {

                    e.Value = string.Format("{0:N0} VND", mucLuong);
                    e.FormattingApplied = true;
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgv_phanquyen.CurrentRow==null)
                {
                    MessageBox.Show("Vui lòng chọn phân quyền cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               int maphanquyen=Convert.ToInt32(dgv_phanquyen.CurrentRow.Cells["ID_PHANQUYEN"].Value);
                phanquyenbll.xoaphanquyen(maphanquyen);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhanQuyen();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_phanquyen.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn phân quyền cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Phanquyen quyen= new Phanquyen
                {
                    ID_PHANQUYEN = Convert.ToInt32(dgv_phanquyen.CurrentRow.Cells["ID_PHANQUYEN"].Value),
                    TENQUYEN = txt_tenphanquyen.Text.Trim(),
                    MoTa = txt_mota.Text.Trim(),
                    MUCLUONGLAMVIEC = decimal.Parse(txt_mucluonglamviec.Text.Trim()),
                };
              
                phanquyenbll.suaPhanquyen(quyen);
                MessageBox.Show("Sua thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhanQuyen();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgv_phanquyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = dgv_phanquyen.Rows[e.RowIndex];


                txt_tenphanquyen.Text = rowst.Cells["TENQUYEN"]?.Value != DBNull.Value ? rowst.Cells["TENQUYEN"].Value.ToString() : "";

                txt_mota.Text = rowst.Cells["MoTa"]?.Value != DBNull.Value ? rowst.Cells["MoTa"].Value.ToString() : "";

                txt_mucluonglamviec.Text = rowst.Cells["MUCLUONGLAMVIEC"]?.Value != DBNull.Value ? rowst.Cells["MUCLUONGLAMVIEC"].Value.ToString() : "";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_timkiem.Text.Trim();
            DataTable dt=phanquyenbll.timkiemPhanquyen(keyword);
            dgv_phanquyen.DataSource = dt;
        }

        private void ufrm_phanquyen_Load(object sender, EventArgs e)
        {

        }

        private void btn_don_Click(object sender, EventArgs e)
        {

        }

        private void dgv_phanquyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_tenphanquyen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mota_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mucluonglamviec_TextChanged(object sender, EventArgs e)
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

        private void txt_maphanquyen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}