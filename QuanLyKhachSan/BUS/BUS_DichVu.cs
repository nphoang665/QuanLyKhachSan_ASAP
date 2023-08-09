using QuanLyKhachSan.DA;
using System;
using System.Collections;
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
        /* public void hienthongtincbo_b(ComboBox cbo)
         {

             cbo.DataSource = da.hienthongtincbo_d();
             cbo.SelectedIndex = -1;

         }*/
        public void hienthongtincbo_b(ComboBox cbo)
        {
            cbo.DataSource = da.hienthongtincbo_d();
            cbo.DisplayMember = "MaDichVu"; 
            cbo.ValueMember = "TenDichVu";
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
            var roomIDs = da.GetRoomIDs();
            cbo.DataSource = roomIDs;
        }

        public void InsertDangKyDichVu(string maDangKyDV, string maDichVu, string maPhong, int soLuong, float donGia)
        {
            da.InsertDangKyDichVu(maDangKyDV, maDichVu, maPhong, soLuong, donGia);
        }


        public float GetDonGiaByMaDichVu(string maDichVu)
        {
            return da.GetDonGiaByMaDichVu(maDichVu);
        }
        public bool CheckDichVuDaTonTai(string maDichVu, string maPhong)
        {
            return da.CheckDichVuDaTonTai(maDichVu, maPhong);
        }

        public void UpdateDangKyDichVu(string maDichVu, string maPhong, int soLuong)
        {
            da.UpdateDangKyDichVu(maDichVu, maPhong, soLuong);
        }
        public string GetMaDichVuByTenDichVu(string tenDichVu)
        {
            return da.GetMaDichVuByTenDichVu(tenDichVu);
        }
        public bool CheckMaDangKyDVTonTai(string maDangKyDV)
        {
            return da.CheckMaDangKyDVTonTai(maDangKyDV);
        }
        public string GetMaDangKyDVByDichVuPhong(string maDichVu, string maPhong)
        {
            return da.GetMaDangKyDVByDichVuPhong(maDichVu, maPhong);
        }
        public bool CheckPhongCoKhachThue(string maPhong)
        {
            return da.CheckPhongCoKhachThue(maPhong);
        }

        public void LoadRentedRoomIDs(ComboBox cbo)
        {
            var rentedRoomIDs = da.GetRentedRoomIDs();
            cbo.DataSource = rentedRoomIDs;
        }
        public string GetTenDichVuByMaDichVu(string tenDichVu)
        {
            return da.GetTenDichVuByMaDichVu(tenDichVu);
        }
        public IList timDV(string tenDV)
        {
            return da.timDV(tenDV);
        }





    }
}
