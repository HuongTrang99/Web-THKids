namespace _123.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DAUSACH")]
    public partial class DAUSACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAUSACH()
        {
            SACHes = new HashSet<SACH>();
        }

        [Key]
        [StringLength(15)]
        public string MaSach { get; set; }

        [StringLength(15)]
        public string MaTheLoai { get; set; }

        [StringLength(15)]
        public string MaNhaXuatBan { get; set; }

        [StringLength(15)]
        public string MaTacGia { get; set; }

        [StringLength(400)]
        public string TenSach { get; set; }

        public int? SoLuong { get; set; }

        public virtual NHAXUATBAN NHAXUATBAN { get; set; }

        public virtual TACGIA TACGIA { get; set; }

        public virtual THELOAI THELOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SACH> SACHes { get; set; }
    }
}
