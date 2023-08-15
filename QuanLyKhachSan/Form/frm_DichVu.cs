using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace QuanLyKhachSan
{
    public partial class frm_DichVu : Form
    {
        BUS_DichVu bus;

        public TabControl TabControl_DichVu_ADM
        {
            get { return tabControl_DichVu_ADM; }
         
        }
        public TabPage TabPage_DichVu_ADM
        {
            get { return tabPage_DangKyDichVu; }
        }
        public TabPage TabPage_DichVu_ADM2
        {
            get { return tabPage_ThemDichVu; }
        }
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
            bus.LoadDichVu(dgv_DanhSachDichVu3);
           
        }

        private void frm_DichVu_Load(object sender, EventArgs e)
        {
            bus.LoadDichVu(dgv_DanhSachDichVu);
            LoadDichVu();
            bus.LoadRentedRoomIDs(cbo_MaPhong);

            listView_DichVuDaDat.Columns.Add("TenDichVu", "Tên dịch vụ", 160);
            listView_DichVuDaDat.Columns.Add("SoLuong", "Số lượng", 100);
            listView_DichVuDaDat.Columns.Add("MaPhong", "Mã phòng", 100);
            bus.hienthongtincbo_b(cbo_MaDichVu3);
            loadTenDGV();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            string maDichVu = txt_MaDichVu.Text;
            string tenDichVu = txt_TenDichVu.Text;
            float donGia = float.Parse(txt_DonGia.Text);
            string donViTinh = txt_DonViTinh.Text;
            bus.ThemDichVu_b(maDichVu, tenDichVu, donGia, donViTinh);
            LoadDichVu();
            bus.hienthongtincbo_b(cbo_MaDichVu3);
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
            bus.hienthongtincbo_b(cbo_MaDichVu3);

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bus.XoaDichVu_b(txt_Madichvu2.Text);
            LoadDichVu();
            bus.hienthongtincbo_b(cbo_MaDichVu3);
        }

        private void dgv_DanhSachDichVu2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string madv = dgv_DanhSachDichVu2.Rows[e.RowIndex].Cells["MaDichVu"].Value.ToString();
                var dv = bus.xuatdichvu(madv);
                txt_Madichvu2.Text = dv.MaDichVu;
                txt_TenDichVu2.Text = dv.TenDichVu;
                txt_DonGia2.Text =dv.DonGia.ToString();
                txt_DonViTinh2.Text = dv.DonViTinh.ToString();
            }
        }

        private void btn_Them_DKDV_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasError = false;
                string errorMessage = "";
                int soLuong=0;

                if (string.IsNullOrWhiteSpace(txt_SoLuong.Text))
                {
                    hasError = true;
                    errorMessage = "Vui lòng nhập số lượng.";
                }
                else if (!int.TryParse(txt_SoLuong.Text, out soLuong) || soLuong <= 0)
                {
                    hasError = true;
                    errorMessage = "Số lượng không hợp lệ. Vui lòng nhập số lượng là một số nguyên dương.";
                }
                else if (cbo_MaPhong.SelectedItem == null)
                {
                    hasError = true;
                    errorMessage = "Vui lòng chọn mã phòng.";
                }
                else if (cbo_MaDichVu3.SelectedItem == null)
                {
                    hasError = true;
                    errorMessage = "Vui lòng chọn mã dịch vụ.";
                }

                if (hasError)
                {
                    MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maPhong = cbo_MaPhong.SelectedItem.ToString();
                string maDichVu = cbo_MaDichVu3.SelectedValue.ToString();

                bool daTonTai = false;
                foreach (ListViewItem existingItem in listView_DichVuDaDat.Items)
                {
                    if (existingItem.SubItems[0].Text == maDichVu && existingItem.SubItems[2].Text == maPhong)
                    {
                        existingItem.SubItems[1].Text = (int.Parse(existingItem.SubItems[1].Text) + soLuong).ToString();
                        daTonTai = true;
                        break;
                    }
                }

                if (!daTonTai)
                {
                    ListViewItem item = new ListViewItem(new string[] { maDichVu, soLuong.ToString(), maPhong });
                    listView_DichVuDaDat.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XoaDKDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_DichVuDaDat.SelectedItems.Count > 0)
                {
                    var selectedItem = listView_DichVuDaDat.SelectedItems[0];
                    string maDichVu = selectedItem.SubItems[0].Text;
                    string maPhong = selectedItem.SubItems[2].Text;
                    string tenDichVu = GetTenDichVuByMaDichVu(maDichVu);

                    DialogResult dialogResult = MessageBox.Show($"Bạn có muốn xóa dịch vụ '{tenDichVu}' của phòng '{maPhong}' không?",
                                                              "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        listView_DichVuDaDat.Items.Remove(selectedItem);
                        MessageBox.Show("Xóa dịch vụ thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa từ danh sách dịch vụ đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetTenDichVuByMaDichVu(string tenDichVu)
        {
            return bus.GetTenDichVuByMaDichVu(tenDichVu);
        }

        private void btn_DangKyDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_DichVuDaDat.Items.Count == 0)
                {
                    MessageBox.Show("Vui lòng thêm dịch vụ vào danh sách dịch vụ trước khi đăng ký!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (ListViewItem item in listView_DichVuDaDat.Items)
                {
                    string tenDichVu = item.SubItems[0].Text; 
                    string maPhong = item.SubItems[2].Text;  
                    int soLuong = int.Parse(item.SubItems[1].Text);

                    string maDichVu = bus.GetMaDichVuByTenDichVu(tenDichVu); 
                    double donGia = bus.GetDonGiaByMaDichVu(maDichVu); 

                  
                    if (bus.CheckDichVuDaTonTai(maDichVu, maPhong))
                    {
                     
                        bus.UpdateDangKyDichVu(maDichVu, maPhong, soLuong);
                    }
                    else
                    {
                       
                        Random random = new Random();
                        string maDangKyDV = "DDV" + random.Next(100, 999).ToString();

                        while (bus.CheckMaDangKyDVTonTai(maDangKyDV))
                        {
                            maDangKyDV = "DDV" + random.Next(100, 999).ToString();
                        }

                        bus.InsertDangKyDichVu(maDangKyDV, maDichVu, maPhong, soLuong, donGia);
                    }

                    frm_ThongTinPhong.Instance.UpdateDichVuDaSuDung(item.Clone() as ListViewItem); // Tạo bản sao của item và thêm vào ListView khác
                }
                MessageBox.Show("Đăng ký dịch vụ thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listView_DichVuDaDat.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetMaDichVuByTenDichVu(string tenDichVu)
        {
            return bus.GetMaDichVuByTenDichVu(tenDichVu);
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string tenDV = txt_TimKiem.Text;
            var kq = bus.timDV(tenDV);
            dgv_DanhSachDichVu3.DataSource = kq;
        }

        private void dgv_DanhSachDichVu3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                string maDichVu = dgv_DanhSachDichVu3.Rows[e.RowIndex].Cells["MaDichVu"].Value.ToString();

                for (int i = 0; i < cbo_MaDichVu3.Items.Count; i++)
                {
                    if (cbo_MaDichVu3.GetItemText(cbo_MaDichVu3.Items[i]) == maDichVu)
                    {
                        cbo_MaDichVu3.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        public void loadTenDGV()
        {
            dgv_DanhSachDichVu.Columns["MaDichVu"].HeaderText = "Mã dịch vụ";
            dgv_DanhSachDichVu.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgv_DanhSachDichVu.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv_DanhSachDichVu.Columns["DonViTinh"].HeaderText = "Đơn vị tính";

            dgv_DanhSachDichVu1.Columns["MaDichVu"].HeaderText = "Mã dịch vụ";
            dgv_DanhSachDichVu1.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgv_DanhSachDichVu1.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv_DanhSachDichVu1.Columns["DonViTinh"].HeaderText = "Đơn vị tính";

            dgv_DanhSachDichVu2.Columns["MaDichVu"].HeaderText = "Mã dịch vụ";
            dgv_DanhSachDichVu2.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgv_DanhSachDichVu2.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv_DanhSachDichVu2.Columns["DonViTinh"].HeaderText = "Đơn vị tính";

            dgv_DanhSachDichVu3.Columns["MaDichVu"].HeaderText = "Mã dịch vụ";
            dgv_DanhSachDichVu3.Columns["TenDichVu"].HeaderText = "Tên dịch vụ";
            dgv_DanhSachDichVu3.Columns["DonGia"].HeaderText = "Đơn giá";
            dgv_DanhSachDichVu3.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
        }

        private void tabPage_ThemDichVu_Click(object sender, EventArgs e)
        {

        }

        private void btn_rp_Click(object sender, EventArgs e)
        {
            frm_rpDichVu frm_RpDichVu = new frm_rpDichVu();
            frm_RpDichVu.ShowDialog();
        }
    }
}
