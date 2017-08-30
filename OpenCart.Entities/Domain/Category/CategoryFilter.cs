namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_category_filter")]
    public class CategoryFilter
    {
        [Key]
        [Column("category_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }

        [Key]
        [Column("filter_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FilterId { get; set; }
    }
}
