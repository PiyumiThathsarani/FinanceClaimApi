using AutoMapper;
using FinanceClaimApi.Models;
using FinanceClaimApi.Services.ApprovalFlows;
using FinanceClaimApi.Services.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinanceClaimApi.Controllers
{
    [Route("api/ApprovalFlow")]
    [ApiController]
    public class ApprovalFlowController : ControllerBase
    {
        private readonly IApprovalFlowRepository _approvalFlowService;
        private readonly IMapper _mapper;

        public ApprovalFlowController(IApprovalFlowRepository approvalFlowService,IMapper mapper)
        {
            _approvalFlowService = approvalFlowService;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult<ICollection<ApprovalFlow>> GetApprovalFlows()
        {
            var approvalFlow = _approvalFlowService.GetAllApprovalFlows();
            var mappedApprovalFlow = _mapper.Map<ICollection<ApprovalFlow>>(approvalFlow);
            return Ok(mappedApprovalFlow);
        }

        [HttpGet("{id}",Name ="GetApprovalFlow")]
        public IActionResult GetApprovalFlow(int id)
        {
            var approvalFlow = _approvalFlowService.GetApprovalFlow(id);
            if (approvalFlow is null)
            {
                return NotFound();
            }
            var mappedApprovalFlow=_mapper.Map<ApprovalFlow>(approvalFlow);
            return Ok(mappedApprovalFlow);

        }

        [HttpPost]
        public ActionResult<ApprovalFlowDto> CreateFund(CreateApprovalFlowDto approvalFlow)
        {
            var requestEntitiy = _mapper.Map<ApprovalFlow>(approvalFlow);
            var newApprovalFlow = _approvalFlowService.AddApprovalFlow(requestEntitiy);
            var approvalFlowForReturn = _mapper.Map<ApprovalFlowDto>(newApprovalFlow);
            return CreatedAtRoute("GetApprovalFlow", new { id = approvalFlowForReturn.Id },
                value: approvalFlowForReturn);

        }
    }

}
