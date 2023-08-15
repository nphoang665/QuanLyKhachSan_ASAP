using QuanLyKhachSan.BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_DangNhap : Form
    {
        BUS_DangNhap bus;

        public frm_DangNhap()
        {
            InitializeComponent();
            bus = new BUS_DangNhap();

        }

        private void pic_Show_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Show, "Hiện mật khẩu");
            txt_MatKhau.PasswordChar = false;
        }

        private void pic_Hide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Hide, "Ẩn mật khẩu");
            txt_MatKhau.PasswordChar = true;

        }

        private void pic_Show_Click(object sender, EventArgs e)
        {
            pic_Show.Hide();
            pic_Hide.Show();
        }

        private void pic_Hide_Click(object sender, EventArgs e)
        {
            pic_Hide.Hide();
            pic_Show.Show();
        }

        private void lbl_QuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_QuenMatKhau frm_QuenMatKhau = new frm_QuenMatKhau();

            frm_QuenMatKhau.ShowDialog();


        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_TenDangNhap.Texts;
            string password = txt_MatKhau.Texts;
            try
            {
                if (string.IsNullOrEmpty(username))
                {
                    lbl_chk_MatKhau.Text = "";
                    throw new Exception("Vui lòng nhập tên đăng nhập.");
                }
                else if (username.Length < 5 || username.Length > 20)
                {
                    lbl_chk_MatKhau.Text = "";
                    throw new Exception("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (string.IsNullOrEmpty(password))
                {
                    lbl_chk_TenDangNhap.Text = "";
                    throw new Exception("Vui lòng nhập mật khẩu.");
                }
                else if (password.Length < 5 || password.Length > 20)
                {
                    lbl_chk_TenDangNhap.Text = "";
                    throw new Exception("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else
                {

                    if (chk_ghiNhoDangNhap.Checked)
                    {
                      

                        var savedLoginInfo = bus.LayThongTinDaLuu();
                        if (savedLoginInfo != null)
                        {
                            bus.CapNhapThongTin(username, password);
                        }
                        else
                        {
                            bus.LuuThongTinDangNhap(username, password);
                        }
                    }
                    else
                    {
                        bus.XoaThongTinDaLuu();
                    }

                  
                    string tinhTrang = bus.KiemTraTinhTrang(username);
                    if (tinhTrang == "ThanhCong")
                    {




                        bool dangnhap = bus.DangNhapTaiKhoan(username, password);
                        if (dangnhap)
                        {
                            this.Hide();
                            frm_TrangChu frm = new frm_TrangChu(username);
                            frm.ShowDialog();
                            this.Close();
                        }
                        else
                        {


                            lbl_chk_TenDangNhap.Text = "";
                            throw new Exception("Tên đăng nhập, mật khẩu không chính xác");
                        }
                    }
                    else if (tinhTrang == "ThatBai")
                    {
                        string lydo = bus.LayLyDo(username);
                        MessageBox.Show("Đăng nhập thất bại. Lý do: " + lydo, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn đang đợi xác thực. Xin vui lòng đợi admin xác thực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                if (ex.Message == ("Vui lòng nhập tên đăng nhập."))
                {
                    lbl_chk_TenDangNhap.Visible = true;
                    lbl_chk_TenDangNhap.ForeColor = Color.Red;
                    lbl_chk_TenDangNhap.Text = ex.Message;
                }
                else if (ex.Message == ("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_chk_TenDangNhap.Visible = true;
                    lbl_chk_TenDangNhap.ForeColor = Color.Red;
                    lbl_chk_TenDangNhap.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_chk_MatKhau.Visible = true;
                    lbl_chk_MatKhau.ForeColor = Color.Red;
                    lbl_chk_MatKhau.Text = ex.Message;
                }
                else if (ex.Message == ("Vui lòng nhập mật khẩu."))
                {
                    lbl_chk_MatKhau.Visible = true;
                    lbl_chk_MatKhau.ForeColor = Color.Red;
                    lbl_chk_MatKhau.Text = ex.Message;
                }
                else if (ex.Message == ("Tên đăng nhập, mật khẩu không chính xác"))
                {
                    lbl_chk_MatKhau.Visible = true;
                    lbl_chk_MatKhau.ForeColor = Color.Red;
                    lbl_chk_MatKhau.Text = ex.Message;
                }
            }
        }


        private void chk_ghiNhoDangNhap_CheckedChanged(object sender, EventArgs e)
        {

        }
        void loadNhomk()
        {
            var savedLoginInfo = bus.LayThongTinDaLuu();

            if (savedLoginInfo != null)
            {
                txt_TenDangNhap.Texts = savedLoginInfo.TaiKhoan;
                txt_MatKhau.Texts = savedLoginInfo.MatKhau;
            }
        }
        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            if (bus.kiemtraluumk() == true)
            {
                chk_ghiNhoDangNhap.Checked = true;

            }
            else
            {
                chk_ghiNhoDangNhap.Checked = false;
            }
            loadNhomk();
        }

        private void lbl_dangky_Click(object sender, EventArgs e)
        {
            this.Hide();

            frm_DangKyTaiKhoan frm_DangKy = new frm_DangKyTaiKhoan();
            frm_DangKy.ShowDialog();
        }
    }
}
