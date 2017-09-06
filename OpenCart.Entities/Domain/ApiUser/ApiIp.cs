namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_api_ip")]
    public class ApiIp
    {
        [Key]
        [Column("api_ip_id")]
        public int Id { get; protected set; }

        [Column("api_id")]
        public int ApiId { get; set; }

        public virtual Api Api { get; set; }

        [Required]
        [StringLength(40)]
        [Column("ip")]
        public string Ip { get; set; }
    }
}
