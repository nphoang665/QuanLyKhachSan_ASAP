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
using System.Linq;
using QuanLyKhachSan.DA;

namespace QuanLyKhachSan
{
    public partial class frm_NguoiDung : Form
    {
        BUS_QuanLyTaiKhoan dstk;

        public frm_NguoiDung()
        {
            InitializeComponent();
            dstk = new BUS_QuanLyTaiKhoan();

        }

        private void dgv_DanhSachNguoiDung2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txt_TimKiem.Text;

            var ketqua = dstk.TimTaiKhoan(timKiem);

            dgv_DanhSachNguoiDung1.DataSource = ketqua;
        }

        private void dgv_DanhSachNguoiDung2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string tendangnhap = dgv_DanhSachNguoiDung2.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                var taiKhoan = dstk.LayTaiKhoan(tendangnhap);

                txt_tk_Sua.Text = taiKhoan.TenDangNhap;
                txt_mk_Sua.Text = taiKhoan.MatKhau;
                cbo_phanquyen_sua.SelectedItem = taiKhoan.PhanQuyen;
                txt_manhansu_sua.Text = taiKhoan.MaNhanSu;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_TenDangNhap.Text;
            string matKhau = txt_MatKhau.Text;
            string phanQuyen = cbo_phanquen_them.SelectedItem.ToString();
            string manhansu = txt_manhansu_them.Text;

            dstk.ThemTaiKhoan(tenDangNhap, matKhau, phanQuyen, manhansu);

            dstk.LoadDsTk(dgv_DanhSachNguoiDung);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung1);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung2);
        }

        private void frm_NguoiDung_Load(object sender, EventArgs e)
        {
            dstk.LoadDsTk(dgv_DanhSachNguoiDung);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung1);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung2);
            cbo_phanquen_them.Items.Add("Nhân viên");
            cbo_phanquen_them.Items.Add("Quản lý");
            cbo_phanquyen_sua.Items.Add("Nhân viên");
            cbo_phanquyen_sua.Items.Add("Quản lý");

        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            string tenDangNhap = txt_tk_Sua.Text;
            string matKhau = txt_mk_Sua.Text;
            string phanQuyen = cbo_phanquyen_sua.SelectedItem.ToString();
            string manhansu = txt_manhansu_sua.Text;

            dstk.SuaTaiKhoan(tenDangNhap, matKhau, phanQuyen, manhansu);

            dstk.LoadDsTk(dgv_DanhSachNguoiDung);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung1);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung2);
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {
            string tenDangNhap = txt_tk_Sua.Text;

            dstk.XoaTaiKhoan(tenDangNhap);

            dstk.LoadDsTk(dgv_DanhSachNguoiDung);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung1);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung2);
        }
    }
}
