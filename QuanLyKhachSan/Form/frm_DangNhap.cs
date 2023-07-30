using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKhachSan
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void pic_Show_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Show, "Hiện mật khẩu");
        }

        private void pic_Hide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_Hide, "Ẩn mật khẩu");
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

        private void lbl_QuenMatKhau_Click(object sender, EventArgs e)
        {
            frm_QuenMatKhau frm_QuenMatKhau = new frm_QuenMatKhau();
            frm_QuenMatKhau.Show();
        }
    }
}
