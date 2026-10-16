using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal class ThanhToanTienMat :IPayment
    {
        public bool KiemTraGiaoDich(out string message)
        {
            message = "Thanh toán tiền mặt hợp lệ.";
            return true; 
        }

        public void GhiNhanGiaoDich(decimal soTien)
        {
            Console.WriteLine($"Đã nhận {soTien:N0} VNĐ bằng tiền mặt.");
        }
    }
}
