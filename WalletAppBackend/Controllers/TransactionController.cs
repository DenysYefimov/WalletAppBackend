using Microsoft.AspNetCore.Mvc;
using WalletAppBackend.Dtos;
using WalletAppBackend.Services;

namespace WalletAppBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController (ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        [Route("{userId:guid}/{cardId:guid}/{id:guid}")]
        public async Task<ActionResult<TransactionDto>> GetById(Guid userId, Guid cardId, Guid id)
        {
            return Ok(await _transactionService.GetById(userId, cardId, id));
        }

        [HttpGet]
        [Route("{userId:guid}/{cardId:guid}")]
        public async Task<ActionResult<List<TransactionDto>>> GetList(Guid userId, Guid cardId)
        {
            return Ok(await _transactionService.GetList(userId, cardId));
        }
    }
}
