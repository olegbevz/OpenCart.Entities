using System.Data.Entity.ModelConfiguration;

namespace OpenCart.Entities
{
    internal class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasRequired(x => x.Group).WithMany(x => x.Users).HasForeignKey(x => x.GroupId);
        }
    }
}
