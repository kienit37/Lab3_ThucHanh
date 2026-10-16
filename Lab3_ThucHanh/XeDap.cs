using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal class XeDap: IMove
    {
        public int TocDo { get; set; } = 15; // km/h
        public decimal ChiPhiBaoDuong { get; set; } = 5000m; // chi phí bảo dưỡng

        public decimal TinhChiPhiVanHanh()
        {
            return ChiPhiBaoDuong;
        }

        public int LayTocDo()
        {
            return TocDo;
        }
    }
}
