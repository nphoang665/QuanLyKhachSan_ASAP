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
                s.MaHoaDon,
                s.TenKhachHang,
                s.CMND,
                s.SoDienThoai,
                s.MaPhong,
                s.NgayThue,
                s.NgayTra,
                s.TongTienDichVu,
                s.TongTienThanhToan


            }).ToList();
            foreach (var hd in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value =hd.MaHoaDon ;
                row.Cells[1].Value = hd.TenKhachHang;
                row.Cells[2].Value = hd.CMND;
                row.Cells[3].Value = hd.SoDienThoai;
                row.Cells[4].Value = hd.MaPhong;
                row.Cells[5].Value =hd.NgayThue.Value.ToShortDateString() ;
                row.Cells[6].Value = hd.NgayTra.Value.ToShortDateString();
                row.Cells[7].Value = hd.TongTienDichVu;
                row.Cells[8].Value = hd.TongTienThanhToan;
            }
        }
    }
}

    
