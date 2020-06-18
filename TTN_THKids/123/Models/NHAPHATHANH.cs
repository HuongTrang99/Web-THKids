namespace _123.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHAPHATHANH")]
    public partial class NHAPHATHANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHAPHATHANH()
        {
            PHIEUNHAPs = new HashSet<PHIEUNHAP>();
        }

        [Key]
        [StringLength(15)]
        public string MaNhaPhatHanh { get; set; }

        [StringLength(50)]
        public string TenNhaPhatHanh { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string ThongTinNguoiDaiDien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAP> PHIEUNHAPs { get; set; }
    }
}
