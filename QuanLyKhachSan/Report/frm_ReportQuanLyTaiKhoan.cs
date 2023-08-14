using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using QuanLyKhachSan.DA;

namespace QuanLyKhachSan
{
    public partial class frm_ReportQuanLyTaiKhoan : Form
    {
        public frm_ReportQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void frm_ReportQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            using (var db = new QuanLyKhachSanEntities())
            {
                var taikhoans = db.TaiKhoans.ToList();
                var dt = new DataTable();
                dt.Columns.Add("TenDangNhap");
                dt.Columns.Add("MatKhau");
                dt.Columns.Add("PhanQuyen");
                dt.Columns.Add("MaNhanSu");
                dt.Columns.Add("TinhTrang");


                foreach (var tk in taikhoans)
                {
                    dt.Rows.Add(tk.TenDangNhap, tk.MatKhau,tk.PhanQuyen,tk.MaNhanSu,tk.TinhTrang);
                }
                this.rpv_quanlytaikhoan.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.ReportQuanLyTaiKhoan.rdlc";
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet_QuanLyTaiKhoan";
                rds.Value = dt;
                this.rpv_quanlytaikhoan.LocalReport.DataSources.Add(rds);
                this.rpv_quanlytaikhoan.RefreshReport();
            }
        }
    }
}
