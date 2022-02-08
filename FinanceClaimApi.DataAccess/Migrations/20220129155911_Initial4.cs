using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class Initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5946), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5945), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5949), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5948), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5951), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5950), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Uva Province" },
                    { 5, "Eastern Province" },
                    { 6, "Central Province" },
                    { 7, "North Central province" },
                    { 8, "Nothern Province" },
                    { 9, "North Western Province" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(6031), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(6029), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(6032) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(6035), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(6034), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(6037), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(6037), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5852), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5863), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5863), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5866), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5865), new DateTime(2022, 1, 29, 21, 29, 11, 139, DateTimeKind.Local).AddTicks(5867) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 20, 52, 46, 960, DateTimeKind.Local).AddTicks(9999), new DateTime(2022, 1, 29, 20, 52, 46, 960, DateTimeKind.Local).AddTicks(9998), new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(2), new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(1), new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(4), new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(4), new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(5) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(72), new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(72) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(74), new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(74), new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(76), new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(75), new DateTime(2022, 1, 29, 20, 52, 46, 961, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 20, 52, 46, 960, DateTimeKind.Local).AddTicks(9910), new DateTime(2022, 1, 29, 20, 52, 46, 960, DateTimeKind.Local).AddTicks(9901), new DateTime(2022, 1, 29, 20, 52, 46, 960, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 20, 52, 46, 960, DateTimeKind.Local).AddTicks(9913), new DateTime(2022, 1, 29, 20, 52, 46, 960, DateTimeKind.Local).AddTicks(9912), new DateTime(2022, 1, 29, 20, 52, 46, 960, DateTimeKind.Local).AddTicks(9913) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 20, 52, 46, 960, DateTimeKind.Local).AddTicks(9915), new DateTime(2022, 1, 29, 20, 52, 46, 960, DateTimeKind.Local).AddTicks(9914), new DateTime(2022, 1, 29, 20, 52, 46, 960, DateTimeKind.Local).AddTicks(9915) });
        }
    }
}
