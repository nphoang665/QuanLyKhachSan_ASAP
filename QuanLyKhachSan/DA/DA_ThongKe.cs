using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var months = Enumerable.Range(1, 11);
            var query = from month in months
                        join hd in db.HoaDon.Where(hd => hd.NgayThue.Value.Year == nam)
                        on month equals hd.NgayThue.Value.Month into g
                        select new DTO_DoanhThuTheoThang
                        {
                            Thang = month,
                            Nam = nam,
                            DoanhThu = g.Sum(hd => hd.TongTienThanhToan)
                        };
            return query.ToList();
        }

        public List<DTO_DoanhThuTheoNgay> ThongKeDoanhThuTheoNgay(int nam, int thang)
        {

            int daysInMonth = DateTime.DaysInMonth(nam, thang);
            var days = Enumerable.Range(1, daysInMonth);
            var query = from day in days
                        join hd in db.HoaDon.Where(hd => hd.NgayThue.Value.Year == nam && hd.NgayThue.Value.Month == thang)
                        on day equals hd.NgayThue.Value.Day into g
                        select new DTO_DoanhThuTheoNgay
                        {
                            ngay = day,
                            doanhthu = g.Sum(hd => hd.TongTienThanhToan)
                        };
            return query.ToList();



        }



    }
}
