using FinanceClaim.Services.Funds;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace FinanceClaimApi.Controllers
{
    [Route("api/Funds")]
    [ApiController]
    public class FundsController : ControllerBase
    {
        private readonly IFundRepository _service;

        public FundsController(IFundRepository service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetFunds()
        {
            var funds = _service.GetAllFunds();
            return Ok(funds);
        }
        [HttpGet("{id}")]
        public IActionResult GetFund(int id)
        {
            var fund = _service.GetFund(id);

            if (fund is null)
            {
                return NotFound();
            }
            return Ok(fund);
        }

        [HttpPost]
        public IActionResult NewFund()
        {
            _service.AddFund();
            return Ok("Success");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFund(int id)
        {
            _service.DeleteFund(id);
            return Ok();
        }
    }
    
}
