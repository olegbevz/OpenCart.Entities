using System.Collections.Generic;

namespace OpenCart.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_api")]
    public class Api : IEntityWithName, IEntityWithStatus
    {
        [Key]
        [Column("api_id")]
        public int Id { get; protected set; }

        [Required]
        [StringLength(64)]
        [Column("name")]
        public string Name { get; set; }

        [Column("key", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Key { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }

        public virtual ICollection<ApiIp> IpAddresses { get; set; } = new HashSet<ApiIp>();

        public virtual ICollection<ApiSession> Sessions { get; set; } = new HashSet<ApiSession>();
    }
}
