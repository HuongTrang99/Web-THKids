namespace _123.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THANHLY")]
    public partial class THANHLY
    {
        [Key]
        [StringLength(15)]
        public string SoHieuThanhLy { get; set; }

        [StringLength(15)]
        public string MaNhanVien { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
