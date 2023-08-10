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
        public ThuePhong LoadThongtinPhong(string maphong)
        {
            var qr = db.ThuePhongs.FirstOrDefault(s => s.MaPhong == maphong);
            return qr;

        }
        public ThongTinKhachHang loadthongtinKhachHang (string makhachhang)
        {
            var qr = db.ThongTinKhachHangs.FirstOrDefault(s => s.MaKhachHang == makhachhang);
            return qr;
        }
        public List<DangKyDichVu> LoadDanhSachDangKyDichVu(string maPhong)
        {
            var danhSachDangKyDichVu = db.DangKyDichVus.Where(d => d.MaPhong == maPhong).ToList();
            return danhSachDangKyDichVu;
        }
        public string GetTenDichVuByMaDichVu(string maDichVu)
        {
            var dichVu = db.QuanLyDichVus.FirstOrDefault(dv => dv.MaDichVu == maDichVu);
            return dichVu != null ? dichVu.TenDichVu : "";
        }

    }
}
