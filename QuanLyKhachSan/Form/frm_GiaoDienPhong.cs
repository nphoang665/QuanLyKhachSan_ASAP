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
    public partial class frm_GiaoDienPhong : Form
    {
        public frm_GiaoDienPhong()
        {
            InitializeComponent();
        }

        private void pic_101_Click(object sender, EventArgs e)
        {
            frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong();
            frm_ThongTinPhong.ShowDialog();
        }
    }
}
