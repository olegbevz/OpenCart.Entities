namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_layout_route")]
    public class oc_layout_route
    {
        [Key]
        public int layout_route_id { get; set; }

        public int layout_id { get; set; }

        public int store_id { get; set; }

        [Required]
        [StringLength(64)]
        public string route { get; set; }
    }
}
