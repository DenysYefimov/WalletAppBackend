using Microsoft.EntityFrameworkCore;
using WalletAppBackend.Common;
using WalletAppBackend.Data;
using WalletAppBackend.Services;

namespace WalletAppBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAutoMapper(typeof(Program).Assembly);
            builder.Services.AddDbContext<WalletAppDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString(Constants.Data.WalletAppDbConnectionStringName)));

            builder.Services.AddScoped<ISupplementaryInformationService, SupplementaryInformationService>();
            builder.Services.AddScoped<ITransactionService, TransactionService>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
