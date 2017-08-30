namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_custom_field_value")]
    public class CustomFieldValue
    {
        [Key]
        [Column("custom_field_value_id")]
        public int Id { get; set; }

        [Column("custom_field_id")]
        public int CustomFieldId { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
