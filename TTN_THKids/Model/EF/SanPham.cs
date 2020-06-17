namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        [Key]
        [StringLength(15)]
        public string MaSanPham { get; set; }

        [Required]
        [StringLength(15)]
        public string MaDMSP { get; set; }

        [StringLength(10)]
        public string MaKichCo { get; set; }

        [StringLength(10)]
        public string MaChatLieu { get; set; }

        [StringLength(10)]
        public string MaThuongHieu { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSanPham { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaSanPham { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaChietKhau { get; set; }

        public int? SoLuong { get; set; }

        [Required]
        public string LinkAnh { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string LinkListAnh { get; set; }

        public string ThongTinSP { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? NgayCapNhat { get; set; }

        public int? SoLuongMua { get; set; }

        public virtual ChatLieu ChatLieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }

        public virtual DanhMucSanPham DanhMucSanPham { get; set; }

        public virtual KichCo KichCo { get; set; }

        public virtual ThuongHieu ThuongHieu { get; set; }
    }
}
