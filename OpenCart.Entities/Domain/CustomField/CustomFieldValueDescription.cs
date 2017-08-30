namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_custom_field_value_description")]
    public class CustomFieldValueDescription : Localizable, IEntityWithName
    {
        [Key]
        [Column("custom_field_value_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomFieldValueId { get; set; }

        [Column("custom_field_id")]
        public int CustomFieldId { get; set; }

        [Required]
        [StringLength(128)]
        [Column("name")]
        public string Name { get; set; }
    }
}
