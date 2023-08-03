﻿using QuanLyKhachSan.BUS;
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
            lbl_KQPhong.Text = phong;
            lbl_KQMaKhachHang.Text = mkh;
            lbl_KQTenKhachHang.Text = tkh;

            var datPhong = bus.layttDatphong(phong);
            lbl_KQNgayDatPhong.Text = datPhong.NgayDat.ToString();
            lbl_KQGiaPhong.Text = datPhong.Phong.DonGia.ToString();

            var hoaDon = datPhong.HoaDons.FirstOrDefault();
            if (hoaDon != null)
            {
                lbl_kqmahoadon.Text = hoaDon.MaHoaDon;

                lbl_KQSoNgayO.Text = hoaDon.SoNgay.ToString();
                lbl_KQNgayThanhToan.Text = hoaDon.NgayTra.ToString();
                lbl_KQTongTien.Text = hoaDon.TongTien.ToString();
                //lbl_KQTongTienDichVu.Text = hoaDon.TongTienDichVu.ToString();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
