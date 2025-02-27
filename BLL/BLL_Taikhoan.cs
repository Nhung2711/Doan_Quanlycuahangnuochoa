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
    public class BLL_Taikhoan
    {
        public DAL_Taikhoan taikhoanDAL;

        public BLL_Taikhoan(string DBconnection)
        {
            taikhoanDAL = new DAL_Taikhoan(DBconnection);
        }



        //-----------------load data-----------------
        public DataTable GetDataTaikhoan()
        {
            return taikhoanDAL.LoadDataTaiKhoan();
        }
        public bool kiemtrataikhoan(string taikhoan)
        {
            return taikhoanDAL.kiemtrataikhoan(taikhoan);

        }
        //=================================================
        public bool themtaikhoan(Taikhoan taikhoan)
        {
            //kiem tra du lieu
            if (string.IsNullOrWhiteSpace(taikhoan.EMAIL) )

                throw new Exception("Dữ liệu không hợp lệ");
            //kiem tra trung ten phan quyen
            if (taikhoanDAL.kiemtrataikhoan(taikhoan.EMAIL))
                throw new Exception("Tên email đã tồn tại");
            //tra ve ket qua
            return taikhoanDAL.themtaikhona(taikhoan);
        }
        //=================================================
        public bool suataikhoan(Taikhoan taikhoan)
        {
            //kiem tra du lieu
            if (taikhoan.ID_TAIKHOAN <= 0 || string.IsNullOrWhiteSpace(taikhoan.EMAIL) || string.IsNullOrWhiteSpace(taikhoan.MATKHAU))
                throw new Exception("Vui lòng nhập đầy đủ thông tin trước khi thay đổi thông tin tài khoản");

            //tra ve ket qua
            return taikhoanDAL.suataikhoan(taikhoan);
        }
        public bool xoataikhoan(int ID_TAIKHOAN)
        {
            //kiem tra du lieu
            if (ID_TAIKHOAN <= 0)
                throw new Exception("Vui lòng chọn tài khoản cần xóa");
            //tra ve ket qua
            return taikhoanDAL.xoataikhoan(ID_TAIKHOAN);

        }
        //================================================
        public DataTable timkiemtaikhoan(string keyword)
        {
            return taikhoanDAL.timkiemtaikhoan(keyword);
        }
    }
}
