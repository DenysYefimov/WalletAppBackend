using WalletAppBackend.Dtos;

namespace WalletAppBackend.Services
{
    public interface ITransactionService
    {
        Task<TransactionDto> GetById(Guid userId, Guid cardId, Guid id);
        Task<List<TransactionDto>> GetList(Guid userId, Guid cardId);
    }
}
