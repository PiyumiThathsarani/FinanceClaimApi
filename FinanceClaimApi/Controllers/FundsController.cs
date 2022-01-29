using AutoMapper;
using FinanceClaimApi.Services.Funds;
using FinanceClaimApi.Models;
using FinanceClaimApi.Services.ViewModels;
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
        private readonly IMapper _mapper;

        public FundsController(IFundRepository service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;   
        }

        [HttpGet]
        public ActionResult<ICollection<Fund>> GetFunds()
        {
            var funds = _service.GetAllFunds();
            var mappedFunds = _mapper.Map<ICollection<Fund>>(funds);
            return Ok(mappedFunds);
        }
        [HttpGet("{id}",Name ="GetFund")]
        public IActionResult GetFund(int id)
        {
            var fund = _service.GetFund(id);

            if (fund is null)
            {
                return NotFound();
            }
            var mappedFund = _mapper.Map<Fund>(fund);
            return Ok(mappedFund);
        }
        [HttpPost]

        public ActionResult<FundDto> CreateFund(CreateFundDto fund)
        {
            var fundEntitiy = _mapper.Map<Fund>(fund);
            var newFund = _service.AddFund(fundEntitiy);

            var fundForReturn = _mapper.Map<FundDto>(newFund);
            return CreatedAtRoute("GetFund", new { id = fundForReturn.Id },
                value:fundForReturn);
           
        }
        [HttpPut("{fundId}")]
        public ActionResult UpdateFund(int fundId,UpdateFundDto fund)
        {
            var updatingFund = _service.GetFund(fundId);
            if (updatingFund is null)
            {
                return NotFound();
            }
            _mapper.Map(fund,updatingFund);
            _service.UpdateFund(updatingFund);
            return NoContent();
        }
        [HttpDelete("{fundId}")]

        public ActionResult DeleteFund(int fundId)
        {
            var deletingFund = _service.GetFund(fundId);
            if (deletingFund is null)
            {
                return NotFound();
            }
            _service.DeleteFund(deletingFund);
            return NoContent();
        }
       
    }
    
}
