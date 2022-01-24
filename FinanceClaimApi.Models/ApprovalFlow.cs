using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Models
{
    public class ApprovalFlow
    {
        public int Id { get; set; }
        public Boolean IsActive { get; set; }
        public Boolean IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public string DeletedRemark { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public FundRequest FundRequest { get; set; }
        public FundApprovalFlow FundApprovalFlow { get; set; }
        public DateTime FlowDate { get; set; }
    }
}
