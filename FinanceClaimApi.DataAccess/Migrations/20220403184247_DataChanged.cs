using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class DataChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6111), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6110), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6115), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6114), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6125), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6124), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6125) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6226), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6225), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6229), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6229), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6232), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6231), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(5993), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(5976), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(5997), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(5996), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(5999), new DateTime(2022, 3, 21, 23, 26, 42, 571, DateTimeKind.Local).AddTicks(6000) });
        }
    }
}
