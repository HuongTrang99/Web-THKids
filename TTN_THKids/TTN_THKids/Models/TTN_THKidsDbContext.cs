namespace TTN_THKids.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TTN_THKidsDbContext : DbContext
    {
        public TTN_THKidsDbContext()
            : base("name=TTN_THKidsDbContext")
        {
        }

        public virtual DbSet<ChatLieu> ChatLieux { get; set; }
        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KichCo> KichCoes { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<QuanTriVien> QuanTriViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieux { get; set; }
        public virtual DbSet<TrangThaiDonHang> TrangThaiDonHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatLieu>()
                .Property(e => e.MaChatLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.SoHieuDonHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.MaDonHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.MaSanPham)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.GiaSanPham)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DanhMuc>()
                .Property(e => e.MaDanhMuc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DanhMucSanPham>()
                .Property(e => e.MaDMSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DanhMucSanPham>()
                .Property(e => e.MaDanhMuc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DanhMucSanPham>()
                .HasMany(e => e.SanPhams)
                .WithRequired(e => e.DanhMucSanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaDonHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaKhachHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaTrangThai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKhachHang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.DonHangs)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KichCo>()
                .Property(e => e.MaKichCo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNhanVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.DonHangs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<QuanTriVien>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaSanPham)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaDMSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaKichCo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaChatLieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaThuongHieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.GiaSanPham)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.GiaChietKhau)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.LinkAnh)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.LinkListAnh)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ThuongHieu>()
                .Property(e => e.MaThuongHieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TrangThaiDonHang>()
                .Property(e => e.MaTrangThai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TrangThaiDonHang>()
                .HasMany(e => e.DonHangs)
                .WithRequired(e => e.TrangThaiDonHang)
                .WillCascadeOnDelete(false);
        }
    }
}
