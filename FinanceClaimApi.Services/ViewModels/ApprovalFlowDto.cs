﻿using FinanceClaimApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Services.ViewModels
{
    public class ApprovalFlowDto
    {
        public int Id { get; set; }
        public Boolean IsCompleted { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime ApprovedOn { get; set; }
        public string Remarks { get; set; }


        public int FundRequestId { get; set; }
        public FundRequest FundRequest { get; set; }
        public int FundApprovalFlowId { get; set; }
        public FundApprovalFlow FundApprovalFlow { get; set; }
        public DateTime FlowDate { get; set; }
    }
}
