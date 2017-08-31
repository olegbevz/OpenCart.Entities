namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_product_image_by_option")]
    public class ProductImageByOption
    {
        [Key]
        [Column("product_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Key]
        [Column("product_image_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductImageId { get; set; }

        public virtual ProductImage ProductImage { get; set; }

        [Key]
        [Column("product_value_id", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OptionValueId { get; set; }

        public virtual OptionValue OptionValue { get; set; } 
    }
}
