namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_order")]
    public class oc_order
    {
        [Key]
        public int order_id { get; set; }

        public int invoice_no { get; set; }

        [Required]
        [StringLength(26)]
        public string invoice_prefix { get; set; }

        public int store_id { get; set; }

        [Required]
        [StringLength(64)]
        public string store_name { get; set; }

        [Required]
        [StringLength(255)]
        public string store_url { get; set; }

        public int customer_id { get; set; }

        public int customer_group_id { get; set; }

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

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string custom_field { get; set; }

        [Required]
        [StringLength(32)]
        public string payment_firstname { get; set; }

        [Required]
        [StringLength(32)]
        public string payment_lastname { get; set; }

        [Required]
        [StringLength(60)]
        public string payment_company { get; set; }

        [Required]
        [StringLength(128)]
        public string payment_address_1 { get; set; }

        [Required]
        [StringLength(128)]
        public string payment_address_2 { get; set; }

        [Required]
        [StringLength(128)]
        public string payment_city { get; set; }

        [Required]
        [StringLength(10)]
        public string payment_postcode { get; set; }

        [Required]
        [StringLength(128)]
        public string payment_country { get; set; }

        public int payment_country_id { get; set; }

        [Required]
        [StringLength(128)]
        public string payment_zone { get; set; }

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
        public string payment_method { get; set; }

        [Required]
        [StringLength(128)]
        public string payment_code { get; set; }

        [Required]
        [StringLength(32)]
        public string shipping_firstname { get; set; }

        [Required]
        [StringLength(32)]
        public string shipping_lastname { get; set; }

        [Required]
        [StringLength(40)]
        public string shipping_company { get; set; }

        [Required]
        [StringLength(128)]
        public string shipping_address_1 { get; set; }

        [Required]
        [StringLength(128)]
        public string shipping_address_2 { get; set; }

        [Required]
        [StringLength(128)]
        public string shipping_city { get; set; }

        [Required]
        [StringLength(10)]
        public string shipping_postcode { get; set; }

        [Required]
        [StringLength(128)]
        public string shipping_country { get; set; }

        public int shipping_country_id { get; set; }

        [Required]
        [StringLength(128)]
        public string shipping_zone { get; set; }

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
        public string shipping_method { get; set; }

        [Required]
        [StringLength(128)]
        public string shipping_code { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string comment { get; set; }

        public decimal total { get; set; }

        public int order_status_id { get; set; }

        public int affiliate_id { get; set; }

        public decimal commission { get; set; }

        public int marketing_id { get; set; }

        [Required]
        [StringLength(64)]
        public string tracking { get; set; }

        [Column("language_id")]
        public int LanguageId { get; set; }

        public int currency_id { get; set; }

        [Required]
        [StringLength(3)]
        public string currency_code { get; set; }

        public decimal currency_value { get; set; }

        [Required]
        [StringLength(40)]
        public string ip { get; set; }

        [Required]
        [StringLength(40)]
        public string forwarded_ip { get; set; }

        [Required]
        [StringLength(255)]
        public string user_agent { get; set; }

        [Required]
        [StringLength(255)]
        public string accept_language { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
