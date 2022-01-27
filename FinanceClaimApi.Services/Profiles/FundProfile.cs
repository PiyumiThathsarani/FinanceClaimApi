using AutoMapper;
using FinanceClaim.Models;
using FinanceClaimApi.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Services.Profiles
{
    public class FundProfile:Profile
    {
        public FundProfile()
        {
            CreateMap<Fund,FundDto>();
            CreateMap<CreateFundDto, Fund>();
            CreateMap<UpdateFundDto, Fund>();
        }
    }
}
