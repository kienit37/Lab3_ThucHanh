using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal class Oto: IMove
    {
        public int TocDo { get; set; } = 100; // km/h
        public decimal ChiPhiXang { get; set; } = 200000m; // chi phí mỗi 100km

        public decimal TinhChiPhiVanHanh()
        {
            return ChiPhiXang;
        }

        public int LayTocDo()
        {
            return TocDo;
        }
    }
}
