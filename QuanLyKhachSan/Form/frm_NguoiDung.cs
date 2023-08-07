using QuanLyKhachSan.BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_NguoiDung : Form
    {
        BUS_QuanLyTaiKhoan dstk;

        public frm_NguoiDung()
        {
            InitializeComponent();
            dstk = new BUS_QuanLyTaiKhoan();

        }

        private void dgv_DanhSachNguoiDung2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiem = txt_TimKiem.Text;

            var ketqua = dstk.TimTaiKhoan(timKiem);

            dgv_DanhSachNguoiDung1.DataSource = ketqua;
        }

        private void dgv_DanhSachNguoiDung2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string tendangnhap = dgv_DanhSachNguoiDung2.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                var taiKhoan = dstk.LayTaiKhoan(tendangnhap);

                txt_tk_Sua.Text = taiKhoan.TenDangNhap;
                txt_mk_Sua.Text = taiKhoan.MatKhau;
                cbo_phanquyen_sua.SelectedItem = taiKhoan.PhanQuyen;
                txt_manhansu_sua.Text = taiKhoan.MaNhanSu;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txt_TenDangNhap.Text;
                string matKhau = txt_MatKhau.Text;
                string manhansu = txt_manhansu_them.Text;
                if (string.IsNullOrEmpty(tenDangNhap))
                {
                    throw new Exception("Lỗi. Chưa nhập tên đăng nhập!");
                }
                else if (dstk.KiemTraTenDangNhap(tenDangNhap))
                {
                    throw new Exception("Lỗi. Tên đăng nhập đã tồn tại!");
                }
                else if (string.IsNullOrEmpty(matKhau))
                {
                    lbl_tdnthem_chk.Visible=false;
                    throw new Exception("Lỗi. Chưa nhập mật khẩu!");
                }
                else if (string.IsNullOrEmpty(manhansu))
                {
                    lbl_mkthem_chk.Visible = false;

                    throw new Exception("Lỗi. Bạn chưa nhập Mã nhân sự");
                }
                else if (!dstk.KiemTraMaNhanSu(manhansu))
                {
                    throw new Exception("Lỗi. Mã nhân sự không hợp lệ!");
                }
                if (cbo_phanquen_them.SelectedItem == null)
                {
                    lbl_mnsthem_chk.Visible = false;

                    throw new Exception("Lỗi. Bạn chưa chọn Phân quyền");
                }
                else
                {
                    string phanQuyen = cbo_phanquen_them.SelectedItem.ToString();
                    bool ktpq = dstk.KiemTraPhanQuyen(manhansu, phanQuyen);
                    if (!ktpq)
                    {
                        throw new Exception("Lỗi. Phân quyền không hợp lệ. Thử kiểm tra lại ở phần nhân viên");
                    }
                    else
                    {
                        lbl_tdnthem_chk.Visible = false;
                        lbl_mkthem_chk.Visible = false;
                        lbl_mnsthem_chk.Visible = false;
                        lbl_pqthem_chk.Visible = false;
                        dstk.ThemTaiKhoan(tenDangNhap, matKhau, phanQuyen, manhansu);
                        dstk.LoadDsTk(dgv_DanhSachNguoiDung);
                        dstk.LoadDsTk(dgv_DanhSachNguoiDung1);
                        dstk.LoadDsTk(dgv_DanhSachNguoiDung2);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("đăng nhập"))
                {
                    lbl_tdnthem_chk.Visible = true;
                    lbl_tdnthem_chk.ForeColor = Color.Red;
                    lbl_tdnthem_chk.Text = ex.Message;
                }
                else if (ex.Message.Contains("mật khẩu"))
                {
                    lbl_mkthem_chk.Visible = true;
                    lbl_mkthem_chk.ForeColor = Color.Red;
                    lbl_mkthem_chk.Text = ex.Message;
                }
                else if (ex.Message.Contains("Phân quyền"))
                {
                    lbl_pqthem_chk.Visible = true;
                    lbl_pqthem_chk.ForeColor = Color.Red;
                    lbl_pqthem_chk.Text = ex.Message;
                }
                else if (ex.Message.Contains("Mã nhân sự"))
                {
                    lbl_mnsthem_chk.Visible = true;
                    lbl_mnsthem_chk.ForeColor = Color.Red;
                    lbl_mnsthem_chk.Text = ex.Message;
                }
            }
        }


        private void frm_NguoiDung_Load(object sender, EventArgs e)
        {
            dstk.LoadDsTk(dgv_DanhSachNguoiDung);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung1);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung2);
            cbo_phanquen_them.Items.Add("Nhân viên");
            cbo_phanquen_them.Items.Add("Quản lý");
            cbo_phanquyen_sua.Items.Add("Nhân viên");
            cbo_phanquyen_sua.Items.Add("Quản lý");


        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            string tenDangNhap = txt_tk_Sua.Text;
            string matKhau = txt_mk_Sua.Text;
            string phanQuyen = cbo_phanquyen_sua.SelectedItem.ToString();
            string manhansu = txt_manhansu_sua.Text;
            bool ktpq = dstk.KiemTraPhanQuyen(manhansu, phanQuyen);
            if (ktpq)
            {
                dstk.SuaTaiKhoan(tenDangNhap, matKhau, phanQuyen, manhansu);

                dstk.LoadDsTk(dgv_DanhSachNguoiDung);
                dstk.LoadDsTk(dgv_DanhSachNguoiDung1);
                dstk.LoadDsTk(dgv_DanhSachNguoiDung2);
            }
            else
            {
                MessageBox.Show("Lỗi. Khác chức vụ");
            }
        }

        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {

            string tenDangNhap = txt_tk_Sua.Text;

            dstk.XoaTaiKhoan(tenDangNhap);

            dstk.LoadDsTk(dgv_DanhSachNguoiDung);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung1);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung2);
        }

        private void tabPage_ThemNguoiDung_Click(object sender, EventArgs e)
        {

        }
    }
}
