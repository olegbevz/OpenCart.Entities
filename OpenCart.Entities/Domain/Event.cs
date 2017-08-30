namespace OpenCart.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_event")]
    public class Event : IEntityWithStatus
    {
        [Key]
		[Column("Id")]
        public int Id { get; set; }

        [Required, StringLength(32), Column("code")]
        public string Code { get; set; }

        [Required, StringLength(65535), Column("trigger", TypeName = "text")]
        public string Trigger { get; set; }

        [Required, StringLength(65535), Column("action", TypeName = "text")]
        public string Action { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
