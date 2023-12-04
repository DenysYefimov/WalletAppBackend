using WalletAppBackend.Common;

namespace WalletAppBackend.Services
{
    public class SupplementaryInformationService : ISupplementaryInformationService
    {
        public decimal GetCardBalance()
        {
            return (decimal)new Random().NextDouble() * Constants.MaxCardBalance;
        }

        public string GetCurrentMonthName()
        {
            return DateTime.Now.ToString(Constants.MonthNameFormat);
        }

        public int GetDailyPoints()
        {
            return 1;
        }
    }
}
