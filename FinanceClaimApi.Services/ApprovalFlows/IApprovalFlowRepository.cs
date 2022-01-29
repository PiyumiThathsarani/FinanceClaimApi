using FinanceClaimApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Services.ApprovalFlows
{
    public interface IApprovalFlowRepository
    {
        public ApprovalFlow GetApprovalFlow(int id);
        public ApprovalFlow AddApprovalFlow(ApprovalFlow approvalFlow);

    }
}
