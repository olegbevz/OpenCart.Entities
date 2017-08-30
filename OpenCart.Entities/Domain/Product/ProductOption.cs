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
        public int product_option_id { get; set; }

		[Column("product_id")]
        public int product_id { get; set; }

		[Column("option_id")]
        public int option_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string value { get; set; }

        public bool required { get; set; }
    }
}
