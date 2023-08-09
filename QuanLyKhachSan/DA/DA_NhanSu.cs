using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
                s.TenNhanSu,
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
                row.Cells[1].Value = ns.TenNhanSu;
                row.Cells[2].Value = ns.GioiTinh;
                row.Cells[3].Value = ns.ChucVu;
                row.Cells[4].Value = ns.NgaySinh;
                row.Cells[5].Value = ns.NgayVaoLam;
                row.Cells[6].Value = ns.DiaChi;
                row.Cells[7].Value = ns.SoDienThoai;

            }
        }
        public void ThemNhanSu(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu,PictureBox pi)
        {
            using (MemoryStream steam =new MemoryStream()) { 
                pi.Image.Save(steam, ImageFormat.Jpeg);
                var nhansu = new NhanSu
                {
                    MaNhanSu = mans,
                    TenNhanSu = tenvn,
                    GioiTinh = gioitinh,
                    DiaChi = diachi,
                    SoDienThoai = sdt,
                    NgaySinh = ngaysinh,
                    NgayVaoLam = ngayvaolam,
                    ChucVu = chucvu,
                    AnhNhanVien=steam.ToArray(),
                    
                };
            db.NhanSus.Add(nhansu);
            db.SaveChanges();
            }
        }
        public void SuaNhanSu(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu)
        {
            var nhanSu = db.NhanSus.FirstOrDefault(ns => ns.MaNhanSu == mans);
            if (nhanSu != null)
            {
                nhanSu.TenNhanSu = tenvn;
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
            var ds = db.NhanSus.Where(ns => ns. TenNhanSu.Contains(hoten)).ToList();
            dtgv.Rows.Clear();
            foreach (var ns in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = ns.MaNhanSu;
                row.Cells[1].Value = ns.TenNhanSu;
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
                row.Cells[1].Value = ns.TenNhanSu;
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
                row.Cells[1].Value = ns.TenNhanSu;
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
                row.Cells[1].Value = ns.TenNhanSu;
                row.Cells[2].Value = ns.GioiTinh;
                row.Cells[3].Value = ns.ChucVu;
                row.Cells[4].Value = ns.NgaySinh;
                row.Cells[5].Value = ns.NgayVaoLam;
                row.Cells[6].Value = ns.DiaChi;
                row.Cells[7].Value = ns.SoDienThoai;

            }

        }
        public void layanhNV(string manv,PictureBox pic)
        {
            var sv = db.NhanSus.FirstOrDefault(a => a.MaNhanSu == manv);
            if (sv == null)
            {
                MessageBox.Show("Không có");
                return;
            }
            using (MemoryStream stream = new MemoryStream(sv.AnhNhanVien))
            {
                pic.Image = Image.FromStream(stream);
            }
        }


    }
}
