using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class InitialNewDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(557), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(557), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(560), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(560), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(565), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(564), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(657), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(656), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(659), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(659), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(661), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(660), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(466), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(457), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(468), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(468), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(470), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(470), new DateTime(2022, 3, 21, 23, 19, 28, 304, DateTimeKind.Local).AddTicks(471) });
        }
    }
}
