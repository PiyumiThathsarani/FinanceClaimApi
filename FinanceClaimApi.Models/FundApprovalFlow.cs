using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Models
{
    public class FundApprovalFlow
    {
        public int Id { get; set; }
        public string FlowName { get; set; }
        public string Description { get; set; }

        public ICollection<ApprovalFlow> ApprovalFlows { get; set; } = new List<ApprovalFlow>();
    }
}
