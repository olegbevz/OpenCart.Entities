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
        public int Id { get; protected set; }

        [Column("country_id")]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        [Column("zone_id")]
        public int ZoneId { get; set; }

        public virtual Zone Zone { get; set; }

        [Column("geo_zone_id")]
        public int GeoZoneId { get; set; }

        public virtual GeoZone GeoZone { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
