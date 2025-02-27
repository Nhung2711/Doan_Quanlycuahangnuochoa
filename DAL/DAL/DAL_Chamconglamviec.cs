using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.MODEL;

namespace DAL.DAL
{
    public class DAL_Chamconglamviec
    {
        private string connectionString;
        public DAL_Chamconglamviec(string connecion)
        {
            this.connectionString = connecion;
        }
        //====================================================
        public DataTable LoadDataChamcong()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                string query = "select CHAMCONGLAMVIEC.ID_CHAMCONG, CHAMCONGLAMVIEC.ID_NHANVIEN, NHANVIEN.HOTEN, CHAMCONGLAMVIEC.NGAYLAMVIEC, CHAMCONGLAMVIEC.TRANGTHAI FROM CHAMCONGLAMVIEC JOIN NHANVIEN ON CHAMCONGLAMVIEC.ID_NHANVIEN= NHANVIEN.ID_NHANVIEN";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            return dt;

        }
        //=====================================================
        public bool kiemtrachamcong(int ID_NHANVIEN, DateTime NGAYLAMVIEC)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string kiemtraQuery = "SELECT COUNT(*) FROM CHAMCONGLAMVIEC WHERE ID_NHANVIEN = @ID_NHANVIEN AND CAST(NGAYLAMVIEC AS DATE) = @NGAYLAMVIEC";

              
                SqlCommand kiemtracmd = new SqlCommand(kiemtraQuery, connection);//thuc hien lenh truy van
                kiemtracmd.Parameters.AddWithValue("@ID_NHANVIEN", ID_NHANVIEN);
                kiemtracmd.Parameters.AddWithValue("@NGAYLAMVIEC", NGAYLAMVIEC.Date);
                return (int)kiemtracmd.ExecuteScalar() > 0;
            }
        }
        //===========================================================
        // Cập nhật tổng công 
        public void UpdateTongCong(int maNV, int increment)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE NHANVIEN SET TONGNGAYCONG = TONGNGAYCONG + @Increment WHERE ID_NHANVIEN = @ID_NHANVIEN";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Increment", increment);
                    cmd.Parameters.AddWithValue("@ID_NHANVIEN", maNV);
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public bool CheckChamCongExists(int maNV, DateTime ngayCong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM CHAMCONGLAMVIEC WHERE ID_NHANVIEN = @ID_NHANVIEN AND NGAYLAMVIEC = @NGAYLAMVIEC";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_NHANVIEN", maNV);
                    cmd.Parameters.AddWithValue("@NGAYLAMVIEC", ngayCong);
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }

        }


        public bool themchamcong(chamcong chamcong)// trong model
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string themQuery = "insert into CHAMCONGLAMVIEC (ID_NHANVIEN, NGAYLAMVIEC, TRANGTHAI) values (@ID_NHANVIEN, @NGAYLAMVIEC, @TRANGTHAI)";

                SqlCommand themcmd = new SqlCommand(themQuery, connection);//thuc hien lenh truy van

                // goi lai lenh thuc hien

                themcmd.Parameters.AddWithValue("@ID_NHANVIEN", chamcong.ID_NHANVIEN);
                themcmd.Parameters.AddWithValue("@NGAYLAMVIEC", chamcong.NGAYLAMVIEC);
                themcmd.Parameters.AddWithValue("@TRANGTHAI", chamcong.TRANGTHAI);
            
                return themcmd.ExecuteNonQuery() > 0;
            }

        }
        //========================================================
        public bool suachamconglamviec(chamcong chamcong)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string suaQuery = "update CHAMCONGLAMVIEC set ID_NHANVIEN = @ID_NHANVIEN, NGAYLAMVIEC = @NGAYLAMVIEC, TRANGTHAI = @TRANGTHAI where ID_CHAMCONG = @ID_CHAMCONG";
                SqlCommand suacmd = new SqlCommand(suaQuery, connection);//thuc hien lenh truy van
                suacmd.Parameters.AddWithValue("@ID_NHANVIEN", chamcong.ID_NHANVIEN);
                suacmd.Parameters.AddWithValue("@NGAYLAMVIEC", chamcong.NGAYLAMVIEC);
                suacmd.Parameters.AddWithValue("@TRANGTHAI", chamcong.TRANGTHAI);
                suacmd.Parameters.AddWithValue("@ID_CHAMCONG", chamcong.ID_CHAMCONG);

                return suacmd.ExecuteNonQuery() > 0;
            }
        }
        //========================================================
        public bool xoachamcong(int ID_CHAMCONG)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string xoaQuery = "delete from CHAMCONGLAMVIEC where ID_CHAMCONG = @ID_CHAMCONG";
                SqlCommand xoacmd = new SqlCommand(xoaQuery, connection);//thuc hien lenh truy van
                xoacmd.Parameters.AddWithValue("@ID_CHAMCONG", ID_CHAMCONG);// goi lai lenh thuc hien
                return xoacmd.ExecuteNonQuery() > 0;
            }
        }
        //============================================================
        public DataTable timkiemchamcong(string keyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string timkiemQuery = "select CHAMCONGLAMVIEC.ID_CHAMCONG, CHAMCONGLAMVIEC.ID_NHANVIEN, NHANVIEN.HOTEN, CHAMCONGLAMVIEC.NGAYLAMVIEC, CHAMCONGLAMVIEC.TRANGTHAI FROM CHAMCONGLAMVIEC JOIN NHANVIEN ON CHAMCONGLAMVIEC.ID_NHANVIEN= NHANVIEN.ID_NHANVIEN where HOTEN like @keyword";
                SqlCommand timkiemcmd = new SqlCommand(timkiemQuery, connection);
                timkiemcmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataAdapter da = new SqlDataAdapter(timkiemcmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }
    }
}
