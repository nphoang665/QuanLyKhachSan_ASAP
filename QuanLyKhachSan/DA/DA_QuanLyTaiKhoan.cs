﻿
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.DA
{
    public  class DA_QuanLyTaiKhoan
    {
        QuanLyKhachSanEntities db;
        public DA_QuanLyTaiKhoan()
        {
            db = new QuanLyKhachSanEntities();
        }
        public dynamic LayDsTk()
        {
            var ds = db.TaiKhoans.Select(s =>
            new
            {
           
                s.TenDangNhap,
                s.MatKhau,
                s.PhanQuyen,
                s.MaNhanSu
            }
            ).ToList();
            return ds;
        }
        public void ThemTaiKhoan( string tenDangNhap, string matKhau, string phanQuyen,string manhansu)
        {
            var taiKhoan = new TaiKhoan
            {

                TenDangNhap = tenDangNhap,
                MatKhau = matKhau,
                PhanQuyen = phanQuyen,
                MaNhanSu = manhansu
               
            };
            db.TaiKhoans.Add(taiKhoan);
            db.SaveChanges();
        }

        public void SuaTaiKhoan( string tenDangNhap, string matKhau, string phanQuyen,string manhansu)
        {
            var taiKhoan = db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tenDangNhap);
            if (taiKhoan != null)
            {
                taiKhoan.TenDangNhap = tenDangNhap;
                taiKhoan.MatKhau = matKhau;
                taiKhoan.PhanQuyen = phanQuyen;
                taiKhoan.MaNhanSu = manhansu;
                db.SaveChanges();
            }
        }

        public void XoaTaiKhoan(string tendangnhap)
        {
            var taiKhoan = db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tendangnhap);
            if (taiKhoan != null)
            {
                db.TaiKhoans.Remove(taiKhoan);
                db.SaveChanges();
            }
        }

        public IList TimTaiKhoan(string timKiem)
        {
            var qr = db.TaiKhoans
                .Where(t => t.TenDangNhap.StartsWith(timKiem))
                .Select(t => new
                {
                    TenDangNhap = t.TenDangNhap,
                    MatKhau = t.MatKhau,
                    PhanQuyen = t.PhanQuyen,
                    MaNhanSu = t.MaNhanSu
                })
                .ToList();
            return qr;
        }

        public bool KiemTraPhanQuyen(string MaNhanSu,string PhanQuyen)
        {
            bool kiemTra = false;
            var PQ = db.NhanSus.FirstOrDefault(s => s.MaNhanSu == MaNhanSu);
            if( PhanQuyen==PQ.ChucVu)
            {
                kiemTra = true;

            }
            else
            {
                kiemTra = false;
            }
            return kiemTra;
        }




        public TaiKhoan LayTaiKhoan(string tendangnhap)
        {
            return db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tendangnhap);
        }
        public bool KiemTraTenDangNhap(string tenDangNhap)
        {
            // Query the database to see if a record with the given username already exists
            var taiKhoan = db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tenDangNhap);
            return taiKhoan != null;
        }

        public bool KiemTraMaNhanSu(string maNhanSu)
        {
            // Query the employee table to see if a record with the given employee code already exists
            var nhanSu = db.NhanSus.FirstOrDefault(n => n.MaNhanSu == maNhanSu);
            return nhanSu != null;
        }

    }
}
