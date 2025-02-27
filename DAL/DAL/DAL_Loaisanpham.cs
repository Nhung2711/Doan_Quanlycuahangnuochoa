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
   public class DAL_Loaisanpham
   {
        private string connectionString;
        public DAL_Loaisanpham(string connecion)
        {
            connectionString = connecion;
        }
        //___________tai dl________________
        public DataTable LoadDataLoaisp()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "select * from LOAISANPHAM";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            return dt;
        }
        //-----------kiemtra-------------------
        public bool kiemtraloaisp(string tenloaisp)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string kiemtraQuery = "select count(*) from LOAISANPHAM where TENLOAISP = @TENLOAISP";
                SqlCommand kiemtracmd = new SqlCommand(kiemtraQuery, connection);
                kiemtracmd.Parameters.AddWithValue("@TENLOAISP", tenloaisp);// goi lai lenh thuc hien
                return (int)kiemtracmd.ExecuteScalar() > 0;
            }
        }
        //===================================================================
        public bool themloaisp(Loaisp loaisp)// trong model
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string themQuery = "insert into LOAISANPHAM (TENLOAISP) values(@TENLOAISP)";

                SqlCommand themcmd = new SqlCommand(themQuery, connection);//thuc hien lenh truy van

                // goi lai lenh thuc hien

                themcmd.Parameters.AddWithValue("@TENLOAISP", loaisp.TENLOAISP);

                return themcmd.ExecuteNonQuery() > 0;
            }
        }
        //==================================================================================
        public bool sualoaisp(Loaisp loaisp)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string suaQuery = "update LOAISANPHAM set TENLOAISP = @TENLOAISP where ID_LOAISP = @ID_LOAISP";
                SqlCommand suacmd = new SqlCommand(suaQuery, connection);//thuc hien lenh truy van
                suacmd.Parameters.AddWithValue("@ID_LOAISP", loaisp.ID_LOAISP);// goi lai lenh thuc hien
                suacmd.Parameters.AddWithValue("@TENLOAISP", loaisp.TENLOAISP);
                
                return suacmd.ExecuteNonQuery() > 0;
            }
        }
        //=================================================
        public bool xoaloaisp(int loaisp)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string xoaQuery = "delete from LOAISANPHAM where ID_LOAISP = @ID_LOAISP";
                SqlCommand xoacmd = new SqlCommand(xoaQuery, connection);//thuc hien lenh truy van
                xoacmd.Parameters.AddWithValue("@ID_LOAISP", loaisp);// goi lai lenh thuc hien
                return xoacmd.ExecuteNonQuery() > 0;
            }
        }
        //=============================
        public DataTable timkiemloaisp(string keyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string timkiemQuery = "select * from LOAISANPHAM where TENLOAISP like @keyword";
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
