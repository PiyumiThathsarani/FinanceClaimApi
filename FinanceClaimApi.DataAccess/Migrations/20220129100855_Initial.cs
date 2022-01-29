using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApprovalFlows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalFlows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FundAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DivisionalSecretariats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivisionalSecretariats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DivisionalSecretariats_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GNDivisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GNDivisionNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DivisionalSecretariatDivId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GNDivisions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GNDivisions_DivisionalSecretariats_DivisionalSecretariatDivId",
                        column: x => x.DivisionalSecretariatDivId,
                        principalTable: "DivisionalSecretariats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GNDivisionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_GNDivisions_GNDivisionId",
                        column: x => x.GNDivisionId,
                        principalTable: "GNDivisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FundRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FundId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FundRequests_Funds_FundId",
                        column: x => x.FundId,
                        principalTable: "Funds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FundRequests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApprovalFlow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FundRequestId = table.Column<int>(type: "int", nullable: false),
                    FundApprovalFlowId = table.Column<int>(type: "int", nullable: false),
                    FlowDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalFlow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApprovalFlow_ApprovalFlows_FundApprovalFlowId",
                        column: x => x.FundApprovalFlowId,
                        principalTable: "ApprovalFlows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApprovalFlow_FundRequests_FundRequestId",
                        column: x => x.FundRequestId,
                        principalTable: "FundRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApprovalFlows",
                columns: new[] { "Id", "Description", "FlowName" },
                values: new object[,]
                {
                    { 1, "Your application is still in reviewing stage", "Reviewing" },
                    { 2, "Your application is still in verified!", "Verified" },
                    { 3, "Your application is approved!", "Approved" },
                    { 4, "Now your fund is in creation", "Fund Creating" },
                    { 5, "Now your fund to be transfered", "Bank Transfer" },
                    { 6, "Your fund is succesfully transfered to your account!", "Transfered" }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Southern Province" },
                    { 2, "Sabaragamuwa Province" },
                    { 3, "Western Province" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "RoleType" },
                values: new object[,]
                {
                    { 1, "PT wanniarachchi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(519), "None", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(518), "Not yet deleted", true, false, "Not yet modified", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(520), "Admin" },
                    { 2, "PT wanniarachchi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(522), "None", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(522), "Not yet deleted", true, false, "Not yet modified", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(523), "Village Officer" },
                    { 3, "PT wanniarachchi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(524), "None", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(524), "Not yet deleted", true, false, "Not yet modified", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(525), "User" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[] { 1, "Hambantota", 1 });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[] { 2, "Kalutara", 2 });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[] { 3, "Ratnapura", 3 });

            migrationBuilder.InsertData(
                table: "DivisionalSecretariats",
                columns: new[] { "Id", "DistrictId", "Name" },
                values: new object[] { 1, 1, "Tissamaharama" });

            migrationBuilder.InsertData(
                table: "DivisionalSecretariats",
                columns: new[] { "Id", "DistrictId", "Name" },
                values: new object[] { 2, 2, "Kirinda" });

            migrationBuilder.InsertData(
                table: "DivisionalSecretariats",
                columns: new[] { "Id", "DistrictId", "Name" },
                values: new object[] { 3, 3, "Thihagoda" });

            migrationBuilder.InsertData(
                table: "GNDivisions",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "DivisionalSecretariatDivId", "GNDivisionNo", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[] { 1, "Piyumi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(438), "None", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(436), "Not deleted", 1, "22E", true, false, "Piyumi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(438), "Gotabhayapura" });

            migrationBuilder.InsertData(
                table: "GNDivisions",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "DivisionalSecretariatDivId", "GNDivisionNo", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[] { 2, "Piyumi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(441), "None", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(440), "Not deleted", 2, "15A", true, false, "Piyumi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(442), "Kirinda" });

            migrationBuilder.InsertData(
                table: "GNDivisions",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "DivisionalSecretariatDivId", "GNDivisionNo", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name" },
                values: new object[] { 3, "Piyumi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(444), "None", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(443), "Not deleted", 3, "17C", true, false, "Piyumi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(445), "Halmillawa" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "GNDivisionId", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name", "Password" },
                values: new object[] { 2, "Piyumi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(341), "None", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(331), "Not deleted", 1, true, false, "Piyumi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(342), "Piyumi Thathsarani", "235689" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "GNDivisionId", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name", "Password" },
                values: new object[] { 3, "Piyumi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(348), "None", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(347), "Not deleted", 2, true, false, "Piyumi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(348), "Thilini Anuradha", "123456" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "GNDivisionId", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name", "Password" },
                values: new object[] { 4, "Piyumi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(350), "None", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(349), "Not deleted", 3, true, false, "Piyumi", new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(350), "Thanuja Mahendran", "124578" });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 1, 3 },
                    { 3, 2, 4 },
                    { 4, 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalFlow_FundApprovalFlowId",
                table: "ApprovalFlow",
                column: "FundApprovalFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalFlow_FundRequestId",
                table: "ApprovalFlow",
                column: "FundRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_ProvinceId",
                table: "Districts",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_DivisionalSecretariats_DistrictId",
                table: "DivisionalSecretariats",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_FundRequests_FundId",
                table: "FundRequests",
                column: "FundId");

            migrationBuilder.CreateIndex(
                name: "IX_FundRequests_UserId",
                table: "FundRequests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GNDivisions_DivisionalSecretariatDivId",
                table: "GNDivisions",
                column: "DivisionalSecretariatDivId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GNDivisionId",
                table: "Users",
                column: "GNDivisionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApprovalFlow");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "ApprovalFlows");

            migrationBuilder.DropTable(
                name: "FundRequests");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Funds");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "GNDivisions");

            migrationBuilder.DropTable(
                name: "DivisionalSecretariats");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
