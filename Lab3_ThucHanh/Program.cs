using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_ThucHanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bài: 1-5
            #region
            /*
            List<NguoiHoc> ds = new List<NguoiHoc>();
            
                ds.Add(new SinhVienChinhQuy { HoTen = "An", SoTinChi = 18 });
            ds.Add(new SinhVienLienThong { HoTen = "Binh", SoTinChi = 15 });
            decimal tong = 0;
            foreach(NguoiHoc nh in ds)
            {
                decimal hocphi = nh.TinhHocPhi();
                tong += hocphi;
                Console.WriteLine("{0}:{1:N0}", nh.HoTen,hocphi);
       
            }
            Console.WriteLine("Tổng học phí: {0:N0}", tong);
            */
            #endregion
            // Bài 6: 
            #region
            /*
           List<NhanVien> nv = new List<NhanVien>();
           nv.Add(new NhanVienVanPhong { HoTen = "Nguyen Van Kien", MaNV = "VP01", LuongCoBan = 3000000m, SoNgayLamViec = 20 });
           nv.Add(new NhanVienKinhDoanh { HoTen = "Tran Thi Binh", MaNV = "KD01", LuongCoBan = 4000000m, DoanhSo = 100000000m, HoaHong = 0.02m });
           nv.Add(new GiangVien { HoTen = "Le Van Cuong", MaNV = "GV01", SoTietDay = 120, DonGiaMoiTiet = 150000m });

           foreach (var ds in nv)
           {
               Console.WriteLine($"{ds.HoTen} ({ds.MaNV}) - Lương: {ds.TinhLuong():N0} VNĐ");
           }
             */
            #endregion

            // Bai 7: 
            #region
            /*
           List<IMove> phuongtien = new List<IMove> ();
           phuongtien.Add(new XeMay());
           phuongtien.Add(new XeMay());
           phuongtien.Add(new Oto());
           foreach (var i in phuongtien)
           {
               Console.WriteLine($"{i.GetType().Name} - Tốc độ: {i.LayTocDo()} km/h - Chi phí: {i.TinhChiPhiVanHanh():N0} VNĐ/100km");
           }
        
           */
            #endregion
            // Bai 8: 
            #region
            /*
            List<TaiLieu> tl = new List<TaiLieu>();
            tl.Add(new Sach { MaTL = "S01", TieuDe = "Lập trình C#", TacGia = "Nguyen Van A", SoTrang = 300 });
            tl.Add(new TapChi { MaTL = "T01", TieuDe = "Khoa học & Đời sống", TacGia = "Tran Thi B", SoPhatHanh = 45 });
            tl.Add(new LuanVan { MaTL = "L01", TieuDe = "AI trong giáo dục", TacGia = "Le Van C", ChuyenNganh = "Công nghệ thông tin" });
            foreach(var i in tl)
            {
                Console.WriteLine(i.InThongTin());
            }
            Console.WriteLine("\n Danh Sach Tai Lieu: ");
            foreach(var i in tl.OfType<Sach>())
            {
                Console.WriteLine(i.InThongTin());
            }
            */
            #endregion

            // Bai 9: 
            #region
            /*
            List<IPayment> dsThanhToan = new List<IPayment>
        {
            new ThanhToanTienMat(),
            new ChuyenKhoan { SoTaiKhoan = "123456789", SoDu = 5000000m },
            new ViDienTu { TenVi = "Momo", SoDu = 200000m }
        };

            foreach (var pt in dsThanhToan)
            {
                if (pt.KiemTraGiaoDich(out string msg))
                {
                    Console.WriteLine(msg);
                    pt.GhiNhanGiaoDich(100000m);
                }
                else
                {
                    Console.WriteLine("Lỗi: " + msg);
                }


            }
            */
            #endregion

            // Bai 10: 
            List<NguoiHoc> dsSinhVien = new List<NguoiHoc>
        {
            new SinhVienChinhQuy { HoTen = "Nguyen Van A", SoTinChi = 20 },
            new SinhVienLienThong { HoTen = "Tran Thi B", SoTinChi = 15 },
            new SinhVienTaiChuc { HoTen = "Le Van C", SoTinChi = 18 },
            new SinhVienQuocTe { HoTen = "Pham Thi D", SoTinChi = 25 }
        };

            Console.WriteLine("Danh sách sinh viên:");
            foreach (var sv in dsSinhVien.OfType<IPrintable>())
            {
                Console.WriteLine(sv.ToDisplayText());
            }
        }
    }
}

