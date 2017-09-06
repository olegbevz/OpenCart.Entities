namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_total")]
    public class OrderTotal : IEntityWithTitle
    {
        [Key]
        [Column("order_total_id")]
        public int Id { get; protected set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        [Required]
        [StringLength(32)]
        [Column("code")]
        public string Code { get; set; }

        [Required]
        [StringLength(255)]
        [Column("title")]
        public string Title { get; set; }

        [Column("value")]
        public decimal Value { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
