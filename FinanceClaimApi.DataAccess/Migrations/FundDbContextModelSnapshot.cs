﻿// <auto-generated />
using System;
using FinanceClaimApi.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    [DbContext(typeof(FundDbContext))]
    partial class FundDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinanceClaimApi.Models.ApprovalFlow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ApprovedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ApprovedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FlowDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FundApprovalFlowId")
                        .HasColumnType("int");

                    b.Property<int>("FundRequestId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FundApprovalFlowId");

                    b.HasIndex("FundRequestId");

                    b.ToTable("ApprovalFlow");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Districts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hambantota",
                            ProvinceId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kalutara",
                            ProvinceId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ratnapura",
                            ProvinceId = 3
                        });
                });

            modelBuilder.Entity("FinanceClaimApi.Models.DivisionalSecretariatDiv", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("DivisionalSecretariats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DistrictId = 1,
                            Name = "Tissamaharama"
                        },
                        new
                        {
                            Id = 2,
                            DistrictId = 2,
                            Name = "Kirinda"
                        },
                        new
                        {
                            Id = 3,
                            DistrictId = 3,
                            Name = "Thihagoda"
                        });
                });

            modelBuilder.Entity("FinanceClaimApi.Models.Fund", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedRemark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FundAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funds");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.FundApprovalFlow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlowName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FundApprovalFlows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Your application is still in reviewing stage",
                            FlowName = "Reviewing"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Your application is still in verified!",
                            FlowName = "Verified"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Your application is approved!",
                            FlowName = "Approved"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Now your fund is in creation",
                            FlowName = "Fund Creating"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Now your fund to be transfered",
                            FlowName = "Bank Transfer"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Your fund is succesfully transfered to your account!",
                            FlowName = "Transfered"
                        });
                });

            modelBuilder.Entity("FinanceClaimApi.Models.FundRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FundId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FundId");

                    b.HasIndex("UserId");

                    b.ToTable("FundRequests");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.GNDivision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedRemark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DivisionalSecretariatDivId")
                        .HasColumnType("int");

                    b.Property<string>("GNDivisionNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DivisionalSecretariatDivId");

                    b.ToTable("GNDivisions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Piyumi",
                            CreatedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1716),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1713),
                            DeletedRemark = "Not deleted",
                            DivisionalSecretariatDivId = 1,
                            GNDivisionNo = "22E",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Piyumi",
                            LastModifiedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1717),
                            Name = "Gotabhayapura"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Piyumi",
                            CreatedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1720),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1719),
                            DeletedRemark = "Not deleted",
                            DivisionalSecretariatDivId = 2,
                            GNDivisionNo = "15A",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Piyumi",
                            LastModifiedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1721),
                            Name = "Kirinda"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Piyumi",
                            CreatedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1724),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1723),
                            DeletedRemark = "Not deleted",
                            DivisionalSecretariatDivId = 3,
                            GNDivisionNo = "17C",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Piyumi",
                            LastModifiedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1724),
                            Name = "Halmillawa"
                        });
                });

            modelBuilder.Entity("FinanceClaimApi.Models.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Provinces");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Southern Province"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sabaragamuwa Province"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Western Province"
                        });
                });

            modelBuilder.Entity("FinanceClaimApi.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedRemark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "PT wanniarachchi",
                            CreatedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1789),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1788),
                            DeletedRemark = "Not yet deleted",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Not yet modified",
                            LastModifiedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1790),
                            RoleType = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "PT wanniarachchi",
                            CreatedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1792),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1791),
                            DeletedRemark = "Not yet deleted",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Not yet modified",
                            LastModifiedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1792),
                            RoleType = "Village Officer"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "PT wanniarachchi",
                            CreatedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1794),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1793),
                            DeletedRemark = "Not yet deleted",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Not yet modified",
                            LastModifiedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1794),
                            RoleType = "User"
                        });
                });

            modelBuilder.Entity("FinanceClaimApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedRemark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GNDivisionId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GNDivisionId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CreatedBy = "Piyumi",
                            CreatedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1631),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1623),
                            DeletedRemark = "Not deleted",
                            GNDivisionId = 1,
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Piyumi",
                            LastModifiedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1632),
                            Name = "Piyumi Thathsarani",
                            Password = "235689"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Piyumi",
                            CreatedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1635),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1634),
                            DeletedRemark = "Not deleted",
                            GNDivisionId = 2,
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Piyumi",
                            LastModifiedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1635),
                            Name = "Thilini Anuradha",
                            Password = "123456"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "Piyumi",
                            CreatedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1637),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1636),
                            DeletedRemark = "Not deleted",
                            GNDivisionId = 3,
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Piyumi",
                            LastModifiedOn = new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1637),
                            Name = "Thanuja Mahendran",
                            Password = "124578"
                        });
                });

            modelBuilder.Entity("FinanceClaimApi.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleId = 1,
                            UserId = 2
                        },
                        new
                        {
                            Id = 2,
                            RoleId = 1,
                            UserId = 3
                        },
                        new
                        {
                            Id = 3,
                            RoleId = 2,
                            UserId = 4
                        },
                        new
                        {
                            Id = 4,
                            RoleId = 3,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("FinanceClaimApi.Models.ApprovalFlow", b =>
                {
                    b.HasOne("FinanceClaimApi.Models.FundApprovalFlow", "FundApprovalFlow")
                        .WithMany("ApprovalFlows")
                        .HasForeignKey("FundApprovalFlowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinanceClaimApi.Models.FundRequest", "FundRequest")
                        .WithMany("ApprovalFlows")
                        .HasForeignKey("FundRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FundApprovalFlow");

                    b.Navigation("FundRequest");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.District", b =>
                {
                    b.HasOne("FinanceClaimApi.Models.Province", "Province")
                        .WithMany("Districts")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.DivisionalSecretariatDiv", b =>
                {
                    b.HasOne("FinanceClaimApi.Models.District", "District")
                        .WithMany("DivSecretariats")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.FundRequest", b =>
                {
                    b.HasOne("FinanceClaimApi.Models.Fund", "Fund")
                        .WithMany("FundRequests")
                        .HasForeignKey("FundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinanceClaimApi.Models.User", "User")
                        .WithMany("Requests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fund");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.GNDivision", b =>
                {
                    b.HasOne("FinanceClaimApi.Models.DivisionalSecretariatDiv", "DivisionalSecretariat")
                        .WithMany("GNDivisions")
                        .HasForeignKey("DivisionalSecretariatDivId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DivisionalSecretariat");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.User", b =>
                {
                    b.HasOne("FinanceClaimApi.Models.GNDivision", "GNDivision")
                        .WithMany("Users")
                        .HasForeignKey("GNDivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GNDivision");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.UserRole", b =>
                {
                    b.HasOne("FinanceClaimApi.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinanceClaimApi.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.District", b =>
                {
                    b.Navigation("DivSecretariats");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.DivisionalSecretariatDiv", b =>
                {
                    b.Navigation("GNDivisions");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.Fund", b =>
                {
                    b.Navigation("FundRequests");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.FundApprovalFlow", b =>
                {
                    b.Navigation("ApprovalFlows");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.FundRequest", b =>
                {
                    b.Navigation("ApprovalFlows");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.GNDivision", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.Province", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("FinanceClaimApi.Models.User", b =>
                {
                    b.Navigation("Requests");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
