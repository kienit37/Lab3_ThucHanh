using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal class NhanVienVanPhong :NhanVien
    {
        public int SoNgayLamViec { get; set; }
        public decimal LuongCoBan { get; set; }

        // Tinh Luong 
        public override decimal TinhLuong()
        {
            return LuongCoBan + SoNgayLamViec * 200000m;
        }
    }
}
