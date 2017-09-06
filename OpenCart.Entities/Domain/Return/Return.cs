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
        public int Id { get; protected set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        [Column("product_id")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [Required]
        [StringLength(32)]
        [Column("firstname")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(32)]
        [Column("lastname")]
        public string LastName { get; set; }

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
        public string ProductName { get; set; }

        [Required]
        [StringLength(64)]
        [Column("model")]
        public string Model { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }

        [Column("opened")]
        public bool Opened { get; set; }

        [Column("return_reason_id")]
        [ForeignKey("ReturnReason")]
        public int ReturnReasonId { get; set; }

        public virtual ReturnReason ReturnReason { get; set; }

        [Column("return_action_id")]
        [ForeignKey("ReturnAction")]
        public int ReturnActionId { get; set; }
        
        public virtual ReturnAction ReturnAction { get; set; }

        [Column("return_status_id")]
        [ForeignKey("ReturnStatus")]
        public int ReturnStatusId { get; set; }

        public virtual ReturnStatus ReturnStatus { get; set; }

        [Column("comment", TypeName = "text")]
        [StringLength(65535)]
        public string Comment { get; set; }

        [Column("date_ordered", TypeName = "date")]
        public DateTime DateOrdered { get; set; }

        [Column("date_added")]
        public DateTime DateAdded { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }

        public virtual ICollection<ReturnHistory> History { get; set; } = new HashSet<ReturnHistory>();
    }
}
