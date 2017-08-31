namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_filter")]
    public class Filter
    {
        [Key]
        [Column("filter_id")]
        public int Id { get; protected set; }

        [Column("filter_group_id")]
        public int FilterGroupId { get; set; }

        public virtual FilterGroup FilterGroup { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
