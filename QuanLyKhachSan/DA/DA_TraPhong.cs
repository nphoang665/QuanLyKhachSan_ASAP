using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.DA
{
    public class DA_TraPhong
    {
        QuanLyKhachSanEntities db;
        public DA_TraPhong()
        {
            db = new QuanLyKhachSanEntities();
        }
        public ThuePhong layphong(string maphong)
        {
            return db.ThuePhong.FirstOrDefault(s => s.MaPhong == maphong);
        }
        public float layTongTienDichVu(string maphong)
        {
            var dichVu = db.DangKyDichVu.Where(s => s.MaPhong == maphong);
            float tongTienDichVu = 0;
            foreach (var dv in dichVu)
            {
                tongTienDichVu += (float)(dv.SoLuong * dv.DonGia);
            }
            return tongTienDichVu;
        }
        public void LuuThongTinThanhToan(HoaDon hoaDon)
        {
            db.HoaDon.Add(hoaDon);
            db.SaveChanges();
        }
        public string layCCCD(string makhachhang)
        {
            var cccd = db.ThongTinKhachHang.FirstOrDefault(x => x.MaKhachHang == makhachhang).CMND;
            return cccd;
        }

        public string laySDT(string makhachhang)
        {
            var sdt = db.ThongTinKhachHang.FirstOrDefault(x => x.MaKhachHang == makhachhang).SoDienThoai;
            return sdt;
        }
        public void XoaDichVuDaDangKyCuaPhong(string maPhong)
        {
            var danhSachDangKyDichVu = db.DangKyDichVu.Where(dk => dk.MaPhong == maPhong).ToList();

            foreach (var dangKyDichVu in danhSachDangKyDichVu)
            {
                db.DangKyDichVu.Remove(dangKyDichVu);
            }

            db.SaveChanges();
        }
        public void XoaThuePhong(string maPhong)
        {
            var thuePhong = db.ThuePhong.FirstOrDefault(tp => tp.MaPhong == maPhong);
            if (thuePhong != null)
            {
                db.ThuePhong.Remove(thuePhong);
                db.SaveChanges();
            }
        }

    }
}
