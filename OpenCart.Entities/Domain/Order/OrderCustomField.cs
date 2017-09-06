namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order_custom_field")]
    public class OrderCustomField : IEntityWithName
    {
        [Key]
        [Column("order_custom_field_id")]
        public int Id { get; protected set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        [Column("custom_field_id")]
        public int CustomFieldId { get; set; }

        public virtual CustomField CustomField { get; set; }

        [Column("custom_field_value_id")]
        public int CustomFieldValueId { get; set; }

        public virtual CustomFieldValue CustomFieldValue { get; set; }

        [Required]
        [StringLength(255)]
        [Column("name")]
        public string Name { get; set; }

        [Column("value", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Value { get; set; }

        [Required]
        [StringLength(32)]
        [Column("type")]
        public string Type { get; set; }

        [Required]
        [StringLength(16)]
        [Column("location")]
        public string Location { get; set; }
    }
}
