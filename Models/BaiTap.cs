namespace StudyEnglish.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiTap")]
    public partial class BaiTap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaiTap()
        {
            LichSu = new HashSet<LichSu>();
        }

        public int maVideo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maBt { get; set; }

        [Column(TypeName = "text")]
        public string CauHoi { get; set; }

        [StringLength(20)]
        public string DA1 { get; set; }

        [StringLength(20)]
        public string DA2 { get; set; }

        [StringLength(20)]
        public string DA3 { get; set; }

        [StringLength(20)]
        public string DA4 { get; set; }

        [StringLength(20)]
        public string DA5 { get; set; }

        public virtual Video Video { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSu> LichSu { get; set; }
    }
}
