using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BUS
{
    internal class BUS_HoaDon
    {
        DA_HoaDon da;
        public BUS_HoaDon()
        {
            da = new DA_HoaDon();
        }
        public void load(DataGridView dtgv)
        {
            da.LayHoaDon(dtgv);
        }
        public void themHoaDon(string madatphong, string MaHoaDon, string MaNhanVien, string MaKhachHang, DateTime ngaydat, int SoNgay, int TongTien, DateTime NgayTra) { 
            da.ThemHoaDon(madatphong,MaHoaDon,MaNhanVien,MaKhachHang,ngaydat,SoNgay,TongTien,NgayTra);
        }
        public DatPhong laydata(string madatphong)
        {
            return da.laydatphong(madatphong);
        }
       public List<string> laydata()
        {
            return da.laydata();
        }
    }
}
