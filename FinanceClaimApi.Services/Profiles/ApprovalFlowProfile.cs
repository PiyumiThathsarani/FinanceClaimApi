using AutoMapper;
using FinanceClaimApi.Models;
using FinanceClaimApi.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.Services.Profiles
{
    public class ApprovalFlowProfile : Profile
    {
        public ApprovalFlowProfile()
        {
            CreateMap<ApprovalFlow, ApprovalFlowDto>();
            CreateMap<CreateApprovalFlowDto, ApprovalFlow>();
        }
    }
}
