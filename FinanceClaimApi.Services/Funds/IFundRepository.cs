using FinanceClaimApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Services.Funds
{
    public interface IFundRepository
    {
        public List<Fund> GetAllFunds();
        public Fund GetFund(int id);
        public Fund AddFund(Fund fund);
        public void UpdateFund(Fund fund);
        public void DeleteFund(Fund fund);

    }
}
