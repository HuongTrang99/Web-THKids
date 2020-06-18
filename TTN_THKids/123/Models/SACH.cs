namespace _123.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public partial class SACH
    {
        [Key]
        [StringLength(15)]
        public string MaDonViSach { get; set; }

        [StringLength(15)]
        public string MaSach { get; set; }

        public virtual DAUSACH DAUSACH { get; set; }
    }
}
