using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BUS
{
    public class BUS_TraPhong
    {
        DA_TraPhong da;
        public BUS_TraPhong()
        {
            da = new DA_TraPhong();
        }
        public ThuePhong layttDatphong(string maphong)
        {
            return da.layphong(maphong);
        }
        public float layTongTienDichVu(string maphong)
        {
            return da.layTongTienDichVu(maphong);
        }
        public void LuuThongTinThanhToan(HoaDon hoaDon)
        {
            // Lưu thông tin thanh toán vào CSDL
            da.LuuThongTinThanhToan(hoaDon);
        }
        public string laycccd(string makhachhang)
        {
            return da.layCCCD(makhachhang);
            
        }
        public string LaySDT(string makhachhang)
        {
            return da.laySDT(makhachhang);

        }
    }
}
