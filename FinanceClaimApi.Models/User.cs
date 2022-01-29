using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Models
{
    public class User
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
        public string Name { get; set; }
        public string Password { get; set; }
        public int GNDivisionId { get; set; }
        public GNDivision GNDivision { get; set; }

        public ICollection<FundRequest> Requests { get; set; } = new List<FundRequest>();
        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    }
}
