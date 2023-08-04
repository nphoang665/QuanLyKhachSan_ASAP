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
          
            
        }
        private void UpdateChart()
        {
           
            chart_doanhthu.Series.Clear();
            chart_doanhthu.Titles.Clear();

     
            chart_doanhthu.Titles.Add("Doanh thu theo tháng");

     
            Series mySeries = new Series();
            mySeries.LegendText = "Doanh thu";
            chart_doanhthu.Series.Add(mySeries);

         
            chart_doanhthu.ChartAreas[0].AxisX.LabelStyle.Format = "Tháng {0}";
            chart_doanhthu.ChartAreas[0].AxisY.LabelStyle.Format = "{0:C}";

            int thang = dateTimePicker1.Value.Month;
            int nam = dateTimePicker1.Value.Year;
           

    
             
                var data = bus.ThongKeDoanhThuTheoThang(nam);
                chart_doanhthu.DataSource = data;

                mySeries.XValueMember = "Thang";
                mySeries.YValueMembers = "DoanhThu";
                chart_doanhthu.Series[0].ChartType = SeriesChartType.Column;
                chart_doanhthu.DataBind();
             
                //var data1 = bus.ThongKeDoanhThuTheoNgay(nam, thang);

                //foreach (var item in data1)
                //{
                //    mySeries.Points.AddXY(item.ngay, item.doanhthu);
                //}

                //chart_doanhthu.ChartAreas[0].AxisX.LabelStyle.Format = "Ngày {0}";
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }
    }
}
