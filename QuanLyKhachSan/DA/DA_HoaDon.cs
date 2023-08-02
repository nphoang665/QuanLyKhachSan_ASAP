using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.DA
{
    internal class DA_HoaDon
    {
        QuanLyKhachSanEntities db;
        public DA_HoaDon()
        {
            db = new QuanLyKhachSanEntities();
        }
        public void LayHoaDon(DataGridView dtgv)
        {
            dtgv.Rows.Clear();
            var ds = db.HoaDons.Select(s => new
            {
               s.MaDatPhong,
               s.MaHoaDon,
               s.MaNhanVien,
               s.MaKhachHang,
               s.NgayDat,
               s.NgayTra,
               s.SoNgay,
               s.TongTien,
               
               
            }).ToList();
            foreach (var hd in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = hd.MaDatPhong;
                row.Cells[1].Value = hd.MaHoaDon;
                row.Cells[2].Value = hd.MaNhanVien;
                row.Cells[3].Value = hd.MaKhachHang;
                row.Cells[4].Value = hd.NgayDat;
                row.Cells[5].Value = hd.SoNgay;
                row.Cells[6].Value = hd.TongTien;
                row.Cells[7].Value = hd.NgayTra;

            }
        }
        public void ThemHoaDon(string madatphong, string MaHoaDon, string MaNhanVien, string MaKhachHang, DateTime  ngaydat, int SoNgay, int TongTien, DateTime NgayTra)
        {

            var HD = new HoaDon
            {
                MaDatPhong= madatphong,
                MaHoaDon= MaHoaDon,
                MaNhanVien= MaNhanVien,
                MaKhachHang= MaKhachHang,
                NgayDat= ngaydat,
                SoNgay= SoNgay,
                TongTien= TongTien,
                NgayTra= NgayTra
            };
            db.HoaDons.Add(HD);
            db.SaveChanges();
        }
    }
}
