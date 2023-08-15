using QuanLyKhachSan.BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_DoiMatKhau : Form
    {
        string _tk;
        BUS_DoiMatKhau bus;
        public frm_DoiMatKhau(string tk)
        {
            InitializeComponent();
            _tk = tk;
            bus = new BUS_DoiMatKhau();
        }

        private void pic_Show_Click_1(object sender, EventArgs e)
        {
            pic_Show.Hide();
            txt_MatKhauCu.PasswordChar = true;
            pic_Hide.Show();
        }

        private void pic_Hide_Click_1(object sender, EventArgs e)
        {
            pic_Hide.Hide();
            txt_MatKhauCu.PasswordChar = false;
            pic_Show.Show();
        }

        private void pic_Hide_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Hide, "Ẩn mật khẩu");
        }

        private void pic_Show_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Show, "Hiện mật khẩu");
        }
        void doimk()
        {
            try
            {
                string matKhauCu = txt_MatKhauCu.Texts;
                string matKhauMoi = txt_MatKhauMoi.Texts;
                string nhapLaiMK = txt_NhapLaiMatKhau.Texts;
                if (string.IsNullOrEmpty(matKhauCu))
                {
                    lbl_mkmoi_chk.Text = "";
                    lbl_remkmoi_chk.Text = "";
                    throw new Exception("Bạn chưa nhập mật khẩu cũ");
                }
                else if (string.IsNullOrWhiteSpace(matKhauCu))
                {
                    lbl_mkmoi_chk.Text = "";
                    lbl_remkmoi_chk.Text = "";
                    throw new Exception("Bạn chưa nhập mật khẩu cũ");
                }
                if (matKhauCu.Length <5 || matKhauCu.Length > 20)
                {
                    lbl_mkmoi_chk.Text = "";
                    lbl_remkmoi_chk.Text = "";
                    throw new Exception("Mật khẩu cũ không được ít hơn 5 kí tự và nhiều hơn 20 kí tự");
                }
                var laymk = bus.Laymk(_tk);


                if (matKhauCu != laymk.MatKhau)
                {
                    lbl_mkmoi_chk.Text = "";
                    lbl_remkmoi_chk.Text = "";
                    throw new Exception("Lỗi. Bạn nhập sai mật khẩu cũ");
                }
                else if (string.IsNullOrEmpty(matKhauMoi))
                {
                    lbl_mkcu_chk.Text = "";
                    lbl_remkmoi_chk.Text = "";
                    throw new Exception("Bạn chưa nhập mật khẩu mới");
                }
                else if (string.IsNullOrWhiteSpace(matKhauMoi))
                {
                    lbl_mkcu_chk.Text = "";
                    lbl_remkmoi_chk.Text = "";
                    throw new Exception("Bạn chưa nhập mật khẩu mới");
                }
                if (matKhauMoi.Length < 5 || matKhauMoi.Length > 20)
                {
                    lbl_mkcu_chk.Text = "";
                    lbl_remkmoi_chk.Text = "";
                    throw new Exception("Mật khẩu mới không được ít hơn 5 kí tự và nhiều hơn 20 kí tự");
                }
                else if (string.IsNullOrEmpty(nhapLaiMK))
                {
                    lbl_mkcu_chk.Text = "";
                    lbl_mkmoi_chk.Text = "";
                    throw new Exception("Bạn chưa nhập xác nhận mật khẩu mới");
                }
                else if (string.IsNullOrWhiteSpace(nhapLaiMK))
                {
                    lbl_mkcu_chk.Text = "";
                    lbl_mkmoi_chk.Text = "";
                    throw new Exception("Bạn chưa nhập xác nhận mật khẩu mới");
                }
                if (nhapLaiMK.Length < 5 || nhapLaiMK.Length > 20)
                {
                    lbl_mkcu_chk.Text = "";
                    lbl_mkmoi_chk.Text = "";
                    throw new Exception("Mật khẩu nhập lại không được ít hơn 5 kí tự và nhiều hơn 20 kí tự");
                }
                else if (matKhauMoi != nhapLaiMK)
                {
                    lbl_mkcu_chk.Text = "";
                    lbl_mkmoi_chk.Text = "";
                    throw new Exception("Mật khẩu nhập lại không trùng khớp!");
                }
                else
                {
                    lbl_mkcu_chk.Text = "";
                    lbl_mkmoi_chk.Text = "";
                    lbl_remkmoi_chk.Text = "";
                    bool doimk = bus.DoiMatKhau(_tk, matKhauCu, matKhauMoi);

                    frm_TrangChu.ViDu.Hide();
                    frm_DangNhap frm = new frm_DangNhap();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == ("Bạn chưa nhập mật khẩu cũ"))
                {
                    lbl_mkcu_chk.Visible = true;
                    lbl_mkcu_chk.ForeColor = Color.Red;
                    lbl_mkcu_chk.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu cũ không được ít hơn 5 kí tự và nhiều hơn 20 kí tự"))
                {
                    lbl_mkcu_chk.Visible = true;
                    lbl_mkcu_chk.ForeColor = Color.Red;
                    lbl_mkcu_chk.Text = ex.Message;
                }
                else if (ex.Message == ("Bạn chưa nhập mật khẩu mới"))
                {
                    lbl_mkmoi_chk.Visible = true;
                    lbl_mkmoi_chk.ForeColor = Color.Red;
                    lbl_mkmoi_chk.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu mới không được ít hơn 5 kí tự và nhiều hơn 20 kí tự"))
                {
                    lbl_mkmoi_chk.Visible = true;
                    lbl_mkmoi_chk.ForeColor = Color.Red;
                    lbl_mkmoi_chk.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu nhập lại không được ít hơn 5 kí tự và nhiều hơn 20 kí tự"))
                {
                    lbl_remkmoi_chk.Visible = true;
                    lbl_remkmoi_chk.ForeColor = Color.Red;
                    lbl_remkmoi_chk.Text = ex.Message;
                }
                else if (ex.Message == ("Bạn chưa nhập xác nhận mật khẩu mới"))
                {
                    lbl_remkmoi_chk.Visible = true;
                    lbl_remkmoi_chk.ForeColor = Color.Red;
                    lbl_remkmoi_chk.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu nhập lại không trùng khớp!"))
                {
                    lbl_remkmoi_chk.Visible = true;
                    lbl_remkmoi_chk.ForeColor = Color.Red;
                    lbl_remkmoi_chk.Text = ex.Message;
                }
                else if (ex.Message == ("Lỗi. Bạn nhập sai mật khẩu cũ"))
                {
                    lbl_mkcu_chk.Visible = true;
                    lbl_mkcu_chk.ForeColor = Color.Red;
                    lbl_mkcu_chk.Text = ex.Message;
                }
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            doimk();
        }


        private void pnl_thongtindangnhap_Paint(object sender, PaintEventArgs e)
        {
            txt_TaiKhoan.Texts = _tk;
        }

        private void frm_DoiMatKhau_Leave(object sender, EventArgs e)
        {

        }

        private void frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            txt_TaiKhoan.Enabled = false;
        }
    }
}
