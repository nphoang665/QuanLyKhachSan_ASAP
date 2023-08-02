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
        public frm_ThongTinPhong()
        {
            InitializeComponent();
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
    }
}
