using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApprovalFlow_ApprovalFlows_FundApprovalFlowId",
                table: "ApprovalFlow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApprovalFlows",
                table: "ApprovalFlows");

            migrationBuilder.RenameTable(
                name: "ApprovalFlows",
                newName: "FundApprovalFlows");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FundApprovalFlows",
                table: "FundApprovalFlows",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApprovalFlow_FundApprovalFlows_FundApprovalFlowId",
                table: "ApprovalFlow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FundApprovalFlows",
                table: "FundApprovalFlows");

            migrationBuilder.RenameTable(
                name: "FundApprovalFlows",
                newName: "ApprovalFlows");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApprovalFlows",
                table: "ApprovalFlows",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(438), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(436), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(441), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(440), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(444), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(443), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(519), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(518), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(522), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(522), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(524), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(524), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(341), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(331), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(348), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(347), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(348) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(350), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(349), new DateTime(2022, 1, 29, 15, 38, 54, 873, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.AddForeignKey(
                name: "FK_ApprovalFlow_ApprovalFlows_FundApprovalFlowId",
                table: "ApprovalFlow",
                column: "FundApprovalFlowId",
                principalTable: "ApprovalFlows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
