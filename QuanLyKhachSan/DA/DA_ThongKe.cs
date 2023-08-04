using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    internal class DA_ThongKe
    {
        QuanLyKhachSanEntities db;
        public DA_ThongKe() { 
            db=new QuanLyKhachSanEntities();
        }
        public List<DTO_DoanhThuTheoThang> ThongKeDoanhThuTheoThang(int nam)
        {

            var query = from hd in db.HoaDons
                        where hd.NgayDat.Year == nam
                        group hd by hd.NgayDat.Month into g
                        select new DTO_DoanhThuTheoThang
                        {
                            Thang = g.Key,
                            DoanhThu = g.Sum(hd => hd.TongTien)
                        };
            return query.ToList();

        }
        public List<DTO_DoanhThuTheoNgay> ThongKeDoanhThuTheoNgay(int nam, int thang)
        {
            var query = from hd in db.HoaDons
                        where hd.NgayDat.Year == nam && hd.NgayDat.Month == thang
                        group hd by hd.NgayDat.Day into g
                        select new DTO_DoanhThuTheoNgay
                        {
                            ngay = g.Key,
                            doanhthu = g.Sum(hd => hd.TongTien)
                        };
            return query.ToList();
        }

    }
}
