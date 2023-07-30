using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
    public class DA_DichVu
    {
        QuanLyKhachSanEntities db;
        public DA_DichVu()
        {
            db =new QuanLyKhachSanEntities();

        }
        public dynamic LoadDichVu()
        {
            var qr = db.QuanLyDichVus.Select(s => new
            {
                s.MaDichVu,
                s.TenDichVu,
                s.DonGia,
                s.DonViTinh
            }).ToList();
            return qr;
        }
    }
}
