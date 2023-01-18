using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class UserDtoChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5627), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5627), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5629), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5632), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5632), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5632) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5719), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5718), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5722), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5721), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5724), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5723), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5538), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5529), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5539) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5541), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5541), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5544), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5543), new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5544) });
        }
    }
}
