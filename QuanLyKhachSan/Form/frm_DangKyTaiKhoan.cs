using QuanLyKhachSan.BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{

    public partial class frm_DangKyTaiKhoan : Form
    {
        BUS_DangKy bus;
        string phanQuyen;
        string Manhansu;
        public frm_DangKyTaiKhoan()
        {
            InitializeComponent();
            bus = new BUS_DangKy();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                string tk = txt_TenDangNhap.Text;
                string mk = txt_MatKhau.Text;
                var tt = bus.KiemTraTTNS(txt_cccd.Text);
                bool ktTaiKhoan = bus.kiemTraTk(tk);

                if (txt_cccd.Text == "")
                {
                    lbl_tk_checkerr.Text = "";
                    lbl_mk_chkerr.Text = "";
                    throw new Exception("*Lỗi. Bạn chưa nhập căn cước công dân");
                }
                else if (tt == null)
                {
                    lbl_tk_checkerr.Text = "";
                    lbl_mk_chkerr.Text = "";
                    throw new Exception("*Lỗi. Không có nhân sự nào có mã căn cước công dân như này");
                }
                //
                else if (tk == "")
                {
                    lbl_cccd_chkerr.Text = "";
                    lbl_mk_chkerr.Text = "";
                    throw new Exception("*Lỗi. Bạn chưa nhập thông tin tài khoản");
                }
                else if (tk.Length < 5 || tk.Length > 20)
                {
                    lbl_cccd_chkerr.Text = "";
                    lbl_mk_chkerr.Text = "";

                    throw new Exception("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (ktTaiKhoan)
                {
                    lbl_cccd_chkerr.Text = "";
                    lbl_mk_chkerr.Text = "";
                    throw new Exception("*Lỗi. Trùng tài khoản");
                }
                else if (mk == "")
                {
                    lbl_cccd_chkerr.Text = "";
                    lbl_tk_checkerr.Text = "";
                    throw new Exception("*Lỗi. Bạn chưa nhập mật khẩu");
                }
                else if (mk.Length < 5 || mk.Length > 20)
                {
                    lbl_cccd_chkerr.Text = "";
                    lbl_tk_checkerr.Text = "";

                    throw new Exception("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else
                {
                    lbl_cccd_chkerr.Text = "";
                    lbl_tk_checkerr.Text = "";
                    lbl_mk_chkerr.Text = "";
                    DialogResult result = MessageBox.Show("Bạn có muốn đăng ký với những thông tin bạn đã nhập chưa ?", "Thông báo xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                       

                        phanQuyen = tt.ChucVu;
                    Manhansu = tt.MaNhanSu;

                    bus.ThemTK(tk, mk, phanQuyen, Manhansu);
                    txt_cccd.Enabled = false;
                    txt_TenDangNhap.Enabled = false;
                    txt_MatKhau.Enabled = false;
                    lbl_notice_successfull.Visible = true; 
                    }
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("căn cước công dân"))
                {
                    lbl_cccd_chkerr.Visible = true;
                    lbl_cccd_chkerr.ForeColor = Color.Red;
                    lbl_cccd_chkerr.Text = ex.Message;
                }
                else if (ex.Message.Contains("tài khoản"))
                {
                    lbl_tk_checkerr.Visible = true;
                    lbl_tk_checkerr.ForeColor = Color.Red;
                    lbl_tk_checkerr.Text = ex.Message;
                }
                else if (ex.Message.Contains("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_tk_checkerr.Visible = true;
                    lbl_tk_checkerr.ForeColor = Color.Red;
                    lbl_tk_checkerr.Text = ex.Message;
                }
                else if (ex.Message.Contains("mật khẩu"))
                {
                    lbl_mk_chkerr.Visible = true;
                    lbl_mk_chkerr.ForeColor = Color.Red;
                    lbl_mk_chkerr.Text = ex.Message;
                }
                else if (ex.Message.Contains("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_mk_chkerr.Visible = true;
                    lbl_mk_chkerr.ForeColor = Color.Red;
                    lbl_mk_chkerr.Text = ex.Message;
                }

            }
        }


        private void lbl_DangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangNhap frm_DangNhap = new frm_DangNhap();
            frm_DangNhap.ShowDialog();
            this.Close();
        }

        private void frm_DangKyTaiKhoan_Load(object sender, EventArgs e)
        {

        
        }
    }
}
