namespace TTN_THKids.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DanhMucSanPham")]
    public partial class DanhMucSanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DanhMucSanPham()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        [StringLength(15)]
        public string MaDMSP { get; set; }

        [StringLength(15)]
        public string MaDanhMuc { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDMSP { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
