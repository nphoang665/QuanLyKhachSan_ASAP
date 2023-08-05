using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_TrangChu
    {
        QuanLyKhachSanEntities db;
        public DA_TrangChu()
        {
            db= new QuanLyKhachSanEntities();
        }
        public string LayTenTk(string tk)
        {
           var qr = db.TaiKhoans.FirstOrDefault(x => x.TenDangNhap ==tk);
            var qrnhasu = db.NhanSus.FirstOrDefault(y => y.MaNhanSu == qr.MaNhanSu);
            return qrnhasu.TenNhanVien;
        }
        public string LayChucVu(string tk)
        {
            var qr = db.TaiKhoans.FirstOrDefault(x => x.TenDangNhap == tk);
            var qrnhasu = db.NhanSus.FirstOrDefault(y => y.MaNhanSu == qr.MaNhanSu);
            return qrnhasu.ChucVu;
        }

    }
}
