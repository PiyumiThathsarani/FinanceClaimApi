using FinanceClaim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaim.Services.Funds
{
    public interface IFundRepository
    {
        public List<Fund> GetAllFunds();
        public Fund GetFund(int id);
        public void AddFund();
        public void DeleteFund(int id);

    }
}
