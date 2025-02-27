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
    public class BLL_Loaisanpham
    {
        public DAL_Loaisanpham loaispDAL;
        public BLL_Loaisanpham(string DBconnection)
        {
            loaispDAL = new DAL_Loaisanpham(DBconnection);
        }
        //-----------------load data-----------------
        public DataTable GetDataLoaisp()
        {
            return loaispDAL.LoadDataLoaisp();
        }
        //====================them loai khach hang--------------------------------------
        public bool themloaisp(Loaisp loaisp)
        {
            //kiem tra du lieu
            if (string.IsNullOrWhiteSpace(loaisp.TENLOAISP) )

                throw new Exception("Du lieu khong hop le");
            //kiem tra trung ten phan quyen
            if (loaispDAL.kiemtraloaisp(loaisp.TENLOAISP))
                throw new Exception("Ten khach hang da ton tai");
            //tra ve ket qua
            return loaispDAL.themloaisp(loaisp);
        }
        //========================================================
        public bool sualoaisp(Loaisp loaisp)
        {
            //kiem tra du lieu
            if (loaisp.ID_LOAISP <= 0 || string.IsNullOrWhiteSpace(loaisp.TENLOAISP))
                throw new Exception("vui lòng nhập đầy đủ thông tin trước khi thay đỏi thông tin loại khách hàng");

            //tra ve ket qua
            return loaispDAL.sualoaisp(loaisp);
        }
        //=================================================
        public bool xoaloasp(int ID_LOAISP)
        {
            //kiem tra du lieu
            if (ID_LOAISP <= 0)
                throw new Exception("vui lòng chọn phân quyền cần xóa");
            //tra ve ket qua
            return loaispDAL.xoaloaisp(ID_LOAISP);

        }
        //======================
        public DataTable timkiemloaisp(string keyword)
        {
            return loaispDAL.timkiemloaisp(keyword);
        }
    }
}
