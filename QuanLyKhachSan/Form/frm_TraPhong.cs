﻿using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_TraPhong : Form
    {
        BUS_Phong busPhong;
        BUS_TraPhong bus;
    
        string phong;
        string mkh;
        string tkh;
        string cccd;
        string sdt;
        public frm_TraPhong(string phong,string makhachhang, string tenkhachhang)
        {
            InitializeComponent();
            this.phong = phong;
            this.mkh = makhachhang;
            this.tkh = tenkhachhang;
            bus= new BUS_TraPhong();
            busPhong = new BUS_Phong();
        }

        private void frm_TraPhong_Load(object sender, EventArgs e)
        {
            lbl_KQPhong.Text = phong;
            lbl_KQMaKhachHang.Text = mkh;
            lbl_KQTenKhachHang.Text = tkh;
            cccd = bus.laycccd(lbl_KQMaKhachHang.Text);
            sdt = bus.LaySDT(lbl_KQMaKhachHang.Text);
            Random random = new Random();
            int randomNumber = random.Next(1000, 9999);
            string maHoaDon = "HD" + randomNumber.ToString();
            lbl_kqmahoadon.Text = maHoaDon;

            var datPhong = bus.layttDatphong(phong);
            lbl_KQNgayDatPhong.Text = datPhong.NgayThue.Value.ToString("dd/MM/yyyy");


            lbl_KQNgayThanhToan.Text = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

            TimeSpan soNgayO = DateTime.Now.Date - datPhong.NgayThue.Value;
            lbl_KQSoNgayO.Text = soNgayO.TotalDays.ToString();

            lbl_KQGiaPhong.Text = datPhong.Phong.DonGia.ToString();
            var busTongTienDichvu = bus.layTongTienDichVu(phong);
            lbl_KQTongTienDichVu.Text = busTongTienDichvu.ToString();

            double soNgay = double.Parse(lbl_KQSoNgayO.Text);
            double giaPhong = double.Parse(lbl_KQGiaPhong.Text);
            double tongTienDichVu = double.Parse(lbl_KQTongTienDichVu.Text);
            lbl_KQTongTien.Text = (soNgay * giaPhong + tongTienDichVu).ToString();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {  /*       
            try
            {
                string maHoaDon = lbl_kqmahoadon.Text;
                string maKhachHang = lbl_KQMaKhachHang.Text;
                string tenKhachHang = lbl_KQTenKhachHang.Text;
                string maPhong = lbl_KQPhong.Text;

                DateTime ngayDatPhong;
                if (!DateTime.TryParseExact(lbl_KQNgayDatPhong.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayDatPhong))
                {
                    MessageBox.Show("Ngày đặt phòng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime ngayTra = DateTime.Now.Date;
                double tongTien = double.Parse(lbl_KQTongTien.Text);

                HoaDon thanhToan = new HoaDon
                {
                    MaHoaDon = maHoaDon,
                    TenKhachHang = tenKhachHang,
                    CMND = cccd,
                    SoDienThoai = sdt,
                    MaPhong = maPhong,
                    NgayThue = ngayDatPhong,
                    NgayTra = ngayTra,
                    TongTienDichVu = double.Parse(lbl_KQTongTienDichVu.Text),
                    TongTienThanhToan = tongTien
                };

                // Lưu thông tin thanh toán vào CSDL
                bus.LuuThongTinThanhToan(thanhToan);
                busPhong.CapNhatTrangThaiPhong(maPhong, "Trống");

                // Xóa các dịch vụ đã đăng ký cho phòng
                bus.XoaDichVuDaDangKyCuaPhong(maPhong);

                // Xóa thông tin đặt phòng trong bảng ThuePhong
                bus.XoaThuePhong(maPhong);
                MessageBox.Show($"Bạn có muốn thanh toán cho Khách hàng '{tenKhachHang}' với số tiền là '{tongTien.ToString("#,##0")}?", "Thanh toán thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Thanh toán thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            try
            {
                string maHoaDon = lbl_kqmahoadon.Text;
                string maKhachHang = lbl_KQMaKhachHang.Text;
                string tenKhachHang = lbl_KQTenKhachHang.Text;
                string maPhong = lbl_KQPhong.Text;

                DateTime ngayDatPhong;
                if (!DateTime.TryParseExact(lbl_KQNgayDatPhong.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayDatPhong))
                {
                    MessageBox.Show("Ngày đặt phòng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime ngayTra = DateTime.Now.Date;
                double tongTien = double.Parse(lbl_KQTongTien.Text);

                // Hiển thị thông báo xác nhận thanh toán
                string message = $"Bạn có muốn thanh toán Phòng:{maPhong} - Khách hàng: {tenKhachHang} - tổng tiền: {tongTien:C} không?";
                DialogResult result = MessageBox.Show(message, "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    HoaDon thanhToan = new HoaDon
                    {
                        MaHoaDon = maHoaDon,
                        TenKhachHang = tenKhachHang,
                        CMND = cccd,
                        SoDienThoai = sdt,
                        MaPhong = maPhong,
                        NgayThue = ngayDatPhong,
                        NgayTra = ngayTra,
                        TongTienDichVu = double.Parse(lbl_KQTongTienDichVu.Text),
                        TongTienThanhToan = tongTien
                    };

                    // Lưu thông tin thanh toán vào CSDL
                    bus.LuuThongTinThanhToan(thanhToan);
                    busPhong.CapNhatTrangThaiPhong(maPhong, "Trống");

                    // Xóa các dịch vụ đã đăng ký cho phòng
                    bus.XoaDichVuDaDangKyCuaPhong(maPhong);

                    // Xóa thông tin đặt phòng trong bảng ThuePhong
                    bus.XoaThuePhong(maPhong);

                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frm_TrangChu frm_TrangChu = new frm_TrangChu();
                    frm_TrangChu.ViDu.OpenChildForm(new frm_GiaoDienPhong());
                }
                else
                {
                    // Người dùng không muốn thanh toán, không cần thực hiện gì thêm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
