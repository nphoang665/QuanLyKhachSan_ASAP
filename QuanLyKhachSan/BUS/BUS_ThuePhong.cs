using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class BUS_ThuePhong
    {
        DA_ThuePhong db;
        public BUS_ThuePhong()
        {
            db = new DA_ThuePhong();
        }
        public dynamic laytt()
        {
            return db.ThongTinKhachHang();
        }
        public dynamic LayThongTinKhachHangVaDatPhong(string maKhachHang)
        {
            return db.LayThongTinKhachHangVaDatPhong(maKhachHang);
        }

        public dynamic LayThongTinPhongTrong()
        {
            return db.LayThongTinPhongTrong();
        }
    }
}
