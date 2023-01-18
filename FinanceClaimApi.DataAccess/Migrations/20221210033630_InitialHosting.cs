using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class InitialHosting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7650), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7649), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7654), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7653), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7656), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7655), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7749), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7748), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7752), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7751), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7753), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7753), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7555), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7547), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7560), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7559), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7562), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7561), new DateTime(2022, 12, 10, 9, 6, 29, 150, DateTimeKind.Local).AddTicks(7562) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5230), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5234), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5233), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5237), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5236), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5358), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5356), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5361), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5365), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5364), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5107), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5097), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5111), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5110), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5114), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5114), new DateTime(2022, 8, 7, 15, 45, 37, 243, DateTimeKind.Local).AddTicks(5115) });
        }
    }
}
