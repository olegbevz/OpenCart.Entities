namespace JustWatch.OpenCart
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_country")]
    public class Country
    {
        [Key, Column("country_id")]
        public int Id { get; set; }

        [Required, StringLength(128), Column("name")]
        public string Name { get; set; }

        [Required, StringLength(2), Column("iso_code_2")]
        public string IsoCode2 { get; set; }

        [Required, StringLength(3), Column("iso_code_3")]
        public string IsoCode3 { get; set; }

        [Required, StringLength(65535), Column("address_format", TypeName = "text")]
        public string AddressFormat { get; set; }

        [Column("postcode_required")]
        public bool PostcodeRequired { get; set; }

        [Column("status")]
        public bool Status { get; set; }
    }
}
