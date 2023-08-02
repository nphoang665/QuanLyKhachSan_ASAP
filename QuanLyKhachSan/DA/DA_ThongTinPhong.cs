using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_ThongTinPhong
    {
        QuanLyKhachSanEntities db;
        public DA_ThongTinPhong() { 
        db= new QuanLyKhachSanEntities();
        }
        public DatPhong LoadThongtinPhong(string maphong)
        {
            var qr = db.DatPhongs.FirstOrDefault(s => s.MaPhong == maphong);
            return qr;

        }
        public ThongTinKhachHang loadthongtinKhachHang (string makhachhang)
        {
            var qr = db.ThongTinKhachHangs.FirstOrDefault(s => s.MaKhachHang == makhachhang);
            return qr;
        }
    }
}
