using QuanLyKhachSan.DA;
using System;
using System.Drawing;
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
        public void ThemNhanSu(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu,PictureBox pi,string cccd)
        {
            da_NhanSu.ThemNhanSu(mans, tenvn, gioitinh, diachi, sdt, ngaysinh, ngayvaolam, chucvu,pi,cccd);
        }
        public void SuaNhanSu(string mans, string tenvn, string gioitinh, string diachi, string sdt, DateTime ngaysinh, DateTime ngayvaolam, string chucvu, PictureBox pic, string cccd)
        {
            da_NhanSu.SuaNhanSu(mans, tenvn, gioitinh, diachi, sdt, ngaysinh, ngayvaolam, chucvu, pic, cccd);
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
        public bool KiemTraKhoa(string manhansu)
        {
            return da_NhanSu.KiemTraKhoa(manhansu);
        }
        public bool KiemTraSDT(string sdt)
        {
            return da_NhanSu.checksdt(sdt);
        }
        public bool KiemTraCCCD(string cccd)
        {
            return da_NhanSu.checkcccd(cccd);
        }
        public bool dodaiccd(string cccd)
        {
            return da_NhanSu.dodaicccd(cccd);
        }
        public bool dodaisdt(string sdt)
        {
            return da_NhanSu.checkcccd(sdt);
        }
    }
}
