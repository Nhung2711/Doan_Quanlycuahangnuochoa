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
    public partial class Phancongcalam : UserControl
    {
        database db = new database();
        private BLL_Phancongcalam phancongcalam_bll;
        private Timer tennhanvienTimer;
        private Timer calamTimer;

        public Phancongcalam()
        {
            phancongcalam_bll = new BLL_Phancongcalam(new database().GetDatabase());
            InitializeComponent();
            LoadPhancongcalam();
            //======================================
            tennhanvienTimer = new Timer();
            tennhanvienTimer.Interval = 1000;
            tennhanvienTimer.Tick += (s, e) => LoadCBNhanvien();
            tennhanvienTimer.Start();
            //===================================
            calamTimer = new Timer();
            calamTimer.Interval = 1000;
            calamTimer.Tick += (s, e) => LoadCBCalam();
            calamTimer.Start();
        }
        public void LoadCBNhanvien()
        {
            string connectionString = new database().GetDatabase();
            string query = "SELECT ID_NHANVIEN, HOTEN FROM NHANVIEN";


            var selectedValue = cb_tennhanvien.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_tennhanvien.DisplayMember = "HOTEN";
            cb_tennhanvien.ValueMember = "ID_NHANVIEN";
            cb_tennhanvien.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["ID_NHANVIEN"].ToString() == selectedValue.ToString()))
            {
                cb_tennhanvien.SelectedValue = selectedValue;
            }
            else
            {

                cb_tennhanvien.SelectedIndex = 0;
            }
        }
        public void LoadCBCalam()
        {
            string connectionString = new database().GetDatabase();
            string query = "SELECT ID_CALAM, TENCA FROM CALAMVIEC";


            var selectedValue = cb_calam.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_calam.DisplayMember = "TENCA";
            cb_calam.ValueMember = "ID_CALAM";
            cb_calam.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["ID_CALAM"].ToString() == selectedValue.ToString()))
            {
                cb_calam.SelectedValue = selectedValue;
            }
            else
            {

                cb_calam.SelectedIndex = 0;
            }
        }
        public void LoadPhancongcalam()
        {
            try
            {
                dgv_phancongcalam.DataSource = phancongcalam_bll.GetDataPhancongcalam();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_calam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Phancongcalam_Load(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            dtngaylam.Value = DateTime.Now;
            cb_tennhanvien.SelectedIndex = 0;
            cb_calam.SelectedIndex = 0;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaylam = dtngaylam.Value;



                phanCongCaLam phancong = new phanCongCaLam
                {
                    NGAYLAM=ngaylam,
                    ID_NHANVIEN = (int)cb_tennhanvien.SelectedValue,
                    ID_CALAM = (int)cb_calam.SelectedValue,


                };

                phancongcalam_bll.themphancongcalam(phancong);

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhancongcalam();

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("vui long nhap du thong tin:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void dgv_phancongcalam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = dgv_phancongcalam.Rows[e.RowIndex];


                if (rowst.Cells["ID_NHANVIEN"]?.Value != null && rowst.Cells["ID_NHANVIEN"].Value != DBNull.Value)
                {
                    int manhanvien = Convert.ToInt32(rowst.Cells["ID_NHANVIEN"].Value);
                    cb_tennhanvien.SelectedValue = manhanvien;
                }
                else
                {
                    cb_tennhanvien.SelectedIndex = -1;
                }
                //=================================================================
                if (rowst.Cells["ID_CALAM"]?.Value != null && rowst.Cells["ID_CALAM"].Value != DBNull.Value)
                {
                    int macalam = Convert.ToInt32(rowst.Cells["ID_CALAM"].Value);
                    cb_calam.SelectedValue = macalam;
                }
                else
                {
                    cb_calam.SelectedIndex = -1;
                }
                //==================================================
                if (rowst.Cells["NGAYLAM"]?.Value != DBNull.Value && rowst.Cells["NGAYLAM"]?.Value != null)
                {
                    dtngaylam.Text = rowst.Cells["NGAYLAM"].Value.ToString();
                }
                else
                {
                    dtngaylam.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngaylam = dtngaylam.Value;


                phanCongCaLam phancong = new phanCongCaLam
                {
                    ID_PHANCONG = Convert.ToInt32(dgv_phancongcalam.CurrentRow.Cells["ID_PHANCONG"].Value),
                    NGAYLAM = ngaylam,
                    ID_CALAM = (int)cb_calam.SelectedValue,
                    ID_NHANVIEN=(int)cb_tennhanvien.SelectedValue,


                };

                phancongcalam_bll.suaphancongcalam(phancong);

                MessageBox.Show("Cập thông tin khách hàng thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadPhancongcalam();

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("vui long nhap du thong tin:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_phancongcalam.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn ca lam cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int phancong = Convert.ToInt32(dgv_phancongcalam.CurrentRow.Cells["ID_PHANCONG"].Value);
                phancongcalam_bll.xoaphancongcalam(phancong);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhancongcalam();
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
            DataTable dt = phancongcalam_bll.timkiemphancongcalam(keyword);
            dgv_phancongcalam.DataSource = dt;
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            ufrm_quanlynhanvien Quanlynv = new ufrm_quanlynhanvien();
            this.Controls.Add(Quanlynv);
            Quanlynv.Dock = DockStyle.Fill;
        }

        private void btn_don_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
    }

