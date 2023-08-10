using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DA;

namespace QuanLyKhachSan.BUS
{
    public class BUS_DangNhap
    {
        DA_DangNhap da_dangnhap;
        public BUS_DangNhap()
        {
            da_dangnhap = new DA_DangNhap();
        }
        public bool DangNhapTaiKhoan(string tk, string mk)
        {
            bool kq = da_dangnhap.DangNhap(tk, mk);

            return kq;
        }

        public void LuuThongTinDangNhap(string username, string password)
        {
            da_dangnhap.da_LuuThongTinDangNhap(username, password);
        }
        public LuuMatKhau LayThongTinDaLuu()
        {
            return da_dangnhap.da_LayThongTinDaLuu();
        }
        public void CapNhapThongTin(string username, string password)
        {
            da_dangnhap.da_CapNhapThongTin(username, password);
        }
        public void XoaThongTinDaLuu()
        {
            da_dangnhap.da_XoaThongTinDaLuu();
        }

        public bool kiemtraluumk()
        {
            return da_dangnhap.kiemtraluumk();
        }
        public string KiemTraTinhTrang(string tk)
        {
            return da_dangnhap.KiemTraTinhTrang(tk);
        }
        public string LayLyDo(string tk)
        {
            return da_dangnhap.LayLyDo(tk);
        }
    }
}
