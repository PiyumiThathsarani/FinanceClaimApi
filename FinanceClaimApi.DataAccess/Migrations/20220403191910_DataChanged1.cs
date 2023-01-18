using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class DataChanged1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FundApprovalFlows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FundApprovalFlows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FundApprovalFlows",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "FundApprovalFlows",
                keyColumn: "Id",
                keyValue: 1,
                column: "FlowName",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "FundApprovalFlows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "FlowName" },
                values: new object[] { "Your application is approved!", "Approved" });

            migrationBuilder.UpdateData(
                table: "FundApprovalFlows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "FlowName" },
                values: new object[] { "Your application is rejected!", "Rejected" });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8091), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8090), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8093), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8093), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8096), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8095), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8196), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8195), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8199), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8198), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8201), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8201), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(7978), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(7965), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(7982), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(7981), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(7984), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(7983), new DateTime(2022, 4, 4, 0, 49, 9, 514, DateTimeKind.Local).AddTicks(7984) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FundApprovalFlows",
                keyColumn: "Id",
                keyValue: 1,
                column: "FlowName",
                value: "Reviewing");

            migrationBuilder.UpdateData(
                table: "FundApprovalFlows",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "FlowName" },
                values: new object[] { "Your application is still in verified!", "Verified" });

            migrationBuilder.UpdateData(
                table: "FundApprovalFlows",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "FlowName" },
                values: new object[] { "Your application is approved!", "Approved" });

            migrationBuilder.InsertData(
                table: "FundApprovalFlows",
                columns: new[] { "Id", "Description", "FlowName" },
                values: new object[,]
                {
                    { 4, "Now your fund is in creation", "Fund Creating" },
                    { 5, "Now your fund to be transfered", "Bank Transfer" },
                    { 6, "Your fund is succesfully transfered to your account!", "Transfered" }
                });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4439), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4438), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4443), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4442), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4445), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4444), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4554), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4552), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4556), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4555), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4559), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4558), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4562) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4326), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4314), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4330), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4329), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4332), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4331), new DateTime(2022, 4, 4, 0, 12, 46, 716, DateTimeKind.Local).AddTicks(4332) });
        }
    }
}
