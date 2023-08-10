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
        /* DA_ThuePhong db;
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
         }*/
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
        public int LayThuePhongCount()
        {
            return db.LayThuePhongCount();
        }

        public void ThemThuePhong(string maThuePhong, string maKhachHang, string maPhong, DateTime ngayThue)
        {
            db.ThemThuePhong(maThuePhong, maKhachHang, maPhong, ngayThue);
        }

        public void CapNhatTrangThaiPhong(string maPhong, string trangThai)
        {
            db.CapNhatTrangThaiPhong(maPhong, trangThai);
        }
        public List<object> LayDanhSachKhachDaThue()
        {
            using (var db = new QuanLyKhachSanEntities())
            {
                var danhSachKhachThue = from tp in db.ThuePhongs
                                        join kh in db.ThongTinKhachHangs on tp.MaKhachHang equals kh.MaKhachHang
                                        select new
                                        {
                                            MaKhachHang = kh.MaKhachHang,
                                            TenKhachHang = kh.TenKhachHang,
                                            NgaySinh = kh.NgaySinh,
                                            GioiTinh = kh.GioiTinh,
                                            CMND = kh.CMND,
                                            DiaChi = kh.DiaChi,
                                            SoDienThoai = kh.SoDienThoai,
                                            MaPhong = tp.MaPhong
                                        };
                return danhSachKhachThue.ToList<object>();
            }
        }

    }
}
