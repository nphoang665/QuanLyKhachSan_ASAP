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
        public HoaDon LayTtTraPhong(string mahoadon)
        {
            return da.layHoaDon(mahoadon);
        }
        public ThuePhong layttDatphong(string maphong)
        {
            return da.layphong(maphong);
        }
        public float layTongTienDichVu(string maphong)
        {
            return da.layTongTienDichVu(maphong);
        }
        //public float TinhTongTien(Phong phong,ThuePhong thuePhong, float tongTienDichVu)
        //{
        //    return da.TinhTongTien(phong, thuePhong, tongTienDichVu);
        //}
    }
}
