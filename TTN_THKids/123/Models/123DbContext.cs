namespace _123.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class _123DbContext : DbContext
    {
        public _123DbContext()
            : base("name=abcDbContext")
        {
        }

        public virtual DbSet<DAUSACH> DAUSACHes { get; set; }
        public virtual DbSet<MUONTRA> MUONTRAs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHAPHATHANH> NHAPHATHANHs { get; set; }
        public virtual DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIENs { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<THANHLY> THANHLies { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }
        public virtual DbSet<THETHUVIEN> THETHUVIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DAUSACH>()
                .Property(e => e.MaSach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAUSACH>()
                .Property(e => e.MaTheLoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAUSACH>()
                .Property(e => e.MaNhaXuatBan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DAUSACH>()
                .Property(e => e.MaTacGia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MUONTRA>()
                .Property(e => e.MaMuonTra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MUONTRA>()
                .Property(e => e.MaThe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MUONTRA>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAPHATHANH>()
                .Property(e => e.MaNhaPhatHanh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAXUATBAN>()
                .Property(e => e.MaNhaXuatBan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MaPhieuNhap)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MaNhaPhatHanh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SACH>()
                .Property(e => e.MaDonViSach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SACH>()
                .Property(e => e.MaSach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MaSinhVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TACGIA>()
                .Property(e => e.MaTacGia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THANHLY>()
                .Property(e => e.SoHieuThanhLy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THANHLY>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THELOAI>()
                .Property(e => e.MaTheLoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THETHUVIEN>()
                .Property(e => e.MaThe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THETHUVIEN>()
                .Property(e => e.MaSinhVien)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
