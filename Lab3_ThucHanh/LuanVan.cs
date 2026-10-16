using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal class LuanVan : TaiLieu
    {
        public string ChuyenNganh { get; set; }

        public override string InThongTin()
        {
            return $"[Luận văn] {TieuDe} - Tác giả: {TacGia}, Chuyên ngành: {ChuyenNganh}";
        }
    }
}
