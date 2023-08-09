using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.BUS
{
    public class BUS_ThongTinPhong
    {
        DA_ThongTinPhong da;
        public BUS_ThongTinPhong() { 
        da=new DA_ThongTinPhong();
        }
        public ThuePhong LoadThongTinPhong(string maphong)
        {
          return da.LoadThongtinPhong(maphong);

        }
        public ThongTinKhachHang loadthongtinkhachhang(string makhachhang)
        {
            return da.loadthongtinKhachHang(makhachhang);
        }
        public List<DangKyDichVu> LoadDanhSachDangKyDichVu(string maPhong)
        {
            return da.LoadDanhSachDangKyDichVu(maPhong);
        }
        public string GetTenDichVuByMaDichVu(string maDichVu)
        {
            return da.GetTenDichVuByMaDichVu(maDichVu);
        }

    }
}
