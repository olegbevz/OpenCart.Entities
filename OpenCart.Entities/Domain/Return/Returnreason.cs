namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_return_reason")]
    public class ReturnReason : Localizable, IEntityWithName
    {
        [Key]
        [Column(Order = 0)]
        public int ReturnReasonId { get; set; }

        [Required]
        [StringLength(128)]
        [Column("name")]
        public string Name { get; set; }
    }
}
