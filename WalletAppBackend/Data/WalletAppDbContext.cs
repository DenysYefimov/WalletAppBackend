using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WalletAppBackend.Common;

namespace WalletAppBackend.Data
{
    public class WalletAppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public WalletAppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString(Constants.Data.WalletAppDbConnectionStringName));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
