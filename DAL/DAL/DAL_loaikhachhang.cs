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
        public DataTable LoadDataLoaiTaiKhoan()
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
        public bool kiemtraloaikhachhang(string tenloaitaikhoan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string kiemtraQuery = "select count(*) from LOAIKHACHHANG where TENLOAI = @TENLOAI";
                SqlCommand kiemtracmd = new SqlCommand(kiemtraQuery, connection);
                kiemtracmd.Parameters.AddWithValue("@TENLOAI", tenloaitaikhoan);// goi lai lenh thuc hien
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
    }
}
