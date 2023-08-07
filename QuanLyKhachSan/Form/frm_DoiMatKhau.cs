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
            txt_MatKhauCu.UseSystemPasswordChar = false;
            pic_Hide.Show();
        }

        private void pic_Hide_Click_1(object sender, EventArgs e)
        {
            pic_Hide.Hide();
            txt_MatKhauCu.UseSystemPasswordChar = true;
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
                string matKhauCu = txt_MatKhauCu.Text;
                string matKhauMoi = txt_MatKhauMoi.Text;
                string nhapLaiMK = txt_NhapLaiMatKhau.Text;
                if (string.IsNullOrEmpty(matKhauCu))
                {
                    throw new Exception("Bạn chưa nhập mật khẩu cũ");
                }
                var laymk = bus.Laymk(_tk);


                if (txt_MatKhauCu.Text != laymk.MatKhau)
                {
                    throw new Exception("Lỗi. Bạn nhập sai mật khẩu cũ");
                }
                else if (string.IsNullOrEmpty(matKhauMoi))
                {
                    lbl_mkcu_chk.Visible = false;

                    throw new Exception("Bạn chưa nhập mật khẩu mới");
                }
                else if (string.IsNullOrEmpty(nhapLaiMK))
                {
                    lbl_mkmoi_chk.Visible = false;

                    throw new Exception("Bạn chưa nhập xác nhận mật khẩu mới");
                }
                else if (matKhauMoi != nhapLaiMK)
                {
                    throw new Exception("Mật khẩu nhập lại không trùng khớp!");
                }
                else
                {
                    lbl_mkcu_chk.Visible = false;
                    lbl_mkmoi_chk.Visible = false;
                    lbl_remkmoi_chk.Visible = false;
                    bool doimk = bus.DoiMatKhau(_tk, txt_MatKhauCu.Text, txt_MatKhauMoi.Text);
                    lbl_mkcu_chk.Visible = false;

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
                else if (ex.Message == ("Bạn chưa nhập mật khẩu mới"))
                {
                    lbl_mkmoi_chk.Visible = true;
                    lbl_mkmoi_chk.ForeColor = Color.Red;
                    lbl_mkmoi_chk.Text = ex.Message;
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
            txt_TaiKhoan.Text = _tk;
        }
    }
}
