namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_filter_group")]
    public class FilterGroup
    {
        [Key]
        [Column("filter_group_id")]
        public int Id { get; protected set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        public virtual ICollection<Filter> Filters { get; set; } = new HashSet<Filter>();

        public virtual ICollection<FilterGroupDescription> Descriptions { get; set; } = new HashSet<FilterGroupDescription>();
    }
}
