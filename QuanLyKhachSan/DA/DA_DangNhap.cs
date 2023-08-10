using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_DangNhap
    {
        QuanLyKhachSanEntities db;
        public DA_DangNhap()
        {
            db = new QuanLyKhachSanEntities();
        }
        public bool DangNhap(string tk, string mk)
        {
            string tks = "";
            bool frag = false;
            var qr = db.TaiKhoans.Where(s => s.TenDangNhap == tk && s.MatKhau == mk);
            if (qr.Count() > 0)
            {
                frag = true;
            }
            else
            {
                frag = false;
            }
            return frag;
        }
        public void da_LuuThongTinDangNhap(string username, string password)
        {
            if (DangNhap(username, password))
            {
                var luuMatKhau = new LuuMatKhau
                {
                    TaiKhoan = username,
                    MatKhau = password
                };

                db.LuuMatKhaus.Add(luuMatKhau);
                db.SaveChanges();
            }
        }

        public LuuMatKhau da_LayThongTinDaLuu()
        {
            var savedLoginInfo = db.LuuMatKhaus.FirstOrDefault();

            return savedLoginInfo;
        }
        public void da_CapNhapThongTin(string username, string password)
        {
            if (DangNhap(username, password))
            {
                var savedLoginInfo = db.LuuMatKhaus.FirstOrDefault();

                if (savedLoginInfo != null)
                {
                    db.LuuMatKhaus.Remove(savedLoginInfo);
                }

                var newSavedLoginInfo = new LuuMatKhau
                {
                    TaiKhoan = username,
                    MatKhau = password
                };
                db.LuuMatKhaus.Add(newSavedLoginInfo);
                db.SaveChanges();
            }
        }

        public void da_XoaThongTinDaLuu()
        {
            db.Database.ExecuteSqlCommand("DELETE FROM LuuMatKhau");
        }
        public bool kiemtraluumk()
        {
            var qr = db.LuuMatKhaus.Select(s => new { s.TaiKhoan });
            return qr.Any();
        }
        public string KiemTraTinhTrang(string tk)
        {
            var qr = db.TaiKhoans.FirstOrDefault(s => s.TenDangNhap == tk);
            return qr.TinhTrang;
        }
        public string LayLyDo(string tk)
        {
            var qr = db.TaiKhoans.FirstOrDefault(s => s.TenDangNhap == tk);
            return qr.LyDo;
        }


    }
}
