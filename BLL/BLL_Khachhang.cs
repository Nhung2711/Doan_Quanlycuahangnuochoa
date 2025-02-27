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
    public class BLL_Khachhang
    {
        public DAL_Khachhang khachhangDAL;

        public BLL_Khachhang(string DBconnection)
        {
            khachhangDAL = new DAL_Khachhang(DBconnection);
        }



        //-----------------load data-----------------
        public DataTable GetDataKhachHang()
        {
            return khachhangDAL.LoadDataKhachhang();
        }




        public bool kiemtrakhachhang(string tenkhachhang)
        {
            return khachhangDAL.kiemtrakhachhang(tenkhachhang);

        }



        public bool themkhachhang(khachhang kh)
        {
           
            if (kh.NGAYSINH == default ||  string.IsNullOrWhiteSpace(kh.HOTEN) || string.IsNullOrWhiteSpace(kh.DIACHI) || string.IsNullOrWhiteSpace(kh.SDT))
            {
                throw new Exception("Du lieu khong hop le");
            }

            if (khachhangDAL.kiemtrakhachhang(kh.HOTEN))
            {
                throw new Exception("Ten khach hang da ton tai");
            }
            if (kh.NGAYSINH >= DateTime.Now)
            {
                throw new Exception("Không được chọn ngày sinh lơn hơn hiện tại ! ");
            }

            //tra ve ket qua
            return khachhangDAL.themkhachhang(kh);
        }
        //==============================================

        public bool suakhachhang(khachhang kh)
        {
            if (kh.ID_KHACHHANG <= 0 || string.IsNullOrWhiteSpace(kh.HOTEN) || string.IsNullOrWhiteSpace(kh.DIACHI) || string.IsNullOrWhiteSpace(kh.SDT) || kh.NGAYSINH == default)
            {
                throw new Exception("Du lieu khong hop le");
            }

            if (kh.NGAYSINH >= DateTime.Now) 
            {
                throw new Exception("Không được chọn ngày sinh lơn hơn hiện tại ! ");
            }
            //tra ve ket qua
            return khachhangDAL.suakhachhang(kh);
        }
        //===========================================
        public bool xoakhachhang(int ID_KHACHHANG)
        {
            //kiem tra du lieu
            if (ID_KHACHHANG <= 0)
                throw new Exception("vui lòng chọn phân quyền cần xóa");
            //tra ve ket qua
            return khachhangDAL.xoaKH(ID_KHACHHANG);

        }
        //==========================================
         public DataTable timkiemkhachhang(string keyword)
        {
            return khachhangDAL.timkiemkhachhang(keyword);
        }
    }
 }

