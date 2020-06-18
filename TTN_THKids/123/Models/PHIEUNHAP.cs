namespace _123.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUNHAP")]
    public partial class PHIEUNHAP
    {
        [Key]
        [StringLength(15)]
        public string MaPhieuNhap { get; set; }

        [StringLength(15)]
        public string MaNhanVien { get; set; }

        [StringLength(15)]
        public string MaNhaPhatHanh { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual NHAPHATHANH NHAPHATHANH { get; set; }
    }
}
