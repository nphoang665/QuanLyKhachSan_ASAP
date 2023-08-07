using QuanLyKhachSan.BUS;
using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_GiaoDienPhong : Form
    {
        BUS_GiaoDienPhong bus;
        public frm_GiaoDienPhong()
        {
            InitializeComponent();
            bus= new BUS_GiaoDienPhong();
        }

        private void pic_101_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_101.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }


        private void pic_102_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_102.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_103_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_103.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_104_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_104.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_105_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_105.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_201_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_201.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_202_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_202.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_203_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_203.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_204_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_204.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_205_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_205.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_301_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_301.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_302_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_302.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_303_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_303.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_304_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_304.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_305_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_305.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_401_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_401.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_402_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_402.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_403_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_403.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_404_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_404.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }

        private void pic_405_Click(object sender, EventArgs e)
        {
            string maPhong = lbl_405.Text;
            var phong = bus.layTrangThai(maPhong);

            if (phong.TinhTrang == "Trống")
            {
                // Open the frm_DatPhong form if the room is available
                frm_ThuePhong quanLyTraPhong = new frm_ThuePhong();
                frm_TrangChu.ViDu.OpenChildForm(quanLyTraPhong);
            }
            else
            {
                // Open the frm_ThongTinPhong form if the room is already rented
                frm_ThongTinPhong frm_ThongTinPhong = new frm_ThongTinPhong(maPhong);
                frm_ThongTinPhong.ShowDialog();
            }
        }
        private void OpenFormThuePhong(string maPhong)
        {
            frm_ThuePhong frmThuePhong = new frm_ThuePhong(maPhong);
            frm_TrangChu.ViDu.OpenChildForm(frmThuePhong);
        }

        /*private void OpenFormThongTinPhong(string maPhong)
        {
            var thuePhong = bus.LayThongTinThuePhong(maPhong);
            if (thuePhong != null)
            {
                frm_ThongTinPhong frmThongTinPhong = new frm_ThongTinPhong(thuePhong);
                frmThongTinPhong.ShowDialog();
            }
            else
            {
                MessageBox.Show("Phòng chưa có khách thuê!");
            }
        }*/
        public void OpenFormThongTinPhong(string maPhong)
        {
            ThuePhong thuePhong = bus.layThongTin(maPhong);
            if (thuePhong != null)
            {
                frm_ThongTinPhong frmThongTinPhong = new frm_ThongTinPhong(thuePhong);
                frmThongTinPhong.ShowDialog();
            }
            else
            {
                MessageBox.Show("Phòng chưa có khách thuê!");
            }
        }
    }
}
