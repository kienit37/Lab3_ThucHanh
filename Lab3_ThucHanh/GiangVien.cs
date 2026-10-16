using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal class GiangVien : NhanVien
    {
        public int SoTietDay { get; set; }
        public decimal DonGiaMoiTiet { get; set; }

        public override decimal TinhLuong()
        {
            return SoTietDay * DonGiaMoiTiet;
        }
    }
}
