using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BUS
{
    public class BUS_XacThucTaiKhoan
    {
        DA_XacThucTaiKhoan da;
        public BUS_XacThucTaiKhoan()
        {
            da= new DA_XacThucTaiKhoan();
        }
        public void LayTaiKhoanChuaXuLy(DataGridView dgv)
        {
            dgv.DataSource = da.LayTaiKhoanCoTinhTrangDangXuLy();
        }
        public void LayTaiKhoanThanhCong(DataGridView dgv)
        {
            dgv.DataSource = da.LayTaiKhoanCoTinhTrangThanhCong();
        }
        public void CapNhatTinhTrangTaiKhoan(string tenDangNhap, string tinhTrang)
        {
            da.CapNhatTinhTrangTaiKhoan(tenDangNhap, tinhTrang);
        }
        public void CapNhatTinhTrangVaLyDoTaiKhoan(string tenDangNhap, string tinhTrang, string lyDo)
        {
            da.CapNhatTinhTrangVaLyDoTaiKhoan(tenDangNhap, tinhTrang, lyDo);
        }
    }
}
