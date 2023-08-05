using QuanLyKhachSan.DA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.BUS
{
    public class BUS_DichVu
    {
        DA_DichVu da;
        public BUS_DichVu() { 
        da= new DA_DichVu();
        }
        public void LoadDichVu(DataGridView dgv)
        {
            dgv.DataSource = da.LoadDichVu();
        }
        public void ThemDichVu_b(string madv, string tendv, float dongia, string donvitinh)
        {
            da.ThemDichVu_d(madv, tendv, dongia, donvitinh);
        }
        public void hienthongtincbo_b(ComboBox cbo)
        {
           
            cbo.DataSource = da.hienthongtincbo_d();
            cbo.SelectedIndex = -1;
            
        }
        public void TimMaDichVu_b(string madv,DataGridView dgv)
        {
           
            dgv.DataSource = da.timdichvu_d(madv);
        }
        public void timtendichvu_b(string tendichvu, DataGridView dgv)
        {

            dgv.DataSource = da.timtendichvu_d(tendichvu);
        }
        public void SuaDichVu_b(string madv, string tendv, float dongia, string donvitinh)
        {
            da.SuaDichVu_d(madv, tendv, dongia, donvitinh);
        }
        public void XoaDichVu_b(string madv)
        {
            da.XoaDichVu_d(madv);
        }
        public QuanLyDichVu xuatdichvu(string madv)
        {
            return da.laydichvu(madv);
        }
        public void LoadRoomIDs(ComboBox cbo)
        {
            // Get the room IDs from the DA_Phong class
            var roomIDs = da.GetRoomIDs();

            // Set the DataSource of the ComboBox to the list of room IDs
            cbo.DataSource = roomIDs;
        }
        public void InsertDangKyDichVu(string maDichVu, string maPhong, int soLuong, float donGia)
        {
            da.InsertDangKyDichVu(maDichVu, maPhong, soLuong, donGia);
        }

    }
}
