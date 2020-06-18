namespace TTN_THKids.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        [StringLength(15)]
        public string MaDonHang { get; set; }

        [Required]
        [StringLength(15)]
        public string MaNhanVien { get; set; }

        [Required]
        [StringLength(15)]
        public string MaKhachHang { get; set; }

        [Required]
        [StringLength(15)]
        public string MaTrangThai { get; set; }

        [Column(TypeName = "money")]
        public decimal TongTien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianTaoDonHang { get; set; }

        [Column(TypeName = "date")]
        public DateTime ThoiGianThanhToan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianGiaoHang { get; set; }

        public string GhiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual TrangThaiDonHang TrangThaiDonHang { get; set; }
    }
}
