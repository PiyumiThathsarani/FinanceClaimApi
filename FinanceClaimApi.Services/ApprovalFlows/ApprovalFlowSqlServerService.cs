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

       
    }
}
