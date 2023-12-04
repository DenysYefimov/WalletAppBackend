using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WalletAppBackend.Data.Entities;

namespace WalletAppBackend.Data.Configuration
{
    public class UserConfiguration : BaseNamedEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
        }
    }
}
