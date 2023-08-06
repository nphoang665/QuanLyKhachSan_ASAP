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
            //cbo_MaDatPhong.DataSource= bus.laydata();
        }

        private void tabPage_HoaDon_Click(object sender, EventArgs e)
        {

        }

        public void hienthi()
        {
            //bus.load(dgv_DanhSachHoaDon);
        }
        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void cbo_MaDatPhong_SelectedIndexChanged(object sender, EventArgs e)
        {


            //var data = bus.laydata(cbo_MaDatPhong.Text);
            //var ngay1 = dtp_NgayLap.Value.Day - dtp_NgayThue.Value.Day;
            //lbl_KQSoNgay.Text = ngay1.ToString();
            //var tien = bus.laytien(data.MaPhong).DonGia;
            //int tong = int.Parse(tien.ToString()) * int.Parse(ngay1.ToString()); 
            //lbl_KQTongTien.Text = tong.ToString();
            //dtp_NgayLap.Value = (DateTime)data.NgayTra;
            //dtp_NgayThue.Value = (DateTime)data.NgayDat;
            //cbo_MaKhachHang.Text = data.MaKhachHang;
            //cbo_MaNhanVien.Text = data.MaNhanVien;

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //var data =bus.checkkhoa(cbo_MaDatPhong.Text);
            //if (!data)
            //{
            //    MessageBox.Show("Đã tồn tại mã phòng");
            //    return;
            //}
            //bus.themHoaDon(cbo_MaDatPhong.Text, txt_mahoadon.Text, cbo_MaNhanVien.Text, cbo_MaKhachHang.Text, dtp_NgayThue.Value, int.Parse(lbl_KQSoNgay.Text), int.Parse(lbl_KQTongTien.Text), dtp_NgayLap.Value);
            //hienthi();
        }
    }
}
