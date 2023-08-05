using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DA;

namespace QuanLyKhachSan.BUS
{
    public class BUS_DangNhap
    {
        DA_DangNhap da_dangnhap;
        public BUS_DangNhap()
        {
            da_dangnhap = new DA_DangNhap();
        }
        public bool DangNhapTaiKhoan(string tk, string mk)
        {
            bool kq = da_dangnhap.DangNhap(tk, mk);
           
            return kq;
        }

        public void SaveLoginInfo(string username, string password)
        {
            da_dangnhap.SaveLoginInfo(username, password);
        }
        public LuuMatKhau GetSavedLoginInfo()
        {
            return da_dangnhap.GetSavedLoginInfo();
        }
        public void UpdateSavedLoginInfo(string username, string password)
        {
            da_dangnhap.UpdateSavedLoginInfo(username, password);
        }
        public void DeleteSavedLoginInfo()
        {
            da_dangnhap.DeleteSavedLoginInfo();
        }


    }
}
