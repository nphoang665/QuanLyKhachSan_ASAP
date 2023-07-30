using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_Phong
    {
        QuanLyKhachSanEntities db;
        public DA_Phong()
        {
            db = new QuanLyKhachSanEntities();
        }
        public dynamic LayPhong()
        {
            var ds = db.Phongs.Select(s =>
            new
            {
                s.MaPhong,
                s.MaDichVu,
                s.LoaiPhong,
                s.TinhTrang,
                s.DonGia
            }
            ).ToList();
            return ds;
        }
        public void ThemPhong(string maPhong,string maDichVu, string loaiPhong, string tinhTrang, float donGia)
        {
            var phong = new Phong
            {
                MaPhong = maPhong,
                MaDichVu = maDichVu,
                LoaiPhong = loaiPhong,
                TinhTrang = tinhTrang,
                DonGia = donGia
            };
            db.Phongs.Add(phong);
            db.SaveChanges();
        }

        public void SuaPhong(string maPhong, string maDichVu, string loaiPhong, string tinhTrang, float donGia)
        {
            var phong = db.Phongs.FirstOrDefault(p => p.MaPhong == maPhong);
            if (phong != null)
            {
                phong.MaDichVu = maDichVu;
                phong.LoaiPhong = loaiPhong;
                phong.TinhTrang = tinhTrang;
                phong.DonGia = donGia;
                db.SaveChanges();
            }
        }

        public void XoaPhong(string maPhong)
        {
            var phong = db.Phongs.FirstOrDefault(p => p.MaPhong == maPhong);
            if (phong != null)
            {
                db.Phongs.Remove(phong);
                db.SaveChanges();
            }
        }
        public Phong LayPhong(string id)
        {
            return db.Phongs.FirstOrDefault(t => t.MaPhong == id);
        }
        public IList TimPhongBangMaPhong(string timkiem)
        {
           var qr= db.Phongs.Where(s=> s.MaPhong.StartsWith(timkiem))
                .Select(select=> new
                {
                    select.MaPhong,
                    select.MaDichVu,
                    select.LoaiPhong,
                    select.TinhTrang,
                    select.DonGia
                }).ToList();
            return qr;

        }
        public IList TimPhongBangTinhTrang(string tinhtrang)
        {
            var qr = db.Phongs.Where(s => s.TinhTrang.StartsWith(tinhtrang))
               .Select(select => new
               {
                   select.MaPhong,
                   select.MaDichVu,
                   select.LoaiPhong,
                   select.TinhTrang,
                   select.DonGia
               }).ToList();
            return qr;

        }
    }
}

