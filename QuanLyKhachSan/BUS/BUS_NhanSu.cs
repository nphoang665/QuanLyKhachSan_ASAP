using QuanLyKhachSan.DA;
using System;
using System.Windows.Forms;

namespace QuanLyKhachSan.BUS
{
    public class BUS_NhanSu
    {
        DA_NhanSu da_NhanSu;
        public BUS_NhanSu()
        {
            da_NhanSu = new DA_NhanSu();
        }
        public void LoadDsNv(DataGridView dgv)
        {
            da_NhanSu.LayNhanVien(dgv);
        }
        public void ThemNhanSu(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu,PictureBox pi)
        {
            da_NhanSu.ThemNhanSu(mans, tenvn, gioitinh, diachi, sdt, ngaysinh, ngayvaolam, chucvu,pi);
        }
        public void SuaNhanSu(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu)
        {
            da_NhanSu.SuaNhanSu(mans, tenvn, gioitinh, diachi, sdt, ngaysinh, ngayvaolam, chucvu);
        }
        public void XoaNhanSu(string mans)
        {
            da_NhanSu.XoaNhanSu(mans);
        }
        public void TimNhanSuTheoTen(string hoten, DataGridView dtgv)
        {
            da_NhanSu.TimTheoTenNhanSu(hoten, dtgv);
        }
        public void TimNhanSuTheoChucVu(string chucvu, DataGridView dtgv)
        {
            da_NhanSu.TimTheoChucVuNhanSu(chucvu, dtgv);
        }
        public void TimNhanSuTheoGioiTinh(string gioitinh, DataGridView dtgv)
        {
            da_NhanSu.TimTheoGioiTinhNhanSu(gioitinh, dtgv);
        }
        public void TimNhanSuTheosdt(string sdt, DataGridView dtgv)
        {
            da_NhanSu.TimTheosdtNhanSu(sdt, dtgv);
        }
        public void layanhNV(string manv, PictureBox pic)
        {
            da_NhanSu.layanhNV(manv, pic);
        }
    }
}
