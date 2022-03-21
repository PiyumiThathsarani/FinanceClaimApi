using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class InitialNewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5593), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5593), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5597), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5596), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5599), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5599), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5697), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5695), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5700), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5699), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5702), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5701), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5491), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5503), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5503), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5506), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5505), new DateTime(2022, 3, 21, 23, 17, 20, 290, DateTimeKind.Local).AddTicks(5506) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
