namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_coupon")]
    public class Coupon : IEntityWithName, IEntityWithStatus
    {
        [Key]
        [Column("coupon_id")]
        public int Id { get; protected set; }

        [Required]
        [StringLength(128)]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        [Column("code")]
        public string Code { get; set; }

        [Column("type", TypeName = "char")]
        [Required]
        [StringLength(1)]
        public string Type { get; set; }

        [Column("discount")]
        public decimal Discount { get; set; }

        [Column("logged")]
        public bool Logged { get; set; }

        [Column("shipping")]
        public bool Shipping { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

        [Column("date_start", TypeName = "date")]
        public DateTime DateStart { get; set; }

        [Column("date_end", TypeName = "date")]
        public DateTime DateEnd { get; set; }

        [Column("uses_total")]
        public int UsesTotal { get; set; }

        [Required]
        [StringLength(11)]
        [Column("uses_customer")]
        public string UsesCustomer { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
