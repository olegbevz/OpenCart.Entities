namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order")]
    public class Order
    {
        [Key]
		[Column("order_id")]
        public int order_id { get; set; }

		[Column("invoice_no")]
        public int invoice_no { get; set; }

        [Required]
        [StringLength(26)]
		[Column("invoice_prefix")]
        public string invoice_prefix { get; set; }

		[Column("store_id")]
        public int store_id { get; set; }

        [Required]
        [StringLength(64)]
		[Column("store_name")]
        public string store_name { get; set; }

        [Required]
        [StringLength(255)]
		[Column("store_url")]
        public string store_url { get; set; }

		[Column("customer_id")]
        public int customer_id { get; set; }

		[Column("customer_group_id")]
        public int customer_group_id { get; set; }

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

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string custom_field { get; set; }

        [Required]
        [StringLength(32)]
		[Column("payment_firstname")]
        public string payment_firstname { get; set; }

        [Required]
        [StringLength(32)]
		[Column("payment_lastname")]
        public string payment_lastname { get; set; }

        [Required]
        [StringLength(60)]
		[Column("payment_company")]
        public string payment_company { get; set; }

        [Required]
        [StringLength(128)]
		[Column("payment_address_1")]
        public string payment_address_1 { get; set; }

        [Required]
        [StringLength(128)]
		[Column("payment_address_2")]
        public string payment_address_2 { get; set; }

        [Required]
        [StringLength(128)]
		[Column("payment_city")]
        public string payment_city { get; set; }

        [Required]
        [StringLength(10)]
		[Column("payment_postcode")]
        public string payment_postcode { get; set; }

        [Required]
        [StringLength(128)]
		[Column("payment_country")]
        public string payment_country { get; set; }

		[Column("payment_country_id")]
        public int payment_country_id { get; set; }

        [Required]
        [StringLength(128)]
		[Column("payment_zone")]
        public string payment_zone { get; set; }

		[Column("payment_zone_id")]
        public int payment_zone_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string payment_address_format { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string payment_custom_field { get; set; }

        [Required]
        [StringLength(128)]
		[Column("payment_method")]
        public string payment_method { get; set; }

        [Required]
        [StringLength(128)]
		[Column("payment_code")]
        public string payment_code { get; set; }

        [Required]
        [StringLength(32)]
		[Column("shipping_firstname")]
        public string shipping_firstname { get; set; }

        [Required]
        [StringLength(32)]
		[Column("shipping_lastname")]
        public string shipping_lastname { get; set; }

        [Required]
        [StringLength(40)]
		[Column("shipping_company")]
        public string shipping_company { get; set; }

        [Required]
        [StringLength(128)]
		[Column("shipping_address_1")]
        public string shipping_address_1 { get; set; }

        [Required]
        [StringLength(128)]
		[Column("shipping_address_2")]
        public string shipping_address_2 { get; set; }

        [Required]
        [StringLength(128)]
		[Column("shipping_city")]
        public string shipping_city { get; set; }

        [Required]
        [StringLength(10)]
		[Column("shipping_postcode")]
        public string shipping_postcode { get; set; }

        [Required]
        [StringLength(128)]
		[Column("shipping_country")]
        public string shipping_country { get; set; }

		[Column("shipping_country_id")]
        public int shipping_country_id { get; set; }

        [Required]
        [StringLength(128)]
		[Column("shipping_zone")]
        public string shipping_zone { get; set; }

		[Column("shipping_zone_id")]
        public int shipping_zone_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string shipping_address_format { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string shipping_custom_field { get; set; }

        [Required]
        [StringLength(128)]
		[Column("shipping_method")]
        public string shipping_method { get; set; }

        [Required]
        [StringLength(128)]
		[Column("shipping_code")]
        public string shipping_code { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string comment { get; set; }

        public decimal total { get; set; }

		[Column("order_status_id")]
        public int order_status_id { get; set; }

		[Column("affiliate_id")]
        public int affiliate_id { get; set; }

        public decimal commission { get; set; }

		[Column("marketing_id")]
        public int marketing_id { get; set; }

        [Required]
        [StringLength(64)]
		[Column("tracking")]
        public string tracking { get; set; }

        [Column("language_id")]
        public int LanguageId { get; set; }

		[Column("currency_id")]
        public int currency_id { get; set; }

        [Required]
        [StringLength(3)]
		[Column("currency_code")]
        public string currency_code { get; set; }

        public decimal currency_value { get; set; }

        [Required]
        [StringLength(40)]
		[Column("ip")]
        public string ip { get; set; }

        [Required]
        [StringLength(40)]
		[Column("forwarded_ip")]
        public string forwarded_ip { get; set; }

        [Required]
        [StringLength(255)]
		[Column("user_agent")]
        public string user_agent { get; set; }

        [Required]
        [StringLength(255)]
		[Column("accept_language")]
        public string accept_language { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
