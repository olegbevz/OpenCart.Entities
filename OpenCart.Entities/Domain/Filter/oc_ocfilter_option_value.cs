namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_ocfilter_option_value")]
    public class oc_ocfilter_option_value
    {
        [Key]
        [Column(Order = 0)]
        public long value_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int option_id { get; set; }

        [Required]
        [StringLength(255)]
        public string keyword { get; set; }

        [Required]
        [StringLength(6)]
        public string color { get; set; }

        [Required]
        [StringLength(255)]
        public string image { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
