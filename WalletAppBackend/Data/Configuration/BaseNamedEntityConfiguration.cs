using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WalletAppBackend.Common;
using WalletAppBackend.Data.Entities;

namespace WalletAppBackend.Data.Configuration
{
    public class BaseNamedEntityConfiguration<TNamedEntity> : BaseEntityConfiguration<TNamedEntity> where TNamedEntity : BaseNamedEntity
    {
        public override void Configure(EntityTypeBuilder<TNamedEntity> builder)
        {
            base.Configure(builder);
            builder.Property(ne => ne.Name).HasMaxLength(Constants.Data.BaseNamedEntity.NameMaxLength);
        }
    }
}
