using QuanLyKhachSan.DA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BUS
{
    public  class BUS_Phong
    {
        DA_Phong DA_;
        public BUS_Phong()
        {
            DA_ = new DA_Phong();
        }
        public void LoadDsTk(DataGridView dgv)
        {
            dgv.DataSource = DA_.LayPhong();
        }

        public void ThemPhong(string maPhong, string loaiPhong, string tinhTrang, float donGia)
        {
            if (KiemTraMaPhongTonTai(maPhong))
            {
                MessageBox.Show("Mã phòng đã tồn tại trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DA_.ThemPhong(maPhong, loaiPhong, tinhTrang, donGia);
        }
        public void SuaPhong(string maPhong, string loaiPhong, string tinhTrang, float donGia)
        {
            DA_.SuaPhong(maPhong, loaiPhong, tinhTrang, donGia);
        }

        public void XoaPhong(string maPhong)
        {
            if (KiemTraPhongDaCoKhachThue(maPhong))
            {
                MessageBox.Show("Phòng đang có khách thuê. Bạn không thể xóa phòng này.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DA_.XoaPhong(maPhong);
        }
        public Phong LayPhong(string id)
        {
            return DA_.LayPhong(id);
        }
        public IList timPhongBangMaPhong(string timkiem) {
            return DA_.TimPhongBangMaPhong(timkiem);
        }
        public IList timphongbangmatinhtrang (string tinhtrang)
        {
            return DA_.TimPhongBangTinhTrang(tinhtrang);
        }
        public IList TimPhongBangLoaiPhong(string LoaiPhong)
        {
            return DA_.TimPhongBangLoaiPhong(LoaiPhong);
        }

        private bool KiemTraMaPhongTonTai(string maPhong)
        {
            
            var phong = DA_.LayPhong(maPhong);
            return phong != null; // Nếu phòng tồn tại, trả về true; ngược lại trả về false.
        }

        public bool KiemTraPhongDaCoKhachThue(string maPhong)
        {
            return DA_.KiemTraPhongDaCoKhachThue(maPhong);
        }
        public void CapNhatTrangThaiPhong(string maPhong, string tinhTrang)
        {
            // Gọi phương thức CapNhatTrangThaiPhong trong DA_Phong để cập nhật trạng thái phòng
            DA_.CapNhatTrangThaiPhong(maPhong, tinhTrang);
        }
    }
}
