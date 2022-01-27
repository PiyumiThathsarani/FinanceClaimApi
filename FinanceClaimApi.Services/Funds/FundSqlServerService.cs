using FinanceClaim.DataAccess;
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
            return _context.Funds.Where(x => !x.IsDeleted).ToList();
        }
        public Fund GetFund(int id)
        {
            return _context.Funds.Find(id);
        }
        public Fund AddFund(Fund fund)
        {
            
            _context.Funds.Add(fund);
            _context.SaveChanges();

            return _context.Funds.Find(fund.Id);
        }
        public void UpdateFund(Fund fund)
        {
            _context.SaveChanges();
        }
        public void DeleteFund(Fund fund)
        {
            fund.IsDeleted=true;
            fund.DeletedOn=DateTime.Now;
            fund.DeletedBy = "Sys";
            fund.DeletedRemark = "Sys Remark";
            _context.SaveChanges();
        }

        
    }
}
