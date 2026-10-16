using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    public abstract class NguoiHoc
    {
        public string HoTen { get; set; }
        public int SoTinChi { get; set; }
        public abstract decimal TinhHocPhi();
    }
    public class SinhVienChinhQuy : NguoiHoc ,IPrintable {
        public override decimal TinhHocPhi()
        {
            return SoTinChi * 450000m;
        }

        public string ToDisplayText()
        {
            return $"[Chính quy] {HoTen} - {SoTinChi} tín chỉ - Học phí: {TinhHocPhi():N0} VNĐ";
        }
    }
    public class SinhVienLienThong :NguoiHoc, IPrintable
    {
        public override decimal TinhHocPhi()
        {
            return SoTinChi * 520000m;
        }
        public string ToDisplayText()
        {
            return $"[Liên thông] {HoTen} - {SoTinChi} tín chỉ - Học phí: {TinhHocPhi():N0} VNĐ";
        }
    }
    public class SinhVienTaiChuc : NguoiHoc, IPrintable
    {
        public override decimal TinhHocPhi()
        {
           return SoTinChi * 400000m;
        }
        public string ToDisplayText()
        {
            return $"[Tại chức] {HoTen} - {SoTinChi} tín chỉ - Học phí: {TinhHocPhi():N0} VNĐ";
        }
    }

    public class SinhVienQuocTe : NguoiHoc, IPrintable
    {
        public override decimal TinhHocPhi() => SoTinChi * 1000000m;
        public string ToDisplayText()
        {
            return $"[Quốc tế] {HoTen} - {SoTinChi} tín chỉ - Học phí: {TinhHocPhi():N0} VNĐ";
        }
    }

}
