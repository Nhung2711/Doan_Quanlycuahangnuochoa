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
    public partial class Nhacungcap : UserControl
    {
        database db = new database();
        private BLL_Nhacungcap nhacungcapbll;
        public Nhacungcap()
        {
            InitializeComponent();
            nhacungcapbll = new BLL_Nhacungcap(new database().GetDatabase());
            LoadNhacungcap();
        }
        public void LoadNhacungcap()
        {
            try
            {
                dgv_nhacungcap.DataSource = nhacungcapbll.GetDataNhacungcap();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nhacungcap_Load(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txt_manhacc.Text = "";
            txt_tennhacc.Text = "";
            txt_dcnhacc.Text = "";
            txt_sdt.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                nhacungcap nhacungcap = new nhacungcap
                {
                    TENNCC = txt_tennhacc.Text.Trim(),
                    DIACHI = txt_dcnhacc.Text.Trim(),
                    SDT = txt_sdt.Text.Trim(),

                    
                };
                nhacungcapbll.themnhacungcap(nhacungcap);
                MessageBox.Show("Thêm thông tin nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhacungcap();
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
                if (dgv_nhacungcap.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                nhacungcap  ncc = new nhacungcap
                {
                    ID_NHACC = Convert.ToInt32(dgv_nhacungcap.CurrentRow.Cells["ID_NHACC"].Value),

                    TENNCC = txt_tennhacc.Text.Trim(),

                    DIACHI = txt_dcnhacc.Text.Trim(),

                    SDT = txt_sdt.Text.Trim(),
                };

                nhacungcapbll.suanhacungcap(ncc);
                MessageBox.Show("Sửa nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhacungcap();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_nhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = dgv_nhacungcap.Rows[e.RowIndex];


                txt_manhacc.Text = rowst.Cells["ID_NHACC"]?.Value != DBNull.Value ? rowst.Cells["ID_NHACC"].Value.ToString() : "";

                txt_tennhacc.Text = rowst.Cells["TENNCC"]?.Value != DBNull.Value ? rowst.Cells["TENNCC"].Value.ToString() : "";
                txt_dcnhacc.Text = rowst.Cells["DIACHI"]?.Value != DBNull.Value ? rowst.Cells["DIACHI"].Value.ToString() : "";
                txt_sdt.Text = rowst.Cells["SDT"]?.Value != DBNull.Value ? rowst.Cells["SDT"].Value.ToString() : "";

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
                if (dgv_nhacungcap.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int mancc= Convert.ToInt32(dgv_nhacungcap.CurrentRow.Cells["ID_NHACC"].Value);
                nhacungcapbll.xoanhacc(mancc);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhacungcap();
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
            DataTable dt = nhacungcapbll.timkiemnhacc(keyword);
            dgv_nhacungcap.DataSource = dt;
        }

        private void btn_don_Click(object sender, EventArgs e)
        {
            txt_manhacc.Text = "";
            txt_tennhacc.Text = "";
            txt_sdt.Text = "";
            txt_dcnhacc.Text = "";
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrmquanlysanpham nhacungcap = new ufrmquanlysanpham();
            this.Controls.Add(nhacungcap);
            nhacungcap.Dock = DockStyle.Fill;
        }
    }
}
