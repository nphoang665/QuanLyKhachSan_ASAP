using System.Collections;
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
            var qr = db.QuanLyDichVu.Select(s => new
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
            db.QuanLyDichVu.Add(dichVu);
            db.SaveChanges();
        }
        /* public dynamic hienthongtincbo_d()
         {
             var qr = db.QuanLyDichVus.Select(s => s.MaDichVu).ToList();
             return qr;
         }*/
        public dynamic hienthongtincbo_d()
        {
            var qr = db.QuanLyDichVu.Select(s => new { s.MaDichVu, s.TenDichVu }).ToList();
            return qr;
        }

        public List<QuanLyDichVu> timdichvu_d(string madv)
        {
            var qr = db.QuanLyDichVu.Where(s => s.MaDichVu == madv).ToList();
            return qr;
        }
        public List<QuanLyDichVu> timtendichvu_d(string tendichvu)
        {
            var qr = db.QuanLyDichVu.Where(s => s.TenDichVu.StartsWith(tendichvu)).ToList();
            return qr;
        }
        public void SuaDichVu_d(string madv, string tendv, float dongia, string donvitinh)
        {
            var qr = db.QuanLyDichVu.Single(s => s.MaDichVu == madv);

            qr.TenDichVu = tendv;
            qr.DonGia = dongia;
            qr.DonViTinh = donvitinh;
            db.SaveChanges();
        }
       public void XoaDichVu_d(string madv)
        {
            var qr = db.QuanLyDichVu.FirstOrDefault(s => s.MaDichVu == madv);
           
            db.QuanLyDichVu.Remove(qr);
            db.SaveChanges();
        }
        public QuanLyDichVu laydichvu(string madv)
        {
            return db.QuanLyDichVu.FirstOrDefault(t => t.MaDichVu == madv);
        }
        public List<string> GetRoomIDs()
        {
            var roomIDs = db.Phong.Select(p => p.MaPhong).ToList();

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

            db.DangKyDichVu.Add(dangKyDichVu);
            db.SaveChanges();
        }

        public List<string> GetRentedRoomIDs()
        {
            var rentedRoomIDs = db.ThuePhong.Select(dkp => dkp.MaPhong).ToList();
            return rentedRoomIDs;
        }
        public float GetDonGiaByMaDichVu(string maDichVu)
        {
            var quanLyDichVu = db.QuanLyDichVu.FirstOrDefault(qldv => qldv.MaDichVu == maDichVu);
            if (quanLyDichVu != null)
            {
                return (float)quanLyDichVu.DonGia.Value;
            }
            return 0; // Hoặc giá trị mặc định khác tùy ý
        }

        public bool CheckDichVuDaTonTai(string maDichVu, string maPhong)
        {
            return db.DangKyDichVu.Any(d => d.MaDichVu == maDichVu && d.MaPhong == maPhong);
        }

        public void UpdateDangKyDichVu(string maDichVu, string maPhong, int soLuong)
        {
            var dangKyDichVu = db.DangKyDichVu.FirstOrDefault(d => d.MaDichVu == maDichVu && d.MaPhong == maPhong);
            if (dangKyDichVu != null)
            {
                dangKyDichVu.SoLuong += soLuong;
                db.SaveChanges();
            }
        }
        public string GetMaDichVuByTenDichVu(string tenDichVu)
        {
            var maDichVu = db.QuanLyDichVu.Where(qldv => qldv.TenDichVu == tenDichVu).Select(qldv => qldv.MaDichVu).FirstOrDefault();
            return maDichVu;
        }
        public bool CheckMaDangKyDVTonTai(string maDangKyDV)
        {
            return db.DangKyDichVu.Any(d => d.MaDangKyDV == maDangKyDV);
        }

        public string GetMaDangKyDVByDichVuPhong(string maDichVu, string maPhong)
        {
            string maDangKyDV = null;

            var dangKyDV = db.DangKyDichVu.FirstOrDefault(dv => dv.MaDichVu == maDichVu && dv.MaPhong == maPhong);

            if (dangKyDV != null)
            {
                maDangKyDV = dangKyDV.MaDangKyDV;
            }

            return maDangKyDV;
        }
        public bool CheckPhongCoKhachThue(string maPhong)
        {
            return db.ThuePhong.Any(tp => tp.MaPhong == maPhong);
        }

        public string GetMaDichVuByPhong(string maPhong)
        {
            var dangKyDV = db.DangKyDichVu.FirstOrDefault(dv => dv.MaPhong == maPhong);
            if (dangKyDV != null)
            {
                return dangKyDV.MaDichVu;
            }
            return null;
        }
        public string GetTenDichVuByMaDichVu(string tenDichVu)
        {
            var tenDichVu1 = db.QuanLyDichVu.Where(qldv => qldv.TenDichVu == tenDichVu).Select(qldv => qldv.TenDichVu).FirstOrDefault();
            return tenDichVu1;
        }
        public IList timDV(string tenDV)
        {
            var qr = db.QuanLyDichVu
                .Where(s => s.TenDichVu.Contains(tenDV))
                .Select(select => new
                {
                    select.MaDichVu,
                    select.TenDichVu,
                    select.DonGia,
                    select.DonViTinh
                }).ToList();
            return qr;
        }


    }
}
