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
    public partial class frm_ThongTinPhong : Form
    {
        string maPhong;
        BUS_ThongTinPhong bus;
        public frm_ThongTinPhong(string maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            bus= new BUS_ThongTinPhong();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_TraPhong quanLyTraPhong = new frm_TraPhong(maPhong);
            frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ThongTinPhong_Load(object sender, EventArgs e)
        {
            dtp_NgayThue.Enabled=false;
            lbl_Phong.Text = maPhong;
           var tt= bus.LoadThongTinPhong(maPhong);
            
            dtp_NgayThue.Value =(DateTime)tt.NgayDat;
            var thongtinkhachhang= bus.loadthongtinkhachhang(tt.MaKhachHang);
            lbl_KQTenKhachHang.Text = thongtinkhachhang.TenKhachHang;
            lbl_KQCMND.Text = thongtinkhachhang.CMND;
            lbl_KQDiaChi.Text = thongtinkhachhang.DiaChi;
        }
    }
}
