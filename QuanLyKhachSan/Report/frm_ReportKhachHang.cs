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
    public partial class frm_ReportKhachHang : Form
    {
        public frm_ReportKhachHang()
        {
            InitializeComponent();
        }

        private void frm_ReportKhachHang_Load(object sender, EventArgs e)
        {
            using (var db = new QuanLyKhachSanEntities())
            {
                var kh = db.ThongTinKhachHangs.ToList();
                var dt = new DataTable();
                dt.Columns.Add("MaKhachHang");
                dt.Columns.Add("TenKhachHang");
                dt.Columns.Add("NgaySinh");
                dt.Columns.Add("GioiTinh");
                dt.Columns.Add("CMND");
                dt.Columns.Add("DiaChi");
                dt.Columns.Add("SoDienThoai");
               


                foreach (var a in kh)
                {
                    dt.Rows.Add(a.MaKhachHang, a.TenKhachHang, a.NgaySinh.Value.ToShortDateString(), a.GioiTinh, a.CMND, a.DiaChi, a.SoDienThoai);
                }
                this.reportViewer1.LocalReport.ReportPath = "Report_KhachHang.rdlc";
                var soucre = new ReportDataSource("ds_khachHang", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(soucre);
                this.reportViewer1.RefreshReport();
            }

        }
    }
}
