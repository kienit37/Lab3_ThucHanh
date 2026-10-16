using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal class TapChi : TaiLieu
    {
        public int SoPhatHanh { get; set; }
        public override string InThongTin()
        {
            return $"[Tạp chí] {TieuDe} - Tác giả: {TacGia}, Số phát hành: {SoPhatHanh}";
        }
    }
}
