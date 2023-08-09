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
        /* public dynamic hienthongtincbo_d()
         {
             var qr = db.QuanLyDichVus.Select(s => s.MaDichVu).ToList();
             return qr;
         }*/
        public dynamic hienthongtincbo_d()
        {
            var qr = db.QuanLyDichVus.Select(s => new { s.MaDichVu, s.TenDichVu }).ToList();
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
        public List<string> GetRoomIDs()
        {
            var roomIDs = db.Phongs.Select(p => p.MaPhong).ToList();

            return roomIDs;
        }
        public void InsertDangKyDichVu(string maDangKyDV, string maDichVu, string maPhong, int soLuong, float donGia)
        {
            var dangKyDichVu = new DangKyDichVu
            {
                MaDangKyDV = maDangKyDV,
                MaDichVu = maDichVu,
                MaPhong = maPhong,
                SoLuong = soLuong,
                DonGia = donGia
            };

            db.DangKyDichVus.Add(dangKyDichVu);
            db.SaveChanges();
        }

        public List<string> GetRentedRoomIDs()
        {
            var rentedRoomIDs = db.ThuePhongs.Select(dkp => dkp.MaPhong).ToList();
            return rentedRoomIDs;
        }
        public float GetDonGiaByMaDichVu(string maDichVu)
        {
            var quanLyDichVu = db.QuanLyDichVus.FirstOrDefault(qldv => qldv.MaDichVu == maDichVu);
            if (quanLyDichVu != null)
            {
                return (float)quanLyDichVu.DonGia.Value;
            }
            return 0; // Hoặc giá trị mặc định khác tùy ý
        }

        public bool CheckDichVuDaTonTai(string maDichVu, string maPhong)
        {
            return db.DangKyDichVus.Any(d => d.MaDichVu == maDichVu && d.MaPhong == maPhong);
        }

        public void UpdateDangKyDichVu(string maDichVu, string maPhong, int soLuong)
        {
            var dangKyDichVu = db.DangKyDichVus.FirstOrDefault(d => d.MaDichVu == maDichVu && d.MaPhong == maPhong);
            if (dangKyDichVu != null)
            {
                dangKyDichVu.SoLuong += soLuong;
                db.SaveChanges();
            }
        }
        public string GetMaDichVuByTenDichVu(string tenDichVu)
        {
            var maDichVu = db.QuanLyDichVus.Where(qldv => qldv.TenDichVu == tenDichVu).Select(qldv => qldv.MaDichVu).FirstOrDefault();
            return maDichVu;
        }
        public bool CheckMaDangKyDVTonTai(string maDangKyDV)
        {
            return db.DangKyDichVus.Any(d => d.MaDangKyDV == maDangKyDV);
        }

        public string GetMaDangKyDVByDichVuPhong(string maDichVu, string maPhong)
        {
            string maDangKyDV = null;

            var dangKyDV = db.DangKyDichVus.FirstOrDefault(dv => dv.MaDichVu == maDichVu && dv.MaPhong == maPhong);

            if (dangKyDV != null)
            {
                maDangKyDV = dangKyDV.MaDangKyDV;
            }

            return maDangKyDV;
        }
        public bool CheckPhongCoKhachThue(string maPhong)
        {
            return db.ThuePhongs.Any(tp => tp.MaPhong == maPhong);
        }

        public string GetMaDichVuByPhong(string maPhong)
        {
            var dangKyDV = db.DangKyDichVus.FirstOrDefault(dv => dv.MaPhong == maPhong);
            if (dangKyDV != null)
            {
                return dangKyDV.MaDichVu;
            }
            return null;
        }
        public string GetTenDichVuByMaDichVu(string tenDichVu)
        {
            var tenDichVu1 = db.QuanLyDichVus.Where(qldv => qldv.TenDichVu == tenDichVu).Select(qldv => qldv.TenDichVu).FirstOrDefault();
            return tenDichVu1;
        }


    }
}
