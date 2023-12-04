namespace WalletAppBackend.Data.Entities
{
    public class Card : BaseEntity
    {
        public decimal Balance { get; set; }

        public ICollection<User>? Users { get; set; }

        public ICollection<Transaction>? Transactions { get; set; }
    }
}
