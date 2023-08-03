using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_TraPhong
    {
        QuanLyKhachSanEntities db;
        public DA_TraPhong()
        {
            db = new QuanLyKhachSanEntities();
        }
        public HoaDon layHoaDon(string mahoadon)
        {
            return db.HoaDons.FirstOrDefault(s => s.MaHoaDon == mahoadon);
        }
        public DatPhong layphong(string maphong)
        {
            return db.DatPhongs.FirstOrDefault(s => s.MaPhong == maphong);
        }
    }
}
