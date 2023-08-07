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
    public partial class frm_DangKyTaiKhoan : Form
    {
        BUS_DangKy bus;
        string phanQuyen;
        string Manhansu;
        public frm_DangKyTaiKhoan()
        {
            InitializeComponent();
            bus= new BUS_DangKy();
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
         
            var tt = bus.KiemTraTTNS(txt_cccd.Text);
            if(tt!= null)
            {
                string tk = txt_TenDangNhap.Text;
                string mk = txt_MatKhau.Text;
                //put code add account here
                phanQuyen = tt.ChucVu;
                Manhansu = tt.MaNhanSu;

                bus.ThemTK(tk, mk, phanQuyen, Manhansu);
                MessageBox.Show("Đăng ký thành công");

            }
            else {
                MessageBox.Show("Không có nhân sự nào có cccd như bạn vừa nhập");
             
                }
        }
    }
}
