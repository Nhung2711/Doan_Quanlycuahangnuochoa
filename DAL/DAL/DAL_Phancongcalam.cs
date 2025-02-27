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
    public class DAL_Phancongcalam
    {
        private string connectionString;
        public DAL_Phancongcalam(string connecion)
        {
            this.connectionString = connecion;
        }
        //=========================================================\
        public DataTable LoadDataPhancongcalam()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                string query =
                    @"SELECT PHANCONGCALAM.ID_PHANCONG, 
                                PHANCONGCALAM.ID_NHANVIEN,
                                NHANVIEN.HOTEN,
                                PHANCONGCALAM.ID_CALAM,
                                CALAMVIEC.TENCA,
                                PHANCONGCALAM.NGAYLAM,
                                CALAMVIEC.GIOBATDAU,
                                CALAMVIEC.GIOKETTHUC
                        FROM PHANCONGCALAM
                        INNER JOIN NHANVIEN ON PHANCONGCALAM.ID_NHANVIEN = NHANVIEN.ID_NHANVIEN
                        INNER JOIN CALAMVIEC ON PHANCONGCALAM.ID_CALAM = CALAMVIEC.ID_CALAM";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            return dt;
        }
        //==============================================================
       
        //====================================================================
        public bool themphancongcalam (phanCongCaLam phancong)// trong model
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string themQuery = "insert into PHANCONGCALAM (ID_NHANVIEN, ID_CALAM, NGAYLAM) values (@ID_NHANVIEN, @ID_CALAM, @NGAYLAM)";

                SqlCommand themcmd = new SqlCommand(themQuery, connection);//thuc hien lenh truy van

                // goi lai lenh thuc hien

                themcmd.Parameters.AddWithValue("@ID_NHANVIEN", phancong.ID_NHANVIEN);
                themcmd.Parameters.AddWithValue("@ID_CALAM", phancong.ID_CALAM);
                themcmd.Parameters.AddWithValue("@NGAYLAM", phancong.NGAYLAM);


                return themcmd.ExecuteNonQuery() > 0;
            }

        }
        //========================================================
        public bool suaphancongcanlam(phanCongCaLam phancongcalam)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string suaQuery = "update PHANCONGCALAM set ID_NHANVIEN = @ID_NHANVIEN, ID_CALAM = @ID_CALAM, NGAYLAM = @NGAYLAM where ID_PHANCONG = @ID_PHANCONG";
                SqlCommand suacmd = new SqlCommand(suaQuery, connection);//thuc hien lenh truy van
                suacmd.Parameters.AddWithValue("@ID_NHANVIEN",phancongcalam.ID_NHANVIEN);
                suacmd.Parameters.AddWithValue("@ID_CALAM", phancongcalam.ID_CALAM);
                suacmd.Parameters.AddWithValue("@NGAYLAM", phancongcalam.NGAYLAM);
                suacmd.Parameters.AddWithValue("@ID_PHANCONG", phancongcalam.ID_PHANCONG);

                return suacmd.ExecuteNonQuery() > 0;
            }
        }
        //=========================================================
        public bool xoaphancongcalam(int ID_PHANCONG)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string xoaQuery = "delete from PHANCONGCALAM where ID_PHANCONG = @ID_PHANCONG";
                SqlCommand xoacmd = new SqlCommand(xoaQuery, connection);//thuc hien lenh truy van
                xoacmd.Parameters.AddWithValue("@ID_PHANCONG", ID_PHANCONG);// goi lai lenh thuc hien
                return xoacmd.ExecuteNonQuery() > 0;
            }
        }
        //========================================================
        public DataTable timkiemphancongcalam(string keyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string timkiemQuery =@"SELECT PHANCONGCALAM.ID_PHANCONG, 
                                PHANCONGCALAM.ID_NHANVIEN,
                                NHANVIEN.HOTEN,
                                PHANCONGCALAM.ID_CALAM,
                                CALAMVIEC.TENCA,
                                PHANCONGCALAM.NGAYLAM,
                                CALAMVIEC.GIOBATDAU,
                                CALAMVIEC.GIOKETTHUC
                                 FROM PHANCONGCALAM
                                 INNER JOIN NHANVIEN ON PHANCONGCALAM.ID_NHANVIEN = NHANVIEN.ID_NHANVIEN
                                 INNER JOIN CALAMVIEC ON PHANCONGCALAM.ID_CALAM = CALAMVIEC.ID_CALAM where HOTEN like @keyword";
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
