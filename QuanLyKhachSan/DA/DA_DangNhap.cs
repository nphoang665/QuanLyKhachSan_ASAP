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
            var luuMatKhau = new LuuMatKhau
            {
                TaiKhoan = username,
                MatKhau = password
            };

            db.LuuMatKhaus.Add(luuMatKhau);
            db.SaveChanges();
        }
        public LuuMatKhau GetSavedLoginInfo()
        {
            // Query the database to get the saved login information
            var savedLoginInfo = db.LuuMatKhaus.FirstOrDefault();

            // Return the saved login information
            return savedLoginInfo;
        }
        public void UpdateSavedLoginInfo(string username, string password)
        {
            // Query the database to get the saved login information
            var savedLoginInfo = db.LuuMatKhaus.FirstOrDefault();

            // Check if there is any saved login information
            if (savedLoginInfo != null)
            {
                // Update the saved login information
                savedLoginInfo.TaiKhoan = username;
                savedLoginInfo.MatKhau = password;
                db.SaveChanges();
            }
            else
            {
                // There is no saved login information, so create a new record
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
