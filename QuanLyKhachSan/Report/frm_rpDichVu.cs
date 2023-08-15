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
    public partial class frm_rpDichVu : Form
    {
        public frm_rpDichVu()
        {
            InitializeComponent();
        }

        private void frm_rpDichVu_Load(object sender, EventArgs e)
        {
            using (var db = new QuanLyKhachSanEntities())
            {
                var phong = db.QuanLyDichVus.ToList();
                var dt = new DataTable();
                dt.Columns.Add("MaDichVu");
                dt.Columns.Add("TenDichVu");
                dt.Columns.Add("DonGia");
                dt.Columns.Add("DonViTinh");

                foreach (var a in phong)
                {
                    dt.Rows.Add(a.MaDichVu, a.TenDichVu, a.DonGia, a.DonViTinh);
                }
                this.rpv_Phong.LocalReport.ReportPath = "ReportDIchVu.rdlc";
                var soucre = new ReportDataSource("ds_dichVu", dt);
                rpv_Phong.LocalReport.DataSources.Clear();
                rpv_Phong.LocalReport.DataSources.Add(soucre);
                this.rpv_Phong.RefreshReport();
            }
        }
    }
}
