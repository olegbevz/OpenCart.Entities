namespace JustWatch.OpenCart
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("oc_currency")]
    public class Currency
    {
        [Key, Column("currency_id")]
        public int Id { get; set; }

        [Required, StringLength(32), Column("title")]
        public string Title { get; set; }

        [Required, StringLength(3), Column("code")]
        public string Code { get; set; }

        [Required, StringLength(12), Column("symbol_left")]
        public string LeftSymbol { get; set; }

        [Required, StringLength(12), Column("symbol_right")]
        public string RightSymbol { get; set; }

        [Column("decimal_place", TypeName = "char"), Required, StringLength(1)]
        public string DecimalPlaces { get; set; }

        [Column("value")]
        public float Value { get; set; }
        
        [Column("status")]
        public bool Status { get; set; }

        [Column("date_modified")]
        public DateTime DateModified { get; set; }
    }
}
