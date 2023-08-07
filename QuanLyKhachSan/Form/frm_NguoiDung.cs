using QuanLyKhachSan.BUS;
using System;
using System.Windows.Forms;

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
                txt_pq_sua.Text = taiKhoan.PhanQuyen;
                txt_manhansu_sua.Text = taiKhoan.MaNhanSu;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_TenDangNhap.Text;
            string matKhau = txt_MatKhau.Text;
            string phanQuyen = txt_PhanQuyen.Text;
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
        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            string tenDangNhap = txt_tk_Sua.Text;
            string matKhau = txt_mk_Sua.Text;
            string phanQuyen = txt_pq_sua.Text;
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
