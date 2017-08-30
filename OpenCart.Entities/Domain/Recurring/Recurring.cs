namespace OpenCart.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oc_recurring")]
    public class Recurring
    {
        [Key]
        [Column("recurring_id")]
        public int RecurringId { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("frequency", TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string Frequency { get; set; }

        [Column("duration", TypeName = "uint")]
        public long Duration { get; set; }

        [Column("cycle", TypeName = "uint")]
        public long Cycle { get; set; }

        [Column("trial_status")]
        public sbyte TrialStatus { get; set; }

        [Column("trial_price")]
        public decimal TrialPrice { get; set; }

        [Column("trial_frequency", TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string TrialFrequency { get; set; }

        [Column("trial_duration", TypeName = "uint")]
        public long TrialDuration { get; set; }

        [Column("trial_cycle", TypeName = "uint")]
        public long TrialCycle { get; set; }

        [Column("status")]
        public sbyte Status { get; set; }

        [Column("sort_order")]
        public int SortOrder { get; set; }
    }
}
