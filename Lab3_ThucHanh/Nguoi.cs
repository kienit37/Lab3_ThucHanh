using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    public class Nguoi
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public Nguoi(string HoTen, DateTime NgaySinh)
        {
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
        }
        public virtual string MoTa()
        {
            return HoTen + " - " + NgaySinh.ToString("dd/MM/yyyy");
        }

    
}
}
