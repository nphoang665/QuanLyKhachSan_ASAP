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
            string timKiem = txt_TimKiem.Texts;

            var ketqua = dstk.TimTaiKhoan(timKiem);

            dgv_DanhSachNguoiDung1.DataSource = ketqua;
        }

        private void dgv_DanhSachNguoiDung2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_tk_Sua.Enabled = false;
            if (e.RowIndex >= 0)
            {
                string tendangnhap = dgv_DanhSachNguoiDung2.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                var taiKhoan = dstk.LayTaiKhoan(tendangnhap);

                txt_tk_Sua.Texts = taiKhoan.TenDangNhap;
                txt_mk_Sua.Texts = taiKhoan.MatKhau;
                cbo_phanquyen_sua.SelectedItem = taiKhoan.PhanQuyen;
                txt_manhansu_sua.Texts = taiKhoan.MaNhanSu;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txt_TenDangNhap.Texts;
                string matKhau = txt_MatKhau.Texts;
                string manhansu = txt_manhansu_them.Texts;
                if (string.IsNullOrEmpty(tenDangNhap))
                {
                    lbl_mkthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    throw new Exception("Lỗi. Chưa nhập tên đăng nhập!");
                }
                else if (dstk.KiemTraTenDangNhap(tenDangNhap))
                {
                    lbl_mkthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    throw new Exception("Lỗi. Tên đăng nhập đã tồn tại!");
                }
                else if (string.IsNullOrEmpty(matKhau))
                {
                    lbl_tdnthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    throw new Exception("Lỗi. Chưa nhập mật khẩu!");
                }
                else if (string.IsNullOrEmpty(manhansu))
                {
                    lbl_tdnthem_chk.Text = "";
                    lbl_mkthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";

                    throw new Exception("Lỗi. Bạn chưa nhập Mã nhân sự");
                }
                else if (!dstk.KiemTraMaNhanSu(manhansu))
                {
                    lbl_tdnthem_chk.Text = "";
                    lbl_mkthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";
                    throw new Exception("Lỗi. Mã nhân sự không hợp lệ!");
                }
                if (cbo_phanquen_them.SelectedItem == null)
                {
                    lbl_tdnthem_chk.Text = "";
                    lbl_mkthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    throw new Exception("Lỗi. Bạn chưa chọn Phân quyền");
                }
                else
                {
                    lbl_tdnthem_chk.Text = "";
                    lbl_mkthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    string phanQuyen = cbo_phanquen_them.SelectedItem.ToString();
                    bool ktpq = dstk.KiemTraPhanQuyen(manhansu, phanQuyen);
                    if (!ktpq)
                    {
                        throw new Exception("Lỗi. Phân quyền không hợp lệ. Thử kiểm tra lại ở phần nhân viên");
                    }
                    else
                    {
                        lbl_tdnthem_chk.Text = "";
                        lbl_mkthem_chk.Text = "";
                        lbl_pqthem_chk.Text = "";
                        lbl_mnsthem_chk.Text = "";
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
            dgv_DanhSachNguoiDung.Columns[0].HeaderCell.Value = "Tên đăng nhập";
            dgv_DanhSachNguoiDung.Columns[1].HeaderCell.Value = "Mật khẩu";
            dgv_DanhSachNguoiDung.Columns[2].HeaderCell.Value = "Phân quyền";
            dgv_DanhSachNguoiDung.Columns[3].HeaderCell.Value = "Mã nhân sự";

            dgv_DanhSachNguoiDung1.Columns[0].HeaderCell.Value = "Tên đăng nhập";
            dgv_DanhSachNguoiDung1.Columns[1].HeaderCell.Value = "Mật khẩu";
            dgv_DanhSachNguoiDung1.Columns[2].HeaderCell.Value = "Phân quyền";
            dgv_DanhSachNguoiDung1.Columns[3].HeaderCell.Value = "Mã nhân sự";

            dgv_DanhSachNguoiDung2.Columns[0].HeaderCell.Value = "Tên đăng nhập";
            dgv_DanhSachNguoiDung2.Columns[1].HeaderCell.Value = "Mật khẩu";
            dgv_DanhSachNguoiDung2.Columns[2].HeaderCell.Value = "Phân quyền";
            dgv_DanhSachNguoiDung2.Columns[3].HeaderCell.Value = "Mã nhân sự";



        }

        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txt_tk_Sua.Texts;
                string matKhau = txt_mk_Sua.Texts;
                string manhansu = txt_manhansu_sua.Texts;
                if (string.IsNullOrEmpty(tenDangNhap))
                {
                    lbl_mksua_Chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                    throw new Exception("Lỗi. Chưa nhập tên đăng nhập!");
                }
                else if (!dstk.KiemTraTenDangNhap(tenDangNhap))
                {
                    lbl_mksua_Chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                    throw new Exception("Lỗi. Tên đăng nhập không tồn tại!");
                }
                else if (string.IsNullOrEmpty(matKhau))
                {
                    lbl_tksua_chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                    throw new Exception("Lỗi. Chưa nhập mật khẩu!");
                }
                else if (string.IsNullOrEmpty(manhansu))
                {
                    lbl_mksua_Chk.Text = "";
                    lbl_tksua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                  
                    throw new Exception("Lỗi. Bạn chưa nhập Mã nhân sự");
                }
                else if (!dstk.KiemTraMaNhanSu(manhansu))
                {
                    lbl_tksua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                    lbl_mksua_Chk.Text = "";
                    throw new Exception("Lỗi. Mã nhân sự không hợp lệ!");
                }
                if (cbo_phanquyen_sua.SelectedItem == null)
                {
                    lbl_mksua_Chk.Text = "";
                    lbl_tksua_chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    throw new Exception("Lỗi. Bạn chưa chọn Phân quyền");
                }
                else
                {
                    lbl_mksua_Chk.Text = "";
                    lbl_tksua_chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    string phanQuyen = cbo_phanquyen_sua.SelectedItem.ToString();
                    bool ktpq = dstk.KiemTraPhanQuyen(manhansu, phanQuyen);
                    if (!ktpq)
                    {
                        throw new Exception("Lỗi. Phân quyền không hợp lệ. Thử kiểm tra lại ở phần nhân viên");
                    }
                    else
                    {

                        lbl_mksua_Chk.Text = "";
                        lbl_tksua_chk.Text = "";
                        lbl_mnssua_chk.Text = "";
                        lbl_pqsua_chk.Text = "";
                        dstk.SuaTaiKhoan(tenDangNhap, matKhau, phanQuyen, manhansu);
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
                    lbl_tksua_chk.Visible = true;
                    lbl_tksua_chk.ForeColor = Color.Red;
                    lbl_tksua_chk.Text = ex.Message;
                }

                else if (ex.Message==("Lỗi. Chưa nhập mật khẩu!"))
                {
                    lbl_mksua_Chk.Visible = true;
                    lbl_mksua_Chk.ForeColor = Color.Red;
                    lbl_mksua_Chk.Text = ex.Message;
                }
                else if (ex.Message.Contains("Phân quyền"))
                {
                    lbl_pqsua_chk.Visible = true;
                    lbl_pqsua_chk.ForeColor = Color.Red;
                    lbl_pqsua_chk.Text = ex.Message;
                }
                else if (ex.Message.Contains("Mã nhân sự"))
                {
                    lbl_mnssua_chk.Visible = true;
                    lbl_mnssua_chk.ForeColor = Color.Red;
                    lbl_mnssua_chk.Text = ex.Message;
                }

            }
        }



        private void btn_Xoa_Click_1(object sender, EventArgs e)
        {

            string tenDangNhap = txt_tk_Sua.Texts;

            dstk.XoaTaiKhoan(tenDangNhap);

            dstk.LoadDsTk(dgv_DanhSachNguoiDung);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung1);
            dstk.LoadDsTk(dgv_DanhSachNguoiDung2);
        }

        private void tabPage_ThemNguoiDung_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_NguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_tdnthem_chk_Click(object sender, EventArgs e)
        {

        }

        private void lbl_mkthem_chk_Click(object sender, EventArgs e)
        {

        }

        private void lbl_mnsthem_chk_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pqthem_chk_Click(object sender, EventArgs e)
        {

        }

        private void txt_TimKiem__TextChanged(object sender, EventArgs e)
        {
            string timKiem = txt_TimKiem.Texts;

            var ketqua = dstk.TimTaiKhoan(timKiem);

            dgv_DanhSachNguoiDung1.DataSource = ketqua;
        }

        private void lbl_pqsua_chk_Click(object sender, EventArgs e)
        {

        }

        private void lbl_PhanQuyen_Sua_Click(object sender, EventArgs e)
        {

        }
    }
}
