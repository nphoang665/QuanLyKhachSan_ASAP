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

        public void ThemPhong(string maPhong,string maDichVu, string loaiPhong, string tinhTrang, float donGia)
        {
            DA_.ThemPhong(maPhong,maDichVu, loaiPhong, tinhTrang, donGia);
        }
        public void SuaPhong(string maPhong, string maDichVu, string loaiPhong, string tinhTrang, float donGia)
        {
            DA_.SuaPhong(maPhong, maDichVu, loaiPhong, tinhTrang, donGia);
        }

        public void XoaPhong(string maPhong)
        {
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
    }
}
