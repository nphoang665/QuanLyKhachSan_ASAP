using QuanLyKhachSan.BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{

    public partial class frm_DangKyTaiKhoan : Form
    {
        BUS_DangKy bus;
        string phanQuyen;
        string Manhansu;
        public frm_DangKyTaiKhoan()
        {
            InitializeComponent();
            bus = new BUS_DangKy();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string tk = txt_TenDangNhap.Text;
                string mk = txt_MatKhau.Text;
                var tt = bus.KiemTraTTNS(txt_cccd.Text);
                bool ktTaiKhoan = bus.kiemTraTk(tk);

                if (txt_cccd.Text == "")
                {
                    throw new Exception("*Lỗi. Bạn chưa nhập căn cước công dân");
                }
                else if (tt == null)
                {
                    throw new Exception("*Lỗi. Không có nhân sự nào có mã căn cước công dân như này");
                }
                else if (tk == "")
                {
                    lbl_cccd_chkerr.Visible = false;
                    throw new Exception("*Lỗi. Bạn chưa nhập thông tin tài khoản");
                }
                else if (ktTaiKhoan)
                {
                    throw new Exception("*Lỗi. Trùng tài khoản");
                }
                else if (mk == "")
                {

                    lbl_tk_checkerr.Visible = false;
                    throw new Exception("*Lỗi. Bạn chưa nhập mật khẩu");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn đăng ký với những thông tin bạn đã nhập chưa ?", "Thông báo xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {

                  
                    lbl_mk_chkerr.Visible = false;

                    phanQuyen = tt.ChucVu;
                    Manhansu = tt.MaNhanSu;

                    bus.ThemTK(tk, mk, phanQuyen, Manhansu);
                    txt_cccd.Enabled = true;
                    txt_TenDangNhap.Enabled = true;
                    txt_MatKhau.Enabled = true;
                    lbl_notice_successfull.Visible = true; 
                    }
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("căn cước công dân"))
                {
                    lbl_cccd_chkerr.Visible = true;
                    lbl_cccd_chkerr.ForeColor = Color.Red;
                    lbl_cccd_chkerr.Text = ex.Message;
                }
                else if (ex.Message.Contains("tài khoản"))
                {
                    lbl_tk_checkerr.Visible = true;
                    lbl_tk_checkerr.ForeColor = Color.Red;
                    lbl_tk_checkerr.Text = ex.Message;
                }
                else if (ex.Message.Contains("mật khẩu"))
                {
                    lbl_mk_chkerr.Visible = true;
                    lbl_mk_chkerr.ForeColor = Color.Red;
                    lbl_mk_chkerr.Text = ex.Message;
                }

            }
        }


        private void lbl_DangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangNhap frm_DangNhap = new frm_DangNhap();
            frm_DangNhap.ShowDialog();
            this.Close();
        }

        private void frm_DangKyTaiKhoan_Load(object sender, EventArgs e)
        {

            lbl_cccd_chkerr.Visible = false;
            lbl_tk_checkerr.Visible = false;
            lbl_mk_chkerr.Visible = false;
            lbl_notice_successfull.Visible = false;
        }
    }
}
