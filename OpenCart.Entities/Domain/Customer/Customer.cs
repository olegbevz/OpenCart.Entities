namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer")]
    public class Customer : IEntityWithStatus
    {
        [Key]
		[Column("customer_id")]
        public int customer_id { get; set; }

		[Column("customer_group_id")]
        public int customer_group_id { get; set; }

		[Column("store_id")]
        public int store_id { get; set; }

        [Column("language_id")]
        public int LanguageId { get; set; }

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

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string cart { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string wishlist { get; set; }

        public bool newsletter { get; set; }

		[Column("address_id")]
        public int address_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string custom_field { get; set; }

        [Required]
        [StringLength(40)]
		[Column("ip")]
        public string ip { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        public bool approved { get; set; }

        public bool safe { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string token { get; set; }

        [Required]
        [StringLength(40)]
        [Column("code")]
        public string Code { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
