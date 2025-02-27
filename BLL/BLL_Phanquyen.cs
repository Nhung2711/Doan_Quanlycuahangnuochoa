using DAL.DAL;
using DAL.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Phanquyen
    {
        public DAL_Phanquyen phanquyenDAL;
        public BLL_Phanquyen( string DBconection)
        {
            phanquyenDAL=new DAL_Phanquyen(DBconection);
        }
        //--------------load data----------------
        public DataTable GetDataPhanQuyen()
        {
            return phanquyenDAL.LoadDataPhanQuyen();
        }
        //--------------them----------------
         public bool themPhanquyen(Phanquyen phanquyen)
        {
            //kiem tra du lieu
            if (string.IsNullOrWhiteSpace(phanquyen.TENQUYEN)||string.IsNullOrWhiteSpace(phanquyen.MoTa)||phanquyen.MUCLUONGLAMVIEC <=0)
              
                throw new Exception("Du lieu khong hop le");
            //kiem tra trung ten phan quyen
            if (phanquyenDAL.kiemtraPhanquyen(phanquyen.TENQUYEN))
                throw new Exception("Ten phan quyen da ton tai");
            //tra ve ket qua
            return phanquyenDAL.themphanquyen(phanquyen);
        }
        //-----------------sua----------------
        public bool suaPhanquyen(Phanquyen phanquyen)
        {
            //kiem tra du lieu
            if (phanquyen.ID_PHANQUYEN<=0||string.IsNullOrWhiteSpace(phanquyen.TENQUYEN) || string.IsNullOrWhiteSpace(phanquyen.MoTa) || phanquyen.MUCLUONGLAMVIEC <= 0)
                throw new Exception("Vui lòng nhập đầy đủ thông tin trước khi thay đỏi thông tin phân quyền");
            
            //tra ve ket qua
            return phanquyenDAL.suaphanquyen(phanquyen);
        }
        //-----------------xoa----------------
        public bool xoaphanquyen(int ID_PHANQUYEN)
        {
            //kiem tra du lieu
            if (ID_PHANQUYEN <= 0)
                throw new Exception("vui lòng chọn phân quyền cần xóa");
            //tra ve ket qua
            return phanquyenDAL.xoaphanquyen(ID_PHANQUYEN);
        }
        //-----------------tim kiem----------------
        public DataTable timkiemPhanquyen(string keyword)
        {
            return phanquyenDAL.timkiemphanquyen(keyword);
        }
    }
}
