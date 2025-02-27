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
    public class BLL_Nhanvien
    {
        public DAL_Nhanvien NhanvienDAL;

        public BLL_Nhanvien(string DBconnection)
        {
            NhanvienDAL = new DAL_Nhanvien(DBconnection);
        }
        //===================================================
        public DataTable GetDataNhanvien()
        {
            return NhanvienDAL.LoadDataNhanvien();
        }
        //====================================================

        public bool kiemtranhanvien(string tennhanvien)
        {
            return NhanvienDAL.kiemtranhanvien(tennhanvien);

        }
        //=======================================================
        public bool themnhanvien(Nhanvien nhanvien)
        {

           

            if (nhanvien.NGAYSINH == default || string.IsNullOrWhiteSpace(nhanvien.HOTEN) || string.IsNullOrWhiteSpace(nhanvien.DIACHI) || string.IsNullOrWhiteSpace(nhanvien.SDT)||nhanvien.TONGLUONG<=0||nhanvien.TONGNGAYCONG<=0)
            {
                throw new Exception("Du lieu khong hop le");
            }

            if (NhanvienDAL.kiemtranhanvien(nhanvien.HOTEN))
            {
                throw new Exception("Ten khach hang da ton tai");
            }
            if (nhanvien.NGAYSINH >= DateTime.Now)
            {
                throw new Exception("Không được chọn ngày sinh lơn hơn hiện tại ! ");
            }

            //tra ve ket qua
            return NhanvienDAL.themnhanvien(nhanvien);
        }
        //====================================================================
        public bool suanhanvien(Nhanvien nhanvien)
        {
            if (nhanvien.ID_NHANVIEN <= 0 || string.IsNullOrWhiteSpace(nhanvien.HOTEN) || string.IsNullOrWhiteSpace(nhanvien.DIACHI) || string.IsNullOrWhiteSpace(nhanvien.SDT) || nhanvien.TONGLUONG <= 0 || nhanvien.TONGNGAYCONG <= 0|| nhanvien.NGAYSINH == default)
            {
                throw new Exception("Du lieu khong hop le");
            }

            if (nhanvien.NGAYSINH >= DateTime.Now)
            {
                throw new Exception("Không được chọn ngày sinh lơn hơn hiện tại ! ");
            }
            //tra ve ket qua
            return NhanvienDAL.suanhanvien(nhanvien);
        }
        //================================================================
        public bool xoanhanvien(int ID_NHANVIEN)
        {
            //kiem tra du lieu
            if (ID_NHANVIEN <= 0)
                throw new Exception("vui lòng chọn phân quyền cần xóa");
            //tra ve ket qua
            return NhanvienDAL.xoanhanvien(ID_NHANVIEN);

        }
        //===================================================================
        public DataTable timkiemnhanvien(string keyword)
        {
            return NhanvienDAL.timkiemnhanvien(keyword);
        }
    }
}
