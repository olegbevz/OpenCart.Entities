namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_affiliate_login")]
    public class AffiliateLogin
    {
        [Key]
		[Column("affiliate_login_id")]
        public int affiliate_login_id { get; set; }

        [Required]
        [StringLength(96)]
		[Column("email")]
        public string email { get; set; }

        [Required]
        [StringLength(40)]
		[Column("ip")]
        public string ip { get; set; }

		[Column("total")]
        public int total { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
