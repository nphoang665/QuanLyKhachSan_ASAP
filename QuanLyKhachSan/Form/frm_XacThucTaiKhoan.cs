using QuanLyKhachSan.BUS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_XacThucTaiKhoan : Form
    {
        BUS_XacThucTaiKhoan bus;
        public frm_XacThucTaiKhoan()
        {
            InitializeComponent();
            bus = new BUS_XacThucTaiKhoan();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if (daChonDong)
            {
                string lyDo = "";
                string reason = Microsoft.VisualBasic.Interaction.InputBox("Lý do", "Nhập lý do", lyDo);

                if (reason != null)
                {
                    if (!string.IsNullOrEmpty(reason))
                    {
                        string taiKhoan = dgv_tkChuaXacThuc.Rows[viTri].Cells[0].Value.ToString();
                        if (taiKhoan != null)
                        {
                            bus.CapNhatTinhTrangVaLyDoTaiKhoan(taiKhoan, "ThatBai", reason);
                            loadDuLieu();
                        }
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn giá trị!", "Thông báo");
            }
        }



        void loadDuLieu()
        {
            bus.LayTaiKhoanChuaXuLy(dgv_tkChuaXacThuc);
            bus.LayTaiKhoanThanhCong(dgv_TaiKhoanDaDuocXacThuc);

        }
        private void frm_XacThucTaiKhoan_Load(object sender, EventArgs e)
        {
            loadDuLieu();

        }

        private void btn_DongY_Click(object sender, EventArgs e)
        {
            if (daChonDong)
            {
                string taiKhoan = dgv_tkChuaXacThuc.Rows[viTri].Cells[0].Value.ToString();
                if (taiKhoan != null)
                {
                    bus.CapNhatTinhTrangTaiKhoan(taiKhoan, "ThanhCong");


                    loadDuLieu();

                }

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn giá trị!", "Thông báo");
            }
        }
        int viTri;
        bool daChonDong = false;

        private void dgv_tkChuaXacThuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                daChonDong = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_tkChuaXacThuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                viTri = e.RowIndex;
                string tinhTrang = dgv_tkChuaXacThuc.Rows[viTri].Cells["TinhTrang"].Value.ToString();
                if (tinhTrang == "ThatBai")
                {
                    btn_Huy.BackColor = Color.Gray;
                    btn_Huy.Enabled = false;
                }
                else
                {
                    btn_Huy.BackColor = Color.Red;

                    btn_Huy.Enabled = true;
                }
            }
        }

        private void dgv_tkChuaXacThuc_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv_TaiKhoanDaDuocXacThuc.ClearSelection();
            dgv_tkChuaXacThuc.ClearSelection();
        }
    }
}
