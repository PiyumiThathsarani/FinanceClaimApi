using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApprovalFlow_FundApprovalFlows_FundApprovalFlowId",
                table: "ApprovalFlow");

            migrationBuilder.DropForeignKey(
                name: "FK_ApprovalFlow_FundRequests_FundRequestId",
                table: "ApprovalFlow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApprovalFlow",
                table: "ApprovalFlow");

            migrationBuilder.RenameTable(
                name: "ApprovalFlow",
                newName: "ApprovalFlows");

            migrationBuilder.RenameIndex(
                name: "IX_ApprovalFlow_FundRequestId",
                table: "ApprovalFlows",
                newName: "IX_ApprovalFlows_FundRequestId");

            migrationBuilder.RenameIndex(
                name: "IX_ApprovalFlow_FundApprovalFlowId",
                table: "ApprovalFlows",
                newName: "IX_ApprovalFlows_FundApprovalFlowId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApprovalFlows",
                table: "ApprovalFlows",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3859), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3858), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3862), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3861), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3864), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3863), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4068), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4067), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4071), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4070), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4073), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4073), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3767), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3758), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3771), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3770), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3773), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3772), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalFlows_FundApprovalFlows_FundApprovalFlowId",
                table: "ApprovalFlows",
                column: "FundApprovalFlowId",
                principalTable: "FundApprovalFlows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalFlows_FundRequests_FundRequestId",
                table: "ApprovalFlows",
                column: "FundRequestId",
                principalTable: "FundRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApprovalFlows_FundApprovalFlows_FundApprovalFlowId",
                table: "ApprovalFlows");

            migrationBuilder.DropForeignKey(
                name: "FK_ApprovalFlows_FundRequests_FundRequestId",
                table: "ApprovalFlows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApprovalFlows",
                table: "ApprovalFlows");

            migrationBuilder.RenameTable(
                name: "ApprovalFlows",
                newName: "ApprovalFlow");

            migrationBuilder.RenameIndex(
                name: "IX_ApprovalFlows_FundRequestId",
                table: "ApprovalFlow",
                newName: "IX_ApprovalFlow_FundRequestId");

            migrationBuilder.RenameIndex(
                name: "IX_ApprovalFlows_FundApprovalFlowId",
                table: "ApprovalFlow",
                newName: "IX_ApprovalFlow_FundApprovalFlowId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApprovalFlow",
                table: "ApprovalFlow",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1716), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1713), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1720), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1719), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1724), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1723), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1789), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1788), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1792), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1791), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1794), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1793), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1631), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1623), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1635), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1634), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1637), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1636), new DateTime(2022, 1, 29, 15, 44, 55, 662, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalFlow_FundApprovalFlows_FundApprovalFlowId",
                table: "ApprovalFlow",
                column: "FundApprovalFlowId",
                principalTable: "FundApprovalFlows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalFlow_FundRequests_FundRequestId",
                table: "ApprovalFlow",
                column: "FundRequestId",
                principalTable: "FundRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
