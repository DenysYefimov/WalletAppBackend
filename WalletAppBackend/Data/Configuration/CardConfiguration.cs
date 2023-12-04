using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WalletAppBackend.Data.Entities;

namespace WalletAppBackend.Data.Configuration
{
    public class CardConfiguration : BaseEntityConfiguration<Card>
    {
        public override void Configure(EntityTypeBuilder<Card> builder)
        {
            base.Configure(builder);
            builder.HasMany(c => c.Users).WithMany(u => u.Cards);
        }
    }
}
