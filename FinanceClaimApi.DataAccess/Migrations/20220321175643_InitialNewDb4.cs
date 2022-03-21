using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class InitialNewDb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9325), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9324), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9329), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9329), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9332), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9331), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9438), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9438), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9442), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9442), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9445), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9444), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9225), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9216), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9228), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9227), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9230), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9230), new DateTime(2022, 3, 21, 23, 23, 28, 755, DateTimeKind.Local).AddTicks(9231) });
        }
    }
}
