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
        public DA_DangNhap() { 
        db= new QuanLyKhachSanEntities();
        }
        public bool DangNhap(string tk, string mk)
        {
            string tks="";
            bool frag = false;
            var qr = db.TaiKhoan.Where(s => s.TenDangNhap == tk && s.MatKhau == mk);
            if (qr.Count() > 0)
            {
                frag = true;
            }
            else
            {
                frag= false;
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

                db.LuuMatKhau.Add(luuMatKhau);
                db.SaveChanges();
            }
        }

        public LuuMatKhau da_LayThongTinDaLuu()
        {
            var savedLoginInfo = db.LuuMatKhau.FirstOrDefault();

            return savedLoginInfo;
        }
        public void da_CapNhapThongTin(string username, string password)
        {
            if (DangNhap(username, password))
            {
                var savedLoginInfo = db.LuuMatKhau.FirstOrDefault();

                if (savedLoginInfo != null)
                {
                    db.LuuMatKhau.Remove(savedLoginInfo);
                }

                var newSavedLoginInfo = new LuuMatKhau
                {
                    TaiKhoan = username,
                    MatKhau = password
                };
                db.LuuMatKhau.Add(newSavedLoginInfo);
                db.SaveChanges();
            }
        }

        public void da_XoaThongTinDaLuu()
        {
            db.Database.ExecuteSqlCommand("DELETE FROM LuuMatKhau");
        }
        public bool kiemtraluumk()
        {
            var qr = db.LuuMatKhau.Select(s => new { s.TaiKhoan });
            return qr.Any();
        }



    }
}
