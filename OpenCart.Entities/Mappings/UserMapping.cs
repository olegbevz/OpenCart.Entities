using System.Data.Entity.ModelConfiguration;

namespace JustWatch.OpenCart
{
    internal class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasRequired(x => x.Group).WithMany(x => x.Users).HasForeignKey(x => x.GroupId);
        }
    }
}
