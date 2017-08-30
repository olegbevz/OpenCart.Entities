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
        public int OrderId { get; set; }

        [Column("invoice_no")]
        public int InvoiceNo { get; set; }

        [Required]
        [StringLength(26)]
        [Column("invoice_prefix")]
        public string InvoicePrefix { get; set; }

        [Column("store_id")]
        public int StoreId { get; set; }

        [Required]
        [StringLength(64)]
        [Column("store_name")]
        public string StoreName { get; set; }

        [Required]
        [StringLength(255)]
        [Column("store_url")]
        public string StoreUrl { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("customer_group_id")]
        public int CustomerGroupId { get; set; }

        [Required]
        [StringLength(32)]
        [Column("firstname")]
        public string Firstname { get; set; }

        [Required]
        [StringLength(32)]
        [Column("lastname")]
        public string Lastname { get; set; }

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

        [Column("custom_field", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string CustomField { get; set; }

        [Required]
        [StringLength(32)]
        [Column("payment_firstname")]
        public string PaymentFirstname { get; set; }

        [Required]
        [StringLength(32)]
        [Column("payment_lastname")]
        public string PaymentLastname { get; set; }

        [Required]
        [StringLength(60)]
        [Column("payment_company")]
        public string PaymentCompany { get; set; }

        [Required]
        [StringLength(128)]
        [Column("payment_address_1")]
        public string PaymentAddress1 { get; set; }

        [Required]
        [StringLength(128)]
        [Column("payment_address_2")]
        public string PaymentAddress2 { get; set; }

        [Required]
        [StringLength(128)]
        [Column("payment_city")]
        public string PaymentCity { get; set; }

        [Required]
        [StringLength(10)]
        [Column("payment_postcode")]
        public string PaymentPostcode { get; set; }

        [Required]
        [StringLength(128)]
        [Column("payment_country")]
        public string PaymentCountry { get; set; }

        [Column("payment_country_id")]
        public int PaymentCountryId { get; set; }

        [Required]
        [StringLength(128)]
        [Column("payment_zone")]
        public string PaymentZone { get; set; }

        [Column("payment_zone_id")]
        public int PaymentZoneId { get; set; }

        [Column("payment_address_format", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string PaymentAddressFormat { get; set; }

        [Column("payment_custom_field", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string PaymentCustomField { get; set; }

        [Required]
        [StringLength(128)]
        [Column("payment_method")]
        public string PaymentMethod { get; set; }

        [Required]
        [StringLength(128)]
        [Column("payment_code")]
        public string PaymentCode { get; set; }

        [Required]
        [StringLength(32)]
        [Column("shipping_firstname")]
        public string ShippingFirstname { get; set; }

        [Required]
        [StringLength(32)]
        [Column("shipping_lastname")]
        public string ShippingLastname { get; set; }

        [Required]
        [StringLength(40)]
        [Column("shipping_company")]
        public string ShippingCompany { get; set; }

        [Required]
        [StringLength(128)]
        [Column("shipping_address_1")]
        public string ShippingAddress1 { get; set; }

        [Required]
        [StringLength(128)]
        [Column("shipping_address_2")]
        public string ShippingAddress2 { get; set; }

        [Required]
        [StringLength(128)]
        [Column("shipping_city")]
        public string ShippingCity { get; set; }

        [Required]
        [StringLength(10)]
        [Column("shipping_postcode")]
        public string ShippingPostcode { get; set; }

        [Required]
        [StringLength(128)]
        [Column("shipping_country")]
        public string ShippingCountry { get; set; }

        [Column("shipping_country_id")]
        public int ShippingCountryId { get; set; }

        [Required]
        [StringLength(128)]
        [Column("shipping_zone")]
        public string ShippingZone { get; set; }

        [Column("shipping_zone_id")]
        public int ShippingZoneId { get; set; }

        [Column("shipping_address_format", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string ShippingAddressFormat { get; set; }

        [Column("shipping_custom_field", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string ShippingCustomField { get; set; }

        [Required]
        [StringLength(128)]
        [Column("shipping_method")]
        public string ShippingMethod { get; set; }

        [Required]
        [StringLength(128)]
        [Column("shipping_code")]
        public string ShippingCode { get; set; }

        [Column("comment", TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string Comment { get; set; }

        [Column("total")]
        public decimal Total { get; set; }

        [Column("order_status_id")]
        public int OrderStatusId { get; set; }

        [Column("affiliate_id")]
        public int AffiliateId { get; set; }

        [Column("commission")]
        public decimal Commission { get; set; }

        [Column("marketing_id")]
        public int MarketingId { get; set; }

        [Required]
        [StringLength(64)]
        [Column("tracking")]
        public string Tracking { get; set; }

        [Column("language_id")]
        public int LanguageId { get; set; }

        [Column("currency_id")]
        public int CurrencyId { get; set; }

        [Required]
        [StringLength(3)]
        [Column("currency_code")]
        public string CurrencyCode { get; set; }

        [Column("currency_value")]
        public decimal CurrencyValue { get; set; }

        [Required]
        [StringLength(40)]
        [Column("ip")]
        public string Ip { get; set; }

        [Required]
        [StringLength(40)]
        [Column("forwarded_ip")]
        public string ForwardedIp { get; set; }

        [Required]
        [StringLength(255)]
        [Column("user_agent")]
        public string UserAgent { get; set; }

        [Required]
        [StringLength(255)]
        [Column("accept_language")]
        public string AcceptLanguage { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
