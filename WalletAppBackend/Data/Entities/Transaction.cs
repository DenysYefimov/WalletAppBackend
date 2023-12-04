using WalletAppBackend.Common;

namespace WalletAppBackend.Data.Entities
{
    public class Transaction : BaseNamedEntity
    {
        public Transaction(string name) : base(name) { }

        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsPending { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public Guid CardId { get; set; }
        public Card? Card { get; set; }
    }
}
