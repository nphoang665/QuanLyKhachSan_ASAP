//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhachSan.DA
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDon
    {
        public string MaDatPhong { get; set; }
        public string MaHoaDon { get; set; }
        public string MaNhanVien { get; set; }
        public System.DateTime NgayDat { get; set; }
        public System.DateTime NgayTra { get; set; }
        public int TongTien { get; set; }
        public int GiamGia { get; set; }
    
        public virtual DatPhong DatPhong { get; set; }
        public virtual NhanSu NhanSu { get; set; }
    }
}
