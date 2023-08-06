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
            lbl_KQSoNgayO.Text = hoadon.SoNgay.ToString();
            lbl_KQNgayThanhToan.Text = hoadon.NgayTra?.ToString("d");
            var datPhong = bus.layttDatphong(phong);
            lbl_KQNgayDatPhong.Text = datPhong.NgayDat.ToString();
            lbl_KQGiaPhong.Text = datPhong.Phong.DonGia.ToString();
            var busTongTienDichvu = bus.layTongTienDichVu(phong);
            lbl_KQTongTienDichVu.Text = busTongTienDichvu.ToString();
            float soNgayO = float.Parse(lbl_KQSoNgayO.Text);
            float giaPhong = float.Parse(lbl_KQGiaPhong.Text);
            float tongTienDichVu = float.Parse(lbl_KQTongTienDichVu.Text);
            lbl_KQTongTien.Text = (soNgayO * giaPhong + tongTienDichVu).ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
