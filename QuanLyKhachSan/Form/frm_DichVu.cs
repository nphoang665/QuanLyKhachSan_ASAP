using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DA;
using System;
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
            listView_DanhSachDichVu.Columns.Add("MaDichVu", "Mã dịch vụ", 100);
            listView_DanhSachDichVu.Columns.Add("TenDichVu", "Tên dịch vụ", 150);
            listView_DanhSachDichVu.Columns.Add("DonGia", "Đơn giá", 100);
            listView_DanhSachDichVu.Columns.Add("DonViTinh", "Đơn vị tính", 100);

            bus.LoadDichVu(dgv_DanhSachDichVu);
            LoadDichVu();
            CopyDataFromDataGridViewToListView(dgv_DanhSachDichVu, listView_DanhSachDichVu);
            bus.LoadRoomIDs(cbo_MaPhong);

            listView_DichVuDaDat.Columns.Add("TenDichVu", "Tên dịch vụ", 160);
            listView_DichVuDaDat.Columns.Add("SoLuong", "Số lượng", 100);
            listView_DichVuDaDat.Columns.Add("MaPhong", "Mã phòng", 100);
            bus.hienthongtincbo_b(cbo_MaDichVu3);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            string maDichVu = txt_MaDichVu.Text;
            string tenDichVu = txt_TenDichVu.Text;
            float donGia = float.Parse(txt_DonGia.Text);
            string donViTinh = txt_DonViTinh.Text;
            bus.ThemDichVu_b(maDichVu, tenDichVu, donGia, donViTinh);
            LoadDichVu();
            CopyDataFromDataGridViewToListView(dgv_DanhSachDichVu, listView_DanhSachDichVu);
            bus.hienthongtincbo_b(cbo_MaDichVu3);
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
            CopyDataFromDataGridViewToListView(dgv_DanhSachDichVu, listView_DanhSachDichVu);
            bus.hienthongtincbo_b(cbo_MaDichVu3);

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bus.XoaDichVu_b(txt_Madichvu2.Text);
            LoadDichVu();
            CopyDataFromDataGridViewToListView(dgv_DanhSachDichVu, listView_DanhSachDichVu);
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
                txt_DonGia2.Text = dv.DonViTinh;
                txt_DonViTinh2.Text = dv.DonViTinh.ToString();
            }
        }
        
        private void CopyDataFromDataGridViewToListView(DataGridView dgv, ListView listView)
        {
            listView.Items.Clear();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (!row.IsNewRow)
                {
                    string maDichVu = row.Cells["MaDichVu"].Value.ToString();
                    string tenDichVu = row.Cells["TenDichVu"].Value.ToString();
                    float donGia = float.Parse(row.Cells["DonGia"].Value.ToString());
                    string donViTinh = row.Cells["DonViTinh"].Value.ToString();

                    ListViewItem item = new ListViewItem(new string[] { maDichVu, tenDichVu, donGia.ToString(), donViTinh });
                    listView.Items.Add(item);
                }
            }
        }

        private void btn_Them_DKDV_Click(object sender, EventArgs e)
        {
            string maPhong = cbo_MaPhong.SelectedItem.ToString();
            string maDichVu = cbo_MaDichVu3.SelectedValue.ToString(); // Lấy mã dịch vụ từ giá trị đã chọn
            int soLuong = int.Parse(txt_SoLuong.Text);

            // Kiểm tra xem dịch vụ đã tồn tại trong ListView chưa
            bool daTonTai = false;
            foreach (ListViewItem existingItem in listView_DichVuDaDat.Items)
            {
                if (existingItem.SubItems[0].Text == maDichVu && existingItem.SubItems[2].Text == maPhong)
                {
                    // Cập nhật số lượng của dịch vụ đã tồn tại
                    existingItem.SubItems[1].Text = (int.Parse(existingItem.SubItems[1].Text) + soLuong).ToString();
                    daTonTai = true;
                    break;
                }
            }

            if (!daTonTai)
            {
                // Thêm thông tin vào ListView
                ListViewItem item = new ListViewItem(new string[] { maDichVu, soLuong.ToString(), maPhong });
                listView_DichVuDaDat.Items.Add(item);
            }
        }

        private void btn_XoaDKDV_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView_DichVuDaDat.SelectedItems.Count > 0)
                {
                    var selectedItem = listView_DichVuDaDat.SelectedItems[0];
                    listView_DichVuDaDat.Items.Remove(selectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DangKyDV_Click(object sender, EventArgs e)
        {        
            try
            {
                foreach (ListViewItem item in listView_DichVuDaDat.Items)
                {
                    string tenDichVu = item.SubItems[0].Text; // Tên dịch vụ được lưu trong cột đầu tiên
                    string maPhong = item.SubItems[2].Text;   // Mã phòng được lưu trong cột thứ ba
                    int soLuong = int.Parse(item.SubItems[1].Text);

                    string maDichVu = bus.GetMaDichVuByTenDichVu(tenDichVu); // Lấy mã dịch vụ từ tên dịch vụ
                    float donGia = bus.GetDonGiaByMaDichVu(maDichVu); // Lấy đơn giá từ mã dịch vụ

                    // Kiểm tra xem dịch vụ đã tồn tại trong cùng một phòng chưa
                    if (bus.CheckDichVuDaTonTai(maDichVu, maPhong))
                    {
                        // Nếu đã tồn tại, cập nhật số lượng dịch vụ đã đăng ký
                        bus.UpdateDangKyDichVu(maDichVu, maPhong, soLuong);
                    }
                    else
                    {
                        // Nếu chưa tồn tại, thêm mới dịch vụ vào cơ sở dữ liệu
                        // Tạo mã đăng ký dịch vụ ngẫu nhiên
                        Random random = new Random();
                        string maDangKyDV = "DDV" + random.Next(100, 999).ToString();

                        // Kiểm tra xem mã đăng ký dịch vụ đã tồn tại chưa
                        while (bus.CheckMaDangKyDVTonTai(maDangKyDV))
                        {
                            maDangKyDV = "DDV" + random.Next(100, 999).ToString();
                        }

                        // Thêm thông tin vào bảng DangKyDichVu
                        bus.InsertDangKyDichVu(maDangKyDV, maDichVu, maPhong, soLuong, donGia);
                    }

                    // Gọi phương thức của form frm_ThongTinPhong để cập nhật thông tin dịch vụ đã đăng ký
                    frm_ThongTinPhong.Instance.UpdateDichVuDaSuDung(item.Clone() as ListViewItem); // Tạo bản sao của item và thêm vào ListView khác

                    MessageBox.Show("Đăng ký dịch vụ thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Clear ListView sau khi đăng ký thành công
                listView_DichVuDaDat.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetMaDichVuByTenDichVu(string tenDichVu)
        {
            // Gọi phương thức của bus để lấy mã dịch vụ từ tên dịch vụ
            return bus.GetMaDichVuByTenDichVu(tenDichVu);
        }       
    }
}
