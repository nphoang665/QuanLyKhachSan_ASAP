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
            //cbo_MaDatPhong.DataSource= bus.laydata();
        }

        private void tabPage_HoaDon_Click(object sender, EventArgs e)
        {

        }

        public void hienthi()
        {
            bus.loadHD(dgv_DanhSachHoaDon);
        }
        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            hienthi();
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            //var data =bus.checkkhoa(cbo_MaDatPhong.Text);
            //if (!data)
            //{
            //    MessageBox.Show("Đã tồn tại mã phòng");
            //    return;
            //}
            //bus.themHoaDon(cbo_MaDatPhong.Text, txt_mahoadon.Text, cbo_MaNhanVien.Text, cbo_MaKhachHang.Text, dtp_NgayThue.Value, int.Parse(lbl_KQSoNgay.Text), int.Parse(lbl_KQTongTien.Text), dtp_NgayLap.Value);
            //hienthi();
        }

        private void dgv_DanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_kqmahd.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
            lbl_kqmathanhtoan.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
            lbl_kqmakhachhang.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
            lbl_kqngaythue.Text= dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[3].Value.ToString();
            lbl_KQSoNgay.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[4].Value.ToString();
            lbl_KQTongTien.Text = dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[5].Value.ToString();
            lbl_KQngaytra.Text= dgv_DanhSachHoaDon.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
