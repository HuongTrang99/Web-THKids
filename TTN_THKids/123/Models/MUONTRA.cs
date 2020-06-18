namespace _123.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MUONTRA")]
    public partial class MUONTRA
    {
        [Key]
        [StringLength(15)]
        public string MaMuonTra { get; set; }

        [StringLength(15)]
        public string MaThe { get; set; }

        [StringLength(15)]
        public string MaNhanVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayMuon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTra { get; set; }

        [StringLength(200)]
        public string Ghichu { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual THETHUVIEN THETHUVIEN { get; set; }
    }
}
