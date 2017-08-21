namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_ocfilter_option_value_to_product_description")]
    public class oc_ocfilter_option_value_to_product_description
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int product_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long value_id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int option_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public sbyte language_id { get; set; }

        [Required]
        [StringLength(255)]
        [Column("description")]
        public string Description { get; set; }
    }
}
