using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class Refresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1125), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1124), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1129), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1129), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1131), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1131), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1219), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1217), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1222), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1222), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1224), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1223), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1041), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1032), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1044), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1043), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1046), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1046), new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1046) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
