using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal abstract class NhanVien
    {
     public string HoTen { get; set; }
        public string MaNV { get; set; }
        public abstract decimal TinhLuong();
    }
}
