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
        public int api_ip_id { get; set; }

		[Column("api_id")]
        public int api_id { get; set; }

        [Required]
        [StringLength(40)]
		[Column("ip")]
        public string ip { get; set; }
    }
}
