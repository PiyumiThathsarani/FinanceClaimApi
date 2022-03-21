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
            var connectionString = "Data Source=SQL5107.site4now.net;Initial Catalog=db_a846e5_efinanceclaim;User Id=db_a846e5_efinanceclaim_admin;Password=Pt_30797323";
            
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
                new District {Id = 2,Name ="Matara",ProvinceId=1},
                new District {Id = 3,Name ="Galle",ProvinceId=1},
                new District {Id = 4,Name ="Kegalle",ProvinceId=2},
                new District {Id = 5,Name ="Ratnapura",ProvinceId=2},
                new District {Id = 6,Name ="Kalutara",ProvinceId=3},
                new District {Id = 7,Name ="Colombo",ProvinceId=3},
                new District {Id = 8,Name ="Gampaha",ProvinceId=3},
                new District {Id = 9,Name ="Badulla",ProvinceId=4},
                new District {Id = 10,Name ="Monaragala",ProvinceId=4},
                new District {Id = 11,Name ="Trincomalee",ProvinceId=5},
                new District {Id = 12,Name ="Batticaloa",ProvinceId=5},
                new District {Id = 13,Name ="Ampara",ProvinceId=5},
                new District {Id = 14,Name ="Matale",ProvinceId=6},
                new District {Id = 15,Name ="Kandy",ProvinceId=6},
                new District {Id = 16,Name ="Nuwara Eliya",ProvinceId=6},
                new District {Id = 17,Name ="Anuradhapura",ProvinceId=7},
                new District {Id = 18,Name ="Polonnaruwa",ProvinceId=7},
                new District{Id = 19,Name ="Jaffna",ProvinceId=8},
                new District{Id = 20,Name ="Kilinochchi",ProvinceId=8},
                new District{Id = 21,Name ="Mannar",ProvinceId=8},
                new District{Id = 22,Name ="Mullaitivu",ProvinceId=8},
                new District{Id = 23,Name ="Vavuniya",ProvinceId=8},
                new District{Id = 24,Name ="Puttalam",ProvinceId=9},
                new District{Id = 25,Name ="Kurunegala",ProvinceId=9}

            }
            );
            modelBuilder.Entity<Province>().HasData(new Province[]
            {
                new Province {Id = 1,Name ="Southern Province"},
                new Province {Id = 2,Name ="Sabaragamuwa Province"},
                new Province {Id = 3,Name ="Western Province"},
                new Province{Id = 4,Name ="Uva Province"},
                new Province{Id=5,Name ="Eastern Province"},
                new Province{Id=6,Name ="Central Province"},
                new Province{Id=7,Name ="North Central province"},
                new Province{Id=8,Name ="Nothern Province"},
                new Province{Id=9,Name ="North Western Province"}

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
