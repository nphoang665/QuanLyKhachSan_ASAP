using QuanLyKhachSan.BUS;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace QuanLyKhachSan
{
    public partial class frm_ThongKe : Form
    {
        BUS_ThongKe bus;
        public frm_ThongKe()
        {
            InitializeComponent();
            bus = new BUS_ThongKe();
        }

        private void frm_ThongKe_Load(object sender, EventArgs e)
        {

            UpdateChart();
        }
        private void UpdateChart()
        {
            chart_doanhthu.Series.Clear();
            chart_doanhthu.Titles.Clear();
            chart_doanhthu.Titles.Add("Doanh Thu Theo Tháng");
            int nam = dateTimePicker1.Value.Year;
            var data = bus.ThongKeDoanhThuTheoThang(nam);
            chart_doanhthu.DataSource = data;
            Series series = new Series();
            series.LegendText = "Doanh Thu";
            series.XValueMember = "Thang";
            series.YValueMembers = "DoanhThu";
            chart_doanhthu.Series.Add(series);




        }
        public void doanhthungay()
        {
            int nam = dateTimePicker1.Value.Year;
            int thang = dateTimePicker1.Value.Month;
            var data = bus.ThongKeDoanhThuTheoNgay(nam, thang);

            chart_doanhthu.Series.Clear();
            chart_doanhthu.Titles.Clear();
            chart_doanhthu.Titles.Add("Doanh Thu Theo Ngày");


            chart_doanhthu.DataSource = data;

            Series series = new Series();
            series.Legend = null;
            series.LegendText = "Doanh Thu";
            series.XValueMember = "ngay";
            series.YValueMembers = "doanhthu";
            chart_doanhthu.Series.Add(series);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            doanhthungay();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            UpdateChart();
        }
    }
}
