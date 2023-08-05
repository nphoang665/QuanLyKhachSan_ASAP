using QuanLyKhachSan.BUS;
using System;
using System.Linq;
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
        void themcotdichvu()
        {
            var maDichVuColumn = new DataGridViewTextBoxColumn
            {
                Name = "MaDichVu",
                HeaderText = "Mã Dịch Vụ",
                DataPropertyName = "MaDichVu"
            };

            // Add the MaDichVu column to the DataGridView
            dgv_danhsachdichvudadat.Columns.Add(maDichVuColumn);

            // Create the TenDichVu column
            var tenDichVuColumn = new DataGridViewTextBoxColumn
            {
                Name = "TenDichVu",
                HeaderText = "Tên Dịch Vụ",
                DataPropertyName = "TenDichVu"
            };

            // Add the TenDichVu column to the DataGridView
            dgv_danhsachdichvudadat.Columns.Add(tenDichVuColumn);

            // Create the DonGia column
            var donGiaColumn = new DataGridViewTextBoxColumn
            {
                Name = "DonGia",
                HeaderText = "Đơn Giá",
                DataPropertyName = "DonGia"
            };

            // Add the DonGia column to the DataGridView
            dgv_danhsachdichvudadat.Columns.Add(donGiaColumn);

            // Create the DonViTinh column
            var donViTinhColumn = new DataGridViewTextBoxColumn
            {
                Name = "DonViTinh",
                HeaderText = "Đơn Vị Tính",
                DataPropertyName = "DonViTinh"
            };

            // Add the DonViTinh column to the DataGridView
            dgv_danhsachdichvudadat.Columns.Add(donViTinhColumn);
            bus.LoadRoomIDs(cbo_MaPhong);
        }
        private void LoadDichVu()
        {
            themcotdichvu();
            bus.LoadDichVu(dgv_DanhSachDichVu);
            bus.LoadDichVu(dgv_DanhSachDichVu1);
            bus.LoadDichVu(dgv_dsdv);
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

        private void dgv_dsdv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the data from the clicked row
            var rowData = dgv_dsdv.Rows[e.RowIndex].Cells.Cast<DataGridViewCell>()
                .Select(cell => cell.Value)
                .ToArray();

            // Check if the data already exists in the destination DataGridView
            bool dataExists = dgv_danhsachdichvudadat.Rows.Cast<DataGridViewRow>()
                .Any(row => row.Cells.Cast<DataGridViewCell>().SequenceEqual(rowData));

            // If the data exists in the destination DataGridView, display a message to the user
            if (dataExists)
            {
                MessageBox.Show("This data already exists in the destination DataGridView and will not be added again.");
            }
            // If the data does not exist in the destination DataGridView, add a new row
            else
            {
                // Add a new row to the destination DataGridView
                var newRow = dgv_danhsachdichvudadat.Rows.Add();

                // Set the values of the new row to the data from the clicked row
                for (int i = 0; i < rowData.Length; i++)
                {
                    dgv_danhsachdichvudadat.Rows[newRow].Cells[i].Value = rowData[i];
                }
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {

            string maDichVu = dgv_danhsachdichvudadat.Rows[0].Cells[0].Value.ToString();


            string donGia = dgv_danhsachdichvudadat.Rows[0].Cells[2].Value.ToString();

            string maPhong = cbo_MaPhong.SelectedValue.ToString();

            int soLuong = int.Parse(txt_SoLuong.Text);

            bus.InsertDangKyDichVu(maDichVu, maPhong, soLuong,float.Parse( donGia));

            MessageBox.Show("Thêm thành công");

        }
    }
}
