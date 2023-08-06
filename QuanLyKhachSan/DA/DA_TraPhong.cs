using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.DA
{
    public class DA_TraPhong
    {
        QuanLyKhachSanEntities db;
        public DA_TraPhong()
        {
            db = new QuanLyKhachSanEntities();
        }
        public HoaDon layHoaDon(string mahoadon)
        {
            return db.HoaDons.FirstOrDefault(s => s.MaHoaDon == mahoadon);
        }
        public ThuePhong layphong(string maphong)
        {
            return db.ThuePhongs.FirstOrDefault(s => s.MaPhong == maphong);
        }
        public float layTongTienDichVu(string maphong)
        {
            var dichVu = db.DangKyDichVus.Where(s => s.MaPhong == maphong);
            float tongTienDichVu = 0;
            foreach (var dv in dichVu)
            {
                tongTienDichVu = (float)(dv.SoLuong * dv.DonGia);
            }
            return tongTienDichVu;
        }
        //public float TinhTongTien(Phong phong,ThuePhong datphong, float tongTienDichVu)
        //{
        //    int soNgayO = (datphong.NgayTra - datphong.NgayDat)?.Days ?? 0;
        //    float giaPhong = (float)phong.DonGia;
        //    float tongTien = (soNgayO * giaPhong) + tongTienDichVu;

            
        //    return tongTien;
        //}


    }
}
