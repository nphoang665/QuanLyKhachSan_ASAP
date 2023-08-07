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

using QuanLyKhachSan.DA;

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
            bool doimk = bus.DoiMatKhau(_tk, txt_MatKhauCu.Text, txt_MatKhauMoi.Text);
            if (doimk)
            {
                frm_TrangChu.ViDu.Hide();
                frm_DangNhap frm = new frm_DangNhap();
                frm.ShowDialog();
                this.Close();

            }
        }



        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string matKhauMoi = txt_MatKhauMoi.Text;
            string nhapLaiMK = txt_NhapLaiMatKhau.Text;

            if (matKhauMoi != nhapLaiMK)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp!");
                return;
            }
            else
            {
                doimk();
            }
        }

        private void pnl_thongtindangnhap_Paint(object sender, PaintEventArgs e)
        {
            txt_TaiKhoan.Text = _tk;
        }
    }
}
