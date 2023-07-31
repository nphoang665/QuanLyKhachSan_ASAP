using System.Collections.Generic;
using System.Linq;

namespace QuanLyKhachSan.DA
{
    public class DA_DichVu
    {
        QuanLyKhachSanEntities db;
        public DA_DichVu()
        {
            db = new QuanLyKhachSanEntities();

        }
        public dynamic LoadDichVu()
        {
            var qr = db.QuanLyDichVus.Select(s => new
            {
                s.MaDichVu,
                s.TenDichVu,
                s.DonGia,
                s.DonViTinh
            }).ToList();
            return qr;
        }
        public void ThemDichVu_d(string madv, string tendv, float dongia, string donvitinh)
        {
            var dichVu = new QuanLyDichVu
            {
                MaDichVu = madv,
                TenDichVu = tendv,
                DonGia = dongia,
                DonViTinh = donvitinh
            };
            db.QuanLyDichVus.Add(dichVu);
            db.SaveChanges();
        }
        public dynamic hienthongtincbo_d()
        {
            var qr = db.QuanLyDichVus.Select(s => s.MaDichVu).ToList();
            return qr;
        }
        public List<QuanLyDichVu> timdichvu_d(string madv)
        {
            var qr = db.QuanLyDichVus.Where(s => s.MaDichVu == madv).ToList();
            return qr;
        }
        public List<QuanLyDichVu> timtendichvu_d(string tendichvu)
        {
            var qr = db.QuanLyDichVus.Where(s => s.TenDichVu.StartsWith(tendichvu)).ToList();
            return qr;
        }
        public void SuaDichVu_d(string madv, string tendv, float dongia, string donvitinh)
        {
            var qr = db.QuanLyDichVus.Single(s => s.MaDichVu == madv);

            qr.TenDichVu = tendv;
            qr.DonGia = dongia;
            qr.DonViTinh = donvitinh;
            db.SaveChanges();
        }
       public void XoaDichVu_d(string madv)
        {
            var qr = db.QuanLyDichVus.FirstOrDefault(s => s.MaDichVu == madv);
           
            db.QuanLyDichVus.Remove(qr);
            db.SaveChanges();
        }
        public QuanLyDichVu laydichvu(string madv)
        {
            return db.QuanLyDichVus.FirstOrDefault(t => t.MaDichVu == madv);
        }
    }
}
