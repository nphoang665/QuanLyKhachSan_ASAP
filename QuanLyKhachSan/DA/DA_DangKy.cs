using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.DA
{
    public class DA_DangKy
    {
        QuanLyKhachSanEntities db;
        public DA_DangKy()
        {

            db = new QuanLyKhachSanEntities();
        }
        public NhanSu KiemTraThongTinNhanSu(string cccd)
        {
            return db.NhanSus.FirstOrDefault(s => s.CCCD == cccd);
        }
        public void themaccount(string tk, string mk, string pq, string mns)
        {
            var taikhoan = new TaiKhoan
            {
                TenDangNhap = tk,
                MatKhau = mk,
                PhanQuyen = pq,
                MaNhanSu = mns,
                TinhTrang = "DangXuLy"

            };
            db.TaiKhoans.Add(taikhoan);
            db.SaveChanges();
        }
        public bool KiemTraTaiKhoan(string tk)
        {
            bool kiemtra = false;
            var s = db.TaiKhoans.FirstOrDefault(kt => kt.TenDangNhap == tk);
            if (s != null)
            {
                kiemtra = true;
            }

            return kiemtra;
        }
    }
}
