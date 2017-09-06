namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_product_option")]
    public class ProductOption
    {
        [Key]
        [Column("product_option_id")]
        public int Id { get; protected set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Column("option_id")]
        public int OptionId { get; set; }

        public virtual Option Option { get; set; }

        [Column("value", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Value { get; set; }

        [Column("required")]
        public bool Required { get; set; }

        public virtual ICollection<OrderOption> OrderOptions { get; set; } = new HashSet<OrderOption>();

        public virtual ICollection<ProductOptionValue> OptionValues { get; set; } = new HashSet<ProductOptionValue>();

    }
}
