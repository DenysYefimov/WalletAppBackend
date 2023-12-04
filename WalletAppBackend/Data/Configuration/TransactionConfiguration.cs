using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WalletAppBackend.Common;
using WalletAppBackend.Data.Entities;

namespace WalletAppBackend.Data.Configuration
{
    public class TransactionConfiguration : BaseNamedEntityConfiguration<Transaction>
    {
        public override void Configure(EntityTypeBuilder<Transaction> builder)
        {
            base.Configure(builder);
            builder.Property(t => t.Description).HasMaxLength(Constants.Data.TransactionEntity.DescriptionMaxLength);
            builder.HasOne(t => t.User).WithMany(u => u.Transactions).HasForeignKey(t => t.UserId);
            builder.HasOne(t => t.Card).WithMany(c => c.Transactions).HasForeignKey(t => t.CardId);
        }
    }
}
