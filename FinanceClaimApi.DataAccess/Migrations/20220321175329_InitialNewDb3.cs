using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class InitialNewDb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(676), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(674), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(677) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(679), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(678), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(681), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(680), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(681) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(773), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(771), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(776), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(775), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(781), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(781), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(589), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(580), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(592), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(592), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(594), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(594), new DateTime(2022, 3, 21, 23, 22, 6, 319, DateTimeKind.Local).AddTicks(595) });
        }
    }
}
