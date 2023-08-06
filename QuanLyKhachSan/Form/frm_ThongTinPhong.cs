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

namespace QuanLyKhachSan
{
    public partial class frm_ThongTinPhong : Form
    {
        string maPhong;
        string maKhachHang;
        string TenKhachHang;
        BUS_ThongTinPhong bus;
        public frm_ThongTinPhong(string maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            bus= new BUS_ThongTinPhong();
        }
        public frm_ThongTinPhong(ThuePhong thuePhong)
        {
            InitializeComponent();
            // Các thao tác khởi tạo form thông tin phòng với dữ liệu từ đối tượng thuePhong
            // ...
        }


        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_TraPhong quanLyTraPhong = new frm_TraPhong(maPhong,maKhachHang,TenKhachHang);
            frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ThongTinPhong_Load(object sender, EventArgs e)
        {
            lbl_Phong.Text = maPhong;
            var tt = bus.LoadThongTinPhong(maPhong);
            maKhachHang = tt.MaKhachHang;
            
            lbl_KQ_NgayThue.Text = tt.NgayThue?.ToShortDateString();
            var thongtinkhachhang = bus.loadthongtinkhachhang(tt.MaKhachHang);
            lbl_KQTenKhachHang.Text = thongtinkhachhang.TenKhachHang;
            TenKhachHang = thongtinkhachhang.TenKhachHang;
            lbl_KQCMND.Text = thongtinkhachhang.CMND;
            lbl_KQDiaChi.Text = thongtinkhachhang.DiaChi;
        }
    }
}
