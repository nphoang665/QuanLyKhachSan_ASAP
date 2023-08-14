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
    public partial class frm_ReportPhong : Form
    {
        public frm_ReportPhong()
        {
            InitializeComponent();
        }

        private void rpv_Phong_Load(object sender, EventArgs e)
        {
            using (var db = new QuanLyKhachSanEntities())
            {
                var phong = db.Phongs.ToList();
                var dt = new DataTable();
                dt.Columns.Add("MaPhong");
                dt.Columns.Add("LoaiPhong");
                dt.Columns.Add("TinhTrang");
                dt.Columns.Add("DonGia");

                foreach (var a in phong)
                {
                    dt.Rows.Add(a.MaPhong, a.LoaiPhong, a.TinhTrang, a.DonGia);
                }
                this.rpv_Phong.LocalReport.ReportPath = "Report_Phong.rdlc";
                var soucre = new ReportDataSource("ds_Phong", dt);
                rpv_Phong.LocalReport.DataSources.Clear();
                rpv_Phong.LocalReport.DataSources.Add(soucre);
                this.rpv_Phong.RefreshReport();
            }
        }
    }
}
