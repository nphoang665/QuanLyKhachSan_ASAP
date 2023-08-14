using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BUS
{
    internal class BUS_KhachHang
    {
        DA_KhachHang da;
        public BUS_KhachHang()
        {
            da = new DA_KhachHang();
        }
        public void LoadDsKh(DataGridView dgv)
        {
            da.LayKhachHang(dgv);
        }
        public void ThemKH(string makh, string tenkh, string gioitinh, DateTime ngaysinh, string diachi, string sdt, string ccccd)
        {
            da.ThemKH(makh, tenkh, gioitinh, ngaysinh,diachi, sdt, ccccd);
        }
        public void SuaKH(string makh, string tenkh, string gioitinh, DateTime ngaysinh, string diachi, string sdt, string ccccd)
        {
            da.SuaKH(makh, tenkh, gioitinh, ngaysinh, diachi, sdt, ccccd);
        }
        public void XoaKH(string makh)
        {
            da.Xoakh(makh);
        }
        public void TimKHTheoTen(string hoten, DataGridView dtgv)
        {
            da.TimTheoTenKh(hoten, dtgv);
        }
        public void TimKHTheoGioiTinh(string gioitinh, DataGridView dtgv)
        {
            da.TimTheoGioiTinhKH(gioitinh, dtgv);
        }
        public void TimTheocccdKH(string cccd, DataGridView dtgv)
        {
            da.TimTheocccdKH(cccd, dtgv);
        }
        public List<string> laykhachhang()
        {
            return da.laytenkh();
        }
        //public bool khachthue(string mkh)
        //{
        //  return  da.khdatphong(mkh);
        //}
        public bool ktkhoa(string makh)
        {
            return da.checkkhoa(makh);
        }
        public bool ktsdt(string sdt)
        {
            return da.checksdt(sdt);
        }
        public bool ktcccd(string cccd)
        {
            return da.checkcccd(cccd);
        }
        public bool dodaiccd(string cccd)
        {
            return da.dodaicccd(cccd);
        }
        public bool dodaisdt(string sdt)
        {
            return da.checkcccd(sdt);
        }
    }
}
