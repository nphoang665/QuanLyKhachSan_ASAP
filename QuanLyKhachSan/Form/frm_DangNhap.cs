using QuanLyKhachSan.BUS;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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
        void DangNhap()
        {
            string tk = txt_TenDangNhap.Text;
            string mk = txt_MatKhau.Text;

            KiemLoi.Clear(); 

            if (string.IsNullOrEmpty(tk))
            {
                KiemLoi.SetError(txt_TenDangNhap, "Vui lòng nhập tên đăng nhập");
                return;
            }

            if (string.IsNullOrEmpty(mk))
            {
                KiemLoi.SetError(txt_MatKhau, "Vui lòng nhập mật khẩu");
                KiemLoi.SetIconPadding(txt_MatKhau, 30);
                return;
            }

            bool dangnhap = bus.DangNhapTaiKhoan(tk, mk);
            if (dangnhap)
            {
                this.Hide();
                frm_TrangChu frm = new frm_TrangChu(tk);
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập, mật khẩu không chính xác");
            }


        }
        private void lbl_QuenMatKhau_Click(object sender, EventArgs e)
        {
            frm_QuenMatKhau frm_QuenMatKhau = new frm_QuenMatKhau();
            frm_QuenMatKhau.Show();
            this.Hide();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {

            if (chk_ghiNhoDangNhap.Checked)
            {
                string username = txt_TenDangNhap.Text;
                string password = txt_MatKhau.Text;

                var savedLoginInfo = bus.GetSavedLoginInfo();
                if (savedLoginInfo != null)
                {
                    bus.UpdateSavedLoginInfo(username, password);
                }
                else
                {
                    bus.SaveLoginInfo(username, password);
                }
            }
            else
            {
                bus.DeleteSavedLoginInfo();
            }
            DangNhap();
        }

        private void chk_ghiNhoDangNhap_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        void loadNhomk()
        {
            var savedLoginInfo = bus.GetSavedLoginInfo();

            if (savedLoginInfo != null)
            {
                txt_TenDangNhap.Text = savedLoginInfo.TaiKhoan;
                txt_MatKhau.Text = savedLoginInfo.MatKhau;
            }
        }
        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            if (bus.kiemtraluumk() == true)
            {
                chk_ghiNhoDangNhap.Checked=true;

            }
            else
            {
                chk_ghiNhoDangNhap.Checked = false;
            }
            loadNhomk();
        }
    }
}
