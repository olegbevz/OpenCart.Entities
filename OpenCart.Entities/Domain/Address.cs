namespace OpenCart.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_address")]
    public class Address
    {
        [Key]
		[Column("address_id")]
        public int address_id { get; set; }

		[Column("customer_id")]
        public int customer_id { get; set; }

        [Required]
        [StringLength(32)]
		[Column("firstname")]
        public string firstname { get; set; }

        [Required]
        [StringLength(32)]
		[Column("lastname")]
        public string lastname { get; set; }

        [Required]
        [StringLength(40)]
		[Column("company")]
        public string company { get; set; }

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

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string custom_field { get; set; }
    }
}
