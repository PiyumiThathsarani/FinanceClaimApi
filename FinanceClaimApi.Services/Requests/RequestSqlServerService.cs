using FinanceClaimApi.DataAccess;
using FinanceClaimApi.Models;

namespace FinanceClaimApi.Services.Requests
{
    public class RequestSqlServerService : IRequestRepository
    {
        private readonly FundDbContext _context = new FundDbContext();

        public List<FundRequest> GetAllFundRequests()
        {
            return _context.FundRequests.ToList();
        }
        public FundRequest GetFundRequest(int id)
        {
            return _context.FundRequests.Find(id);
        }

        public FundRequest AddFundRequest(FundRequest request)
        {
            //request.FundId = fundId;
            //request.UserId = userId;
            _context.FundRequests.Add(request);
            _context.SaveChanges();

            return _context.FundRequests.Find(request.Id);
        }


    }
}
