using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class Initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DivisionalSecretariats",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Kegalle");

            migrationBuilder.UpdateData(
                table: "DivisionalSecretariats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Kalutara");

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2638), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2636), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2642), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2641), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2644), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2643), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2734), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2733), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2737), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2736), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2738), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2738), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2553), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2544), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2556), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2555), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2556) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2558), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2557), new DateTime(2022, 1, 30, 15, 5, 8, 896, DateTimeKind.Local).AddTicks(2558) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DivisionalSecretariats",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Kirinda");

            migrationBuilder.UpdateData(
                table: "DivisionalSecretariats",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Thihagoda");

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7492), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7491), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7496), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7495), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7498), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7498), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7591), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7589), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7594), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7593), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7404), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7392), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7407), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7407), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7409), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7409), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7410) });
        }
    }
}
