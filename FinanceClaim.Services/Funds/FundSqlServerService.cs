using FinanceClaim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaim.Services.Funds
{
    public class FundSqlServerService : IFundRepository
    {
        private readonly FundDbContext _context = new FundDbContext();
        public List<Fund> GetAllFunds()
        {
            return _context.Funds.ToList();
        }
        public Fund GetFund(int id)
        {
            return _context.Funds.Find(id);
        }

        List<Fund> IFundRepository.GetAllFunds()
        {
            throw new NotImplementedException();
        }

        Fund IFundRepository.GetFund(int id)
        {
            throw new NotImplementedException();
        }
    }
}
