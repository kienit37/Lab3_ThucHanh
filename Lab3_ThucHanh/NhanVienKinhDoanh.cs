using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal class NhanVienKinhDoanh : NhanVien
    {
        public decimal LuongCoBan { get; set; }
        public decimal DoanhSo { get; set; }
        public decimal HoaHong { get; set; }

        public override decimal TinhLuong()
        {
            return LuongCoBan + DoanhSo * HoaHong;
        }
    }
}
