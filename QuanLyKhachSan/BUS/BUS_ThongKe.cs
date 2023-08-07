using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    internal class BUS_ThongKe
    {
        DA_ThongKe da;
        public BUS_ThongKe()
        {
            da = new DA_ThongKe();
        }
        //public List<DTO_DoanhThuTheoThang> ThongKeDoanhThuTheoThang(int nam)
        //{

        //    return da.ThongKeDoanhThuTheoThang(nam);

        //}
        //public List<DTO_DoanhThuTheoNgay> ThongKeDoanhThuTheoNgay(int nam, int thang)
        //{


        //    return da.ThongKeDoanhThuTheoNgay(nam, thang);
        //}
    }
}
