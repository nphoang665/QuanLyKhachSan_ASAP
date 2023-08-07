using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DA;

namespace QuanLyKhachSan.BUS
{
    public class BUS_QuanLyTaiKhoan
    {
        DA_QuanLyTaiKhoan DA_;
        public BUS_QuanLyTaiKhoan()
        {
            DA_ = new DA_QuanLyTaiKhoan();
        }
        public void LoadDsTk(DataGridView dgv)
        {
            dgv.DataSource = DA_.LayDsTk();
        }
        public void ThemTaiKhoan( string tenDangNhap, string matKhau, string phanQuyen,string maNhanSu)
        {
            DA_.ThemTaiKhoan(tenDangNhap, matKhau, phanQuyen, maNhanSu);
        }

        public void SuaTaiKhoan( string tenDangNhap, string matKhau, string phanQuyen, string maNhanSu)
        {
            DA_.SuaTaiKhoan( tenDangNhap, matKhau, phanQuyen, maNhanSu);
        }

        public void XoaTaiKhoan(string id)
        {
            DA_.XoaTaiKhoan(id);
        }

        public IList TimTaiKhoan(string timKiem)
        {
            return DA_.TimTaiKhoan(timKiem);
        }

        public TaiKhoan LayTaiKhoan(string id)
        {
            return DA_.LayTaiKhoan(id);
        }
        public bool KiemTraPhanQuyen(string MaNhanSu,string PhanQuyen)
        {
            return DA_.KiemTraPhanQuyen(MaNhanSu, PhanQuyen);
        }
        public bool KiemTraTenDangNhap(string tenDangNhap)
        {
            return DA_.KiemTraTenDangNhap(tenDangNhap);
        }

        public bool KiemTraMaNhanSu(string maNhanSu)
        {
            return DA_.KiemTraMaNhanSu(maNhanSu);
        }

    }
}
