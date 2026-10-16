using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal abstract class TaiLieu
    {
        public string MaTL { get; set; }
        public string TieuDe { get; set; }
        public string TacGia { get; set; }

        public abstract string InThongTin();
    }
}
