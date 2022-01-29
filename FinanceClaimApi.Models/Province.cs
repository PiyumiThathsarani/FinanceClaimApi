using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Models
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<District> Districts { get; set; } = new List<District>();
    }
}
