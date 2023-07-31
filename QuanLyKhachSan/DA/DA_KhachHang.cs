
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyKhachSan.DA
{
    internal class DA_KhachHang
    {
        QuanLyKhachSanEntities db;
        public DA_KhachHang()
        {
            db = new QuanLyKhachSanEntities();
        }
        public void LayKhachHang(DataGridView dtgv)
        {
            dtgv.Rows.Clear();
            var ds = db.ThongTinKhachHangs.Select(s => new
            {
                s.MaKhachHang,
                s.TenKhachHang,
                s.GioiTinh,
                s.NgaySinh,
                s.DiaChi,
                s.SoDienThoai,
                s.CMND,
                s.MaPhong,
                s.NgayThue

            }).ToList();
            foreach (var kh in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = kh.MaKhachHang;
                row.Cells[1].Value = kh.TenKhachHang;
                row.Cells[2].Value = kh.GioiTinh;
                row.Cells[3].Value = kh.NgaySinh;
                row.Cells[4].Value = kh.DiaChi;
                row.Cells[5].Value = kh.SoDienThoai;
                row.Cells[6].Value = kh.CMND;
                row.Cells[7].Value = kh.MaPhong;
                row.Cells[8].Value = kh.NgayThue;

            }
        }
        public void ThemKH(string makh, string tenkh, string gioitinh, DateTime ngaysinh, string diachi, string sdt, string ccccd, string maphong, DateTime ngaythue)
        {

            var kh = new ThongTinKhachHang
            {
                MaKhachHang = makh,
                TenKhachHang = tenkh,
                GioiTinh = gioitinh,
                NgaySinh = ngaysinh,
                DiaChi = diachi,
                SoDienThoai = sdt,
                CMND = ccccd,
                MaPhong = maphong,
                NgayThue = ngaythue
            };
            db.ThongTinKhachHangs.Add(kh);
            db.SaveChanges();
        }
        public void SuaKH(string makh, string tenkh, string gioitinh, DateTime ngaysinh, string diachi, string sdt, string ccccd, string maphong, DateTime ngaythue)
        {
            var kh = db.ThongTinKhachHangs.FirstOrDefault(a => a.MaKhachHang == makh);
            if (kh != null)
            {
                kh.TenKhachHang = tenkh;
                kh.GioiTinh = gioitinh;
                kh.NgaySinh = ngaysinh;
                kh.DiaChi = diachi;
                kh.SoDienThoai = sdt;
                kh.CMND = ccccd;
                kh.MaPhong = maphong;
                kh.NgayThue = ngaythue;
                db.SaveChanges();
            }
        }
        public void Xoakh(string makh)
        {
            var kh = db.ThongTinKhachHangs.FirstOrDefault(a => a.MaKhachHang == makh);
            if (kh != null)
            {
                db.ThongTinKhachHangs.Remove(kh);
                db.SaveChanges();
            }
        }
        public void TimTheoTenKh(string hoten, DataGridView dtgv)
        {
            var ds = db.ThongTinKhachHangs.Where(a => a.TenKhachHang.Contains(hoten)).ToList();
            dtgv.Rows.Clear();
            foreach (var kh in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = kh.MaKhachHang;
                row.Cells[1].Value = kh.TenKhachHang;
                row.Cells[2].Value = kh.GioiTinh;
                row.Cells[3].Value = kh.NgaySinh;
                row.Cells[4].Value = kh.DiaChi;
                row.Cells[5].Value = kh.SoDienThoai;
                row.Cells[6].Value = kh.CMND;
                row.Cells[7].Value = kh.MaPhong;
                row.Cells[8].Value = kh.NgayThue;

            }

        }
      
        public void TimTheoGioiTinhKH(string gioitinh, DataGridView dtgv)
        {
            var ds = db.ThongTinKhachHangs.Where(a => a.GioiTinh == gioitinh).ToList();
            dtgv.Rows.Clear();
            foreach (var kh in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = kh.MaKhachHang;
                row.Cells[1].Value = kh.TenKhachHang;
                row.Cells[2].Value = kh.GioiTinh;
                row.Cells[3].Value = kh.NgaySinh;
                row.Cells[4].Value = kh.DiaChi;
                row.Cells[5].Value = kh.SoDienThoai;
                row.Cells[6].Value = kh.CMND;
                row.Cells[7].Value = kh.MaPhong;
                row.Cells[8].Value = kh.NgayThue;

            }

        }
        public void TimTheocccdKH(string cccd, DataGridView dtgv)
        {
            var ds = db.ThongTinKhachHangs.Where(a => a.CMND.Contains(cccd)).ToList();
            dtgv.Rows.Clear();
            foreach (var kh in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = kh.MaKhachHang;
                row.Cells[1].Value = kh.TenKhachHang;
                row.Cells[2].Value = kh.GioiTinh;
                row.Cells[3].Value = kh.NgaySinh;
                row.Cells[4].Value = kh.DiaChi;
                row.Cells[5].Value = kh.SoDienThoai;
                row.Cells[6].Value = kh.CMND;
                row.Cells[7].Value = kh.MaPhong;
                row.Cells[8].Value = kh.NgayThue;

            }
        }

        public List<string> layda()
        {
            
                var data = db.ThongTinKhachHangs.Select(x => x.MaPhong).ToList();
                return data;
            
        }
        public List<string> laytenkh()
        {
            var data=db.ThongTinKhachHangs.Select(x => x.TenKhachHang).ToList();
            return data;
        }
        public bool khdatphong(string mkh)
        {
            var data = db.DatPhongs.Select(x => x.MaKhachHang==mkh);
            if (data != null)
            {
                MessageBox.Show("Khách vẫn còn đặt phòng");
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool kiemtrakhoa(string mk)
        {
            var data = db.ThongTinKhachHangs.Where(x => x.MaKhachHang == mk);
            if(data != null)
            {
                MessageBox.Show("Trùng khóa chính");
                return false;
            }
            else { return true; }
        }
    }
}
