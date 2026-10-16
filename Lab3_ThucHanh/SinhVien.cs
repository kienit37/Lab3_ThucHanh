using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    public class SinhVien : Nguoi, IValidatable, IPrintable
    {
    
        public string MaSV { get; set; }
        public double DiemTB { get; set; }

        public SinhVien(string HoTen, DateTime NgaySinh,string MaSV,double DiemTB) : base(HoTen, NgaySinh)
        {
            this.MaSV = MaSV;
            this.DiemTB = DiemTB;
        }
 
        public override string MoTa()
        {
            return base.MoTa() + " - " + MaSV + "- "+ DiemTB.ToString("N2");
        }
        public bool IsValid( out string message)
        {
            if (string.IsNullOrWhiteSpace(MaSV)) { message = "Thiếu mã"; return false; }
            if (DiemTB < 0 || DiemTB > 10) { message = "Điểm sai"; return false; }
            message = ""; return true;
        }
        public string ToDisplayText() { return MaSV + " - " + HoTen; }
    }
}
