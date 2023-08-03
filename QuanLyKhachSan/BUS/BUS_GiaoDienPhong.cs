using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class BUS_GiaoDienPhong
    {
        DA_GiaoDienPhong da;
        public BUS_GiaoDienPhong() {
            da= new DA_GiaoDienPhong();
        }
        public Phong layTrangThai(string maPhong)
        {
            return da.LayTrangThai(maPhong);
        }
    }
}
