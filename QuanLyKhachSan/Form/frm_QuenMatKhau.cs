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
    public partial class frm_QuenMatKhau : Form
    {
        BUS_QuenMatKhau bus;
        public frm_QuenMatKhau()
        {
            InitializeComponent();
            bus= new BUS_QuenMatKhau();
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
            string tenDangNhap = txt_TenDangNhap.Text;
            if (bus.kiemTraTenDangNhap(tenDangNhap))
            {
               pnl_dmk.Visible = true;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập không tồn tại!");
            }
        }

        private void btn_LayLaiMatKhau_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_LayLaiMatKhau_Click_1(object sender, EventArgs e)
        {
            string tenDangNhap = txt_TenDangNhap.Text;
            string matKhauMoi = txt_MatKhau.Text;
            string nhapLaiMK = txt_NhapLaiMK.Text;

            if (matKhauMoi != nhapLaiMK)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không khớp!");
                return;
            }

            bus.doiMatKhau(tenDangNhap, matKhauMoi);
            MessageBox.Show("Đổi mật khẩu thành công!");
        }
    }
}
