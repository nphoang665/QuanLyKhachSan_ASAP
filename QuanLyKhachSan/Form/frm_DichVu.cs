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
    public partial class frm_DichVu : Form
    {
        BUS_DichVu bus;
        public frm_DichVu()
        {
            InitializeComponent();
            bus= new BUS_DichVu();
        }

        private void frm_DichVu_Load(object sender, EventArgs e)
        {
            bus.LoadDichVu(dgv_DanhSachDichVu);
            bus.LoadDichVu(dgv_DanhSachDichVu1);

            bus.LoadDichVu(dgv_DanhSachDichVu2);

        }
    }
}
