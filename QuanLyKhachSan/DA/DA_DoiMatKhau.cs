using System.Linq;

namespace QuanLyKhachSan.DA
{
    public class DA_DoiMatKhau
    {
        QuanLyKhachSanEntities db;
        public DA_DoiMatKhau()
        {
            db = new QuanLyKhachSanEntities();
        }
        public TaiKhoan LayMatKhau(string tk)
        {
            return db.TaiKhoans.FirstOrDefault(s => s.TenDangNhap == tk);
        }
        public bool DoiMatKhau(string tk, string mk, string mkmoi)
        {
            bool frag = false;
            var dmk = db.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tk && t.MatKhau == mk);
            if (dmk != null)
            {
                dmk.MatKhau = mkmoi;
                frag = true;
                db.SaveChanges();
            }
            else
            {
                frag = false;
            }
            return frag;
        }
    }

}
