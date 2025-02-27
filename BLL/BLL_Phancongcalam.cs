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
    public class BLL_Phancongcalam
    {
        public DAL_Phancongcalam phancongcalam_dal;
        public BLL_Phancongcalam(string DBconnection)
        {
            phancongcalam_dal = new DAL_Phancongcalam(DBconnection);
        }
        //============================================================
        public DataTable GetDataPhancongcalam()
        {
            return phancongcalam_dal.LoadDataPhancongcalam();
        }
        //===========================================================
      
        //===========================================================
        public bool themphancongcalam(phanCongCaLam phancong)
        {
            //kiem tra du lieu
            if (phancong.ID_NHANVIEN <= 0 || phancong.ID_CALAM <= 0 || phancong.NGAYLAM == default)

                throw new Exception("Du lieu khong hop le");

            //kiem tra trung ten phan quyen

            //tra ve ket qua
            return phancongcalam_dal.themphancongcalam(phancong);
        }
        //========================================================
        public bool suaphancongcalam(phanCongCaLam phancongcalam)
        {
            //kiem tra du lieu
            if (phancongcalam.ID_PHANCONG <= 0 || phancongcalam.ID_NHANVIEN<=0 || phancongcalam.ID_CALAM <= 0)
                throw new Exception("vui lòng nhập đầy đủ thông tin trước khi thay đỏi thông tin loại khách hàng");

            //tra ve ket qua
            return phancongcalam_dal.suaphancongcanlam(phancongcalam);
        }
        //=================================================
        public bool xoaphancongcalam(int ID_PHANCONG)
        {
            //kiem tra du lieu
            if (ID_PHANCONG <= 0)
                throw new Exception("vui lòng chọn phân quyền cần xóa");
            //tra ve ket qua
            return phancongcalam_dal.xoaphancongcalam(ID_PHANCONG);

        }
        //================================================
        public DataTable timkiemphancongcalam(string keyword)
        {
            return phancongcalam_dal.timkiemphancongcalam(keyword);
        }
    }
}
