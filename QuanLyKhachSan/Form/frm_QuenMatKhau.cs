using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_QuenMatKhau : Form
    {
        BUS_QuenMatKhau bus;
        public frm_QuenMatKhau()
        {
            InitializeComponent();
            bus = new BUS_QuenMatKhau();
            pnl_dmk.Visible = false;
        }

        private void lbl_DangNhap_Click(object sender, EventArgs e)
        {
            frm_DangNhap frm_DangNhap = new frm_DangNhap();
            frm_DangNhap.ShowDialog();
        }

        private void pic_Show_Click(object sender, EventArgs e)
        {
            pic_Show.Hide();
            txt_MatKhau.UseSystemPasswordChar = false;
            pic_Hide.Show();
        }

        private void pic_Hide_Click(object sender, EventArgs e)
        {
            pic_Hide.Hide();
            txt_MatKhau.UseSystemPasswordChar = true;
            pic_Show.Show();
        }

        private void pic_Hide1_Click(object sender, EventArgs e)
        {
            pic_Hide1.Hide();
            txt_NhapLaiMK.UseSystemPasswordChar = true;
            pic_Show1.Show();
        }

        private void pic_Show1_Click(object sender, EventArgs e)
        {
            pic_Show1.Hide();
            txt_NhapLaiMK.UseSystemPasswordChar = false;
            pic_Hide1.Show();
        }

        private void pic_Show_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Show, "Hiện mật khẩu");
        }

        private void pic_Hide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Hide, "Ẩn mật khẩu");
        }

        private void pic_Hide1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Hide1, "Ẩn mật khẩu");
        }

        private void pic_Show1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Show1, "Hiện mật khẩu");
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txt_TenDangNhap.Text;
                if (string.IsNullOrEmpty(tenDangNhap))
                {
                   
                    throw new Exception("Bạn chưa nhập tên đăng nhập");
                }
                else if (!bus.kiemTraTenDangNhap(tenDangNhap))
                {

                    throw new Exception("Tên đăng nhập không tồn tại!");
                }
                else
                {
                    lbl_tendangnhap_chk.Text = "";
                    pnl_dmk.Visible = true;
                    txt_TenDangNhap.Enabled = false;
                }


            }
            catch (Exception ex)
            {
                if (ex.Message == ("Bạn chưa nhập tên đăng nhập"))
                {
                    lbl_tendangnhap_chk.Visible = true;
                    lbl_tendangnhap_chk.ForeColor = Color.Red;
                    lbl_tendangnhap_chk.Text = ex.Message;
                }
                else if (ex.Message == ("Tên đăng nhập không tồn tại!"))
                {
                    lbl_tendangnhap_chk.Visible = true;
                    lbl_tendangnhap_chk.ForeColor = Color.Red;
                    lbl_tendangnhap_chk.Text = ex.Message;
                }


            }
        }

        private void btn_LayLaiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void btn_LayLaiMatKhau_Click_1(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txt_TenDangNhap.Text;
                string matKhauMoi = txt_MatKhau.Text;
                string nhapLaiMK = txt_NhapLaiMK.Text;
                if (txt_MatKhau.Text == "")
                {
                    lbl_rematkhaumoi_chk.Text = "";
                    throw new Exception("Bạn chưa nhập mật khẩu");
                }
                else if (txt_NhapLaiMK.Text == "")
                {
                    lbl_matkhaumoi_chk.Text = "";
                    throw new Exception("Bạn chưa nhập xác nhận lại mật khẩu");
                }
                else if(matKhauMoi!= nhapLaiMK)
                {
                    lbl_matkhaumoi_chk.Text = "";
                    throw new Exception("Lỗi. Mật khẩu không trùng nhau");
                }
                else
                {
                    lbl_matkhaumoi_chk.Text = "";
                    lbl_rematkhaumoi_chk.Text = "";
                    bus.doiMatKhau(tenDangNhap, matKhauMoi);
                    lbl_notice_successfull.Visible = true;
                }
            }
            catch (Exception ex)
            {

                if (ex.Message == ("Bạn chưa nhập mật khẩu"))
                {
                    lbl_matkhaumoi_chk.Visible = true;
                    lbl_matkhaumoi_chk.ForeColor = Color.Red;
                    lbl_matkhaumoi_chk.Text = ex.Message;
                }
                else if (ex.Message == ("Lỗi. Mật khẩu không trùng nhau"))
                {
                    lbl_rematkhaumoi_chk.Visible = true;
                    lbl_rematkhaumoi_chk.ForeColor = Color.Red;
                    lbl_rematkhaumoi_chk.Text = ex.Message;
                }
                else if (ex.Message == ("Bạn chưa nhập xác nhận lại mật khẩu"))
                {
                    lbl_rematkhaumoi_chk.Visible = true;
                    lbl_rematkhaumoi_chk.ForeColor = Color.Red;
                    lbl_rematkhaumoi_chk.Text = ex.Message;
                }

            }
        }

        private void pic_Show_Click_1(object sender, EventArgs e)
        {
            pic_Show.Hide();
            txt_MatKhau.UseSystemPasswordChar = false;
            pic_Hide.Show();
        }

        private void pic_Hide_Click_1(object sender, EventArgs e)
        {
            pic_Hide.Hide();
            txt_MatKhau.UseSystemPasswordChar = true;
            pic_Show.Show();
        }

        private void pic_Show1_Click_1(object sender, EventArgs e)
        {
            pic_Show1.Hide();
            txt_NhapLaiMK.UseSystemPasswordChar = false;
            pic_Hide1.Show();
        }

        private void pic_Hide1_Click_1(object sender, EventArgs e)
        {
            pic_Hide1.Hide();
            txt_NhapLaiMK.UseSystemPasswordChar = true;
            pic_Show1.Show();
        }

        private void pic_Show_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Show, "Hiện mật khẩu");
        }

        private void pic_Hide_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Hide, "Ẩn mật khẩu");
        }

        private void pic_Show1_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Show1, "Hiện mật khẩu");
        }

        private void pic_Hide1_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Hide1, "Ẩn mật khẩu");
        }

        private void lbl_DangNhap_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frm_DangNhap frm_DangNhap = new frm_DangNhap();
            frm_DangNhap.ShowDialog();
        }
    }
}
