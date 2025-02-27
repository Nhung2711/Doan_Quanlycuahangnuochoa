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
    public class BLL_Loaikhachhang
    {
        public DAL_loaikhachhang loaikhachhangDAL;
        public BLL_Loaikhachhang(string DBconnection)
        {
            loaikhachhangDAL = new DAL_loaikhachhang(DBconnection);
        }
        //-----------------load data-----------------
        public DataTable GetDataLoaiKhachHang()
        {
            return loaikhachhangDAL.LoadDataLoaikh();
        }
        //them loai khach hang--------------------------------------
        public bool themloaikhachhang(LoaiKH loaikhachhang)
        {
            //kiem tra du lieu
            if (string.IsNullOrWhiteSpace(loaikhachhang.TENLOAI) || loaikhachhang.GIAMGIA <= 0)

                throw new Exception("Du lieu khong hop le");
            //kiem tra trung ten phan quyen
            if (loaikhachhangDAL.kiemtraloaikhachhang (loaikhachhang.TENLOAI))
                throw new Exception("Ten khach hang da ton tai");
            //tra ve ket qua
            return loaikhachhangDAL.themloaikhachhang(loaikhachhang);
        }
        //-----------------sua----------------
        public bool sualoaikhachhang(LoaiKH loaikhachhang)
        {
            //kiem tra du lieu
            if (loaikhachhang.ID_LOAIKHACHHANG <= 0 || string.IsNullOrWhiteSpace(loaikhachhang.TENLOAI) ||  loaikhachhang.GIAMGIA <= 0)
                throw new Exception("vui lòng nhập đầy đủ thông tin trước khi thay đỏi thông tin loại khách hàng");

            //tra ve ket qua
            return loaikhachhangDAL.sualoaikhachhang(loaikhachhang);
        }
        //-----------------xoa----------------
        public bool xoaloaikhachhang(int ID_LOAIKHACHHANG)
        {
            //kiem tra du lieu
            if (ID_LOAIKHACHHANG <= 0)
                throw new Exception("vui lòng chọn phân quyền cần xóa");
            //tra ve ket qua
            return loaikhachhangDAL.xoaloaiKH(ID_LOAIKHACHHANG);

        }
        //=============================
        public DataTable timkiemloaikhachhang(string keyword)
        {
            return loaikhachhangDAL.timkiemloaikhachhang(keyword);
        }
    }
}
