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
    public partial class frm_KhachHang : Form
    {
        BUS_KhachHang bus;

        public frm_KhachHang()
        {
            InitializeComponent();
            bus = new BUS_KhachHang();

        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {

            bus.LoadDsKh(dgv_DanhSachKhachHang2);
            bus.LoadDsKh(dgv_DanhSachKhachHang);
            bus.LoadDsKh(dgv_DanhSachKhachHang1);
            var data2 = bus.laykhachhang();
            cbo_TenKhachHang.DataSource = data2;
            cbo_TenKhachHang.SelectedIndex = -1;
        }

        private void dgv_DanhSachKhachHang2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh_sua.Text = dgv_DanhSachKhachHang2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_tenkh_sua.Text = dgv_DanhSachKhachHang2.Rows[e.RowIndex].Cells[1].Value.ToString();
            string gioitinh = dgv_DanhSachKhachHang2.Rows[e.RowIndex].Cells[2].Value.ToString();

            //dtp_NgaySinh2 = (DateTimePicker)dgv_DanhSachNhanVien2.Rows[e.RowIndex].Cells[3].Value;
            txt_diachi_sua.Text = dgv_DanhSachKhachHang2.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_sdt_sua.Text = dgv_DanhSachKhachHang2.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_cccd_sua.Text = dgv_DanhSachKhachHang2.Rows[e.RowIndex].Cells[6].Value.ToString();
            //dtp_NgayVaoLam2 = (DateTimePicker)dgv_DanhSachNhanVien2.Rows[e.RowIndex].Cells[8].Value;

            if (gioitinh == "Nam")
            {
                rdb_nam_sua.Checked = true;
            }
            else
            {
                rdb_nu_sua.Checked = true;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rda_Nam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            //var data = bus.ktkhoa(txt_makh.Text);
            //if (!data)
            //{
            //    MessageBox.Show("Đã tồn tại khách hàng");
            //    return;
            //}
            bool isValid = batloi(txt_makh.Text, txt_TenKhachHang.Text, txt_DiaChi.Text, txt_SoDienThoai.Text, txt_CMND.Text,gioitinh);
            if (!isValid)
                return;
            bus.ThemKH(txt_makh.Text, txt_TenKhachHang.Text, gioitinh, dtp_NgaySinh.Value.Date, txt_DiaChi.Text, txt_SoDienThoai.Text, txt_CMND.Text);
            bus.LoadDsKh(dgv_DanhSachKhachHang2);
            bus.LoadDsKh(dgv_DanhSachKhachHang);
            bus.LoadDsKh(dgv_DanhSachKhachHang1);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng này không này không?", "Sửa", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //var data = bus.khachthue(txt_makh.Text);
                //if (!data)
                //    return;

                bus.XoaKH(txt_makh_sua.Text);
            }

            bus.LoadDsKh(dgv_DanhSachKhachHang2);
            bus.LoadDsKh(dgv_DanhSachKhachHang);
            bus.LoadDsKh(dgv_DanhSachKhachHang1);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rda_Nam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            bool isValid = batloi(txt_makh_sua.Text, txt_tenkh_sua.Text, gioitinh, txt_diachi_sua.Text, txt_sdt_sua.Text, txt_cccd_sua.Text);
            if (!isValid)
                return;
            DialogResult result = MessageBox.Show("Bạn có muốn sủa thông tin khách hàng này không?", "Sửa", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                bus.SuaKH(txt_makh_sua.Text, txt_tenkh_sua.Text, gioitinh, dtp_NgaySinh.Value.Date, txt_diachi_sua.Text, txt_sdt_sua.Text, txt_cccd_sua.Text);
            bus.LoadDsKh(dgv_DanhSachKhachHang2);
            bus.LoadDsKh(dgv_DanhSachKhachHang);
            bus.LoadDsKh(dgv_DanhSachKhachHang1);
        }
        public bool batloi(string makh, string tenkh, string diachi, string sdt, string cccd, string gioitinh)
        {
            try
            {
                if (string.IsNullOrEmpty(makh))
                    throw new Exception("Chưa nhập mã khách hàng");
                if (string.IsNullOrEmpty(tenkh))
                    throw new Exception("Chưa nhập tên khách hàng");
                if (string.IsNullOrEmpty(diachi))
                    throw new Exception("Chưa nhập địa chỉ");
                if (string.IsNullOrEmpty(sdt))
                    throw new Exception("Chưa nhập số điện thoại");
                if (string.IsNullOrEmpty(cccd))
                    throw new Exception("Chưa nhập căn cước công dân");
                if (string.IsNullOrEmpty(gioitinh))
                    throw new Exception("Chưa chọn giới tính");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        private void cbo_TenKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            bus.TimKHTheoTen(cbo_TenKhachHang.Text, dgv_DanhSachKhachHang1);

        }

        private void txt_CMND1_TextChanged(object sender, EventArgs e)
        {
            bus.TimTheocccdKH(txt_CMND1.Text, dgv_DanhSachKhachHang1);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bus.TimKHTheoGioiTinh("Nam", dgv_DanhSachKhachHang1);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bus.TimKHTheoGioiTinh("Nữ", dgv_DanhSachKhachHang1);

        }

        private void txt_CMND1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_tenkh_sua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sdt_sua_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_TenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_cccd_sua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
