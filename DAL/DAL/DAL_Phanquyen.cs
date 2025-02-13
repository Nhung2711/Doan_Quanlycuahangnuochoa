using DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAL
{
    public class DAL_Phanquyen
    {
        private string conectionString;
        public DAL_Phanquyen(string conection)
        {
            conectionString = conection;
        }
        //________________tai du lieu______________________________
        public DataTable LoadDataPhanQuyen()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                string query = "select * from PHANQUYEN";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            return dt;

        }
        //================================
        //_______kiemtra_____________________
        public bool kiemtraPhanquyen(string tenphanquyen)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                string kiemtraQuery = "select count(*) from PHANQUYEN where TENQUYEN = @TENQUYEN";
                SqlCommand kiemtracmd = new SqlCommand(kiemtraQuery, connection);
                kiemtracmd.Parameters.AddWithValue("@TENQUYEN", tenphanquyen);// goi lai lenh thuc hien
                return (int)kiemtracmd.ExecuteScalar() > 0;
            }
        }
        //================================
        //_________them_____________________
        public bool themphanquyen(Phanquyen phanquyen)// trong model
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();

                string themQuery = "insert into PHANQUYEN( TENQUYEN,MoTa,MUCLUONGLAMVIEC) values(@TENQUYEN,@MoTa,@MUCLUONGLAMVIEC)";

                SqlCommand themcmd = new SqlCommand(themQuery, connection);//thuc hien lenh truy van

             // goi lai lenh thuc hien

                themcmd.Parameters.AddWithValue("@TENQUYEN", phanquyen.TENQUYEN);

                themcmd.Parameters.AddWithValue("@MoTa", phanquyen.MoTa);

                themcmd.Parameters.AddWithValue("@MUCLUONGLAMVIEC", phanquyen.MUCLUONGLAMVIEC);

                return themcmd.ExecuteNonQuery() > 0;
            }
        }
        //=======================================================================================//

        //_________sua_____________________
        public bool suaphanquyen(Phanquyen phanquyen)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                string suaQuery = "update PHANQUYEN set TENQUYEN = @TENQUYEN, MoTa = @MoTa, MUCLUONGLAMVIEC = @MUCLUONGLAMVIEC where ID_PHANQUYEN = @ID_PHANQUYEN";
                SqlCommand suacmd = new SqlCommand(suaQuery, connection);//thuc hien lenh truy van
                suacmd.Parameters.AddWithValue("@ID_PHANQUYEN", phanquyen.ID_PHANQUYEN);// goi lai lenh thuc hien
                suacmd.Parameters.AddWithValue("@TENQUYEN", phanquyen.TENQUYEN);
                suacmd.Parameters.AddWithValue("@MoTa", phanquyen.MoTa);
                suacmd.Parameters.AddWithValue("@MUCLUONGLAMVIEC", phanquyen.MUCLUONGLAMVIEC);
                return suacmd.ExecuteNonQuery() > 0;
            }
        }
        //==================================================================================================//

        //_________xoa_____________________
        public bool xoaphanquyen(int ID_PHANQUYEN)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                string xoaQuery = "delete from PHANQUYEN where ID_PHANQUYEN = @ID_PHANQUYEN";
                SqlCommand xoacmd = new SqlCommand(xoaQuery, connection);//thuc hien lenh truy van
                xoacmd.Parameters.AddWithValue("@ID_PHANQUYEN", ID_PHANQUYEN);// goi lai lenh thuc hien
                return xoacmd.ExecuteNonQuery() > 0;
            }
        }
        //__________timkiem_________________
        public DataTable timkiemphanquyen(string keyword)
        {
            using (SqlConnection connection = new SqlConnection(conectionString))
            {
                connection.Open();
                string timkiemQuery = "select * from PHANQUYEN where TENQUYEN like @keyword";
                SqlCommand timkiemcmd = new SqlCommand(timkiemQuery, connection);
                timkiemcmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataAdapter da = new SqlDataAdapter(timkiemcmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }

        }
        //===============================================
    }
}

