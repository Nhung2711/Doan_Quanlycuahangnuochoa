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
    public partial class thongtinkhachhang : UserControl
    {
        database db = new database();
        private BLL_Khachhang khachhangbll;
        private Timer khachhangTimer;
        public thongtinkhachhang()
            
        {
            InitializeComponent();
            khachhangbll = new BLL_Khachhang(new database().GetDatabase());
            LoadKhachhang();
            khachhangTimer = new Timer();
            khachhangTimer.Interval = 1000;
            khachhangTimer.Tick += (s, e) => LoadCBkhachhang();
            khachhangTimer.Start();
        }

        //-------------------------------------------------------------------------------------
        public void LoadCBkhachhang()
        {
            string connectionString = new database().GetDatabase();
            string query = "SELECT ID_LOAIKHACHHANG, TENLOAI FROM LOAIKHACHHANG";


            var selectedValue = cb_loaikh.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_loaikh.DisplayMember = "TENLOAI";
            cb_loaikh.ValueMember = "ID_LOAIKHACHHANG";
            cb_loaikh.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["ID_LOAIKHACHHANG"].ToString() == selectedValue.ToString()))
            {
                cb_loaikh.SelectedValue = selectedValue;
            }
            else
            {

                cb_loaikh.SelectedIndex = 0;
            }
        }

        //-------------------------------------------------------------------------------------
        public void LoadKhachhang()
        {
            try
            {
                dgv_khachhang.DataSource = khachhangbll.GetDataKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thongtinkhachhang_Load(object sender, EventArgs e)
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

            txt_tenkh.Text = "";
            txt_sdt.Text = "";
            txt_diachi.Text = "";
            cb_loaikh.SelectedIndex = 0;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaysinh = dtpnskhachhang.Value;

              

                khachhang kh = new khachhang
                {
                    HOTEN = txt_tenkh.Text.Trim(),
                    NGAYSINH= ngaysinh,
                    DIACHI = txt_diachi.Text.Trim(),
                    SDT = txt_sdt.Text.Trim(),
                    ID_LOAIKHACHHANG = (int)cb_loaikh.SelectedValue,


                };

                khachhangbll.themkhachhang(kh);

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadKhachhang();

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
                DateTime ngaysinh = dtpnskhachhang.Value;   

               
                khachhang kh = new khachhang
                {
                    ID_KHACHHANG = Convert.ToInt32(dgv_khachhang.CurrentRow.Cells["ID_KHACHHANG"].Value),    
                    HOTEN = txt_tenkh.Text.Trim(),
                    NGAYSINH = ngaysinh,
                    DIACHI = txt_diachi.Text.Trim(),
                    SDT = txt_sdt.Text.Trim(),
                    ID_LOAIKHACHHANG = (int)cb_loaikh.SelectedValue,


                };

                khachhangbll.suakhachhang(kh);

                MessageBox.Show("Cập thông tin khách hàng thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadKhachhang();

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("vui long nhap du thong tin:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = dgv_khachhang.Rows[e.RowIndex];


                txt_tenkh.Text = rowst.Cells["HOTEN"]?.Value != DBNull.Value ? rowst.Cells["HOTEN"].Value.ToString() : "";

                txt_diachi.Text = rowst.Cells["DIACHI"]?.Value != DBNull.Value ? rowst.Cells["DIACHI"].Value.ToString() : "";

                txt_sdt.Text = rowst.Cells["SDT"]?.Value != DBNull.Value ? rowst.Cells["SDT"].Value.ToString() : "";

                if (rowst.Cells["NGAYSINH"]?.Value != DBNull.Value && rowst.Cells["NGAYSINH"]?.Value != null)
                {
                    dtpnskhachhang.Text = rowst.Cells["NGAYSINH"].Value.ToString();
                }
                else
                {
                    dtpnskhachhang.Value = DateTime.Now;
                }

                if (rowst.Cells["ID_LOAIKHACHHANG"]?.Value != null && rowst.Cells["ID_LOAIKHACHHANG"].Value != DBNull.Value)
                {
                    int maloaikhachhang = Convert.ToInt32(rowst.Cells["ID_LOAIKHACHHANG"].Value);
                    cb_loaikh.SelectedValue = maloaikhachhang;
                }
                else
                {
                    cb_loaikh.SelectedIndex = -1;
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
                if (dgv_khachhang.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int maloaikh = Convert.ToInt32(dgv_khachhang.CurrentRow.Cells["ID_KHACHHANG"].Value);
                khachhangbll.xoakhachhang(maloaikh);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachhang();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_timkiem.Text.Trim();
            DataTable dt = khachhangbll.timkiemkhachhang(keyword);
            dgv_khachhang.DataSource = dt;
        }

        private void btn_don_Click(object sender, EventArgs e)
        {

            Clear();
        }
    }
 }

