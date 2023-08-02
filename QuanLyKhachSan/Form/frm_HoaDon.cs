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
    public partial class frm_HoaDon : Form
    {
        BUS_HoaDon bus;
        public frm_HoaDon()
        {
            InitializeComponent();
            bus = new BUS_HoaDon();
        }

        private void tabPage_HoaDon_Click(object sender, EventArgs e)
        {

        }

        public void hienthi()
        {
            bus.load(dgv_DanhSachHoaDon);
        }
        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            hienthi();
        }
    }
}
