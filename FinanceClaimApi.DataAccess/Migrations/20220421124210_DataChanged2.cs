using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class DataChanged2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeletedRemark", "GNDivisionId", "IsActive", "IsDeleted", "LastModifiedBy", "LastModifiedOn", "Name", "Password" },
                values: new object[,]
                {
                    { 2, "Piyumi", new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1041), "None", new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1032), "Not deleted", 1, true, false, "Piyumi", new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1042), "Piyumi Thathsarani", "235689" },
                    { 3, "Piyumi", new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1044), "None", new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1043), "Not deleted", 2, true, false, "Piyumi", new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1044), "Thilini Anuradha", "123456" },
                    { 4, "Piyumi", new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1046), "None", new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1046), "Not deleted", 3, true, false, "Piyumi", new DateTime(2022, 4, 8, 18, 8, 17, 943, DateTimeKind.Local).AddTicks(1046), "Thanuja Mahendran", "124578" }
                });
        }
    }
}
