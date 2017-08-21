namespace JustWatch.OpenCart
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer_login")]
    public class oc_customer_login
    {
        [Key]
        public int customer_login_id { get; set; }

        [Required]
        [StringLength(96)]
        public string email { get; set; }

        [Required]
        [StringLength(40)]
        public string ip { get; set; }

        public int total { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
