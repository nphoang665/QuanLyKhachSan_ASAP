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
            // Call the ThongKeDoanhThuTheoThang method to get the data
            int nam = dateTimePicker1.Value.Year;
          var  data = bus.ThongKeDoanhThuTheoThang(nam);

        

            // Set the DataSource property of the Chart control to the data
            chart_doanhthu.DataSource = data;

            // Create a new Series and add it to the Chart
            Series series = new Series();
            series.XValueMember = "Thang";
            series.YValueMembers = "DoanhThu";
            chart_doanhthu.Series.Add(series);

    


        }
        public void doanhthungay()
        {
            // Call the ThongKeDoanhThuTheoNgay method to get the data
            int nam = 2023; // Set the year you want to display data for
            int thang = 8; // Set the month you want to display data for
            var data = bus.ThongKeDoanhThuTheoNgay(nam, thang);

            // Create a new Chart control
      

            // Set the DataSource property of the Chart control to the data
            chart_doanhthu.DataSource = data;

            // Create a new Series and add it to the Chart
            Series series = new Series();
            series.XValueMember = "ngay";
            series.YValueMembers = "doanhthu";
            chart_doanhthu.Series.Add(series);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           doanhthungay();
        }
    }
}
