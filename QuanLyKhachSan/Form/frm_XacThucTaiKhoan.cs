using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DA;
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
    public partial class frm_XacThucTaiKhoan : Form
    {
        BUS_XacThucTaiKhoan bus;
        public frm_XacThucTaiKhoan()
        {
            InitializeComponent();
            bus= new BUS_XacThucTaiKhoan();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            string lyDo = "";
            string reason = Microsoft.VisualBasic.Interaction.InputBox("Lý do", "Nhập lý do", lyDo);

            string taiKhoan = dgv_tkChuaXacThuc.Rows[viTri].Cells[0].Value.ToString();
            if (taiKhoan != null)
            {
                bus.CapNhatTinhTrangVaLyDoTaiKhoan(taiKhoan, "ThatBai", reason);

                bus.LayTaiKhoanChuaXuLy(dgv_tkChuaXacThuc);
                bus.LayTaiKhoanThanhCong(dgv_TaiKhoanDaDuocXacThuc);
            }

        }

        private void frm_XacThucTaiKhoan_Load(object sender, EventArgs e)
        {
            bus.LayTaiKhoanChuaXuLy(dgv_tkChuaXacThuc);
            bus.LayTaiKhoanThanhCong(dgv_TaiKhoanDaDuocXacThuc);
        }

        private void btn_DongY_Click(object sender, EventArgs e)
        {
          string taiKhoan = dgv_tkChuaXacThuc.Rows[viTri].Cells[0].Value.ToString();
            if (taiKhoan != null)
            {
                bus.CapNhatTinhTrangTaiKhoan(taiKhoan, "ThanhCong");

                bus.LayTaiKhoanChuaXuLy(dgv_tkChuaXacThuc);
                bus.LayTaiKhoanThanhCong(dgv_TaiKhoanDaDuocXacThuc);
            }
        }
        int viTri;
        private void dgv_tkChuaXacThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
