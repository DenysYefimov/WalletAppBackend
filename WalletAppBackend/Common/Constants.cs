namespace WalletAppBackend.Common
{
    public static class Constants
    {
        public static class Data
        {
            public const string WalletAppDbConnectionStringName = "WalletAppDatabase";

            public static class BaseNamedEntity
            {
                public const int NameMaxLength = 256;
            }

            public static class TransactionEntity
            {
                public const int DescriptionMaxLength = 1024;
            }
        }

        public const int MaxCardBalance = 1500;
        public const string MonthNameFormat = "MMMM";
    }
}
