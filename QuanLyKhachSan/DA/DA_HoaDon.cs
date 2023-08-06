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
        public void loadHD(DataGridView dtgv)
        {

            dtgv.Rows.Clear();
            var ds = db.HoaDons.Select(s => new
            {
                s.MaHoaDon,
                s.MaThanhToan,
                s.MaKhachHang,
                s.NgayThue,
                s.SoNgay,
                s.TongTien,
                s.NgayTra
                

            }).ToList();
            foreach (var ns in ds)
            {
                DataGridViewColumn column = new DataGridViewTextBoxColumn();

                int ViTri = dtgv.Rows.Add();
                DataGridViewRow row = dtgv.Rows[ViTri];
                row.Cells[0].Value = ns.MaThanhToan;
                row.Cells[1].Value = ns.MaHoaDon;
                row.Cells[2].Value = ns.MaKhachHang;
                row.Cells[3].Value = ns.NgayThue.Value.ToShortDateString();
                row.Cells[4].Value = ns.SoNgay;
                row.Cells[5].Value = ns.TongTien;
                row.Cells[6].Value = ns.NgayTra.Value.ToShortDateString();

            }
        }
       
    }

}

    
