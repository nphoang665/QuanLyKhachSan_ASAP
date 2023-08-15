using QuanLyKhachSan.BUS;
using QuanLyKhachSan.BUS;
using System;
using System.Data;
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
                string tdn = dgv_DanhSachNguoiDung2.Rows[e.RowIndex].Cells["TenDangNhap"].Value.ToString();
                string mk = dgv_DanhSachNguoiDung2.Rows[e.RowIndex].Cells["Matkhau"].Value.ToString();
                string mns = dgv_DanhSachNguoiDung2.Rows[e.RowIndex].Cells["Manhansu"].Value.ToString();
                string pq = dgv_DanhSachNguoiDung2.Rows[e.RowIndex].Cells["Phanquyen"].Value.ToString();
                txt_tk_Sua.Texts = tdn;
                txt_mk_Sua.Texts = mk;
                cbo_phanquyen_sua.SelectedItem = pq;
                txt_manhansu_sua.Texts = mns;
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txt_TenDangNhap.Texts;
                string matKhau = txt_MatKhau.Texts;
                string manhansu = txt_manhansu_them.Texts;
                if (string.IsNullOrWhiteSpace(tenDangNhap))
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
                else if (tenDangNhap.Length < 5 || tenDangNhap.Length > 20)
                {
                    lbl_mkthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    throw new Exception("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (string.IsNullOrWhiteSpace(matKhau))
                {
                    lbl_tdnthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    throw new Exception("Lỗi. Chưa nhập mật khẩu!");
                }
                else if (matKhau.Length < 5 || matKhau.Length > 20)
                {
                    lbl_tdnthem_chk.Text = "";
                    lbl_pqthem_chk.Text = "";
                    lbl_mnsthem_chk.Text = "";
                    throw new Exception("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (string.IsNullOrWhiteSpace(manhansu))
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
                        loadThongTin();

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
                if (ex.Message == ("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
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
                else if (ex.Message.Contains("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
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
        void loadThongTin()
        {
            var data = dstk.LoadDsTkData();
            dgv_DanhSachNguoiDung.DataSource = data;
            dgv_DanhSachNguoiDung1.DataSource = data;
            dgv_DanhSachNguoiDung2.DataSource = data;

            cbo_phanquen_them.Items.Clear();
            cbo_phanquyen_sua.Items.Clear();

            cbo_phanquen_them.Items.Add("Nhân viên");
            cbo_phanquen_them.Items.Add("Quản lý");
            cbo_phanquyen_sua.Items.Add("Nhân viên");
            cbo_phanquyen_sua.Items.Add("Quản lý");

            dgv_DanhSachNguoiDung.Columns[0].HeaderCell.Value = "Tên đăng nhập";
            dgv_DanhSachNguoiDung.Columns[1].HeaderCell.Value = "Mật khẩu";
            dgv_DanhSachNguoiDung.Columns[3].HeaderCell.Value = "Phân quyền";
            dgv_DanhSachNguoiDung.Columns[2].HeaderCell.Value = "Mã nhân sự";
            dgv_DanhSachNguoiDung1.Columns[0].HeaderCell.Value = "Tên đăng nhập";
            dgv_DanhSachNguoiDung1.Columns[1].HeaderCell.Value = "Mật khẩu";
            dgv_DanhSachNguoiDung1.Columns[3].HeaderCell.Value = "Phân quyền";
            dgv_DanhSachNguoiDung1.Columns[2].HeaderCell.Value = "Mã nhân sự";
            dgv_DanhSachNguoiDung2.Columns[0].HeaderCell.Value = "Tên đăng nhập";
            dgv_DanhSachNguoiDung2.Columns[1].HeaderCell.Value = "Mật khẩu";
            dgv_DanhSachNguoiDung2.Columns[2].HeaderCell.Value = "Mã nhân sự";
            dgv_DanhSachNguoiDung2.Columns[3].HeaderCell.Value = "Phân quyền";
            dgv_DanhSachNguoiDung2.Columns["TenDangNhap"].ReadOnly = true;
            dgv_DanhSachNguoiDung2.Columns["Phanquyen"].ReadOnly = true;
        }

        private void frm_NguoiDung_Load(object sender, EventArgs e)
        {

            loadThongTin();

        }


        private void btn_Sua_Click_1(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txt_tk_Sua.Texts;
                string matKhau = txt_mk_Sua.Texts;
                string manhansu = txt_manhansu_sua.Texts;
                if (string.IsNullOrWhiteSpace(tenDangNhap))
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
                else if (tenDangNhap.Length < 5 || tenDangNhap.Length > 20)
                {
                    lbl_mksua_Chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                    throw new Exception("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (string.IsNullOrWhiteSpace(matKhau))
                {
                    lbl_tksua_chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                    throw new Exception("Lỗi. Chưa nhập mật khẩu!");
                }
                else if (matKhau.Length < 5 || matKhau.Length > 20)
                {
                    lbl_tksua_chk.Text = "";
                    lbl_mnssua_chk.Text = "";
                    lbl_pqsua_chk.Text = "";
                    throw new Exception("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự");
                }
                else if (string.IsNullOrWhiteSpace(manhansu))
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
                        DialogResult dialogResult = MessageBox.Show("Bạn hãy xác nhận chắc chắn bạn muốn sửa hay không?",
                                                          "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            lbl_mksua_Chk.Text = "";
                            lbl_tksua_chk.Text = "";
                            lbl_mnssua_chk.Text = "";
                            lbl_pqsua_chk.Text = "";
                            dstk.SuaTaiKhoan(tenDangNhap, matKhau, phanQuyen, manhansu);
                            loadThongTin();

                        }
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
                if (ex.Message == ("Tên đăng nhập không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_tksua_chk.Visible = true;
                    lbl_tksua_chk.ForeColor = Color.Red;
                    lbl_tksua_chk.Text = ex.Message;
                }
                else if (ex.Message == ("Mật khẩu không được nhỏ hơn 5 và lớn hơn 20 kí tự"))
                {
                    lbl_mksua_Chk.Visible = true;
                    lbl_mksua_Chk.ForeColor = Color.Red;
                    lbl_mksua_Chk.Text = ex.Message;
                }
                else if (ex.Message == ("Lỗi. Chưa nhập mật khẩu!"))
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
            DialogResult dialogResult = MessageBox.Show("Bạn hãy xác nhận chắc chắn bạn muốn xóa hay không?",
                                                        "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string tenDangNhap = txt_tk_Sua.Texts;

                dstk.XoaTaiKhoan(tenDangNhap);
                loadThongTin();

            }
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

        private void tabPage_CapNhat_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void dgv_DanhSachNguoiDung2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_DanhSachNguoiDung.Columns["MaNhanSu"].Index)
            {
                string maNhanSu = dgv_DanhSachNguoiDung.Rows[e.RowIndex].Cells["MaNhanSu"].Value.ToString();

                BUS_QuanLyTaiKhoan bus = new BUS_QuanLyTaiKhoan();


                if (bus.KiemTraMaNhanSu(maNhanSu))
                {
                    string phanQuyen = bus.LayPhanQuyen(maNhanSu);

                    dgv_DanhSachNguoiDung.Rows[e.RowIndex].Cells["PhanQuyen"].Value = phanQuyen;
                }
              
                         }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                var dataTable = new DataTable();
                dataTable.Columns.Add("TenDangNhap");
                dataTable.Columns.Add("MatKhau");
                dataTable.Columns.Add("MaNhanSu");
                dataTable.Columns.Add("PhanQuyen");

                foreach (DataGridViewRow row in dgv_DanhSachNguoiDung2.Rows)
                {
                    var dataRow = dataTable.NewRow();
                    dataRow["TenDangNhap"] = row.Cells[0].Value.ToString();
                    dataRow["MatKhau"] = row.Cells[1].Value.ToString();
                    dataRow["MaNhanSu"] = row.Cells[2].Value.ToString();
                    dataRow["PhanQuyen"] = row.Cells[3].Value.ToString();

                    dataTable.Rows.Add(dataRow);
                }

                var bus = new BUS_QuanLyTaiKhoan();

                bus.CapNhatDsTk(dataTable);
                loadThongTin();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ThemTuBang_Click(object sender, EventArgs e)
        {

            XoaHangTrong();
            dstk.SaveData(dgv_DanhSachNguoiDung);
            //loadThongTin();
        }
        private void XoaHangTrong()
        {
            for (int i = 0; i < dgv_DanhSachNguoiDung.Rows.Count - 1; i++)
            {
                if (dgv_DanhSachNguoiDung.Rows[i].Cells[0].Value.ToString() == "")
                {
                    dgv_DanhSachNguoiDung.Rows.RemoveAt(i);
                    i--;
                }
            }
        }
        private void dgv_DanhSachNguoiDung_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
         
        }
        private void btn_InDuLieu_Click(object sender, EventArgs e)
        {
            frm_ReportQuanLyTaiKhoan frm = new frm_ReportQuanLyTaiKhoan();
            frm.ShowDialog();
        }

        private void dgv_DanhSachNguoiDung_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
         
        }

        private void dgv_DanhSachNguoiDung_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        
        }
    }
}
