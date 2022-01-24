using FinanceClaim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Models
{
    public class FundRequest
    {
        public int Id { get; set; }
        public DateTime DueDate { get; set; }
        public Boolean IsActive { get; set; }
        public Boolean IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public string DeletedRemark { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
       
        public Fund Fund { get; set; }
        public User User { get; set; }

        public ICollection<ApprovalFlow> ApprovalFlows { get; set; }
    }
}
