using BLL;
using DAL.DAL;
using DAL.DATABASE;
using DAL.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doan_Quanlycuahangnuochoa.UI.UserForm
{
    public partial class thongtinnhanvien : UserControl
    {
        database db = new database();
        private BLL_Nhanvien NhanvienBLL;
        private Timer nhanvienTimer;
        
        public thongtinnhanvien()
        {
            InitializeComponent();
            NhanvienBLL = new BLL_Nhanvien(new database().GetDatabase());
            LoadNhanvien();
            nhanvienTimer = new Timer();
            nhanvienTimer.Interval = 1000;
            nhanvienTimer.Tick += (s, e) => LoadCBtaikhoan();
            nhanvienTimer.Start();
        }
        //================================
        public void LoadCBtaikhoan()
        {
            string connectionString = new database().GetDatabase();
            string query = "SELECT ID_TAIKHOAN, EMAIL FROM TAIKHOAN";


            var selectedValue = cb_taikhoan.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_taikhoan.DisplayMember = "EMAIL";
            cb_taikhoan.ValueMember = "ID_TAIKHOAN";
            cb_taikhoan.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["ID_TAIKHOAN"].ToString() == selectedValue.ToString()))
            {
                cb_taikhoan.SelectedValue = selectedValue;
            }
            else
            {

                cb_taikhoan.SelectedIndex = 0;
            }
        }
        //=======================================================================================
        public void LoadNhanvien()
        {
            try
            {
                dgv_nhanvien.DataSource = NhanvienBLL.GetDataNhanvien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //=======================================================================================

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_quanlynhanvien Quanlynv = new ufrm_quanlynhanvien();
            this.Controls.Add(Quanlynv);
            Quanlynv.Dock = DockStyle.Fill;
        }

        private void thongtinnhanvien_Load(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            txt_tennv.Text = "";
            txt_diachinv.Text = "";
            txt_dtnv.Text = "";
            txt_tongluong.Text = "";
            txt_tongngaycong.Text = "";
            cb_taikhoan.SelectedIndex = 0;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaysinh = dtnsnhanvien.Value;



                Nhanvien nhanvien = new Nhanvien
                {
                    HOTEN = txt_tennv.Text.Trim(),
                    NGAYSINH = ngaysinh,
                    DIACHI = txt_diachinv.Text.Trim(),
                    SDT = txt_dtnv.Text.Trim(),
                    TONGLUONG = int.Parse(txt_tongluong.Text.Trim()),
                    TONGNGAYCONG = int.Parse(txt_tongngaycong.Text.Trim()),
                    ID_TAIKHOAN = (int)cb_taikhoan.SelectedValue,


                };

                NhanvienBLL.themnhanvien(nhanvien);

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadNhanvien();

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("vui long nhap du thong tin:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaysinh = dtnsnhanvien.Value;


                Nhanvien nhanvien = new Nhanvien
                {
                    ID_NHANVIEN = Convert.ToInt32(dgv_nhanvien.CurrentRow.Cells["ID_NHANVIEN"].Value),
                    HOTEN = txt_tennv.Text.Trim(),
                    NGAYSINH = ngaysinh,
                    DIACHI = txt_diachinv.Text.Trim(),
                    SDT = txt_dtnv.Text.Trim(),
                    TONGLUONG = int.Parse(txt_tongluong.Text.Trim()),
                    TONGNGAYCONG = int.Parse(txt_tongngaycong.Text.Trim()),
                    ID_TAIKHOAN = (int)cb_taikhoan.SelectedValue,


                };

                NhanvienBLL.suanhanvien(nhanvien);

                MessageBox.Show("Cập thông tin khách hàng thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadNhanvien();

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("vui long nhap du thong tin:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = dgv_nhanvien.Rows[e.RowIndex];


                txt_tennv.Text = rowst.Cells["HOTEN"]?.Value != DBNull.Value ? rowst.Cells["HOTEN"].Value.ToString() : "";

                txt_diachinv.Text = rowst.Cells["DIACHI"]?.Value != DBNull.Value ? rowst.Cells["DIACHI"].Value.ToString() : "";

                txt_dtnv.Text = rowst.Cells["SDT"]?.Value != DBNull.Value ? rowst.Cells["SDT"].Value.ToString() : "";

                txt_tongluong.Text = rowst.Cells["TONGLUONG"]?.Value != DBNull.Value ? rowst.Cells["TONGLUONG"].Value.ToString() : "";

                txt_tongngaycong.Text = rowst.Cells["TONGNGAYCONG"]?.Value != DBNull.Value ? rowst.Cells["TONGNGAYCONG"].Value.ToString() : "";

                if (rowst.Cells["NGAYSINH"]?.Value != DBNull.Value && rowst.Cells["NGAYSINH"]?.Value != null)
                {
                    dtnsnhanvien.Text = rowst.Cells["NGAYSINH"].Value.ToString();
                }
                else
                {
                    dtnsnhanvien.Value = DateTime.Now;
                }

                if (rowst.Cells["ID_TAIKHOAN"]?.Value != null && rowst.Cells["ID_TAIKHOAN"].Value != DBNull.Value)
                {
                    int mataikhoan = Convert.ToInt32(rowst.Cells["ID_TAIKHOAN"].Value);
                    cb_taikhoan.SelectedValue = mataikhoan;
                }
                else
                {
                    cb_taikhoan.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_nhanvien.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int manhanvien = Convert.ToInt32(dgv_nhanvien.CurrentRow.Cells["ID_NHANVIEN"].Value);
                NhanvienBLL.xoanhanvien(manhanvien);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanvien();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_timnv_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void txt_tim_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_tim.Text.Trim();
            DataTable dt = NhanvienBLL.timkiemnhanvien(keyword);
            dgv_nhanvien.DataSource = dt;
        }

        private void btn_don_Click(object sender, EventArgs e)
        {

        }
    }
}
