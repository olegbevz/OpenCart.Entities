namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_affiliate")]
    public class Affiliate : IEntityWithStatus
    {
        [Key]
		[Column("affiliate_id")]
        public int affiliate_id { get; set; }

        [Required]
        [StringLength(32)]
		[Column("firstname")]
        public string firstname { get; set; }

        [Required]
        [StringLength(32)]
		[Column("lastname")]
        public string lastname { get; set; }

        [Required]
        [StringLength(96)]
		[Column("email")]
        public string email { get; set; }

        [Required]
        [StringLength(32)]
		[Column("telephone")]
        public string telephone { get; set; }

        [Required]
        [StringLength(32)]
		[Column("fax")]
        public string fax { get; set; }

        [Required]
        [StringLength(40)]
		[Column("password")]
        public string password { get; set; }

        [Required]
        [StringLength(9)]
		[Column("salt")]
        public string salt { get; set; }

        [Required]
        [StringLength(40)]
		[Column("company")]
        public string company { get; set; }

        [Required]
        [StringLength(255)]
		[Column("website")]
        public string website { get; set; }

        [Required]
        [StringLength(128)]
		[Column("address_1")]
        public string address_1 { get; set; }

        [Required]
        [StringLength(128)]
		[Column("address_2")]
        public string address_2 { get; set; }

        [Required]
        [StringLength(128)]
		[Column("city")]
        public string city { get; set; }

        [Required]
        [StringLength(10)]
		[Column("postcode")]
        public string postcode { get; set; }

		[Column("country_id")]
        public int country_id { get; set; }

		[Column("zone_id")]
        public int zone_id { get; set; }

        [Required]
        [StringLength(64)]
        [Column("code")]
        public string Code { get; set; }

        public decimal commission { get; set; }

        [Required]
        [StringLength(64)]
		[Column("tax")]
        public string tax { get; set; }

        [Required]
        [StringLength(6)]
		[Column("payment")]
        public string payment { get; set; }

        [Required]
        [StringLength(100)]
		[Column("cheque")]
        public string cheque { get; set; }

        [Required]
        [StringLength(64)]
		[Column("paypal")]
        public string paypal { get; set; }

        [Required]
        [StringLength(64)]
		[Column("bank_name")]
        public string bank_name { get; set; }

        [Required]
        [StringLength(64)]
		[Column("bank_branch_number")]
        public string bank_branch_number { get; set; }

        [Required]
        [StringLength(64)]
		[Column("bank_swift_code")]
        public string bank_swift_code { get; set; }

        [Required]
        [StringLength(64)]
		[Column("bank_account_name")]
        public string bank_account_name { get; set; }

        [Required]
        [StringLength(64)]
		[Column("bank_account_number")]
        public string bank_account_number { get; set; }

        [Required]
        [StringLength(40)]
		[Column("ip")]
        public string ip { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        public bool approved { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
