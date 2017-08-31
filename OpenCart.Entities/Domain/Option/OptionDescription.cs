namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_option_description")]
    public class OptionDescription : Localizable, IEntityWithName
    {
        [Key]
        [Column("option_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OptionId { get; set; }

        public virtual Option Option { get; set; }

        [Required]
        [StringLength(128)]
        [Column("name")]
        public string Name { get; set; }
    }
}
