namespace WalletAppBackend.Data.Entities
{
    public class User : BaseNamedEntity
    {
        public User(string name) : base(name) { }

        public ICollection<Card>? Cards { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
    }
}
