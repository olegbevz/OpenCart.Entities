namespace JustWatch.OpenCart
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_api_session")]
    public class oc_api_session
    {
        [Key]
        public int api_session_id { get; set; }

        public int api_id { get; set; }

        [Required]
        [StringLength(32)]
        public string token { get; set; }

        [Required]
        [StringLength(32)]
        public string session_id { get; set; }

        [Required]
        [StringLength(32)]
        public string session_name { get; set; }

        [Required]
        [StringLength(40)]
        public string ip { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
