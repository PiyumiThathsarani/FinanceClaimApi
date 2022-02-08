using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceClaimApi.DataAccess.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "ApprovalFlows",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovedOn",
                table: "ApprovalFlows",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "ApprovalFlows",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ApprovalFlows",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ApprovalFlows");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "ApprovalFlows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovedOn",
                table: "ApprovalFlows",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ApprovedBy",
                table: "ApprovalFlows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3859), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3858), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3862), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3861), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3862) });

            migrationBuilder.UpdateData(
                table: "GNDivisions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3864), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3863), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4068), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4067), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4071), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4070), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4073), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4073), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3767), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3758), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3768) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3771), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3770), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "DeletedOn", "LastModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3773), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3772), new DateTime(2022, 1, 29, 17, 28, 1, 934, DateTimeKind.Local).AddTicks(3773) });
        }
    }
}
