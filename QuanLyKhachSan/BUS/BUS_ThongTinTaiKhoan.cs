using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class BUS_ThongTinTaiKhoan
    {
        DA_ThongTinTaiKhoan da;
        public BUS_ThongTinTaiKhoan()
        {
            da= new DA_ThongTinTaiKhoan();
        }
        public TaiKhoan LayttTaiKhoan(string tk)
        {
            return da.layThongTinTaiKhoan(tk);
        }
        public NhanSu LayTTNhanSu(string mans)
        {
            return da.laythongTinNhanSu(mans);
        }
    }
}
