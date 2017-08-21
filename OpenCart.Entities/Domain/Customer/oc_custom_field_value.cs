namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_custom_field_value")]
    public class oc_custom_field_value
    {
        [Key]
        public int custom_field_value_id { get; set; }

        public int custom_field_id { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
