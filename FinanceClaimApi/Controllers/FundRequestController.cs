using AutoMapper;
using FinanceClaimApi.Models;
using FinanceClaimApi.Services.Requests;
using FinanceClaimApi.Services.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceClaimApi.Controllers
{
    [Route("api/Requests")]
    [ApiController]
    public class FundRequestController : ControllerBase
    {
        private readonly IRequestRepository _requestService;
        private readonly IMapper _mapper;

        public FundRequestController(IRequestRepository requestService,IMapper mapper)
        {
            _requestService = requestService;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<FundRequest>> GetFundRequests()
        {
            var request = _requestService.GetAllFundRequests();
            var mappedRequests = _mapper.Map<ICollection<FundRequest>>(request);
            return Ok(mappedRequests);
        }
        [HttpGet("{id}", Name = "GetFundRequest")]
        public IActionResult GetFundRequest(int id)
        {
            var request = _requestService.GetFundRequest(id);

            if (request is null)
            {
                return NotFound();
            }
            var mappedFundRequest = _mapper.Map<FundRequest>(request);
            return Ok(mappedFundRequest);
        }
        [HttpPost]

        public ActionResult<FundRequestDto> CreateFund(CreateFundRequestDto request)
        {
            var requestEntitiy = _mapper.Map<FundRequest>(request);
            var newFundRequest = _requestService.AddFundRequest(requestEntitiy);
            var requestForReturn = _mapper.Map<FundRequestDto>(newFundRequest);
            return CreatedAtRoute("GetFundRequest", new { id = requestForReturn.Id },
                value: requestForReturn);

        }
        

    }
}
