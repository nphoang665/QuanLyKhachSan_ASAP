using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DA
{
   public class DA_GiaoDienPhong
    {
        QuanLyKhachSanEntities db;
        public DA_GiaoDienPhong()
        {
            db=new QuanLyKhachSanEntities();
        }
        public Phong LayTrangThai(string maphong)
        {
            return db.Phongs.FirstOrDefault(s => s.MaPhong == maphong);
        }
    }
}
