using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Models
{
    public enum ApprovalStatus
    {
        InReviewingStage,//0
        InVerifyingStage,//1
        InApprovalStage,//2
        InFundProcessingStage,//3
        InFundTransferStage,//4
        FundTransfered//5
    }
}
