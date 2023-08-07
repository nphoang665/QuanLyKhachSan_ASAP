using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_ThongTinTaiKhoan
    {
        QuanLyKhachSanEntities db;
        public DA_ThongTinTaiKhoan()
        {
            db= new QuanLyKhachSanEntities();
        }
        public TaiKhoan layThongTinTaiKhoan(string TenDangNhap)
        {
            return db.TaiKhoans.FirstOrDefault(s=> s.TenDangNhap==TenDangNhap);
        }
        public NhanSu laythongTinNhanSu(string manhansu)
        {
            return db.NhanSus.FirstOrDefault(s => s.MaNhanSu == manhansu);
        }
    }
}
