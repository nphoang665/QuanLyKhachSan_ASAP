using QuanLyKhachSan.BUS;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_DichVu : Form
    {
        BUS_DichVu bus;
        public frm_DichVu()
        {
            InitializeComponent();
            bus = new BUS_DichVu();
        }
        private void LoadDichVu()
        {
            bus.LoadDichVu(dgv_DanhSachDichVu);
            bus.LoadDichVu(dgv_DanhSachDichVu1);

            bus.LoadDichVu(dgv_DanhSachDichVu2);
            bus.hienthongtincbo_b(cbo: cbo_MaDichVu);
            cbo_MaDichVu.SelectedItem = "";
        }
        private void frm_DichVu_Load(object sender, EventArgs e)
        {

            LoadDichVu();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            string maDichVu = txt_MaDichVu.Text;
            string tenDichVu = txt_TenDichVu.Text;
            float donGia = float.Parse(txt_DonGia.Text);
            string donViTinh = txt_DonViTinh.Text;
            bus.ThemDichVu_b(maDichVu, tenDichVu, donGia, donViTinh);
            LoadDichVu();
        }

        private void cbo_MaDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbo_MaDichVu.SelectedItem != null)
            {
                bus.TimMaDichVu_b(cbo_MaDichVu.SelectedItem.ToString(), dgv_DanhSachDichVu1);
            }
            else
            {
                bus.LoadDichVu(dgv_DanhSachDichVu1);
            }


        }

        private void txt_TenDichVu1_TextChanged(object sender, EventArgs e)
        {
            if (txt_TenDichVu1.Text != "")
            {

                bus.timtendichvu_b(txt_TenDichVu1.Text, dgv_DanhSachDichVu1);
            }
            else
            {
                bus.LoadDichVu(dgv_DanhSachDichVu1);

            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            bus.SuaDichVu_b(txt_Madichvu2.Text,txt_TenDichVu2.Text,float.Parse(txt_DonGia2.Text),txt_DonViTinh2.Text);
            LoadDichVu();


        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bus.XoaDichVu_b(txt_Madichvu2.Text);
            LoadDichVu();
        }

        private void dgv_DanhSachDichVu2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string madv = dgv_DanhSachDichVu2.Rows[e.RowIndex].Cells["MaDichVu"].Value.ToString();
                var dv = bus.xuatdichvu(madv);
                txt_Madichvu2.Text = dv.MaDichVu;
                txt_TenDichVu2.Text = dv.TenDichVu;
                txt_DonGia2.Text = dv.DonViTinh;
                txt_DonViTinh2.Text = dv.DonViTinh.ToString();
            }
        }
    }
}
