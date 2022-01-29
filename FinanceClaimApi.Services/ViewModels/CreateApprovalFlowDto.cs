using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Services.ViewModels
{
    public class CreateApprovalFlowDto
    {
        public Boolean IsCompleted { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string Remarks { get; set; }


        public int FundRequestId { get; set; }
        public int FundApprovalFlowId { get; set; }
        public DateTime FlowDate { get; set; }
    }
}
