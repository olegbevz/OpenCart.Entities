using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace OpenCart.Entities.Mappings
{
    internal class TaxRateMapping : EntityTypeConfiguration<TaxRate>
    {
        public TaxRateMapping()
        {
            HasMany(x => x.CustomerGroups)
            .WithMany()
            .Map(x => x.ToTable("oc_tax_rate_to_customer_group")
            .MapLeftKey("tax_rate_id")
            .MapRightKey("customer_group_id"));
        }
    }
}
