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
        public int Id { get; protected set; }

        [Column("api_id")]
        public int ApiId { get; set; }

        [Required]
        [StringLength(32)]
        [Column("token")]
        public string Token { get; set; }

        [Required]
        [StringLength(32)]
        [Column("session_id")]
        public string SessionId { get; set; }

        [Required]
        [StringLength(32)]
        [Column("session_name")]
        public string SessionName { get; set; }

        [Required]
        [StringLength(40)]
        [Column("ip")]
        public string Ip { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
