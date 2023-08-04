using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class BUS_ThuePhong
    {
        DA_ThuePhong da;
        public BUS_ThuePhong()
        {
            da = new DA_ThuePhong();
        }
        public dynamic laytt()
        {
            return da.ThongTinKhachHang();
        }
        public dynamic LayThongTinKhachHangVaDatPhong(string maKhachHang)
        {
            return da.LayThongTinKhachHangVaDatPhong(maKhachHang);
        }
        public dynamic LayThongTinPhongTrong()
        {
            return da.LayThongTinPhongTrong();
        }
    }
}
