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
using System.Linq;
using QuanLyKhachSan.DA;


namespace QuanLyKhachSan
{
    public partial class frm_ThuePhong : Form
    {
        BUS_ThuePhong bus;
        string _maphong;
        public frm_ThuePhong()
        {
            InitializeComponent();
            bus = new BUS_ThuePhong();
        }
        public frm_ThuePhong(string maphong)
        {
           _maphong = maphong;
        }

        private void tabPage_ThuePhong_Click(object sender, EventArgs e)
        {

        }

        private void frm_ThuePhong_Load(object sender, EventArgs e)
        {
            var tt = bus.laytt();
            foreach (var makhachhang in tt)
            {
                cbo_MaKhachHang.Items.Add(makhachhang.MaKhachHang);
            }
            var phongs = bus.LayThongTinPhongTrong();
            dgv_PhongTrong.DataSource = phongs;
           

        }
     
        private void lstv_ChiTiet_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbo_MaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

            string maKhachHang = cbo_MaKhachHang.SelectedItem.ToString();

 
            var kh = bus.LayThongTinKhachHangVaDatPhong(maKhachHang);

            if (kh != null)
            {
                lstv_ChiTiet.Items.Clear();
                lstv_ChiTiet.Items.Add(new ListViewItem("Mã khách hàng: " + maKhachHang));
                lstv_ChiTiet.Items.Add(new ListViewItem("Tên khách hàng: " + kh.TenKhachHang));
                lstv_ChiTiet.Items.Add(new ListViewItem("Giới tính: " + kh.GioiTinh));
                lstv_ChiTiet.Items.Add(new ListViewItem("Địa chỉ: " + kh.DiaChi));
                lstv_ChiTiet.Items.Add(new ListViewItem("Số điện thoại: " + kh.SoDienThoai));
                lstv_ChiTiet.Items.Add(new ListViewItem("Ngày sinh: " + kh.NgaySinh.ToString("dd/MM/yyyy")));             
            }
        }

        private void dtp_NgayThue_ValueChanged(object sender, EventArgs e)
        {
            var item = lstv_ChiTiet.FindItemWithText("Ngày thuê");
            if (item != null)
            {
                item.Text = "Ngày thuê: " + dtp_NgayThue.Value.ToString("dd/MM/yyyy");
            }
            else
            {
                lstv_ChiTiet.Items.Add(new ListViewItem("Ngày thuê: " + dtp_NgayThue.Value.ToString("dd/MM/yyyy")));
            }
        }

        private void dgv_PhongTrong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_PhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                string maPhong = dgv_PhongTrong.Rows[rowIndex].Cells["MaPhong"].Value.ToString();
                string loaiPhong = dgv_PhongTrong.Rows[rowIndex].Cells["LoaiPhong"].Value.ToString();
                string tinhTrang = dgv_PhongTrong.Rows[rowIndex].Cells["TinhTrang"].Value.ToString();
                string donGia = dgv_PhongTrong.Rows[rowIndex].Cells["DonGia"].Value.ToString();

 
                if (lsv_phongchon.Items.Count == 0)
                {
                    lsv_phongchon.Items.Add(new ListViewItem("Mã phòng: " + maPhong));
                    lsv_phongchon.Items.Add(new ListViewItem("Loại phòng: " + loaiPhong));
                    lsv_phongchon.Items.Add(new ListViewItem("Tình trạng: " + tinhTrang));
                    lsv_phongchon.Items.Add(new ListViewItem("Đơn giá: " + donGia));
                }
                else
                {
                    lsv_phongchon.Items[0].Text = "Mã phòng: " + maPhong;
                    lsv_phongchon.Items[1].Text = "Loại phòng: " + loaiPhong;
                    lsv_phongchon.Items[2].Text = "Tình trạng: " + tinhTrang;
                    lsv_phongchon.Items[3].Text = "Đơn giá: " + donGia;
                }
            }
        }
    }
}
