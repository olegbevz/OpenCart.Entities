using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace OpenCart.Entities.Mappings
{
    internal class InformationMapping : EntityTypeConfiguration<Information>
    {
        public InformationMapping()
        {
            HasMany(x => x.Stores)
            .WithMany()
            .Map(x => x.ToTable("oc_information_to_store")
            .MapLeftKey("information_id")
            .MapRightKey("store_id"));
        }
    }
}
