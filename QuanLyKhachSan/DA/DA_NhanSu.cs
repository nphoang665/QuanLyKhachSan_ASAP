﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan.DA
{
    public class DA_NhanSu
    {
        QuanLyKhachSanEntities db;
        public DA_NhanSu()
        {
            db = new QuanLyKhachSanEntities();
        }
        public void LayNhanVien(DataGridView dtgv)
        {
            dtgv.Rows.Clear();
            var ds = db.NhanSus.Select(s => new
            {
                s.MaNhanSu,
                s.TenNhanVien,
                s.GioiTinh,
                s.DiaChi,
                s.SoDienThoai,
                s.NgaySinh,
                s.NgayVaoLam,
                s.ChucVu

            }).ToList();
            foreach (var ns in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = ns.MaNhanSu;
                row.Cells[1].Value = ns.TenNhanVien;
                row.Cells[2].Value = ns.GioiTinh;
                row.Cells[3].Value = ns.ChucVu;
                row.Cells[4].Value = ns.NgaySinh;
                row.Cells[5].Value = ns.NgayVaoLam;
                row.Cells[6].Value = ns.DiaChi;
                row.Cells[7].Value = ns.SoDienThoai;

            }
        }
        public void ThemNhanSu(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu)
        {

            var nhansu = new NhanSu
            {
                MaNhanSu = mans,
                TenNhanVien = tenvn,
                GioiTinh = gioitinh,
                DiaChi = diachi,
                SoDienThoai = sdt,
                NgaySinh = ngaysinh,
                NgayVaoLam = ngayvaolam,
                ChucVu = chucvu
            };
            db.NhanSus.Add(nhansu);
            db.SaveChanges();
        }
        public void SuaNhanSu(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu)
        {
            var nhanSu = db.NhanSus.FirstOrDefault(ns => ns.MaNhanSu == mans);
            if (nhanSu != null)
            {
                nhanSu.TenNhanVien = tenvn;
                nhanSu.GioiTinh = gioitinh;
                nhanSu.DiaChi = diachi;
                nhanSu.SoDienThoai = sdt;
                nhanSu.NgaySinh = ngaysinh;
                nhanSu.NgayVaoLam = ngayvaolam;
                nhanSu.ChucVu = chucvu;
                db.SaveChanges();
            }
        }
        public void XoaNhanSu(string mans)
        {
            var nhansu = db.NhanSus.FirstOrDefault(ns => ns.MaNhanSu == mans);
            if (nhansu != null)
            {
                db.NhanSus.Remove(nhansu);
                db.SaveChanges();
            }
        }
        public void TimTheoTenNhanSu(string hoten, DataGridView dtgv)
        {
            var ds = db.NhanSus.Where(ns => ns.TenNhanVien.Contains(hoten)).ToList();
            dtgv.Rows.Clear();
            foreach (var ns in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = ns.MaNhanSu;
                row.Cells[1].Value = ns.TenNhanVien;
                row.Cells[2].Value = ns.GioiTinh;
                row.Cells[3].Value = ns.ChucVu;
                row.Cells[4].Value = ns.NgaySinh;
                row.Cells[5].Value = ns.NgayVaoLam;
                row.Cells[6].Value = ns.DiaChi;
                row.Cells[7].Value = ns.SoDienThoai;

            }

        }
        public void TimTheoChucVuNhanSu(string chucvu, DataGridView dtgv)
        {
            var ds = db.NhanSus.Where(ns => ns.ChucVu.Contains(chucvu)).ToList();
            dtgv.Rows.Clear();
            foreach (var ns in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = ns.MaNhanSu;
                row.Cells[1].Value = ns.TenNhanVien;
                row.Cells[2].Value = ns.GioiTinh;
                row.Cells[3].Value = ns.ChucVu;
                row.Cells[4].Value = ns.NgaySinh;
                row.Cells[5].Value = ns.NgayVaoLam;
                row.Cells[6].Value = ns.DiaChi;
                row.Cells[7].Value = ns.SoDienThoai;

            }

        }
        public void TimTheoGioiTinhNhanSu(string gioitinh, DataGridView dtgv)
        {
            var ds = db.NhanSus.Where(ns => ns.GioiTinh == gioitinh).ToList();
            dtgv.Rows.Clear();
            foreach (var ns in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = ns.MaNhanSu;
                row.Cells[1].Value = ns.TenNhanVien;
                row.Cells[2].Value = ns.GioiTinh;
                row.Cells[3].Value = ns.ChucVu;
                row.Cells[4].Value = ns.NgaySinh;
                row.Cells[5].Value = ns.NgayVaoLam;
                row.Cells[6].Value = ns.DiaChi;
                row.Cells[7].Value = ns.SoDienThoai;

            }

        }
        public void TimTheosdtNhanSu(string sdt, DataGridView dtgv)
        {
            var ds = db.NhanSus.Where(ns => ns.SoDienThoai.Contains(sdt)).ToList();
            dtgv.Rows.Clear();
            foreach (var ns in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = ns.MaNhanSu;
                row.Cells[1].Value = ns.TenNhanVien;
                row.Cells[2].Value = ns.GioiTinh;
                row.Cells[3].Value = ns.ChucVu;
                row.Cells[4].Value = ns.NgaySinh;
                row.Cells[5].Value = ns.NgayVaoLam;
                row.Cells[6].Value = ns.DiaChi;
                row.Cells[7].Value = ns.SoDienThoai;

            }

        }


    }
}