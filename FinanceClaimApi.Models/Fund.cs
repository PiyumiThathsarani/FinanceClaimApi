using FinanceClaimApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Models
{
    public class Fund
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal FundAmount { get; set; }
        public string ImagePath { get; set; } 
        public string Description { get; set; }
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

        public ICollection<FundRequest> FundRequests { get; set; }= new List<FundRequest>();
    }
}
