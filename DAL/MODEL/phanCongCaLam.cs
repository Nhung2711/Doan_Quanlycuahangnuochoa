using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class phanCongCaLam
    {
        public int ID_PHANCONG { get; set; }
        public int ID_NHANVIEN { get; set; }
        public int ID_CALAM { get; set; }
        public DateTime NGAYLAM { get; set; }
    }
}
