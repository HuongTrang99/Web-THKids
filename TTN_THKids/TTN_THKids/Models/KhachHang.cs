namespace TTN_THKids.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            DonHangs = new HashSet<DonHang>();
        }

        [Key]
        [StringLength(15)]
        public string MaKhachHang { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(1000)]
        public string DiaChi { get; set; }

        public int SoDienThoai { get; set; }

        [StringLength(500)]
        public string TenDangNhap { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgaySinh { get; set; }

        public bool? GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ThoiGianDangKy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}
