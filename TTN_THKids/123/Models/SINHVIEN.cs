namespace _123.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SINHVIEN()
        {
            THETHUVIENs = new HashSet<THETHUVIEN>();
        }

        [Key]
        [StringLength(15)]
        public string MaSinhVien { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string Gioitinh { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        public int? SoDienThoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THETHUVIEN> THETHUVIENs { get; set; }
    }
}
