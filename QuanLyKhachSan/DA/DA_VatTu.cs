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
            var ds = db.VatTu.Select(s =>
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
            db.VatTu.Add(vatTu);
            db.SaveChanges();
        }
        public dynamic LayNhanSu()
        {
            var ds = db.NhanSu.Select(s =>
            new
            {
                s.MaNhanSu,
                s.TenNhanSu
            }
            ).ToList();
            return ds;
        }
        public void SuaVatTu(string maVatTu, string tenVatTu, string nhaCungCap, string nguoiQuanLy, string ghiChu)
        {
            var vatTu = db.VatTu.FirstOrDefault(p => p.MaVatTu == maVatTu);
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
            var vatTu = db.VatTu.FirstOrDefault(p => p.MaVatTu == maVatTu);
            if (vatTu != null)
            {
                db.VatTu.Remove(vatTu);
                db.SaveChanges();
            }
        }
        public dynamic TimVatTuTheoMa(string maVatTu)
        {
            var ds = db.VatTu.Where(v => v.MaVatTu == maVatTu).Select(s =>
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
            var ds = db.VatTu.Where(v => v.TenVatTu.Contains(tenVatTu)).Select(s =>
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
            var ds = db.VatTu.Where(v => v.NguoiQuanLy == nguoiQuanLy).Select(s =>
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
