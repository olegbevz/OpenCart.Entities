namespace JustWatch.OpenCart
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_zone_to_geo_zone")]
    public class oc_zone_to_geo_zone
    {
        [Key]
        public int zone_to_geo_zone_id { get; set; }

        public int country_id { get; set; }

        public int zone_id { get; set; }

        public int geo_zone_id { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
