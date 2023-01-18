using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "Password");

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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "GNDivisionId", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name", "Password" },
                values: new object[,]
                {
                    { 2, "Piyumi", new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5538), "None", new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5529), "Not deleted", 1, true, false, "Piyumi", new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5539), "Piyumi Thathsarani", "235689" },
                    { 3, "Piyumi", new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5541), "None", new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5541), "Not deleted", 2, true, false, "Piyumi", new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5542), "Thilini Anuradha", "123456" },
                    { 4, "Piyumi", new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5544), "None", new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5543), "Not deleted", 3, true, false, "Piyumi", new DateTime(2022, 8, 7, 15, 28, 30, 859, DateTimeKind.Local).AddTicks(5544), "Thanuja Mahendran", "124578" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Username");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2479), new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2470), new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2481), new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2481), new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2483), new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2483), new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2667), new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2666), new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2669), new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2668), new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2671), new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2670), new DateTime(2022, 4, 21, 18, 12, 10, 343, DateTimeKind.Local).AddTicks(2671) });
        }
    }
}
