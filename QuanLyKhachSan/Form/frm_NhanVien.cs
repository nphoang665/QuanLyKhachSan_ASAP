using QuanLyKhachSan.BUS;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace QuanLyKhachSan
{
    public partial class frm_NhanVien : Form
    {
        BUS_NhanSu bus;

        public frm_NhanVien()
        {
            InitializeComponent();
            bus = new BUS_NhanSu();

        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            bus.LoadDsNv(dgv_nhansu);
            bus.LoadDsNv(dgv2_NhanSu);
            bus.LoadDsNv(dgv1_NhanSu);
            
        }
        public bool batloi(string mans, string tennv, string diachi, string sdt, string chucvu, string gioitinh, string cccd)
        {
            try
            {
                if (string.IsNullOrEmpty(mans))
                    throw new Exception("Chưa nhập mã nhân sự");
                if (string.IsNullOrEmpty(tennv))
                    throw new Exception("Chưa nhập tên nhân viên");
                if (string.IsNullOrEmpty(diachi))
                    throw new Exception("Chưa nhập địa chỉ");
                if (string.IsNullOrEmpty(sdt))
                    throw new Exception("Chưa nhập số điện thoại");
                if (string.IsNullOrEmpty(chucvu))
                    throw new Exception("Chưa nhập chức vụ");
                if (string.IsNullOrEmpty(gioitinh))
                    throw new Exception("Chưa nhập giới tính");
                if (string.IsNullOrEmpty(cccd))
                    throw new Exception("Chưa nhập căn cước công dân");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string gioitinh;
                if (rda_Nam.Checked)
                {
                    gioitinh = "Nam";
                }
                else if (rda_Nu.Checked)
                {
                    gioitinh = "Nữ";
                }
                else
                {
                    gioitinh = null;
                }
                bool isValid = batloi(txt_manv_them.Text, txt_TenNhanVien.Text, txt_DiaChi.Text, txt_SoDienThoai.Text, txt_chucvu1.Text, gioitinh, txt_cccd.Text);
                if (!isValid)
                    return;
                bool khoaching = bus.KiemTraKhoa(txt_manv_them.Text);
                if (!khoaching)
                    return;
                bool leSdt = bus.dodaisdt(txt_SoDienThoai.Text);
                if (!leSdt) return;
                bool lecccd = bus.dodaiccd(txt_cccd.Text);
                if (!lecccd) return;
                bool ktsdt = bus.KiemTraSDT(txt_SoDienThoai.Text); 
                if (!ktsdt)
                    return;
                bool ktcccd = bus.KiemTraCCCD(txt_cccd.Text);
                if (!ktcccd)
                    return;
                bus.ThemNhanSu(txt_manv_them.Text, txt_TenNhanVien.Text, gioitinh, txt_DiaChi.Text, txt_SoDienThoai.Text, dtp_NgaySinh.Value.Date, dtp_NgayVaoLam.Value.Date, txt_chucvu1.Text, pic_anhnhanvien, txt_cccd.Text);

                bus.LoadDsNv(dgv_nhansu);
                bus.LoadDsNv(dgv1_NhanSu);
                bus.LoadDsNv(dgv2_NhanSu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã thêm thông tin nhân viên " + txt_TenNhanVien.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string gioitinh;
            if (rda_Nam.Checked)
            {
                gioitinh = "Nam";
            }
            else
            {
                gioitinh = "Nữ";
            }
            bool isValid = batloi(txt_manv_sua.Text, txt_TenNhanVien2.Text, txt_DiaChi2.Text, txt_SoDienThoai2.Text, txt_chucvu2.Text, gioitinh, txt_cccd_sua.Text);
            if (!isValid)
                return;
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sủa nhân sự này không?", "Sửa", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)

                    bus.SuaNhanSu(txt_manv_sua.Text, txt_TenNhanVien2.Text, gioitinh, txt_DiaChi2.Text, txt_SoDienThoai2.Text, dtp_NgaySinh2.Value.Date, dtp_NgayVaoLam2.Value.Date, txt_chucvu2.Text, pic_anh, txt_cccd_sua.Text);
                
            }
            catch (Exception ex)
            {
                File.AppendAllText("error.log", ex.ToString() + Environment.NewLine);
                return;
            }
            MessageBox.Show("Đã sửa thông tin nhân viên " + txt_TenNhanVien2.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_manv_sua.Enabled = true;
            bus.LoadDsNv(dgv_nhansu);
            bus.LoadDsNv(dgv1_NhanSu);
            bus.LoadDsNv(dgv2_NhanSu);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân sự này không?", "Xoát", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                    bus.XoaNhanSu(txt_manv_sua.Text);
                bus.LoadDsNv(dgv_nhansu);
                bus.LoadDsNv(dgv2_NhanSu);
                bus.LoadDsNv(dgv1_NhanSu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã xóa thông tin nhân viên " + txt_TenNhanVien2.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_manv_sua.Enabled = true;

        }

        private void txt_timten_TextChanged(object sender, EventArgs e)
        {
            bus.TimNhanSuTheoTen(txt_timten.Text, dgv1_NhanSu);

        }

        private void dgv2_NhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manv_sua.Enabled = false;
            try
            {
                txt_manv_sua.Text = dgv2_NhanSu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_TenNhanVien2.Text = dgv2_NhanSu.Rows[e.RowIndex].Cells[1].Value.ToString();
                string gioitinh = dgv2_NhanSu.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_chucvu2.Text = dgv2_NhanSu.Rows[e.RowIndex].Cells[3].Value.ToString();
                string ngaysinh2 = dgv2_NhanSu.Rows[e.RowIndex].Cells[4].Value.ToString();
                string ngayvaolam2 = dgv2_NhanSu.Rows[e.RowIndex].Cells[5].Value.ToString();
                dtp_NgaySinh2.Value = DateTime.Parse(ngaysinh2);
                dtp_NgayVaoLam2.Value = DateTime.Parse(ngayvaolam2);
                txt_DiaChi2.Text = dgv2_NhanSu.Rows[e.RowIndex].Cells[6].Value.ToString();
                txt_SoDienThoai2.Text = dgv2_NhanSu.Rows[e.RowIndex].Cells[7].Value.ToString();
                if (gioitinh == "Nam")
                {
                    rda_Nam2.Checked = true;
                }
                else
                {
                    rda_Nu2.Checked = true;
                }
                bus.layanhNV(txt_manv_sua.Text, pic_anh);
                txt_cccd_sua.Text = dgv2_NhanSu.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tabPage_TimNhanVien_Click(object sender, EventArgs e)
        {
            bus.TimNhanSuTheoChucVu(txt_timchuvu.Text, dgv1_NhanSu);
            if (txt_timchuvu.Text == null)
            {
                bus.LoadDsNv(dgv2_NhanSu);
            }
        }

        private void rdb_namtim_CheckedChanged(object sender, EventArgs e)
        {
            bus.TimNhanSuTheoGioiTinh("Nam", dgv1_NhanSu);

        }

        private void txt_sdt_tim_TextChanged(object sender, EventArgs e)
        {
            bus.TimNhanSuTheosdt(txt_sdt_tim.Text, dgv1_NhanSu);
            if (txt_sdt_tim.Text == null)
            {
                bus.LoadDsNv(dgv2_NhanSu);
            }
        }

        private void rdb_nutim_CheckedChanged(object sender, EventArgs e)
        {
            bus.TimNhanSuTheoGioiTinh("Nữ", dgv1_NhanSu);

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            bus.LoadDsNv(dgv1_NhanSu);

        }

        private void txt_timten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_timchuvu_TextChanged(object sender, EventArgs e)
        {
            bus.TimNhanSuTheoChucVu(txt_chucvu2.Text, dgv2_NhanSu);
            if (txt_chucvu2.Text == null)
            {
                bus.LoadDsNv(dgv2_NhanSu);
            }
        }

        private void txt_timchuvu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_chucvu2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_TenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_chucvu1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_SoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_sdt_tim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_SoDienThoai2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_mo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic_anhnhanvien.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btn_mo_sua_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic_anh.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_reportNhanVien frm = new frm_reportNhanVien();
            frm.ShowDialog();
        }

        private void lb_manv_them_Click(object sender, EventArgs e)
        {

        }

        private void txt_cccd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_cccd_sua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
