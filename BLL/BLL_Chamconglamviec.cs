using DAL.DAL;
using DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Chamconglamviec
    {
        public DAL_Chamconglamviec chamcongdal;
        public BLL_Chamconglamviec(string DBconnection)
        {
            chamcongdal = new DAL_Chamconglamviec(DBconnection);
        }
        //-----------------load data-----------------
        public DataTable GetDataChamcong()
        {
            return chamcongdal.LoadDataChamcong();
        }
        //==========================================
       
        //========================================
        public bool themchamcong(chamcong chamcong)
        {

            //kiem tra du lieu
            //kiem tra du lieu
            if (chamcong.ID_NHANVIEN <= 0 || string.IsNullOrWhiteSpace(chamcong.TRANGTHAI) || chamcong.NGAYLAMVIEC == default)

                throw new Exception("Du lieu khong hop le");
            if (chamcongdal.kiemtrachamcong(chamcong.ID_NHANVIEN, chamcong.NGAYLAMVIEC))
            {
                return false;

            }
            chamcongdal.themchamcong(chamcong);

            if(chamcong.TRANGTHAI== "Có mặt")
            {
               chamcongdal.UpdateTongCong(chamcong.ID_NHANVIEN, 1);

            }
            return true;

           
        }
        public bool suachamcong(chamcong chamcong)
        {
            if (chamcong.ID_CHAMCONG <= 0 || chamcong.ID_NHANVIEN <= 0 || string.IsNullOrWhiteSpace(chamcong.TRANGTHAI) || chamcong.NGAYLAMVIEC == default)
            {
                throw new Exception("Du lieu khong hop le");
            }

           
            //tra ve ket qua
            return chamcongdal.suachamconglamviec(chamcong);

           
        }
        //================================================
        public bool xoachamcong(int ID_CHAMCONG)
        {
            //kiem tra du lieu
            if (ID_CHAMCONG <= 0)
                throw new Exception("vui lòng chọn phân quyền cần xóa");
            //tra ve ket qua
            return chamcongdal.xoachamcong(ID_CHAMCONG);

        }
        //=================================================


        public DataTable timkiemchamcong(string keyword)
        {
            return chamcongdal.timkiemchamcong(keyword);
        }
    }
}
