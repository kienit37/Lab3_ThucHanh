using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal class Sach: TaiLieu
    {
        public int SoTrang { get; set; }

        public override string InThongTin()
        {
            return $"[Sách] {TieuDe} - Tác giả: {TacGia}, Số trang: {SoTrang}";
        }
    }
}
