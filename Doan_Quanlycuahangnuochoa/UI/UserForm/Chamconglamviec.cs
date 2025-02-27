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
    public partial class Chamconglamviec : UserControl
    {
        database db = new database();
        private BLL_Chamconglamviec chamcongbll;
        private Timer nhanvienTimer;
        public Chamconglamviec()
        {

            InitializeComponent();
        }

        private void Chamconglamviec_Load(object sender, EventArgs e)
        {
            chamcongbll = new BLL_Chamconglamviec(new database().GetDatabase());
            LoadChamcong();
            nhanvienTimer = new Timer();
            nhanvienTimer.Interval = 1000;
            nhanvienTimer.Tick += (s, i) => LoadCBnhanvien();
            nhanvienTimer.Start();
        } 
        public void LoadCBnhanvien()
        {
            string connectionString = new database().GetDatabase();
            string query = "SELECT ID_NHANVIEN , HOTEN FROM NHANVIEN";


            var selectedValue = cb_nhanvien.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_nhanvien.DisplayMember = "HOTEN";
            cb_nhanvien.ValueMember = "ID_NHANVIEN";
            cb_nhanvien.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["ID_NHANVIEN"].ToString() == selectedValue.ToString()))
            {
                cb_nhanvien.SelectedValue = selectedValue;
            }
            else
            {

                cb_nhanvien.SelectedIndex = 0;
            }
        }
        public void LoadChamcong()
        {
            try
            {
                dgv_chamcong.DataSource = chamcongbll.GetDataChamcong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Clear()
        {
            txt_machamcong.Text = "";
            cb_trangthai.SelectedIndex = 0;
            dtngaylam.Value = DateTime.Now;
            cb_nhanvien.SelectedIndex = 0;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaylamviec = dtngaylam.Value;
               


                chamcong chamcong = new chamcong
                {
                    TRANGTHAI = cb_trangthai.Text.Trim(),
                    NGAYLAMVIEC = ngaylamviec,
                   
                    ID_NHANVIEN = (int)cb_nhanvien.SelectedValue,


                };

                if(!chamcongbll.themchamcong(chamcong)) {
                    MessageBox.Show("Thêm thất bại ! Nhân viên này đã chấm công hôm nay ròi ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; 
                }


                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadChamcong();

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
                if (dgv_chamcong.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn phân quyền cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                chamcong chamcong = new chamcong
                {
                    ID_CHAMCONG = Convert.ToInt32(dgv_chamcong.CurrentRow.Cells["ID_CHAMCONG"].Value),

                    ID_NHANVIEN = (int)cb_nhanvien.SelectedValue,

                    TRANGTHAI = cb_trangthai.Text.Trim(),
                    NGAYLAMVIEC = dtngaylam.Value,
                };

                chamcongbll.suachamcong(chamcong);


                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChamcong();
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_chamcong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = dgv_chamcong.Rows[e.RowIndex];


                txt_machamcong.Text = rowst.Cells["ID_CHAMCONG"]?.Value != DBNull.Value ? rowst.Cells["ID_CHAMCONG"].Value.ToString() : "";

                cb_trangthai.Text = rowst.Cells["TRANGTHAI"]?.Value != DBNull.Value ? rowst.Cells["TRANGTHAI"].Value.ToString() : "";

               

                if (rowst.Cells["NGAYLAMVIEC"]?.Value != DBNull.Value && rowst.Cells["NGAYLAMVIEC"]?.Value != null)
                {
                    dtngaylam.Text = rowst.Cells["NGAYLAMVIEC"].Value.ToString();
                }
                else
                {
                    dtngaylam.Value = DateTime.Now;
                }

                if (rowst.Cells["ID_NHANVIEN"]?.Value != null && rowst.Cells["ID_NHANVIEN"].Value != DBNull.Value)
                {
                    int manhanvien = Convert.ToInt32(rowst.Cells["ID_NHANVIEN"].Value);
                    cb_nhanvien.SelectedValue = manhanvien;
                }
                else
                {
                    cb_nhanvien.SelectedIndex = -1;
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
                if (dgv_chamcong.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn loại khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int machamcong = Convert.ToInt32(dgv_chamcong.CurrentRow.Cells["ID_CHAMCONG"].Value);
                chamcongbll.xoachamcong(machamcong);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChamcong();
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
            DataTable dt = chamcongbll.timkiemchamcong(keyword);
            dgv_chamcong.DataSource = dt;
        }

        private void btn_don_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_quanlynhanvien Quanlynhanvien= new ufrm_quanlynhanvien();
            this.Controls.Add(Quanlynhanvien);
            Quanlynhanvien.Dock = DockStyle.Fill;
        }
    }
    }

