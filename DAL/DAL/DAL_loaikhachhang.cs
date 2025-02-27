using DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class DAL_loaikhachhang
    {
        private string connectionString;
        public DAL_loaikhachhang(string connecion)
        {
            connectionString = connecion;
        }
        //___________tai dl________________
        public DataTable LoadDataLoaikh()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from LOAIKHACHHANG";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            return dt;
        }
        //-----------kiemtra-------------------
        public bool kiemtraloaikhachhang(string tenloaikh)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string kiemtraQuery = "select count(*) from LOAIKHACHHANG where TENLOAI = @TENLOAI";
                SqlCommand kiemtracmd = new SqlCommand(kiemtraQuery, connection);
                kiemtracmd.Parameters.AddWithValue("@TENLOAI", tenloaikh);// goi lai lenh thuc hien
                return (int)kiemtracmd.ExecuteScalar() > 0;
            }
        }
        //-----------them-------------------
        public bool themloaikhachhang(LoaiKH loaikhachhang)// trong model
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string themQuery = "insert into LOAIKHACHHANG (TENLOAI,GIAMGIA) values(@TENLOAI,@GIAMGIA)";

                SqlCommand themcmd = new SqlCommand(themQuery, connection);//thuc hien lenh truy van

                // goi lai lenh thuc hien

                themcmd.Parameters.AddWithValue("@TENLOAI", loaikhachhang.TENLOAI);

                themcmd.Parameters.AddWithValue("@GIAMGIA", loaikhachhang.GIAMGIA);



                return themcmd.ExecuteNonQuery() > 0;
            }
        }
            // //_________sua_____________________
        public bool sualoaikhachhang(LoaiKH loaikhachhang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string suaQuery = "update LOAIKHACHHANG set TENLOAI = @TENLOAI, GIAMGIA = @GIAMGIA where ID_LOAIKHACHHANG = @ID_LOAIKHACHHANG";
                SqlCommand suacmd = new SqlCommand(suaQuery, connection);//thuc hien lenh truy van
                suacmd.Parameters.AddWithValue("@ID_LOAIKHACHHANG", loaikhachhang.ID_LOAIKHACHHANG);// goi lai lenh thuc hien
                suacmd.Parameters.AddWithValue("@TENLOAI", loaikhachhang.TENLOAI);
                suacmd.Parameters.AddWithValue("@GIAMGIA", loaikhachhang.GIAMGIA);
                return suacmd.ExecuteNonQuery() > 0;
            }
        }
        //==================================================================================================//
        public bool xoaloaiKH(int ID_LOAIKHACHHANG)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string xoaQuery = "delete from LOAIKHACHHANG where ID_LOAIKHACHHANG = @ID_LOAIKHACHHANG";
                SqlCommand xoacmd = new SqlCommand(xoaQuery, connection);//thuc hien lenh truy van
                xoacmd.Parameters.AddWithValue("@ID_LOAIKHACHHANG", ID_LOAIKHACHHANG);// goi lai lenh thuc hien
                return xoacmd.ExecuteNonQuery() > 0;
            }
        }
        public DataTable timkiemloaikhachhang(string keyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string timkiemQuery = "select * from LOAIKHACHHANG where TENLOAI like @keyword";
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

