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
    public class BLL_Calam
    {
        public DAL_Calam calamDAL;
        public BLL_Calam(string DBconnection)
        {
            calamDAL = new DAL_Calam(DBconnection);
        }
        //-----------------load data-----------------
        public DataTable GetDataCalam()
        {
            return calamDAL.LoadDataCalam();
        }
        //==========================================
        public bool kiemtracalam(string tencalam)
        {
            return calamDAL.kiemtracalam(tencalam);

        }
        //==============================================
        public bool themcalam(Calamviec calam)
        {

            //kiem tra du lieu
            if (string.IsNullOrWhiteSpace(calam.TENCA))

                throw new Exception("Dữ liệu không hợp lệ");
        
            if (calamDAL.kiemtracalam(calam.TENCA))
                throw new Exception("Tên khách hàng đã tồn tại");
           
            return calamDAL.themcalam(calam);
        }
        //===================================================
        public bool suacalam(Calamviec calam)
        {
            //kiem tra du lieu
            if (calam.ID_CALAM <= 0 || string.IsNullOrWhiteSpace(calam.TENCA))
                throw new Exception("Vui lòng nhập đầy đủ thông tin trước khi thay đỏi thông tin loại khách hàng");

            //tra ve ket qua
            return calamDAL.suacalam(calam);
        }
        //================================================
        public bool xoacalam(int ID_CALAM)
        {
            //kiem tra du lieu
            if (ID_CALAM <= 0)
                throw new Exception("Vui lòng chọn phân quyền cần xóa");
            //tra ve ket qua
            return calamDAL.xoacalam(ID_CALAM);

        }
        //=============================================
        public DataTable timkiemcalam(string keyword)
        {
            return calamDAL.timkiemcalam(keyword);
        }
    }
}
