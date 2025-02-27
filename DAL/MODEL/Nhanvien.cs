using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Nhanvien
    {
        public int ID_NHANVIEN { get; set; }
        public string HOTEN { get; set; }
        public DateTime NGAYSINH { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public decimal TONGNGAYCONG { get; set; }
        public decimal TONGLUONG { get; set; }
        public int ID_TAIKHOAN { get; set; }
    }
}
