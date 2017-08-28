namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_total")]
    public class OrderTotal
    {
        [Key]
        public int order_total_id { get; set; }

        public int order_id { get; set; }

        [Required]
        [StringLength(32)]
        [Column("code")]
        public string Code { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        public decimal value { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
