namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_status")]
    public class oc_order_status : Localizable
    {
        [Key]
        [Column(Order = 0)]
        public int order_status_id { get; set; }

        [Required]
        [StringLength(32)]
        [Column("name")]
        public string Name { get; set; }
    }
}
