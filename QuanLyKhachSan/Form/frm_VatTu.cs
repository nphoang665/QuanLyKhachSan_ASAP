using System;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_VatTu : Form
    {
        BUS_VatTu bus;
        public frm_VatTu()
        {
            InitializeComponent();
            bus = new BUS_VatTu();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maVatTu = txt_MaVatTu.Text;
            string tenVatTu = txt_TenVatTu.Text;
            string nhaCungCap = txt_NhaCungCap.Text;
            string nguoiQuanLy = cbo_NguoiQuanLy.SelectedValue.ToString();
            string ghiChu = txt_GhiChu.Text;

            if (string.IsNullOrEmpty(maVatTu) || string.IsNullOrEmpty(tenVatTu) || string.IsNullOrEmpty(nhaCungCap) || string.IsNullOrEmpty(nguoiQuanLy))
            {
                MessageBox.Show("Error: Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bus.ThemVatTu(maVatTu, tenVatTu, nhaCungCap, nguoiQuanLy, ghiChu);
                frm_VatTu_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            txt_MaVatTu2.Enabled = false;
            string maVatTu = txt_MaVatTu2.Text;
            string tenVatTu = txt_TenVatTu2.Text;
            string nhaCungCap = txt_NhaCungCap2.Text;
            string nguoiQuanLy = cbo_NguoiQuanLy2.Text;
            string ghiChu = txt_GhiChu.Text;


            if (string.IsNullOrEmpty(maVatTu) || string.IsNullOrEmpty(tenVatTu) || string.IsNullOrEmpty(nhaCungCap) || string.IsNullOrEmpty(nguoiQuanLy))
            {
                MessageBox.Show("Error: Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                bus.SuaVatTu(maVatTu, tenVatTu, nhaCungCap, nguoiQuanLy, ghiChu);
                frm_VatTu_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txt_MaVatTu2.Enabled = false;

            string maVatTu = txt_MaVatTu2.Text;
            if (string.IsNullOrEmpty(maVatTu))
            {
                MessageBox.Show("Error: Vui lòng nhập mã vật tư.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            try
            {
                bus.XoaVatTu(maVatTu);
                frm_VatTu_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    


private void frm_VatTu_Load(object sender, EventArgs e)
        {

            bus.LoadNhanSu(cbo_NguoiQuanLy);
            bus.LoadDsTk(dgv_DanhSachVatTu);
            bus.LoadDsTk(dgv_DanhSachVatTu1);
            bus.LoadDsTk(dgv_DanhSachVatTu2);
            dgv_DanhSachVatTu1.Enabled = false;
            bus.LoadNhanSu(cbo_NguoiQuanLy1);
            bus.LoadNhanSu(cbo_NguoiQuanLy2);
            bus.LoadVatTu(cbo_MaVatTu1);


        }

        private void cbo_MaVatTu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maVatTu = cbo_MaVatTu1.Text;
            dgv_DanhSachVatTu1.DataSource = bus.TimVatTuTheoMa(maVatTu);
        }

        private void txt_TenVatTu1_TextChanged(object sender, EventArgs e)
        {

            string tenVatTu = txt_TenVatTu1.Text;
            dgv_DanhSachVatTu1.DataSource = bus.TimVatTuTheoTen(tenVatTu);
        }

        private void cbo_NguoiQuanLy1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string nguoiQuanLy = cbo_NguoiQuanLy1.SelectedValue.ToString();
            dgv_DanhSachVatTu1.DataSource = bus.TimVatTuTheoNguoiQuanLy(nguoiQuanLy);
        }

        private void tabPage_Sua_XoaPhong_Click(object sender, EventArgs e)
        {

        }

        private void cbo_NguoiQuanLy2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_DanhSachVatTu1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_DanhSachVatTu1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgv_DanhSachVatTu2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mavattu = dgv_DanhSachVatTu2.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tenvattu = dgv_DanhSachVatTu2.Rows[e.RowIndex].Cells[1].Value.ToString();
            string nhacungcap = dgv_DanhSachVatTu2.Rows[e.RowIndex].Cells[2].Value.ToString();
            string nguoiquanly = dgv_DanhSachVatTu2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_MaVatTu2.Text = mavattu;
            txt_TenVatTu2.Text = tenvattu;
            txt_NhaCungCap2.Text = nhacungcap;
            cbo_NguoiQuanLy2.Text = nguoiquanly;
        }

        private void dgv_DanhSachVatTu2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
