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
        public int order_custom_field_id { get; set; }

        public int order_id { get; set; }

        public int custom_field_id { get; set; }

        public int custom_field_value_id { get; set; }

        [Required]
        [StringLength(255)]
        [Column("name")]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string value { get; set; }

        [Required]
        [StringLength(32)]
        public string type { get; set; }

        [Required]
        [StringLength(16)]
        public string location { get; set; }
    }
}
