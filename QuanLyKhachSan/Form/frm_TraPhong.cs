using QuanLyKhachSan.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_TraPhong : Form
    {

        BUS_TraPhong bus;
        string phong;
        string mkh;
        string tkh;
        public frm_TraPhong(string phong,string makhachhang, string tenkhachhang)
        {
            InitializeComponent();
            this.phong = phong;
            this.mkh = makhachhang;
            this.tkh = tenkhachhang;
            bus= new BUS_TraPhong();
        }

        private void frm_TraPhong_Load(object sender, EventArgs e)
        {
            var hoadon = bus.LayTtTraPhong(mkh);
            lbl_KQPhong.Text = phong;
            lbl_KQMaKhachHang.Text = mkh;
            lbl_KQTenKhachHang.Text = tkh;
            lbl_kqmahoadon.Text = hoadon.MaHoaDon;

            // Lấy thông tin ngày đặt phòng từ bảng ThuePhong
            var datPhong = bus.layttDatphong(phong);
            /*lbl_KQNgayDatPhong.Text = datPhong.NgayThue.ToString("d", CultureInfo.InvariantCulture);*/
            lbl_KQNgayDatPhong.Text = datPhong.NgayThue.Value.ToString("dd/MM/yyyy");


            // Lấy ngày thanh toán là ngày hiện tại
            lbl_KQNgayThanhToan.Text = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Tính số ngày ở bằng cách lấy ngày hiện tại trừ đi ngày đặt phòng
            TimeSpan soNgayO = DateTime.Now.Date - datPhong.NgayThue.Value;
            lbl_KQSoNgayO.Text = soNgayO.TotalDays.ToString();

            lbl_KQGiaPhong.Text = datPhong.Phong.DonGia.ToString();

            var busTongTienDichvu = bus.layTongTienDichVu(phong);
            lbl_KQTongTienDichVu.Text = busTongTienDichvu.ToString();

            float soNgay = float.Parse(lbl_KQSoNgayO.Text);
            float giaPhong = float.Parse(lbl_KQGiaPhong.Text);
            float tongTienDichVu = float.Parse(lbl_KQTongTienDichVu.Text);
            lbl_KQTongTien.Text = (soNgay * giaPhong + tongTienDichVu).ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
