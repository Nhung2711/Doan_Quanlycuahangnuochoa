using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Taikhoan
    {
        public int ID_TAIKHOAN { get; set; }
        public string EMAIL { get; set; }
        public string MATKHAU { get; set; }
        public int ID_PHANQUYEN { get; set; }
    }
}
