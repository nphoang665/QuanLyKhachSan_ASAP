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

    }
}
