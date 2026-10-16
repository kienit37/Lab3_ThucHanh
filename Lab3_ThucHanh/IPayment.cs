using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal interface  IPayment 
    {
        bool KiemTraGiaoDich(out string message);  
        void GhiNhanGiaoDich(decimal soTien);
    }
}
