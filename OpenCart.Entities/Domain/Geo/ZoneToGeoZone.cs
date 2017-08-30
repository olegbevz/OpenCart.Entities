namespace OpenCart.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_zone_to_geo_zone")]
    public class ZoneToGeoZone
    {
        [Key]
		[Column("zone_to_geo_zone_id")]
        public int zone_to_geo_zone_id { get; set; }

		[Column("country_id")]
        public int country_id { get; set; }

		[Column("zone_id")]
        public int zone_id { get; set; }

		[Column("geo_zone_id")]
        public int geo_zone_id { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
