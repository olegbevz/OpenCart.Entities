namespace OpenCart.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_user")]
    public class User : IEntityWithStatus
    {
        [Key, Column("user_id")]
        public int Id { get; protected set; }

        [Column("user_group_id")]
        public int GroupId { get; set; }

        public virtual UserGroup Group { get; set; }

        [Required, StringLength(20), Column("username")]
        public string UserName { get; set; }

        [Required, StringLength(40), Column("password")]
        public string Password { get; set; }

        [Required, StringLength(9), Column("salt")]
        public string PasswordSalt { get; set; }

        [Required, StringLength(32), Column("firstname")]
        public string FirstName { get; set; }

        [Required, StringLength(32), Column("lastname")]
        public string LastName { get; set; }

        [Required, StringLength(96), Column("email")]
        public string Email { get; set; }

        [Required, StringLength(255), Column("image")]
        public string Image { get; set; }

        [Required, StringLength(40), Column("code")]
        public string Code { get; set; }

        [Required, StringLength(40), Column("ip")]
        public string IP { get; set; }

        [Column("status")]
        public bool Status { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }
    }
}
