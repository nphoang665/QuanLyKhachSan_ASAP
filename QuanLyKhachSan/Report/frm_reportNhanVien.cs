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
    public partial class frm_reportNhanVien : Form
    {
        public frm_reportNhanVien()
        {
            InitializeComponent();
        }

        private void frm_reportNhanVien_Load(object sender, EventArgs e)
        {
            using (var db = new QuanLyKhachSanEntities())
            {
                var nhansu = db.NhanSus.ToList();
                var dt = new DataTable();
                dt.Columns.Add("MaNhanSu");
                dt.Columns.Add("TenNhanSu");
                dt.Columns.Add("GioiTinh");
                dt.Columns.Add("DiaChi");
                dt.Columns.Add("SoDienThoai");
                dt.Columns.Add("NgaySinh");
                dt.Columns.Add("NgayVaoLam");
                dt.Columns.Add("ChucVu");
                dt.Columns.Add("CCCD");


                foreach (var a in nhansu)
                {
                    dt.Rows.Add(a.MaNhanSu, a.TenNhanSu, a.GioiTinh, a.DiaChi,a.SoDienThoai, a.NgaySinh.Value.ToShortDateString(),a.NgayVaoLam.Value.ToShortDateString(), a.ChucVu,a.CCCD);
                }
                this.reportViewer1.LocalReport.ReportPath = "repor_Nhanvien.rdlc";
                var soucre = new ReportDataSource("ds_nhanVien", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(soucre);
                this.reportViewer1.RefreshReport();
            }   


        }
    }
}
