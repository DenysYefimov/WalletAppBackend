using WalletAppBackend.Common;

namespace WalletAppBackend.Dtos
{
    public class TransactionDto
    {
        public TransactionDto(string name)
        {
            Name = name;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsPending { get; set; }
        public string? UserName { get; set; }
    }
}
