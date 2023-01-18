using FinanceClaimApi.DataAccess;
using FinanceClaimApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Services.ApprovalFlows
{
    public class ApprovalFlowSqlServerService : IApprovalFlowRepository
    {
        private readonly FundDbContext _context = new FundDbContext();

        public List<ApprovalFlow> GetAllApprovalFlows()
        {
            return _context.ApprovalFlows.ToList();
        }
        public ApprovalFlow GetApprovalFlow(int id)
        {
            return _context.ApprovalFlows.Find(id);
        }
        public ApprovalFlow AddApprovalFlow(ApprovalFlow approvalFlow)
        {
            _context.ApprovalFlows.Add(approvalFlow);
            _context.SaveChanges();

            return _context.ApprovalFlows.Find(approvalFlow.Id);
        }
        public ApprovalFlow AddFundRequestApproval(ApprovalFlow approval)
        {

            _context.ApprovalFlows.Add(approval);
            _context.SaveChanges();
            if (_context.ApprovalFlows.Any(x => x.FundApprovalFlowId == approval.Id))
            {

            }
            else
            {
                var approverId = _context.FundApprovalFlows.Where(x => x.FlowName == "Approved").Select(x => x.Id).FirstOrDefault();
                if (approverId != null)
                {
                    ApprovalFlow approver = new ApprovalFlow()
                    {
                        IsCompleted = true,
                        ApprovedBy = "3",
                        ApprovedOn = DateTime.Now,
                        Remarks = "",
                        FundRequestId = approval.Id,
                        FundApprovalFlowId = approverId,
                        FlowDate = DateTime.Now,
                        Status = ApprovalStatus.Approved
                    };
                    _context.ApprovalFlows.Add(approver);
                }
                _context.SaveChanges();

            }

            return _context.ApprovalFlows.Find(approval.Id);
        }


    }
}
