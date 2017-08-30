namespace OpenCart.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_api_session")]
    public class ApiSession
    {
        [Key]
		[Column("api_session_id")]
        public int api_session_id { get; set; }

		[Column("api_id")]
        public int api_id { get; set; }

        [Required]
        [StringLength(32)]
		[Column("token")]
        public string token { get; set; }

        [Required]
        [StringLength(32)]
		[Column("session_id")]
        public string session_id { get; set; }

        [Required]
        [StringLength(32)]
		[Column("session_name")]
        public string session_name { get; set; }

        [Required]
        [StringLength(40)]
		[Column("ip")]
        public string ip { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
