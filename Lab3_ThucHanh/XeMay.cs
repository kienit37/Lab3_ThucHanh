using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal class XeMay : IMove
    {
        public int TocDo { get; set; } = 60;
        public decimal ChiPhiXang { get; set; } = 50000m;
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
