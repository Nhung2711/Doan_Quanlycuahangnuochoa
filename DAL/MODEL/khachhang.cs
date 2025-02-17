using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class khachhang
    {
        public int ID_KHACHHANG { get; set; }
        public string TENKHACHHANG { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public string EMAIL { get; set; }
        public int ID_LOAIKHACHHANG { get; set; }
        
    }
}
