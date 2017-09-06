namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_return_action")]
    public class ReturnAction : IEntityWithName, ILocalizable
    {
        [Key]
        [Column("return_action_id", Order = 0)]
        public int Id { get; protected set; }

        [Required]
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }

        [Column("language_id", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }
    }
}
