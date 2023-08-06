using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_ThuePhong
    {
        QuanLyKhachSanEntities db;

        public DA_ThuePhong()
        {
            db = new QuanLyKhachSanEntities();
        }
        public dynamic ThongTinKhachHang()
        {
            var qr = db.ThongTinKhachHangs.Select(s => new
            {
                s.MaKhachHang,
            }).ToList();
            return qr;
        }

        public dynamic LayThongTinKhachHangVaDatPhong(string maKhachHang)
        {
            var qr = from kh in db.ThongTinKhachHangs
                     where kh.MaKhachHang == maKhachHang
                     select new
                     {
                         kh.MaKhachHang,
                         kh.TenKhachHang,
                         kh.GioiTinh,
                         kh.NgaySinh,
                         kh.CMND,
                         kh.SoDienThoai,
                         kh.DiaChi,
                     };
            return qr.FirstOrDefault();
        }


        public dynamic LayThongTinPhongTrong()
        {
            var qr = from p in db.Phongs
                     where p.TinhTrang == "Trống"
                     select new
                     {
                         p.MaPhong,
                         p.LoaiPhong,
                         p.TinhTrang,
                         p.DonGia
                     };
            return qr.ToList();
        }
    }
}
