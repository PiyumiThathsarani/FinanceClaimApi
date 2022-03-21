using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class InitialNewDb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
