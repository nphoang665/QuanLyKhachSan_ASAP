﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyKhachSanEntities : DbContext
    {
        public QuanLyKhachSanEntities()
            : base("name=QuanLyKhachSanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DangKyDichVu> DangKyDichVu { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<LuuMatKhau> LuuMatKhau { get; set; }
        public virtual DbSet<NhanSu> NhanSu { get; set; }
        public virtual DbSet<Phong> Phong { get; set; }
        public virtual DbSet<QuanLyDichVu> QuanLyDichVu { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
        public virtual DbSet<ThongTinKhachHang> ThongTinKhachHang { get; set; }
        public virtual DbSet<ThuePhong> ThuePhong { get; set; }
        public virtual DbSet<VatTu> VatTu { get; set; }
    }
}
