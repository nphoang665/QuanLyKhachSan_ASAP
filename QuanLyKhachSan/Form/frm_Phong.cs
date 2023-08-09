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
            dsp.LoadDsTk(dgv_phong2);
            dsp.LoadDsTk(dgv_phong3);

            txt_timphong.TextChanged += txt_timphong_TextChanged;
            txt_TimLoaiPhong.TextChanged += txt_TimLoaiPhong_TextChanged;
            txt_timtinhtrang.TextChanged += txt_timtinhtrang_TextChanged;

            dgv_phong2.Columns["MaPhong"].HeaderText = "Mã phòng";
            dgv_phong2.Columns["LoaiPhong"].HeaderText = "Loại phòng";
            dgv_phong2.Columns["TinhTrang"].HeaderText = "Tình trạng";
            dgv_phong2.Columns["DonGia"].HeaderText = "Đơn giá";

            dgv_phong3.Columns["MaPhong"].HeaderText = "Mã phòng";
            dgv_phong3.Columns["LoaiPhong"].HeaderText = "Loại phòng";
            dgv_phong3.Columns["TinhTrang"].HeaderText = "Tình trạng";
            dgv_phong3.Columns["DonGia"].HeaderText = "Đơn giá";
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
