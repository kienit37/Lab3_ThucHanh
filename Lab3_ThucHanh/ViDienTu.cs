using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal class ViDienTu : IPayment
    {
        public string TenVi { get; set; }
        public decimal SoDu { get; set; }

        public bool KiemTraGiaoDich(out string message)
        {
            if (SoDu > 0)
            {
                message = "Ví điện tử hợp lệ.";
                return true;
            }
            else
            {
                message = "Ví điện tử không đủ số dư.";
                return false;
            }
        }

        public void GhiNhanGiaoDich(decimal soTien)
        {
            SoDu -= soTien;
            Console.WriteLine($"Đã thanh toán {soTien:N0} VNĐ bằng ví {TenVi}. Số dư còn lại: {SoDu:N0} VNĐ");
        }
    }
}
