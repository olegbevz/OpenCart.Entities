using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace OpenCart.Entities.Mappings
{
    internal class CouponMapping : EntityTypeConfiguration<Coupon>
    {
        public CouponMapping()
        {
            HasMany(x => x.Categories)
             .WithMany(x => x.Coupons)
             .Map(x => x.ToTable("oc_coupon_category")
             .MapLeftKey("category_id")
             .MapRightKey("filter_id"));
        }
    }
}
