using Microsoft.AspNetCore.Mvc;
using SOP.Models;

namespace SOP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankInfoController : ControllerBase
    {
        private readonly ILogger<BankInfoController> _logger;

        public BankInfoController(ILogger<BankInfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetBankInfo")]
        public IEnumerable<BankInfo> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new BankInfo
            {
                BankDetails = DateOnly.FromDateTime(DateTime.Now.AddDays(index)).ToString(),
                Name = Random.Shared.Next(-20, 55).ToString()
            })
            .ToArray();
        }
    }
}