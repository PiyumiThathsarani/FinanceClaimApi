using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Province Province { get; set; }

        public ICollection<DivisionalSecretariatDiv> DivSecretariats { get; set; }
    }
}
