using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Models
{
    public class DivisionalSecretariatDiv
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int DistrictId { get; set; }
        public District District { get; set; }

        public ICollection<GNDivision> GNDivisions { get; set; } = new List<GNDivision>();
    }
}
