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
    public class DAL_Nhacungcap
    {
        private string connectionString;
        public DAL_Nhacungcap(string connecion)
        {
            this.connectionString = connecion;
        }
        //============================================
        public DataTable LoadDataNhacungcap()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                connection.Open();
                string query = "select * from NHACUNGCAP";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            return dt;

        }
        //========================================================
        public bool kiemtranhacungcap(string tennhacungcap)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string kiemtraQuery = "select count(*) from NHACUNGCAP where TENNCC = @TENNCC";
                SqlCommand kiemtracmd = new SqlCommand(kiemtraQuery, connection);
                kiemtracmd.Parameters.AddWithValue("@TENNCC", tennhacungcap);// goi lai lenh thuc hien
                return (int)kiemtracmd.ExecuteScalar() > 0;
            }
        }
        //=========================================================
        public bool themnhacc(nhacungcap nhacc)// trong model
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string themQuery = "insert into NHACUNGCAP (TENNCC, DIACHI, SDT) values (@TENNCC, @DIACHI, @SDT)";

                SqlCommand themcmd = new SqlCommand(themQuery, connection);//thuc hien lenh truy van

                // goi lai lenh thuc hien

                themcmd.Parameters.AddWithValue("@TENNCC", nhacc.TENNCC);
                themcmd.Parameters.AddWithValue("@DIACHI", nhacc.DIACHI);
                themcmd.Parameters.AddWithValue("@SDT", nhacc.SDT);


                return themcmd.ExecuteNonQuery() > 0;
            }

        }
        //========================================================

        public bool suanhacc(nhacungcap nhacungcap)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string suaQuery = "update NHACUNGCAP set  TENNCC= @TENNCC, SDT = @SDT, DIACHI=@DIACHI where ID_NHACC = @ID_NHACC";
                SqlCommand suacmd = new SqlCommand(suaQuery, connection);//thuc hien lenh truy van
                suacmd.Parameters.AddWithValue("@TENNCC", nhacungcap.TENNCC);
                suacmd.Parameters.AddWithValue("@SDT", nhacungcap.SDT);
                suacmd.Parameters.AddWithValue("@DIACHI", nhacungcap.DIACHI);
                suacmd.Parameters.AddWithValue("@ID_NHACC", nhacungcap.ID_NHACC);

                return suacmd.ExecuteNonQuery() > 0;
            }
        }
        //============================================================
        public bool xoanhacungcap(int ID_NHACC)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string xoaQuery = "delete from NHACUNGCAP where ID_NHACC = @ID_NHACC";
                SqlCommand xoacmd = new SqlCommand(xoaQuery, connection);//thuc hien lenh truy van
                xoacmd.Parameters.AddWithValue("@ID_NHACC", ID_NHACC);// goi lai lenh thuc hien
                return xoacmd.ExecuteNonQuery() > 0;
            }
        }
        //==========================================================
        public DataTable timkiem(string keyword)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string timkiemQuery = "select * from NHACUNGCAP where TENNCC like @keyword";
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
