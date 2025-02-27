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
    public partial class ufrm_mataikhoan : UserControl
    {
        database db = new database();
        private BLL_Taikhoan taikhoanbll;
        private Timer taikhoanTimer;
        public ufrm_mataikhoan()
        {
            InitializeComponent();
            taikhoanbll = new BLL_Taikhoan(new database().GetDatabase());
            LoadTaikhoan();
            taikhoanTimer = new Timer();
            taikhoanTimer.Interval = 1000;
            taikhoanTimer.Tick += (s, e) => Loadcbtaikhoan();
            taikhoanTimer.Start();
        }
        public void Loadcbtaikhoan()
        {
            string connectionString = new database().GetDatabase();
            string query = "SELECT ID_PHANQUYEN, TENQUYEn FROM PHANQUYEN";


            var selectedValue = cb_tenquyen.SelectedValue;

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb_tenquyen.DisplayMember = "TENQUYEN";
            cb_tenquyen.ValueMember = "ID_PHANQUYEN";
            cb_tenquyen.DataSource = dt;


            if (selectedValue != null && dt.AsEnumerable().Any(row => row["ID_PHANQUYEN"].ToString() == selectedValue.ToString()))
            {
                cb_tenquyen.SelectedValue = selectedValue;
            }
            else
            {

                cb_tenquyen.SelectedIndex = 0;
            }

        }

        private void ufrm_mataikhoan_Load(object sender, EventArgs e)
        {
            
        }
        public void LoadTaikhoan()
        {
            try
            {
                dgv_taikhoan.DataSource =taikhoanbll.GetDataTaikhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thông tin kết nối:" + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Clear()
        {
            txt_email.Text = "";
            txt_password.Text = "";
            cb_tenquyen.SelectedIndex = 0;

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                Taikhoan taikhoan = new Taikhoan
                {
                    EMAIL = txt_email.Text.Trim(),
                    MATKHAU = txt_password.Text.Trim(),
                    ID_PHANQUYEN = (int)cb_tenquyen.SelectedValue,



                };
                taikhoanbll.themtaikhoan(taikhoan);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTaikhoan();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin" , "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_taikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowst = dgv_taikhoan.Rows[e.RowIndex];

                txt_maloaikhachhang.Text = rowst.Cells["ID_TAIKHOAN"]?.Value != DBNull.Value ? rowst.Cells["ID_TAIKHOAN"].Value.ToString() : "";
                txt_email.Text = rowst.Cells["EMAIL"]?.Value != DBNull.Value ? rowst.Cells["EMAIL"].Value.ToString() : "";

                txt_password.Text = rowst.Cells["MATKHAU"]?.Value != DBNull.Value ? rowst.Cells["MATKHAU"].Value.ToString() : "";

               
                if (rowst.Cells["ID_PHANQUYEN"]?.Value != null && rowst.Cells["ID_PHANQUYEN"].Value != DBNull.Value)
                {
                    int mataikhoan = Convert.ToInt32(rowst.Cells["ID_PHANQUYEN"].Value);
                    cb_tenquyen.SelectedValue = mataikhoan;
                }
                else
                {
                    cb_tenquyen.SelectedIndex = -1;
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
           
                Taikhoan taikhoan = new Taikhoan
                {
                    ID_TAIKHOAN = Convert.ToInt32(dgv_taikhoan.CurrentRow.Cells["ID_TAIKHOAN"].Value),
                    EMAIL = txt_email.Text.Trim(),
                    MATKHAU = txt_password.Text.Trim(),

                    ID_PHANQUYEN = (int)cb_tenquyen.SelectedValue,


                };

                taikhoanbll.suataikhoan(taikhoan);

                MessageBox.Show("Cập thông tin tài khoản thành công ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTaikhoan();

                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin " , "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_taikhoan.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn tài khoản cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int mataikhoan = Convert.ToInt32(dgv_taikhoan.CurrentRow.Cells["ID_TAIKHOAN"].Value);
                taikhoanbll.xoataikhoan(mataikhoan);
                MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTaikhoan();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_don_Click(object sender, EventArgs e)
        {
            txt_maloaikhachhang.Text = "";
            txt_password.Text = "";
            txt_email.Text = "";
            cb_tenquyen.SelectedIndex = 0;
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_timkiem.Text.Trim();
            DataTable dt = taikhoanbll.timkiemtaikhoan(keyword);
            dgv_taikhoan.DataSource = dt;
        }
    }
}
