using FinanceClaimApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Services.Requests
{
    public interface IRequestRepository
    {
        public List<FundRequest> GetAllFundRequests();
        public FundRequest GetFundRequest(int id);
        public FundRequest AddFundRequest(FundRequest request);
    }
}
