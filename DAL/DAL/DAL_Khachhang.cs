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
    public class DAL_Khachhang
    {
        private string connectionString;
        public DAL_Khachhang(string connecion)
        {
          this.connectionString = connecion;
        }


        //___________tai dl________________
        public DataTable LoadDataKhachhang()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                string query = @"SELECT KHACHHANG.ID_KHACHHANG, KHACHHANG.HOTEN, KHACHHANG.NGAYSINH, KHACHHANG.DIACHI, KHACHHANG.SDT, KHACHHANG.ID_LOAIKHACHHANG, LOAIKHACHHANG.TENLOAI FROM KHACHHANG JOIN LOAIKHACHHANG ON KHACHHANG.ID_LOAIKHACHHANG= LOAIKHACHHANG.ID_LOAIKHACHHANG";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            return dt;
        }



        //----------------------------------------------------
        public bool kiemtrakhachhang(string tenkhachhang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string kiemtraQuery = "select count(*) from KHACHHANG where HOTEN = @HOTEN";
                SqlCommand kiemtracmd = new SqlCommand(kiemtraQuery, connection);
                kiemtracmd.Parameters.AddWithValue("@HOTEN", tenkhachhang);// goi lai lenh thuc hien
                return (int)kiemtracmd.ExecuteScalar() > 0;
            }
        }

        //------------------------------------------------------------
        public bool themkhachhang(khachhang khachhang)// trong model
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string themQuery = "insert into KHACHHANG (HOTEN, NGAYSINH, DIACHI, SDT, ID_LOAIKHACHHANG) values (@HOTEN, @NGAYSINH, @DIACHI, @SDT, @ID_LOAIKHACHHANG)";

                SqlCommand themcmd = new SqlCommand(themQuery, connection);//thuc hien lenh truy van

                // goi lai lenh thuc hien

                themcmd.Parameters.AddWithValue("@HOTEN", khachhang.HOTEN);
                themcmd.Parameters.AddWithValue("@NGAYSINH", khachhang.NGAYSINH);
                themcmd.Parameters.AddWithValue("@DIACHI", khachhang.DIACHI);
                themcmd.Parameters.AddWithValue("@SDT", khachhang.SDT);
                themcmd.Parameters.AddWithValue("@ID_LOAIKHACHHANG", khachhang.ID_LOAIKHACHHANG);



                return themcmd.ExecuteNonQuery() > 0;
            }

        }
        //=====================================================================
        public bool suakhachhang(khachhang khachhang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string suaQuery = "update KHACHHANG set HOTEN = @HoTen, NGAYSINH = @NgaySinh, DIACHI = @DiaChi,SDT = @sdt, ID_LOAIKHACHHANG = @loaiKhachHang where ID_KHACHHANG = @ID_KHACHHANG";
                SqlCommand suacmd = new SqlCommand(suaQuery, connection);//thuc hien lenh truy van
                suacmd.Parameters.AddWithValue("@HoTen", khachhang.HOTEN);
                suacmd.Parameters.AddWithValue("@NgaySinh", khachhang.NGAYSINH);
                suacmd.Parameters.AddWithValue("@DiaChi", khachhang.DIACHI);
                suacmd.Parameters.AddWithValue("@sdt", khachhang.SDT);
                suacmd.Parameters.AddWithValue("@loaiKhachHang", khachhang.ID_LOAIKHACHHANG);
                suacmd.Parameters.AddWithValue("@ID_KHACHHANG", khachhang.ID_KHACHHANG);

                return suacmd.ExecuteNonQuery() > 0;
            }
        }
        //=======================================================================
        public bool xoaKH(int ID_KHACHHANG)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string xoaQuery = "delete from KHACHHANG where ID_KHACHHANG = @ID_KHACHHANG";
                SqlCommand xoacmd = new SqlCommand(xoaQuery, connection);//thuc hien lenh truy van
                xoacmd.Parameters.AddWithValue("@ID_KHACHHANG", ID_KHACHHANG);// goi lai lenh thuc hien
                return xoacmd.ExecuteNonQuery() > 0;
            }
        }
        //============================================\
        public DataTable timkiemkhachhang(string keyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string timkiemQuery = "select * from KHACHHANG where HOTEN like @keyword";
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
