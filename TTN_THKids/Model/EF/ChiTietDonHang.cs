namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDonHang")]
    public partial class ChiTietDonHang
    {
        [Key]
        [StringLength(15)]
        public string SoHieuDonHang { get; set; }

        [Required]
        [StringLength(15)]
        public string MaDonHang { get; set; }

        [Required]
        [StringLength(15)]
        public string MaSanPham { get; set; }

        public int SoLuongSanPham { get; set; }

        [Column(TypeName = "money")]
        public decimal GiaSanPham { get; set; }

        public string GhiChu { get; set; }

        public virtual DonHang DonHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
