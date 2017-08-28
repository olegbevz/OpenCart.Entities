namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_voucher_theme")]
    public class VoucherTheme
    {
        [Key]
        public int voucher_theme_id { get; set; }

        [Required]
        [StringLength(255)]
        public string image { get; set; }
    }
}
