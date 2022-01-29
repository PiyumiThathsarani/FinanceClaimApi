using FinanceClaimApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Services.ViewModels
{
    public class CreateFundRequestDto
    {
        public int FundId { get; set; }
        public int UserId { get; set; }

    }
}
