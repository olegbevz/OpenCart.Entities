namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_address")]
    public class Address
    {
        [Key]
        [Column("address_id")]
        public int AddressId { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(32)]
        [Column("firstname")]
        public string Firstname { get; set; }

        [Required]
        [StringLength(32)]
        [Column("lastname")]
        public string Lastname { get; set; }

        [Required]
        [StringLength(40)]
        [Column("company")]
        public string Company { get; set; }

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

        [Column("custom_field", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string CustomField { get; set; }
    }
}
