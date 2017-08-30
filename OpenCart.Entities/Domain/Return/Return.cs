namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_return")]
    public class Return
    {
        [Key]
        [Column("return_id")]
        public int Id { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

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
        [StringLength(255)]
        [Column("product")]
        public string Product { get; set; }

        [Required]
        [StringLength(64)]
        [Column("model")]
        public string Model { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        public bool opened { get; set; }

        [Column("return_reason_id")]
        public int ReturnReasonId { get; set; }

        [Column("return_action_id")]
        public int ReturnActionId { get; set; }

        [Column("return_status_id")]
        public int ReturnStatusId { get; set; }

        [Column("comment", TypeName = "text")]
        [StringLength(65535)]
        public string Comment { get; set; }

        [Column("date_ordered", TypeName = "date")]
        public DateTime DateOrdered { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
