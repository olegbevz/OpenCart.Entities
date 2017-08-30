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
        public int ProductOptionId { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("option_id")]
        public int OptionId { get; set; }

        [Column("value", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Value { get; set; }

        public bool required { get; set; }
    }
}
