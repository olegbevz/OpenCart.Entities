namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_layout_route")]
    public class LayoutRoute
    {
        [Key]
        [Column("layout_route_id")]
        public int Id { get; set; }

        [Column("layout_id")]
        public int LayoutId { get; set; }

        [Column("store_id")]
        public int StoreId { get; set; }

        [Required]
        [StringLength(64)]
        [Column("route")]
        public string Route { get; set; }
    }
}
