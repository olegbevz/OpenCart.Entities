namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_customer")]
    public class Customer : Localizable, IEntityWithStatus
    {
        [Key]
        [Column("customer_id")]
        public int Id { get; protected set; }

        [Column("customer_group_id")]
        public int CustomerGroupId { get; set; }

        public virtual CustomerGroup CustomerGroup { get; set; }

        [Column("store_id")]
        public int StoreId { get; set; }

        public virtual Store Store { get; set; }

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

        [Column("cart", TypeName = "text")]
        [StringLength(65535)]
        public string Cart { get; set; }

        [Column("wishlist", TypeName = "text")]
        [StringLength(65535)]
        public string Wishlist { get; set; }

        [Column("newsletter")]
        public bool NewsLetter { get; set; }

        [Column("address_id")]
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        [Column("custom_field", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string CustomField { get; set; }

        [Required]
        [StringLength(40)]
        [Column("ip")]
        public string Ip { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("approved")]
        public bool Approved { get; set; }

        [Column("safe")]
        public bool Safe { get; set; }

        [Column("token", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Token { get; set; }

        [Required]
        [StringLength(40)]
        [Column("code")]
        public string Code { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
