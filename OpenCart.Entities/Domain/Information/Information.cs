namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_information")]
    public class Information : IEntityWithStatus
    {
        [Key]
        [Column("information_id")]
        public int Id { get; protected set; }

        [Column("bottom")]
        public int Bottom { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }

        [Column("status")]
        public bool Status { get; set; }
    }
}
