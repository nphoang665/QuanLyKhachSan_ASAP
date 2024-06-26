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
        void EnableTextBox() {
            txt_TenDangNhap.Enabled = false;
            txt_ChucVu.Enabled = false;
            txt_cmnd.Enabled = false;
            txt_diaChi.Enabled = false;
            txt_TenNhanVien.Enabled = false;
            txt_sdt.Enabled = false;
            txt_gioitinh.Enabled = false;
            txt_NgaySinh.Enabled = false;
            txt_NgayVaoLam.Enabled = false;
        }
        private void frm_ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            
            var thongtintaikhoan = bus.LayttTaiKhoan(_tk);
            txt_TenDangNhap.Texts = thongtintaikhoan.TenDangNhap;
            Manhansu = thongtintaikhoan.MaNhanSu;
            var thongtinnhansu = bus.LayTTNhanSu(Manhansu);
            txt_cmnd.Texts = thongtinnhansu.CCCD;
            txt_TenNhanVien.Texts = thongtinnhansu.TenNhanSu;
            txt_ChucVu.Texts = thongtinnhansu.ChucVu;
            txt_gioitinh.Texts = thongtinnhansu.GioiTinh;
            txt_NgaySinh.Texts = thongtinnhansu.NgaySinh?.ToShortDateString(); 
            txt_NgayVaoLam.Texts = thongtinnhansu.NgayVaoLam?.ToShortDateString();
            txt_sdt.Texts = thongtinnhansu.SoDienThoai;
            txt_diaChi.Texts = thongtinnhansu.DiaChi;
            if (txt_gioitinh.Texts == "Nam")
            {
                pictureBox1.Image = Properties.Resources.male_information;
            }
            else if (txt_gioitinh.Text == "Nữ")
            {
                pictureBox1.Image = Properties.Resources.Female_Information;
            }
            bus.layanhNV(Manhansu,pictureBox1);
            EnableTextBox();

        }

        private void txt_TenDangNhap__TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TenNhanVien__TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ChucVu__TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_gioitinh__TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_diaChi__TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cmnd__TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sdt__TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_mo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                bus.LuuAnhNv(Manhansu, pictureBox1.Image);
                MessageBox.Show("Đổi ảnh đại diện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_XoaAvt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (txt_gioitinh.Texts == "Nam")
                {
                    pictureBox1.Image = Properties.Resources.male_information;
                }
                else if (txt_gioitinh.Texts == "Nữ")
                {
                    pictureBox1.Image = Properties.Resources.Female_Information;
                }
                MessageBox.Show("Xóa ảnh đại diện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_KhoiPhucAvt_Click(object sender, EventArgs e)
        {
            bus.KhoiPhucAnhNv(Manhansu, pictureBox1);
            MessageBox.Show("Khôi phục ảnh đại diện thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
