using FinanceClaimApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceClaimApi.DataAccess
{
    public class FundDbContext : DbContext
    {
        public DbSet<Fund> Funds { get; set; }
        public DbSet<FundRequest> FundRequests {get; set;}
        public DbSet<FundApprovalFlow> FundApprovalFlows { get;set; }
        public DbSet<ApprovalFlow> ApprovalFlows { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<GNDivision> GNDivisions { get; set; }
        public DbSet<DivisionalSecretariatDiv> DivisionalSecretariats { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Province> Provinces { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server = (localdb)\mssqllocaldb; Database = DbNew; Trusted_Connection = True";
            
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User
                {
                Id = 2,
                IsActive = true,
                IsDeleted = false,
                DeletedBy ="None",
                DeletedOn = DateTime.Now,
                DeletedRemark ="Not deleted",
                CreatedBy ="Piyumi",
                CreatedOn = DateTime.Now,
                LastModifiedBy ="Piyumi",
                LastModifiedOn = DateTime.Now,
                Name ="Piyumi Thathsarani",
                Password ="235689",
                GNDivisionId =1 
                },
                new User
                {
                Id = 3,
                IsActive = true,
                IsDeleted = false,
                DeletedBy ="None",
                DeletedOn = DateTime.Now,
                DeletedRemark ="Not deleted",
                CreatedBy ="Piyumi",
                CreatedOn = DateTime.Now,
                LastModifiedBy ="Piyumi",
                LastModifiedOn = DateTime.Now,
                Name ="Thilini Anuradha",
                Password ="123456",
                GNDivisionId =2
                },
                new User
                {
                Id = 4,
                IsActive = true,
                IsDeleted = false,
                DeletedBy ="None",
                DeletedOn = DateTime.Now,
                DeletedRemark ="Not deleted",
                CreatedBy ="Piyumi",
                CreatedOn = DateTime.Now,
                LastModifiedBy ="Piyumi",
                LastModifiedOn = DateTime.Now,
                Name ="Thanuja Mahendran",
                Password ="124578",
                GNDivisionId =3
                }
            });
            modelBuilder.Entity<GNDivision>().HasData(new GNDivision[]
            {
                new GNDivision
                {
                Id = 1,
                IsActive = true,
                IsDeleted = false,
                DeletedBy ="None",
                DeletedOn = DateTime.Now,
                DeletedRemark ="Not deleted",
                CreatedBy ="Piyumi",
                CreatedOn = DateTime.Now,
                LastModifiedBy ="Piyumi",
                LastModifiedOn = DateTime.Now,
                Name ="Gotabhayapura",
                GNDivisionNo ="22E",
                DivisionalSecretariatDivId=1
                },
                new GNDivision
                {
                Id = 2,
                IsActive = true,
                IsDeleted = false,
                DeletedBy ="None",
                DeletedOn = DateTime.Now,
                DeletedRemark ="Not deleted",
                CreatedBy ="Piyumi",
                CreatedOn = DateTime.Now,
                LastModifiedBy ="Piyumi",
                LastModifiedOn = DateTime.Now,
                Name ="Kirinda",
                GNDivisionNo ="15A",
                DivisionalSecretariatDivId=2
                },
                new GNDivision
                {
                Id = 3,
                IsActive = true,
                IsDeleted = false,
                DeletedBy ="None",
                DeletedOn = DateTime.Now,
                DeletedRemark ="Not deleted",
                CreatedBy ="Piyumi",
                CreatedOn = DateTime.Now,
                LastModifiedBy ="Piyumi",
                LastModifiedOn = DateTime.Now,
                Name ="Halmillawa",
                GNDivisionNo ="17C",
                DivisionalSecretariatDivId=3
                }
            }
            );
            modelBuilder.Entity<DivisionalSecretariatDiv>().HasData(new DivisionalSecretariatDiv[]
            {
                new DivisionalSecretariatDiv {Id = 1, Name ="Tissamaharama",DistrictId=1},
                new DivisionalSecretariatDiv {Id = 2, Name ="Kirinda",DistrictId=2},
                new DivisionalSecretariatDiv {Id=3,Name="Thihagoda",DistrictId=3}
            }
            );
            modelBuilder.Entity<District>().HasData(new District[]
            {
                new District {Id = 1,Name ="Hambantota",ProvinceId=1},
                new District {Id = 2,Name ="Kalutara",ProvinceId=2},
                new District {Id = 3,Name ="Ratnapura",ProvinceId=3}
            }
            );
            modelBuilder.Entity<Province>().HasData(new Province[]
            {
                new Province {Id = 1,Name ="Southern Province"},
                new Province {Id = 2,Name ="Sabaragamuwa Province"},
                new Province {Id = 3,Name ="Western Province"}
            }
            );
            modelBuilder.Entity<UserRole>().HasData(new UserRole[]
            {
                new UserRole {Id = 1,RoleId=1,UserId=2},
                new UserRole {Id = 2,RoleId=1,UserId=3},
                new UserRole {Id = 3,RoleId=2,UserId=4},
                new UserRole {Id = 4,RoleId=3,UserId=2}
            });
            modelBuilder.Entity<Role>().HasData(new Role[]
            {
                new Role
                {
                    Id = 1,
                    IsActive=true,
                    IsDeleted=false,
                    DeletedBy="None",
                    DeletedOn=DateTime.Now,
                    DeletedRemark="Not yet deleted",
                    CreatedBy= "PT wanniarachchi",
                    CreatedOn= DateTime.Now,
                    LastModifiedBy="Not yet modified",
                    LastModifiedOn= DateTime.Now,
                    RoleType="Admin"

                },
                new Role
                {
                    Id = 2,
                    IsActive=true,
                    IsDeleted=false,
                    DeletedBy="None",
                    DeletedOn=DateTime.Now,
                    DeletedRemark="Not yet deleted",
                    CreatedBy= "PT wanniarachchi",
                    CreatedOn= DateTime.Now,
                    LastModifiedBy="Not yet modified",
                    LastModifiedOn= DateTime.Now,
                    RoleType="Village Officer"

                },
                new Role
                {
                    Id = 3,
                    IsActive=true,
                    IsDeleted=false,
                    DeletedBy="None",
                    DeletedOn=DateTime.Now,
                    DeletedRemark="Not yet deleted",
                    CreatedBy= "PT wanniarachchi",
                    CreatedOn= DateTime.Now,
                    LastModifiedBy="Not yet modified",
                    LastModifiedOn= DateTime.Now,
                    RoleType="User"

                }
            });
            modelBuilder.Entity<FundApprovalFlow>().HasData(new FundApprovalFlow[]
            {
                new FundApprovalFlow{Id=1,FlowName="Reviewing",Description="Your application is still in reviewing stage"},
                new FundApprovalFlow{Id=2,FlowName="Verified",Description="Your application is still in verified!"},
                new FundApprovalFlow{Id=3,FlowName="Approved",Description="Your application is approved!"},
                new FundApprovalFlow{Id=4,FlowName="Fund Creating",Description ="Now your fund is in creation"},
                new FundApprovalFlow{Id=5,FlowName="Bank Transfer",Description="Now your fund to be transfered"},
                new FundApprovalFlow{Id=6,FlowName="Transfered",Description="Your fund is succesfully transfered to your account!"}
            });

        }
    }
}
