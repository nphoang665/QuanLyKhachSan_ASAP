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
        //public List<DTO_DoanhThuTheoThang> ThongKeDoanhThuTheoThang(int nam)
        //{
        //    var query = from hd in db.HoaDons
        //                where hd.NgayThue.Value.Year == nam
        //                group hd by new { Month = hd.NgayThue.Value.Month, Year = hd.NgayThue.Value.Year } into g
        //                select new DTO_DoanhThuTheoThang
        //                {
        //                    Thang = g.Key.Month,
        //                     Nam = g.Key.Year,
        //                    DoanhThu = g.Sum(hd => hd.TongTien)
        //                };

        //    return query.ToList();
        //}

        //public List<DTO_DoanhThuTheoNgay> ThongKeDoanhThuTheoNgay(int nam, int thang)
        //{
        //    var query = from hd in db.HoaDons
        //                where hd.NgayThue.Value.Year == nam && hd.NgayThue.Value.Month == thang
        //                group hd by hd.NgayThue.Value.Day into g
        //                select new DTO_DoanhThuTheoNgay
        //                {
        //                    ngay = g.Key,
        //                    doanhthu = g.Sum(hd => hd.TongTien)
        //                };

        //    return query.ToList();
        //}


    }
}
