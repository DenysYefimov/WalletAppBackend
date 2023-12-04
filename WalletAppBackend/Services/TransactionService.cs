using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WalletAppBackend.Data;
using WalletAppBackend.Data.Entities;
using WalletAppBackend.Dtos;

namespace WalletAppBackend.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly WalletAppDbContext _dbContext;
        private readonly IMapper _mapper;

        public TransactionService(WalletAppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<TransactionDto> GetById(Guid userId, Guid cardId, Guid id)
        {
            return _mapper.Map<TransactionDto>(
                await _dbContext.Set<Transaction>()
                    .FirstOrDefaultAsync(t => t.UserId == userId
                        && t.CardId == cardId
                        && t.Id == id));
        }

        public Task<List<TransactionDto>> GetList(Guid userId, Guid cardId)
        {
            return Task.FromResult(
                _mapper.Map<List<TransactionDto>>(
                    _dbContext.Set<Transaction>()
                        .Where(t => t.UserId == userId
                            && t.CardId == cardId)));
        }
    }
}
