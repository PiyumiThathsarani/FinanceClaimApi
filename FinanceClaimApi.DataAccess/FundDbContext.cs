using FinanceClaim.Models;
using FinanceClaimApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaim.DataAccess
{
    public class FundDbContext : DbContext
    {
        public DbSet<Fund> Funds { get; set; }
        public DbSet<FundRequest> FundRequests {get; set;}
        public DbSet<FundApprovalFlow> ApprovalFlows { get;set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<GNDivision> GNDivisions { get; set; }
        public DbSet<DivisionalSecretariatDiv> DivisionalSecretariats { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Province> Provinces { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server = (localdb)\mssqllocaldb; Database = MyFundDb; Trusted_Connection = True";
            
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
