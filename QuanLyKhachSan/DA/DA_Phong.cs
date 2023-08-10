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
            var ds = db.Phong.Select(s =>
            new
            {
                s.MaPhong,
                s.LoaiPhong,
                s.TinhTrang,
                s.DonGia
            }
            ).ToList();
            return ds;
        }
        public void ThemPhong(string maPhong, string loaiPhong, string tinhTrang, float donGia)
        {
            var phong = new Phong
            {
                MaPhong = maPhong,
                LoaiPhong = loaiPhong,
                TinhTrang = tinhTrang,
                DonGia = donGia
            };
            db.Phong.Add(phong);
            db.SaveChanges();
        }

        public void SuaPhong(string maPhong, string loaiPhong, string tinhTrang, float donGia)
        {
            var phong = db.Phong.FirstOrDefault(p => p.MaPhong == maPhong);
            if (phong != null)
            {
               
                phong.LoaiPhong = loaiPhong;
                phong.TinhTrang = tinhTrang;
                phong.DonGia = donGia;
                db.SaveChanges();
            }
        }

        public void XoaPhong(string maPhong)
        {
            var phong = db.Phong.FirstOrDefault(p => p.MaPhong == maPhong);
            if (phong != null)
            {
                db.Phong.Remove(phong);
                db.SaveChanges();
            }
        }
        public Phong LayPhong(string id)
        {
            return db.Phong.FirstOrDefault(t => t.MaPhong == id);
        }
        public IList TimPhongBangMaPhong(string timkiem)
        {
            var qr = db.Phong
                .Where(s => s.MaPhong.Contains(timkiem))
                .Select(select => new
                {
                    select.MaPhong,
                    select.LoaiPhong,
                    select.TinhTrang,
                    select.DonGia
                }).ToList();
            return qr;
        }
        public IList TimPhongBangTinhTrang(string tinhTrang)
        {
            var qr = db.Phong
                .Where(s => s.TinhTrang.Contains(tinhTrang)) 
                .Select(select => new
                {
                    select.MaPhong,
                    select.LoaiPhong,
                    select.TinhTrang,
                    select.DonGia
                }).ToList();
            return qr;
        }

        public IList TimPhongBangLoaiPhong(string loaiPhong)
        {
            var qr = db.Phong
                .Where(s => s.LoaiPhong.Contains(loaiPhong))
                .Select(select => new
                {
                    select.MaPhong,
                    select.LoaiPhong,
                    select.TinhTrang,
                    select.DonGia
                }).ToList();
            return qr;
        }

        public bool KiemTraPhongDaCoKhachThue(string maPhong)
        {
            return db.ThuePhong.Any(d => d.MaPhong == maPhong);
        }
        public void CapNhatTrangThaiPhong(string maPhong, string tinhTrang)
        {
            var phong = db.Phong.FirstOrDefault(p => p.MaPhong == maPhong);
            if (phong != null)
            {
                phong.TinhTrang = tinhTrang;
                db.SaveChanges();
            }
        }
    }
}

