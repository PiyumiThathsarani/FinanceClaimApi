using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class Initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "ProvinceId" },
                values: new object[] { "Matara", 1 });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "ProvinceId" },
                values: new object[] { "Galle", 1 });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "Name", "ProvinceId" },
                values: new object[,]
                {
                    { 4, "Kegalle", 2 },
                    { 5, "Ratnapura", 2 },
                    { 6, "Kalutara", 3 },
                    { 7, "Colombo", 3 },
                    { 8, "Gampaha", 3 },
                    { 9, "Badulla", 4 },
                    { 10, "Monaragala", 4 },
                    { 11, "Trincomalee", 5 },
                    { 12, "Batticaloa", 5 },
                    { 13, "Ampara", 5 },
                    { 14, "Matale", 6 },
                    { 15, "Kandy", 6 },
                    { 16, "Nuwara Eliya", 6 },
                    { 17, "Anuradhapura", 7 },
                    { 18, "Polonnaruwa", 7 },
                    { 19, "Jaffna", 8 },
                    { 20, "Kilinochchi", 8 },
                    { 21, "Mannar", 8 },
                    { 22, "Mullaitivu", 8 },
                    { 23, "Vavuniya", 8 },
                    { 24, "Puttalam", 9 },
                    { 25, "Kurunegala", 9 }
                });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7492), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7491), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7496), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7495), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7498), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7498), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7591), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7589), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7592) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7594), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7593), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7404), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7392), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7407), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7407), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7409), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7409), new DateTime(2022, 1, 29, 21, 43, 16, 442, DateTimeKind.Local).AddTicks(7410) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "ProvinceId" },
                values: new object[] { "Kalutara", 2 });

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "ProvinceId" },
                values: new object[] { "Ratnapura", 3 });

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
    }
}
