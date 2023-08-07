using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class BUS_DangKy
    {
        DA_DangKy da;
        public BUS_DangKy() { 
        da= new DA_DangKy();
        }
        public NhanSu KiemTraTTNS(string cccd)
        {
            return da.KiemTraThongTinNhanSu(cccd);
        }
        public void ThemTK(string tk, string mk, string kq, string mns)
        {
             da.themaccount(tk, mk, kq, mns);
        }
    }
}
