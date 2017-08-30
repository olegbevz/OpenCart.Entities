namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_status")]
    public class OrderStatus : Localizable, IEntityWithName
    {
        [Key]
        [Column("order_status_id", Order = 0)]
        public int Id { get; protected set; }

        [Required]
        [StringLength(32)]
        [Column("name")]
        public string Name { get; set; }
    }
}
