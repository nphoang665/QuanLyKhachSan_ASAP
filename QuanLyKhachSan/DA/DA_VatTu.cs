using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_VatTu
    {
        QuanLyKhachSanEntities db;
        public DA_VatTu()
        {
            db = new QuanLyKhachSanEntities();
        }
        public dynamic LayVatTu()
        {
            var ds = db.VatTus.Select(s =>
            new
            {
                s.MaVatTu,
                s.TenVatTu,
                s.NhaCungCap,
                s.NguoiQuanLy,
                s.GhiChu
            }
            ).ToList();
            return ds;
        }
        public void ThemVatTu(string maVatTu, string tenVatTu, string nhaCungCap, string nguoiQuanLy, string ghiChu)
        {
            var vatTu = new VatTu
            {
                MaVatTu = maVatTu,
                TenVatTu = tenVatTu,
                NhaCungCap = nhaCungCap,
                NguoiQuanLy = nguoiQuanLy,
                GhiChu = ghiChu
            };
            db.VatTus.Add(vatTu);
            db.SaveChanges();
        }
        public dynamic LayNhanSu()
        {
            var ds = db.NhanSus.Select(s =>
            new
            {
                s.MaNhanSu,
                s.TenNhanVien
            }
            ).ToList();
            return ds;
        }
        public void SuaVatTu(string maVatTu, string tenVatTu, string nhaCungCap, string nguoiQuanLy, string ghiChu)
        {
            var vatTu = db.VatTus.FirstOrDefault(p => p.MaVatTu == maVatTu);
            if (vatTu != null)
            {
                vatTu.TenVatTu = tenVatTu;
                vatTu.NhaCungCap = nhaCungCap;
                vatTu.NguoiQuanLy = nguoiQuanLy;
                vatTu.GhiChu = ghiChu;
                db.SaveChanges();
            }
        }

        public void XoaVatTu(string maVatTu)
        {
            var vatTu = db.VatTus.FirstOrDefault(p => p.MaVatTu == maVatTu);
            if (vatTu != null)
            {
                db.VatTus.Remove(vatTu);
                db.SaveChanges();
            }
        }
        public dynamic TimVatTuTheoMa(string maVatTu)
        {
            var ds = db.VatTus.Where(v => v.MaVatTu == maVatTu).Select(s =>
            new
            {
                s.MaVatTu,
                s.TenVatTu,
                s.NhaCungCap,
                s.NguoiQuanLy,
                s.GhiChu
            }
            ).ToList();
            return ds;
        }

        public dynamic TimVatTuTheoTen(string tenVatTu)
        {
            var ds = db.VatTus.Where(v => v.TenVatTu.Contains(tenVatTu)).Select(s =>
            new
            {
                s.MaVatTu,
                s.TenVatTu,
                s.NhaCungCap,
                s.NguoiQuanLy,
                s.GhiChu
            }
            ).ToList();
            return ds;
        }

        public dynamic TimVatTuTheoNguoiQuanLy(string nguoiQuanLy)
        {
            var ds = db.VatTus.Where(v => v.NguoiQuanLy == nguoiQuanLy).Select(s =>
            new
            {
                s.MaVatTu,
                s.TenVatTu,
                s.NhaCungCap,
                s.NguoiQuanLy,
                s.GhiChu
            }
            ).ToList();
            return ds;
        }
    }
}
