using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal class ChuyenKhoan : IPayment
    {
        public string SoTaiKhoan { get; set; }
        public decimal SoDu { get; set; }
        public bool KiemTraGiaoDich (out string message)
        {
            if(SoDu > 0)
            {
                message = "Chuyen Khoan Hop Le";
                return true;
            }else
            {
                message = "So Du Khong du";
                return false;
            }
        }
        public void GhiNhanGiaoDich(decimal soTien)
        {
            SoDu = SoDu - soTien;
            Console.WriteLine($"Đã chuyển khoản {soTien:N0} VNĐ từ tài khoản {SoTaiKhoan}. Số dư còn lại: {SoDu:N0} VNĐ");
        }
    }
}
