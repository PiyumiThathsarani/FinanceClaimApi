using FinanceClaimApi.DataAccess;
using FinanceClaimApi.Models;

namespace FinanceClaimApi.Services.Requests
{
    public class RequestSqlServerService : IRequestRepository
    {
        private readonly FundDbContext _context = new FundDbContext();

        public List<FundRequest> GetAllFundRequests()
        {
            return _context.FundRequests.ToList();
        }
        public FundRequest GetFundRequest(int id)
        {
            return _context.FundRequests.Find(id);
        }

        public FundRequest AddFundRequest(FundRequest request)
        {
            //request.FundId = fundId;
            //request.UserId = userId;
            _context.FundRequests.Add(request);
            _context.SaveChanges();
            if (_context.ApprovalFlows.Any(x => x.FundRequestId == request.Id)){

            }
            else
            {
                var reviewerId=_context.FundApprovalFlows.Where(x=>x.FlowName=="Pending").Select(x=>x.Id).FirstOrDefault();
                if (reviewerId != null)
                {
                    ApprovalFlow reviewer = new ApprovalFlow()
                    {
                        IsCompleted = false,
                        ApprovedBy = "2",                       
                        Remarks = "",
                        FundRequestId = request.Id,
                        FundApprovalFlowId = reviewerId,
                        FlowDate = DateTime.Now,
                        Status = ApprovalStatus.Pending
                    };
                    _context.ApprovalFlows.Add(reviewer);
                }
               /* var verifierId = _context.FundApprovalFlows.Where(x => x.FlowName == "Approved").Select(x => x.Id).FirstOrDefault();
                if (verifierId != null)
                {
                    ApprovalFlow verifier = new ApprovalFlow()
                    {
                        IsCompleted = true,
                        ApprovedBy = "3",
                        ApprovedOn = DateTime.Now,
                        Remarks = "",
                        FundRequestId = request.Id,
                        FundApprovalFlowId = verifierId,
                        FlowDate = DateTime.Now,
                        Status = ApprovalStatus.Approved
                    };
                    _context.ApprovalFlows.Add(verifier);
                }*/
                _context.SaveChanges();

            }

            return _context.FundRequests.Find(request.Id);
        }
        


    }
}
