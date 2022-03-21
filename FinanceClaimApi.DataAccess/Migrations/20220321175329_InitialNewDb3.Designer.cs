﻿// <auto-generated />
using System;
using FinanceClaimApi.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    [DbContext(typeof(FundDbContext))]
    [Migration("20220321175329_InitialNewDb3")]
    partial class InitialNewDb3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ApprovedOn")
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FundApprovalFlowId");

                    b.HasIndex("FundRequestId");

                    b.ToTable("ApprovalFlows");
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
                            Name = "Matara",
                            ProvinceId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Galle",
                            ProvinceId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kegalle",
                            ProvinceId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "Ratnapura",
                            ProvinceId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Kalutara",
                            ProvinceId = 3
                        },
                        new
                        {
                            Id = 7,
                            Name = "Colombo",
                            ProvinceId = 3
                        },
                        new
                        {
                            Id = 8,
                            Name = "Gampaha",
                            ProvinceId = 3
                        },
                        new
                        {
                            Id = 9,
                            Name = "Badulla",
                            ProvinceId = 4
                        },
                        new
                        {
                            Id = 10,
                            Name = "Monaragala",
                            ProvinceId = 4
                        },
                        new
                        {
                            Id = 11,
                            Name = "Trincomalee",
                            ProvinceId = 5
                        },
                        new
                        {
                            Id = 12,
                            Name = "Batticaloa",
                            ProvinceId = 5
                        },
                        new
                        {
                            Id = 13,
                            Name = "Ampara",
                            ProvinceId = 5
                        },
                        new
                        {
                            Id = 14,
                            Name = "Matale",
                            ProvinceId = 6
                        },
                        new
                        {
                            Id = 15,
                            Name = "Kandy",
                            ProvinceId = 6
                        },
                        new
                        {
                            Id = 16,
                            Name = "Nuwara Eliya",
                            ProvinceId = 6
                        },
                        new
                        {
                            Id = 17,
                            Name = "Anuradhapura",
                            ProvinceId = 7
                        },
                        new
                        {
                            Id = 18,
                            Name = "Polonnaruwa",
                            ProvinceId = 7
                        },
                        new
                        {
                            Id = 19,
                            Name = "Jaffna",
                            ProvinceId = 8
                        },
                        new
                        {
                            Id = 20,
                            Name = "Kilinochchi",
                            ProvinceId = 8
                        },
                        new
                        {
                            Id = 21,
                            Name = "Mannar",
                            ProvinceId = 8
                        },
                        new
                        {
                            Id = 22,
                            Name = "Mullaitivu",
                            ProvinceId = 8
                        },
                        new
                        {
                            Id = 23,
                            Name = "Vavuniya",
                            ProvinceId = 8
                        },
                        new
                        {
                            Id = 24,
                            Name = "Puttalam",
                            ProvinceId = 9
                        },
                        new
                        {
                            Id = 25,
                            Name = "Kurunegala",
                            ProvinceId = 9
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
                            CreatedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9325),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9324),
                            DeletedRemark = "Not deleted",
                            DivisionalSecretariatDivId = 1,
                            GNDivisionNo = "22E",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Piyumi",
                            LastModifiedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9326),
                            Name = "Gotabhayapura"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Piyumi",
                            CreatedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9329),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9329),
                            DeletedRemark = "Not deleted",
                            DivisionalSecretariatDivId = 2,
                            GNDivisionNo = "15A",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Piyumi",
                            LastModifiedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9330),
                            Name = "Kirinda"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Piyumi",
                            CreatedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9332),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9331),
                            DeletedRemark = "Not deleted",
                            DivisionalSecretariatDivId = 3,
                            GNDivisionNo = "17C",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Piyumi",
                            LastModifiedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9332),
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
                        },
                        new
                        {
                            Id = 4,
                            Name = "Uva Province"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Eastern Province"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Central Province"
                        },
                        new
                        {
                            Id = 7,
                            Name = "North Central province"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Nothern Province"
                        },
                        new
                        {
                            Id = 9,
                            Name = "North Western Province"
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
                            CreatedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9438),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9438),
                            DeletedRemark = "Not yet deleted",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Not yet modified",
                            LastModifiedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9439),
                            RoleType = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "PT wanniarachchi",
                            CreatedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9442),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9442),
                            DeletedRemark = "Not yet deleted",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Not yet modified",
                            LastModifiedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9443),
                            RoleType = "Village Officer"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "PT wanniarachchi",
                            CreatedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9445),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9444),
                            DeletedRemark = "Not yet deleted",
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Not yet modified",
                            LastModifiedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9445),
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
                            CreatedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9225),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9216),
                            DeletedRemark = "Not deleted",
                            GNDivisionId = 1,
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Piyumi",
                            LastModifiedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9225),
                            Name = "Piyumi Thathsarani",
                            Password = "235689"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "Piyumi",
                            CreatedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9228),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9227),
                            DeletedRemark = "Not deleted",
                            GNDivisionId = 2,
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Piyumi",
                            LastModifiedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9228),
                            Name = "Thilini Anuradha",
                            Password = "123456"
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "Piyumi",
                            CreatedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9230),
                            DeletedBy = "None",
                            DeletedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9230),
                            DeletedRemark = "Not deleted",
                            GNDivisionId = 3,
                            IsActive = true,
                            IsDeleted = false,
                            LastModifiedBy = "Piyumi",
                            LastModifiedOn = new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9231),
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