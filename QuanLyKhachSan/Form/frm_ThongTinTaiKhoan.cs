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
    public partial class frm_ThongTinTaiKhoan : Form
    {
        string _tk;
        BUS_ThongTinTaiKhoan bus;
        string Manhansu;
        public frm_ThongTinTaiKhoan(string taikhoan)
        {
            InitializeComponent();
            _tk = taikhoan;
            bus = new BUS_ThongTinTaiKhoan();
        }

        private void frm_ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            var thongtintaikhoan = bus.LayttTaiKhoan(_tk);
            txt_TenDangNhap.Text = thongtintaikhoan.TenDangNhap;
            //lấy mã nhân viên
            Manhansu = thongtintaikhoan.MaNhanSu;
            //điền thông tin nhân sự
            var thongtinnhansu = bus.LayTTNhanSu(Manhansu);
            txt_cmnd.Text = thongtinnhansu.CCCD;
            txt_TenNhanVien.Text = thongtinnhansu.TenNhanSu;
            txt_ChucVu.Text = thongtinnhansu.ChucVu;
            txt_gioitinh.Text = thongtinnhansu.GioiTinh;
            dtp_NgaySinh.Value = thongtinnhansu.NgaySinh.Value;
            dtp_NgayVaoLam.Value = thongtinnhansu.NgayVaoLam.Value;
            txt_sdt.Text = thongtinnhansu.SoDienThoai;
            txt_diaChi.Text = thongtinnhansu.DiaChi;
            if (txt_gioitinh.Text == "Nam")
            {
                pictureBox1.Image = Properties.Resources.male_information;
            }
            else if (txt_gioitinh.Text == "Nữ")
            {
                pictureBox1.Image = Properties.Resources.Female_Information;
            }


        }
    }
}
