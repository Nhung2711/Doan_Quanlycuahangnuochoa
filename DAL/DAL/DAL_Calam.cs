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
    public class DAL_Calam
    {
        private string connectionString;
        public DAL_Calam(string connecion)
        {
            this.connectionString = connecion;
        }
        //============================================
        public DataTable LoadDataCalam()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                string query = "select * from CALAMVIEC";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            return dt;

        }
        //============================================================
        public bool kiemtracalam(string tencalam)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string kiemtraQuery = "select count(*) from CALAMVIEC where TENCA = @TENCA";
                SqlCommand kiemtracmd = new SqlCommand(kiemtraQuery, connection);
                kiemtracmd.Parameters.AddWithValue("@TENCA", tencalam);// goi lai lenh thuc hien
                return (int)kiemtracmd.ExecuteScalar() > 0;
            }
        }
        //==================================================================
        public bool themcalam(Calamviec calam)// trong model
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string themQuery = "insert into CALAMVIEC (TENCA, GIOBATDAU, GIOKETTHUC) values (@TENCA, @GIOBATDAU, @GIOKETTHUC)";

                SqlCommand themcmd = new SqlCommand(themQuery, connection);//thuc hien lenh truy van

                // goi lai lenh thuc hien

                themcmd.Parameters.AddWithValue("@TENCA", calam.TENCA);
                themcmd.Parameters.AddWithValue("@GIOBATDAU", calam.GIOBATDAU);
                themcmd.Parameters.AddWithValue("@GIOKETTHUC", calam.GIOKETTHUC);
                

                return themcmd.ExecuteNonQuery() > 0;
            }

        }
        //=================================================
        public bool suacalam(Calamviec calam)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string suaQuery = "update CALAMVIEC set TENCA = @TENCA, GIOBATDAU = @GIOBATDAU, GIOKETTHUC = @GIOKETTHUC where ID_CALAM = @ID_CALAM";
                SqlCommand suacmd = new SqlCommand(suaQuery, connection);//thuc hien lenh truy van
                suacmd.Parameters.AddWithValue("@TENCA", calam.TENCA);
                suacmd.Parameters.AddWithValue("@GIOBATDAU", calam.GIOBATDAU);
                suacmd.Parameters.AddWithValue("@GIOKETTHUC", calam.GIOKETTHUC);
                suacmd.Parameters.AddWithValue("@ID_CALAM", calam.ID_CALAM);

                return suacmd.ExecuteNonQuery() > 0;
            }
        }
        //============================================================
        public bool xoacalam(int ID_CALAM)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string xoaQuery = "delete from CALAMVIEC where ID_CALAM = @ID_CALAM";
                SqlCommand xoacmd = new SqlCommand(xoaQuery, connection);//thuc hien lenh truy van
                xoacmd.Parameters.AddWithValue("@ID_CALAM", ID_CALAM);// goi lai lenh thuc hien
                return xoacmd.ExecuteNonQuery() > 0;
            }
        }
        //=============================================================
        public DataTable timkiemcalam(string keyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string timkiemQuery = "select * from CALAMVIEC where TENCA like @keyword";
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
