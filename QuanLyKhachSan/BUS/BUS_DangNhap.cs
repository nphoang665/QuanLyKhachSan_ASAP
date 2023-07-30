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


    }
}
