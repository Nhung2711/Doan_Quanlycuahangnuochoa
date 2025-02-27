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
    public class DAL_Taikhoan
    {
        private string connectionString;
        public DAL_Taikhoan(string connecion)
        {
            this.connectionString = connecion;
        }


        //___________tai dl________________
    
        public DataTable LoadDataTaiKhoan()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                string query = @"SELECT TAIKHOAN.ID_TAIKHOAN, TAIKHOAN.EMAIL, TAIKHOAN.MATKHAU, TAIKHOAN.ID_PHANQUYEN, PHANQUYEN.TENQUYEN FROM TAIKHOAN JOIN PHANQUYEN ON TAIKHOAN.ID_PHANQUYEN = PHANQUYEN.ID_PHANQUYEN";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            return dt;
        }
        //===================================================================
        public bool kiemtrataikhoan(string taikhoan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string kiemtraQuery = "select count(*) from TAIKHOAN where EMAIL = @EMAIL";
                SqlCommand kiemtracmd = new SqlCommand(kiemtraQuery, connection);
                kiemtracmd.Parameters.AddWithValue("@EMAIL", taikhoan);// goi lai lenh thuc hien
                return (int)kiemtracmd.ExecuteScalar() > 0;
            }
        }
        //===================================================================
        public bool themtaikhona(Taikhoan taikhoan)// trong model
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string themQuery = "insert into TAIKHOAN (EMAIL, MATKHAU, ID_PHANQUYEN) values (@EMAIL, @MATKHAU, @ID_PHANQUYEN)";

                SqlCommand themcmd = new SqlCommand(themQuery, connection);//thuc hien lenh truy van

                // goi lai lenh thuc hien

                themcmd.Parameters.AddWithValue("@EMAIL", taikhoan.EMAIL);
                themcmd.Parameters.AddWithValue("@MATKHAU", taikhoan.MATKHAU);
                
                themcmd.Parameters.AddWithValue("@ID_PHANQUYEN", taikhoan.ID_PHANQUYEN);

                return themcmd.ExecuteNonQuery() > 0;
            }

        }
        //===============================================================
        public bool suataikhoan(Taikhoan taikhoan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string suaQuery = "update TAIKHOAN set EMAIL = @EMAIL, MATKHAU = @MATKHAU, ID_PHANQUYEN = @ID_PHANQUYEN where ID_TAIKHOAN = @ID_TAIKHOAN";
                SqlCommand suacmd = new SqlCommand(suaQuery, connection);//thuc hien lenh truy van
                suacmd.Parameters.AddWithValue("@EMAIL", taikhoan.EMAIL);
                suacmd.Parameters.AddWithValue("@MATKHAU", taikhoan.MATKHAU);
         
                suacmd.Parameters.AddWithValue("@ID_PHANQUYEN", taikhoan.ID_PHANQUYEN);
                suacmd.Parameters.AddWithValue("@ID_TAIKHOAN", taikhoan.ID_TAIKHOAN);

                return suacmd.ExecuteNonQuery() > 0;
            }
        }
        //=============================================================
        public bool xoataikhoan(int ID_TAIKHOAN)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string xoaQuery = "delete from TAIKHOAN where ID_TAIKHOAN = @ID_TAIKHOAN";
                SqlCommand xoacmd = new SqlCommand(xoaQuery, connection);//thuc hien lenh truy van
                xoacmd.Parameters.AddWithValue("@ID_TAIKHOAN", ID_TAIKHOAN);// goi lai lenh thuc hien
                return xoacmd.ExecuteNonQuery() > 0;
            }
        }
        //===============================================
        public DataTable timkiemtaikhoan(string keyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string timkiemQuery = "select * from TAIKHOAN where EMAIL like @keyword";
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
