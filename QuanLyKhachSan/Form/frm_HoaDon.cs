using QuanLyKhachSan.BUS;
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
    public partial class frm_HoaDon : Form
    {
        BUS_HoaDon bus;
        public frm_HoaDon()
        {
            InitializeComponent();
            bus = new BUS_HoaDon();
            cbo_MaDatPhong.DataSource= bus.laydata();
        }

        private void tabPage_HoaDon_Click(object sender, EventArgs e)
        {

        }

        public void hienthi()
        {
            bus.load(dgv_DanhSachHoaDon);
        }
        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void cbo_MaDatPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            var data = bus.laydata(cbo_MaDatPhong.Text);
            var ngay1= dtp_NgayLap.Value.Day - dtp_NgayThue.Value.Day;
            lbl_KQSoNgay.Text=ngay1.ToString();
            dtp_NgayLap.Value = (DateTime)data.NgayTra;
            dtp_NgayThue.Value = (DateTime)data.NgayDat;
            cbo_MaKhachHang.Text = data.MaKhachHang;
            cbo_MaNhanVien.Text = data.MaNhanVien;

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }
    }
}
