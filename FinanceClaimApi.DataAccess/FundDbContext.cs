using FinanceClaim.Models;
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server = (localdb)\mssqllocaldb; Database = MyFundDb; Trusted_Connection = True";
            
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
