using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKhachSan
{
    public partial class frm_DoiMatKhau : Form
    {
        public frm_DoiMatKhau()
        {
            InitializeComponent();
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
    }
}
