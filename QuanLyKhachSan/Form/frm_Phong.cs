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
    public partial class frm_Phong : Form
    {
        BUS_Phong dsp;

        public frm_Phong()
        {
            InitializeComponent();
            dsp = new BUS_Phong();

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_KQPhong.Text;
            string loaiPhong = txt_loaiphong_sua.Text;
            string tinhTrang = lbl_KQTinhTrang.Text;
            float donGia = float.Parse(txt_dongia_sua.Text);

            BUS_Phong busPhong = new BUS_Phong();
            busPhong.SuaPhong(maPhong, loaiPhong, tinhTrang, donGia);

            MessageBox.Show("Sửa thông tin phòng " + maPhong + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dsp.LoadDsTk(dgv_phong1);
            dsp.LoadDsTk(dgv_phong2);
            dsp.LoadDsTk(dgv_phong3);

            lbl_KQPhong.Text = string.Empty;
            txt_loaiphong_sua.Text = string.Empty;
            lbl_KQTinhTrang.Text = string.Empty;
            txt_dongia_sua.Text = string.Empty;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_KQPhong.Text;

            BUS_Phong busPhong = new BUS_Phong();
            bool phongDaThue = busPhong.KiemTraPhongDaCoKhachThue(maPhong);

            if (phongDaThue)
            {
                MessageBox.Show("Phòng đang có khách thuê. Bạn không thể xóa phòng này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa phòng " + maPhong + " không?", "Xác nhận xóa phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    busPhong.XoaPhong(maPhong);

                    MessageBox.Show("Xóa phòng " + maPhong + " thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dsp.LoadDsTk(dgv_phong1);
                    dsp.LoadDsTk(dgv_phong2);
                    dsp.LoadDsTk(dgv_phong3);

                    lbl_KQPhong.Text = string.Empty;
                    txt_loaiphong_sua.Text = string.Empty;
                    lbl_KQTinhTrang.Text = string.Empty;
                    txt_dongia_sua.Text = string.Empty;
                }
            }
        }

        private void txt_timphong_TextChanged(object sender, EventArgs e)
        {
            txt_TimLoaiPhong.Text = string.Empty; 
            txt_timtinhtrang.Text = string.Empty;

            string timphong = txt_timphong.Text;
            var kq = dsp.timPhongBangMaPhong(timphong);
            dgv_phong2.DataSource = kq;
        }

        private void txt_timtinhtrang_TextChanged(object sender, EventArgs e)
        {
            txt_timphong.Text = string.Empty;
            txt_TimLoaiPhong.Text = string.Empty;

            string timtinhtrang = txt_timtinhtrang.Text;
            var kq = dsp.timphongbangmatinhtrang(timtinhtrang);
            dgv_phong2.DataSource = kq;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maPhong = txt_maphong_them.Text;
            string loaiPhong = cbo_loaiPhong_them.Text;
            string tinhTrang = cbo_tinhTrang_them.Text;
            float donGia;

            KiemLoi.Clear();

            if (string.IsNullOrWhiteSpace(maPhong) || maPhong.Any(c => !char.IsLetterOrDigit(c)))
            {
                KiemLoi.SetError(txt_maphong_them, "Mã phòng không được để trống và chỉ chấp nhận ký tự chữ và số.");
                return;
            }

            if (!float.TryParse(txt_donGia_Them.Text, out donGia))
            {
                KiemLoi.SetError(txt_donGia_Them, "Đơn giá không được để trống và phải là một số hợp lệ.");
                return;
            }

            dsp.ThemPhong(maPhong, loaiPhong, tinhTrang, donGia);

            dsp.LoadDsTk(dgv_phong1);
            dsp.LoadDsTk(dgv_phong2);
            dsp.LoadDsTk(dgv_phong3);
        }

        private void dgv_phong3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string id = dgv_phong3.Rows[e.RowIndex].Cells["MaPhong"].Value.ToString();
                var taiKhoan = dsp.LayPhong(id);
                lbl_KQPhong.Text = taiKhoan.MaPhong;
                txt_loaiphong_sua.Text = taiKhoan.LoaiPhong;
                lbl_KQTinhTrang.Text = taiKhoan.TinhTrang;
                txt_dongia_sua.Text = taiKhoan.DonGia.ToString();
            }
        }

        private void frm_Phong_Load(object sender, EventArgs e)
        {
            dsp.LoadDsTk(dgv_phong1);
            dsp.LoadDsTk(dgv_phong2);
            dsp.LoadDsTk(dgv_phong3);

            txt_timphong.TextChanged += txt_timphong_TextChanged;
            txt_TimLoaiPhong.TextChanged += txt_TimLoaiPhong_TextChanged;
            txt_timtinhtrang.TextChanged += txt_timtinhtrang_TextChanged;

            cbo_loaiPhong_them.Items.AddRange(new object[] {
                "Phòng đơn",
                "Phòng đôi",
                "Phòng ba"
            });
            cbo_loaiPhong_them.SelectedIndex = 0;
            cbo_loaiPhong_them.DropDownStyle = ComboBoxStyle.DropDownList;

            cbo_tinhTrang_them.Items.Add("Trống");
            if (cbo_tinhTrang_them.Items.Count > 0)
            {
                cbo_tinhTrang_them.SelectedIndex = 0;
            }
            cbo_tinhTrang_them.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txt_TimLoaiPhong_TextChanged(object sender, EventArgs e)
        {
            txt_timphong.Text = string.Empty;
            txt_timtinhtrang.Text = string.Empty;

            string loaiPhong = txt_TimLoaiPhong.Text;
            var kq = dsp.TimPhongBangLoaiPhong(loaiPhong);
            dgv_phong2.DataSource = kq;
        }
    }
}
