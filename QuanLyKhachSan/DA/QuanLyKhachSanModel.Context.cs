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
    
        public virtual DbSet<DangKyDichVu> DangKyDichVus { get; set; }
        public virtual DbSet<DatPhong> DatPhongs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<LuuMatKhau> LuuMatKhaus { get; set; }
        public virtual DbSet<NhanSu> NhanSus { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<QuanLyDichVu> QuanLyDichVus { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThongKe> ThongKes { get; set; }
        public virtual DbSet<ThongTinKhachHang> ThongTinKhachHangs { get; set; }
        public virtual DbSet<VatTu> VatTus { get; set; }
    }
}