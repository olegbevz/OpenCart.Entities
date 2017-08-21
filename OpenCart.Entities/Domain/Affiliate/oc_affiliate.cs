namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_affiliate")]
    public class oc_affiliate
    {
        [Key]
        public int affiliate_id { get; set; }

        [Required]
        [StringLength(32)]
        public string firstname { get; set; }

        [Required]
        [StringLength(32)]
        public string lastname { get; set; }

        [Required]
        [StringLength(96)]
        public string email { get; set; }

        [Required]
        [StringLength(32)]
        public string telephone { get; set; }

        [Required]
        [StringLength(32)]
        public string fax { get; set; }

        [Required]
        [StringLength(40)]
        public string password { get; set; }

        [Required]
        [StringLength(9)]
        public string salt { get; set; }

        [Required]
        [StringLength(40)]
        public string company { get; set; }

        [Required]
        [StringLength(255)]
        public string website { get; set; }

        [Required]
        [StringLength(128)]
        public string address_1 { get; set; }

        [Required]
        [StringLength(128)]
        public string address_2 { get; set; }

        [Required]
        [StringLength(128)]
        public string city { get; set; }

        [Required]
        [StringLength(10)]
        public string postcode { get; set; }

        public int country_id { get; set; }

        public int zone_id { get; set; }

        [Required]
        [StringLength(64)]
        [Column("code")]
        public string Code { get; set; }

        public decimal commission { get; set; }

        [Required]
        [StringLength(64)]
        public string tax { get; set; }

        [Required]
        [StringLength(6)]
        public string payment { get; set; }

        [Required]
        [StringLength(100)]
        public string cheque { get; set; }

        [Required]
        [StringLength(64)]
        public string paypal { get; set; }

        [Required]
        [StringLength(64)]
        public string bank_name { get; set; }

        [Required]
        [StringLength(64)]
        public string bank_branch_number { get; set; }

        [Required]
        [StringLength(64)]
        public string bank_swift_code { get; set; }

        [Required]
        [StringLength(64)]
        public string bank_account_name { get; set; }

        [Required]
        [StringLength(64)]
        public string bank_account_number { get; set; }

        [Required]
        [StringLength(40)]
        public string ip { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        public bool approved { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
