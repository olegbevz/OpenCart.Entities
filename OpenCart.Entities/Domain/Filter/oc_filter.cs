namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_filter")]
    public class oc_filter
    {
        [Key]
        public int filter_id { get; set; }

        public int filter_group_id { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
