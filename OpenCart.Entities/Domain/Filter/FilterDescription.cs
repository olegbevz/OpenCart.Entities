namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_filter_description")]
    public class FilterDescription : Localizable, IEntityWithName
    {
        [Key]
        [Column("filter_id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FilterId { get; set; }

        [Column("filter_group_id")]
        public int FilterGroupId { get; set; }

        [Required]
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }
    }
}
