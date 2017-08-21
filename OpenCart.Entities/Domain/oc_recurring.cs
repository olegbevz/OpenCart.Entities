namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_recurring")]
    public class oc_recurring
    {
        [Key]
        public int recurring_id { get; set; }

        public decimal price { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string frequency { get; set; }

        [Column(TypeName = "uint")]
        public long duration { get; set; }

        [Column(TypeName = "uint")]
        public long cycle { get; set; }

        public sbyte trial_status { get; set; }

        public decimal trial_price { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string trial_frequency { get; set; }

        [Column(TypeName = "uint")]
        public long trial_duration { get; set; }

        [Column(TypeName = "uint")]
        public long trial_cycle { get; set; }

        public sbyte status { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
