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
            //thêm
            string maVatTu = txt_MaVatTu.Text;
            string tenVatTu = txt_TenVatTu.Text;
            string nhaCungCap = txt_NhaCungCap.Text;
            string nguoiQuanLy = cbo_NguoiQuanLy.SelectedValue.ToString();
            string ghiChu = txt_GhiChu.Text;

            bus.ThemVatTu(maVatTu, tenVatTu, nhaCungCap, nguoiQuanLy, ghiChu);
            frm_VatTu_Load(sender, e);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            //sửa
            string maVatTu = txt_MaVatTu.Text;
            string tenVatTu = txt_TenVatTu.Text;
            string nhaCungCap = txt_NhaCungCap.Text;
            string nguoiQuanLy = cbo_NguoiQuanLy.SelectedValue.ToString();
            string ghiChu = txt_GhiChu.Text;

            bus.SuaVatTu(maVatTu, tenVatTu, nhaCungCap, nguoiQuanLy, ghiChu);
            frm_VatTu_Load(sender, e);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //xóa
            string maVatTu = txt_MaVatTu.Text;

            bus.XoaVatTu(maVatTu);
            frm_VatTu_Load(sender, e);
        }

        private void frm_VatTu_Load(object sender, EventArgs e)
        {
            //load datagridview
            bus.LoadNhanSu(cbo_NguoiQuanLy);
            bus.LoadDsTk(dgv_DanhSachVatTu);
            bus.LoadDsTk(dgv_DanhSachVatTu1);
            bus.LoadDsTk(dgv_DanhSachVatTu2);
            dgv_DanhSachVatTu1.Enabled = false;
            

        
        }

        private void cbo_MaVatTu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tìm theo mã vật tư
            string maVatTu = cbo_MaVatTu1.SelectedValue.ToString();
            dgv_DanhSachVatTu1.DataSource = bus.TimVatTuTheoMa(maVatTu);
        }

        private void txt_TenVatTu1_TextChanged(object sender, EventArgs e)
        {
            //tìm theo tên vật tư
            string tenVatTu = txt_TenVatTu1.Text;
            dgv_DanhSachVatTu1.DataSource = bus.TimVatTuTheoTen(tenVatTu);
        }

        private void cbo_NguoiQuanLy1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tìm theo người quản lý
            string nguoiQuanLy = cbo_NguoiQuanLy1.SelectedValue.ToString();
            dgv_DanhSachVatTu1.DataSource = bus.TimVatTuTheoNguoiQuanLy(nguoiQuanLy);
        }
    }
}
