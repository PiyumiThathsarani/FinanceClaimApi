using FinanceClaimApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Services.ViewModels
{
    public class FundRequestDto
    {
        public int Id { get; set; }
        
        public int FundId { get; set; }
        public Fund Fund { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
