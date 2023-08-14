using Microsoft.Reporting.WinForms;
using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_reportHoaDon : Form
    {
        public frm_reportHoaDon()
        {
            InitializeComponent();
        }

        private void frm_reportHoaDon_Load(object sender, EventArgs e)
        {
            using (var db = new QuanLyKhachSanEntities())
            {
                var hd = db.HoaDons.ToList();
                var dt = new DataTable();
                dt.Columns.Add("MaHoaDon");
                dt.Columns.Add("TenKhachHang");
                dt.Columns.Add("CMND");
                dt.Columns.Add("SoDienThoai");
                dt.Columns.Add("MaPhong");
                dt.Columns.Add("NgayThue");
                dt.Columns.Add("NgayTra");
                dt.Columns.Add("TongTienDichVu");
                dt.Columns.Add("TongTienThanhToan");

                foreach (var a in hd)
                {
                    dt.Rows.Add(a.MaHoaDon, a.TenKhachHang, a.CMND, a.SoDienThoai, a.MaPhong, a.NgayThue.Value.ToShortDateString(), a.NgayTra.Value.ToShortDateString(),a.TongTienDichVu,a.TongTienThanhToan);
                }
                this.reportViewer1.LocalReport.ReportPath = "report_HoaDon.rdlc";
                var soucre = new ReportDataSource("ds_hoadon", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(soucre);
                this.reportViewer1.RefreshReport();
            }
         
        }
    }
}
