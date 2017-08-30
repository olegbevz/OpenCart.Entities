namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_blog_to_layout")]
    public class BlogToLayout
    {
        [Key]
        [Column("blog_to_layout_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; protected set; }

        [Key]
        [Column("store_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }

        [Column("layout_id")]
        public int LayoutId { get; set; }
    }
}
