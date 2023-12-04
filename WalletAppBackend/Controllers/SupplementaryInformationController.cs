using Microsoft.AspNetCore.Mvc;
using WalletAppBackend.Services;

namespace WalletAppBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SupplementaryInformationController : ControllerBase
    {
        private readonly ISupplementaryInformationService _supplementaryInformationService;

        public SupplementaryInformationController(ISupplementaryInformationService supplementaryInformationService)
        {
            _supplementaryInformationService = supplementaryInformationService;
        }

        [HttpGet]
        [Route("current-month-name")]
        public ActionResult<string> GetCurrentMonthName()
        {
            return Ok(_supplementaryInformationService.GetCurrentMonthName());
        }

        [HttpGet]
        [Route("card-balance")]
        public ActionResult<decimal> GetCardBalance()
        {
            return Ok(_supplementaryInformationService.GetCardBalance());
        }

        [HttpGet]
        [Route("daily-points")]
        public ActionResult<int> GetDailyPoints()
        {
            return Ok(_supplementaryInformationService.GetDailyPoints());
        }
    }
}
