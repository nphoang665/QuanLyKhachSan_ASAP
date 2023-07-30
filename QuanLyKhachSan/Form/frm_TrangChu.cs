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

namespace QuanLyKhachSan
{
    public partial class frm_TrangChu : Form
    {
        BUS_TrangChu bus;
        public Form frm_HienTai;
        public string TenDangNhap;
        string _tk;
        public frm_TrangChu(string tk)
        {
            InitializeComponent();

            _tk = tk;
            bus = new BUS_TrangChu();
        }

        public void OpenChildForm(Form frm_Con)
        {
            if (frm_HienTai != null)
            {
                frm_HienTai.Close();
            }

            frm_HienTai = frm_Con;
            frm_Con.TopLevel = false;
            frm_Con.FormBorderStyle = FormBorderStyle.None;
            frm_Con.Dock = DockStyle.Fill;
            pnl_Main.Controls.Add(frm_Con);
            frm_Con.Show();
            
        }

        private void DiChuyenPanel(Control btn)
        {
            pnl_Slide.Top = btn.Top;
            pnl_Slide.Height = btn.Height;

        }

        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_TenDangNhap.Text = TenDangNhap;
            ThongTinTaiKoan();
        }
        
        private void linkLabel_Thoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btn_TrangChu);
        }
        void ThongTinTaiKoan()
        {
            lbl_TenDangNhap.Text = bus.LayTen(_tk);
            //phân quyền tại đây
            

        }

        private void btn_ThuePhong_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btn_ThuePhong);
            OpenChildForm(new frm_ThuePhong());
        }

        private void btn_TraPhong_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btn_TraPhong);
            OpenChildForm(new frm_TraPhong());
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btn_KhachHang);
            OpenChildForm(new frm_KhachHang());
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btn_NhanVien);
            OpenChildForm(new frm_NhanVien());
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btn_HoaDon);
            OpenChildForm(new frm_HoaDon());
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btn_TaiKhoan);
            OpenChildForm(new frm_NguoiDung());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_DoiMatKhau(_tk));
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Phong());
        }

        private void vậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_VatTu());
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_DichVu());
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_NhanVien());
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_NguoiDung());
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ThuePhong());
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_TraPhong());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Date.Text = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss tt");
        }
    }
}
