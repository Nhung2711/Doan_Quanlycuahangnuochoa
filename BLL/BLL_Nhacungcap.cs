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
    public class BLL_Nhacungcap
    {
        public DAL_Nhacungcap nhacungcapdal;
        public BLL_Nhacungcap(string DBconnection)
        {
            nhacungcapdal = new DAL_Nhacungcap(DBconnection);
        }
        //-----------------load data-----------------
        public DataTable GetDataNhacungcap()
        {
            return nhacungcapdal.LoadDataNhacungcap();
        }
        //==========================================
        public bool kiemtrancc(string tennhacungcap)
        {
            return nhacungcapdal.kiemtranhacungcap(tennhacungcap);

        }
        //==============================================
        public bool themnhacungcap(nhacungcap ncc)
        {

            //kiem tra du lieu
            if (string.IsNullOrWhiteSpace(ncc.TENNCC))

                throw new Exception("Dữ liệu không hợp lệ");

            if (nhacungcapdal.kiemtranhacungcap(ncc.TENNCC))
                throw new Exception("Tên khách hàng đã tồn tại");

            return nhacungcapdal.themnhacc(ncc);
        }
        //============================================

        public bool suanhacungcap(nhacungcap ncc)
        {
            if (ncc.ID_NHACC <= 0 || string.IsNullOrWhiteSpace(ncc.TENNCC) || string.IsNullOrWhiteSpace(ncc.DIACHI) || string.IsNullOrWhiteSpace(ncc.DIACHI) )
            {
                throw new Exception("Dữ liệu không hợp lệ");
            }

            
            //tra ve ket qua
            return nhacungcapdal.suanhacc(ncc);
        }
        //===============================================
        public bool xoanhacc(int ID_NHACC)
        {
            //kiem tra du lieu
            if (ID_NHACC <= 0)
                throw new Exception("Vui lòng chọn phân quyền cần xóa");
            //tra ve ket qua
            return nhacungcapdal.xoanhacungcap(ID_NHACC);

        }
        //==============================================
        public DataTable timkiemnhacc(string keyword)
        {
            return nhacungcapdal.timkiem(keyword);
        }
    }
}
