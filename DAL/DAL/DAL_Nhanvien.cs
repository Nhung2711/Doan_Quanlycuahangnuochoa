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
    public class DAL_Nhanvien
    {
        private string connectionString;
        public DAL_Nhanvien(string connecion)
        {
            this.connectionString = connecion;
        }
        //====================================================
        public DataTable LoadDataNhanvien()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                string query = @"SELECT NHANVIEN.ID_NHANVIEN, NHANVIEN.HOTEN, NHANVIEN.NGAYSINH, NHANVIEN.DIACHI, NHANVIEN.SDT, NHANVIEN.TONGNGAYCONG, NHANVIEN.TONGLUONG, NHANVIEN.ID_TAIKHOAN, TAIKHOAN.EMAIL  FROM NHANVIEN JOIN TAIKHOAN ON NHANVIEN.ID_TAIKHOAN = TAIKHOAN.ID_TAIKHOAN";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            return dt;
        }
        //================================
        public bool kiemtranhanvien(string tennhanvien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string kiemtraQuery = "select count(*) from NHANVIEN where HOTEN = @HOTEN";
                SqlCommand kiemtracmd = new SqlCommand(kiemtraQuery, connection);
                kiemtracmd.Parameters.AddWithValue("@HOTEN", tennhanvien);// goi lai lenh thuc hien
                return (int)kiemtracmd.ExecuteScalar() > 0;
            }
        }
        //==========================================
        public bool themnhanvien(Nhanvien nhanvien)// trong model
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string themQuery = "insert into NHANVIEN (HOTEN, NGAYSINH, DIACHI, SDT, TONGNGAYCONG, TONGLUONG, ID_TAIKHOAN) values (@HOTEN, @NGAYSINH, @DIACHI, @SDT, @TONGNGAYCONG, @TONGLUONG, @ID_TAIKHOAN)";

                SqlCommand themcmd = new SqlCommand(themQuery, connection);//thuc hien lenh truy van

                // goi lai lenh thuc hien

                themcmd.Parameters.AddWithValue("@HOTEN", nhanvien.HOTEN);
                themcmd.Parameters.AddWithValue("@NGAYSINH", nhanvien.NGAYSINH);
                themcmd.Parameters.AddWithValue("@DIACHI", nhanvien.DIACHI);
                themcmd.Parameters.AddWithValue("@SDT", nhanvien.SDT);
                themcmd.Parameters.AddWithValue("@TONGNGAYCONG", nhanvien.TONGNGAYCONG);
                themcmd.Parameters.AddWithValue("@TONGLUONG", nhanvien.TONGLUONG);
                themcmd.Parameters.AddWithValue("@ID_TAIKHOAN", nhanvien.ID_TAIKHOAN);



                return themcmd.ExecuteNonQuery() > 0;
            }

        }
        //=============================================================================
        public bool suanhanvien(Nhanvien nhanvien)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string suaQuery = "update NHANVIEN set HOTEN = @HoTen, NGAYSINH = @NgaySinh, DIACHI = @DiaChi,SDT = @sdt,TONGLUONG=@TONGLUONG, TONGNGAYCONG=@TONGNGAYCONG, ID_TAIKHOAN = @ID_TAIKHOAN where ID_NHANVIEN = @ID_NHANVIEN";
                SqlCommand suacmd = new SqlCommand(suaQuery, connection);//thuc hien lenh truy van
                suacmd.Parameters.AddWithValue("@HoTen", nhanvien.HOTEN);
                suacmd.Parameters.AddWithValue("@NgaySinh", nhanvien.NGAYSINH);
                suacmd.Parameters.AddWithValue("@DiaChi", nhanvien.DIACHI);
                suacmd.Parameters.AddWithValue("@sdt", nhanvien.SDT);
                suacmd.Parameters.AddWithValue("@ID_NHANVIEN", nhanvien.ID_NHANVIEN);
                suacmd.Parameters.AddWithValue("@TONGNGAYCONG", nhanvien.TONGNGAYCONG);
                suacmd.Parameters.AddWithValue("@TONGLUONG", nhanvien.TONGLUONG);
                suacmd.Parameters.AddWithValue("@ID_TAIKHOAN", nhanvien.ID_TAIKHOAN);

                return suacmd.ExecuteNonQuery() > 0;
            }
        }
        //====================================================================================
        public bool xoanhanvien(int ID_NHANVIEN)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string xoaQuery = "delete from NHANVIEN where ID_NHANVIEN = @ID_NHANVIEN";
                SqlCommand xoacmd = new SqlCommand(xoaQuery, connection);//thuc hien lenh truy van
                xoacmd.Parameters.AddWithValue("@ID_NHANVIEN", ID_NHANVIEN);// goi lai lenh thuc hien
                return xoacmd.ExecuteNonQuery() > 0;
            }
        }
        //===================================================================================
        public DataTable timkiemnhanvien(string keyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string timkiemQuery = "select * from NHANVIEN where HOTEN like @keyword";
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
