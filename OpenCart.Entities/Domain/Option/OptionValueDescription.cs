namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_option_value_description")]
    public class OptionValueDescription : Localizable, IEntityWithName
    {
        [Key]
        [Column("option_value_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OptionValueId { get; set; }

        [Column("option_id")]
        public int OptionId { get; set; }

        [Required]
        [StringLength(128)]
        [Column("name")]
        public string Name { get; set; }
    }
}
