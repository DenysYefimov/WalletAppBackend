namespace WalletAppBackend.Services
{
    public interface ISupplementaryInformationService
    {
        string GetCurrentMonthName();
        decimal GetCardBalance();
        int GetDailyPoints();
    }
}
