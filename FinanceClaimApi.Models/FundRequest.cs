﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Models
{
    public class FundRequest
    {
        public int Id { get; set; }
        
        public int FundId { get; set; }
        public Fund Fund { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<ApprovalFlow> ApprovalFlows { get; set; } = new List<ApprovalFlow>();
    }
}
