using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public DatPhong layttDatphong(string maphong)
        {
            return da.layphong(maphong);
        }

    }
}
