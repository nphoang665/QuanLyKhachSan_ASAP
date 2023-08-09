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
        public static frm_TrangChu ViDu { get; private set; }
        BUS_TrangChu bus;
        public Form frm_HienTai;
        public string TenDangNhap;
        string _tk;
        public string ChucVu;

        public frm_TrangChu()
        {
            InitializeComponent();
        }
            public frm_TrangChu(string tk)
        {
            InitializeComponent();
            // Khởi tạo ViDu của frm_TrangChu
            ViDu = this;
            _tk = tk;
            bus = new BUS_TrangChu();
            ChucVu = bus.LayChucVu(tk);
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
        void PhanQuyen()
        {
            if (ChucVu == "Nhân viên")
            {
                btn_NhanVien.Visible = false;
                quảnLýToolStripMenuItem.Enabled = false;
                btn_TaiKhoan.Visible = false;

                btn_NhanVien.ForeColor = Color.Gray;
                quảnLýToolStripMenuItem.ForeColor = Color.Gray;
                btn_TaiKhoan.ForeColor = Color.Gray;

                btn_NhanVien.Click += (s, e) => MessageBox.Show("Chức năng này chỉ dành cho quản lý");
                quảnLýToolStripMenuItem.Click += (s, e) => MessageBox.Show("Chức năng này chỉ dành cho quản lý");
                btn_TaiKhoan.Click += (s, e) => MessageBox.Show("Chức năng này chỉ dành cho quản lý");
            }
            else if (ChucVu == "Quản lý")
            {
                btn_NhanVien.Enabled = true;
            }
        }



        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            timer1.Start();
            lbl_TenDangNhap.Text = _tk;
            OpenChildForm(new frm_GiaoDienPhong());
           
            ThongTinTaiKoan();
        }
        
        private void linkLabel_Thoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Hide();
                frm_DangNhap frm_DangNhap = new frm_DangNhap();
                frm_DangNhap.ShowDialog();
            }
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btn_TrangChu);
            OpenChildForm(new frm_GiaoDienPhong());
        }
        void ThongTinTaiKoan()
        {
            //lbl_TenDangNhap.Text = bus.LayTen(_tk);
            //phân quyền tại đây
            

        }

        private void btn_TraPhong_Click(object sender, EventArgs e)
        {
            /*DiChuyenPanel(btn_TraPhong);
            OpenChildForm(new frm_TraPhong());*/
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
                this.Hide();
                frm_DangNhap frm_DangNhap = new frm_DangNhap();
                frm_DangNhap.ShowDialog();
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


        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frm_TraPhong());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Date.Text = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss tt");
        }

        private void btn_Phong_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btn_Phong);
            OpenChildForm(new frm_Phong());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Thoát khỏi ứng dụng?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_ThongKe());
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThuePhong_Click(object sender, EventArgs e)
        {
            DiChuyenPanel(btn_ThuePhong);
            OpenChildForm(new frm_ThuePhong());
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenChildForm(new frm_ThongTinTaiKhoan(_tk));
        }
    }
}
