using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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
            return db.TaiKhoan.FirstOrDefault(s=> s.TenDangNhap==TenDangNhap);
        }
        public NhanSu laythongTinNhanSu(string manhansu)
        {
            return db.NhanSu.FirstOrDefault(s => s.MaNhanSu == manhansu);
        }
        public void layanhNV(string manv, PictureBox pic)
        {
            var sv = db.NhanSu.FirstOrDefault(a => a.MaNhanSu == manv);
            if (sv == null)
            {
                MessageBox.Show("Không có");
                return;
            }
            using (MemoryStream stream = new MemoryStream(sv.AnhNhanVien))
            {
                pic.Image = Image.FromStream(stream);
            }
        }
        public void LuuAnhNhanVien(string manhansu, Image anh)
        {
            var nhansu = db.NhanSu.FirstOrDefault(s => s.MaNhanSu == manhansu);
            if (nhansu != null)
            {
                using (var stream = new MemoryStream())
                {
                    anh.Save(stream, ImageFormat.Jpeg);
                    nhansu.AnhNhanVien = stream.ToArray();
                }
                db.SaveChanges();
            }
        }

    }
}
