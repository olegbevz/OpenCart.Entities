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
        public int Id { get; protected set; }

        [Required]
        [StringLength(32)]
        [Column("firstname")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(32)]
        [Column("lastname")]
        public string LastName { get; set; }

        [Required]
        [StringLength(96)]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [StringLength(32)]
        [Column("telephone")]
        public string Telephone { get; set; }

        [Required]
        [StringLength(32)]
        [Column("fax")]
        public string Fax { get; set; }

        [Required]
        [StringLength(40)]
        [Column("password")]
        public string Password { get; set; }

        [Required]
        [StringLength(9)]
        [Column("salt")]
        public string Salt { get; set; }

        [Required]
        [StringLength(40)]
        [Column("company")]
        public string Company { get; set; }

        [Required]
        [StringLength(255)]
        [Column("website")]
        public string Website { get; set; }

        [Required]
        [StringLength(128)]
        [Column("address_1")]
        public string Address1 { get; set; }

        [Required]
        [StringLength(128)]
        [Column("address_2")]
        public string Address2 { get; set; }

        [Required]
        [StringLength(128)]
        [Column("city")]
        public string City { get; set; }

        [Required]
        [StringLength(10)]
        [Column("postcode")]
        public string Postcode { get; set; }

        [Column("country_id")]
        public int CountryId { get; set; }

        [Column("zone_id")]
        public int ZoneId { get; set; }

        [Required]
        [StringLength(64)]
        [Column("code")]
        public string Code { get; set; }

        [Column("commission")]
        public decimal Commission { get; set; }

        [Required]
        [StringLength(64)]
        [Column("tax")]
        public string Tax { get; set; }

        [Required]
        [StringLength(6)]
        [Column("payment")]
        public string Payment { get; set; }

        [Required]
        [StringLength(100)]
        [Column("cheque")]
        public string Cheque { get; set; }

        [Required]
        [StringLength(64)]
        [Column("paypal")]
        public string Paypal { get; set; }

        [Required]
        [StringLength(64)]
        [Column("bank_name")]
        public string BankName { get; set; }

        [Required]
        [StringLength(64)]
        [Column("bank_branch_number")]
        public string BankBranchNumber { get; set; }

        [Required]
        [StringLength(64)]
        [Column("bank_swift_code")]
        public string BankSwiftCode { get; set; }

        [Required]
        [StringLength(64)]
        [Column("bank_account_name")]
        public string BankAccountName { get; set; }

        [Required]
        [StringLength(64)]
        [Column("bank_account_number")]
        public string BankAccountNumber { get; set; }

        [Required]
        [StringLength(40)]
        [Column("ip")]
        public string Ip { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("approved")]
        public bool Approved { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        public virtual Country Country { get; set; }

        public virtual Zone Zone { get; set; }

        public virtual ICollection<AffiliateActivity> AffiliateActivities { get; set; } = new HashSet<AffiliateActivity>();

        public virtual ICollection<AffiliateTransaction> AffiliateTransactions { get; set; } = new HashSet<AffiliateTransaction>();

        public virtual ICollection<Order> Order { get; set; } = new HashSet<Order>();
    }
}
