﻿using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BUS
{
    public class BUS_ThongTinTaiKhoan
    {
        DA_ThongTinTaiKhoan da;
        public BUS_ThongTinTaiKhoan()
        {
            da= new DA_ThongTinTaiKhoan();
        }
        public TaiKhoan LayttTaiKhoan(string tk)
        {
            return da.layThongTinTaiKhoan(tk);
        }
        public NhanSu LayTTNhanSu(string mans)
        {
            return da.laythongTinNhanSu(mans);
        }
        public void layanhNV(string manv, PictureBox pic)
        {
            da.layanhNV(manv, pic);
        }
        public void LuuAnhNv(string manv, Image pic)
        {
            da.LuuAnhNhanVien(manv, pic);
        }
        public void KhoiPhucAnhNv(string manhansu, PictureBox pic)
        {
            da.layanhNV(manhansu, pic);
        }

    }
}
