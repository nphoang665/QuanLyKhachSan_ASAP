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
            var qr = db.TaiKhoans.Where(s => s.TenDangNhap == tk && s.MatKhau == mk);
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
        public void SaveLoginInfo(string username, string password)
        {
            // Check if the provided username and password are correct
            if (DangNhap(username, password))
            {
                // If the username and password are correct, save the login information
                var luuMatKhau = new LuuMatKhau
                {
                    TaiKhoan = username,
                    MatKhau = password
                };

                db.LuuMatKhaus.Add(luuMatKhau);
                db.SaveChanges();
            }
        }

        public LuuMatKhau GetSavedLoginInfo()
        {
            var savedLoginInfo = db.LuuMatKhaus.FirstOrDefault();

            return savedLoginInfo;
        }
        public void UpdateSavedLoginInfo(string username, string password)
        {
            // Check if the provided username and password are correct
            if (DangNhap(username, password))
            {
                // If the username and password are correct, update the saved login information
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

        public void DeleteSavedLoginInfo()
        {
            // Delete all data from the LuuMatKhau table
            db.Database.ExecuteSqlCommand("DELETE FROM LuuMatKhau");
        }




    }
}
