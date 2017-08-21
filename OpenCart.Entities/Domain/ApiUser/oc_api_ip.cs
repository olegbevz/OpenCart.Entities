namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_api_ip")]
    public class oc_api_ip
    {
        [Key]
        public int api_ip_id { get; set; }

        public int api_id { get; set; }

        [Required]
        [StringLength(40)]
        public string ip { get; set; }
    }
}
