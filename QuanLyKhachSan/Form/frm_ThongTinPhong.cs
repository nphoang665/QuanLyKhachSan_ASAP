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
        public frm_ThongTinPhong(string maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_TraPhong quanLyTraPhong = new frm_TraPhong();
            frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ThongTinPhong_Load(object sender, EventArgs e)
        {
            lbl_Phong.Text = maPhong;
        }
    }
}
