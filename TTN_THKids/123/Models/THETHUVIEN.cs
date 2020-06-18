namespace _123.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THETHUVIEN")]
    public partial class THETHUVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THETHUVIEN()
        {
            MUONTRAs = new HashSet<MUONTRA>();
        }

        [Key]
        [StringLength(15)]
        public string MaThe { get; set; }

        [StringLength(15)]
        public string MaSinhVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTaoThe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayGiaHan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MUONTRA> MUONTRAs { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
